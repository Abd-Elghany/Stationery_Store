using Stationery_Store.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stationery_Store.Forms
{
    public partial class SellForm : Form
    {
        public SellForm()
        {
            InitializeComponent();
        }
        Context context = new Context();
        private void searchBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = SearchTextBox.Text.Trim();

            // Search For Products
            var results = context.Products
                .Where(p => p.Name.Contains(searchTerm))
                .ToList();

            productsGridView.DataSource = results;
        }
    }
}
