using Stationery_Store.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Stationery_Store.Forms
{
    public partial class SellForm : Form
    {
        private Context context = new Context();

        // قائمة المنتجات التي أضافها المستخدم للبيع (السلة)
        private List<Product> selectedProducts = new List<Product>();

        public SellForm()
        {
            InitializeComponent();

            // تعطيل توليد الأعمدة التلقائي لجداول البيانات
            productsGridView.AutoGenerateColumns = false;

            ConfigureProductGrid();
            ConfigureSellGrid();
            SellGridView.CellValueChanged += SellGridView_CellValueChanged;
            SellGridView.EditingControlShowing += SellGridView_EditingControlShowing;
        }

        /// <summary>
        /// دالة البحث عن المنتجات عند كتابة نص في مربع البحث
        /// </summary>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = SearchTextBox.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                productsGridView.DataSource = null;
                return;
            }

            // البحث في قاعدة البيانات عن المنتجات التي تحتوي أسمها على نص البحث
            var results = context.Products
                .Where(p => p.Name.Contains(searchTerm))
                .Take(50)
                .ToList();

            productsGridView.DataSource = results;
        }

        /// <summary>
        /// دالة إضافة المنتج المختار من قائمة المنتجات إلى قائمة البيع
        /// </summary>
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (productsGridView.CurrentRow == null)
            {
                MessageBox.Show("من فضلك اختر منتج لإضافته");
                return;
            }

            var selectedProduct = (Product)productsGridView.CurrentRow.DataBoundItem;

            if (selectedProducts.Any(p => p.ID == selectedProduct.ID))
            {
                MessageBox.Show("المنتج مضاف بالفعل في السلة");
                return;
            }

            selectedProducts.Add(selectedProduct);

            var price = selectedProduct.Price;

            // إضافة الصف مع الـ ID مخفي
            int rowIndex = SellGridView.Rows.Add();
            var row = SellGridView.Rows[rowIndex];
            row.Cells["SellProductId"].Value = selectedProduct.ID;
            row.Cells["SellProductName"].Value = selectedProduct.Name;
            row.Cells["SellQuantity"].Value = 1;
            row.Cells["SellPrice"].Value = price;
        }


        /// <summary>
        /// دالة تنفيذ عملية البيع عند الضغط على زر البيع
        /// </summary>
        private void SellBtn_Click(object sender, EventArgs e)
        {
            if (SellGridView.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد منتجات للبيع");
                return;
            }

            bool hasError = false;

            for (int i = 0; i < SellGridView.Rows.Count; i++)
            {
                var row = SellGridView.Rows[i];

                string productName = row.Cells["SellProductName"].Value?.ToString();

                //if (row.Cells["SellProductId"].Value == null || string.IsNullOrWhiteSpace(row.Cells["SellProductId"].Value.ToString()))
                //{
                //    MessageBox.Show("رقم المنتج غير موجود. تأكد من إدخال البيانات بشكل صحيح.");
                //    hasError = true;
                //    continue;
                //}

                int productId = int.Parse(row.Cells["SellProductId"].Value.ToString());
                Console.WriteLine("productName ==> "+ productName);
                int quantity;
                decimal price;

                // التأكد من صحة الكمية المدخلة
                if (!int.TryParse(row.Cells["SellQuantity"].Value?.ToString(), out quantity) || quantity <= 0)
                {
                    MessageBox.Show($"برجاء إدخال كمية صحيحة للمنتج: {productName}");
                    hasError = true;
                    continue;
                }

                // التأكد من صحة السعر المدخل (يمكن أن يكون عشري)
                if (!decimal.TryParse(row.Cells["SellPrice"].Value?.ToString(), out price) || price <= 0)
                {
                    MessageBox.Show($"برجاء إدخال سعر صحيح للمنتج: {productName}");
                    hasError = true;
                    continue;
                }

                // إيجاد المنتج في قاعدة البيانات باستخدام الاسم (الأفضل استخدام ID لو متوفر)
                var product = context.Products.FirstOrDefault(p => p.ID == productId);

                if (product == null)
                {
                    MessageBox.Show($"المنتج غير موجود في قاعدة البيانات: {productName}");
                    hasError = true;
                    continue;
                }

                // التحقق من توفر الكمية المطلوبة
                if (quantity > product.Quantity)
                {
                    MessageBox.Show($"الكمية المطلوبة غير متاحة للمنتج: {productName}");
                    hasError = true;
                    continue;
                }

                // تحديث الكمية المتبقية في قاعدة البيانات
                product.Quantity -= quantity;

                // يمكن هنا إضافة سجل بيع أو فاتورة حسب نظامك
                // كود إضافي لمعالجة البيع يمكن إضافته هنا
            }

            if (!hasError)
            {
                context.SaveChanges();
                MessageBox.Show("تمت عملية البيع بنجاح");

                // إعادة تهيئة الحقول بعد البيع
                selectedProducts.Clear();
                SellGridView.Rows.Clear();
                SearchTextBox.Clear();
                productsGridView.DataSource = null;
            }
            UpdateTotalPrice();
        }

        /// <summary>
        /// تهيئة أعمدة جدول المنتجات (productsGridView)
        /// </summary>
        private void ConfigureProductGrid()
        {
            productsGridView.Columns.Clear();

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "الاسم",
                DataPropertyName = "Name"
            });

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "الوصف",
                DataPropertyName = "Description"
            });

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "السعر",
                DataPropertyName = "Price"
            });

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "الكمية المتاحة",
                DataPropertyName = "Quantity"
            });
        }

        /// <summary>
        /// تهيئة أعمدة جدول البيع (SellGridView) مع السماح بتعديل العمودين "الكمية" و"السعر"
        /// </summary>
        private void ConfigureSellGrid()
        {
            SellGridView.Columns.Clear();

            // عمود الـ ID (مخفي)
            SellGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SellProductId",
                Visible = false // نخفي العمود عشان ما يظهرش للمستخدم
            });

            SellGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "اسم المنتج",
                Name = "SellProductName",
                ReadOnly = true
            });

            SellGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "الكمية",
                Name = "SellQuantity",
                ReadOnly = false
            });

            SellGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "السعر",
                Name = "SellPrice",
                ReadOnly = false
            });
        }


        // يمكنك هنا إضافة أحداث مثل التحقق من المدخلات أثناء تحرير الخلايا لو حبيت



        //Total Salary

        private void UpdateTotalPrice()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in SellGridView.Rows)
            {
                if (row.IsNewRow) continue; // تجاهل صف الإدخال الجديد

                if (decimal.TryParse(row.Cells["SellPrice"].Value?.ToString(), out decimal price) &&
                    int.TryParse(row.Cells["SellQuantity"].Value?.ToString(), out int quantity))
                {
                    total += price * quantity;
                }
            }

            TotalLabel.Text = $"الإجمالي: {total} جنيه";
        }

        private void SellGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.TextChanged -= CellTextChanged; // مهم جدًا عشان ميكررش الحدث
            e.Control.TextChanged += CellTextChanged;
        }

        private void CellTextChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void SellGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                (SellGridView.Columns[e.ColumnIndex].Name == "SellQuantity" ||
                 SellGridView.Columns[e.ColumnIndex].Name == "SellPrice"))
            {
                UpdateTotalPrice();
            }
        }





    }
}
