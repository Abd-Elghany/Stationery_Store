namespace Stationery_Store.Forms
{
    partial class SellForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            SellGridView = new DataGridView();
            AddBtn = new Button();
            productsGridView = new DataGridView();
            SearchTextBox = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            SellBtn = new Button();
            TotalLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)SellGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SellGridView
            // 
            SellGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            SellGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            SellGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SellGridView.Location = new Point(557, 11);
            SellGridView.Margin = new Padding(3, 4, 3, 4);
            SellGridView.Name = "SellGridView";
            SellGridView.RightToLeft = RightToLeft.Yes;
            SellGridView.RowHeadersWidth = 51;
            SellGridView.Size = new Size(504, 385);
            SellGridView.TabIndex = 7;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.DarkGray;
            AddBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.Location = new Point(122, 402);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(165, 41);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "إضافة";
            AddBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // productsGridView
            // 
            productsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGridView.Location = new Point(11, 132);
            productsGridView.Name = "productsGridView";
            productsGridView.RightToLeft = RightToLeft.Yes;
            productsGridView.RowHeadersWidth = 51;
            productsGridView.Size = new Size(540, 264);
            productsGridView.TabIndex = 3;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(78, 85);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(280, 27);
            SearchTextBox.TabIndex = 0;
            SearchTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 24);
            label1.Name = "label1";
            label1.Size = new Size(251, 45);
            label1.TabIndex = 1;
            label1.Text = "ابحث بأسم المنتج";
            // 
            // panel1
            // 
            panel1.Controls.Add(TotalLabel);
            panel1.Controls.Add(SellBtn);
            panel1.Controls.Add(SellGridView);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SearchTextBox);
            panel1.Controls.Add(productsGridView);
            panel1.Controls.Add(AddBtn);
            panel1.Location = new Point(1, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 500);
            panel1.TabIndex = 4;
            // 
            // SellBtn
            // 
            SellBtn.BackColor = Color.Green;
            SellBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SellBtn.Location = new Point(649, 403);
            SellBtn.Name = "SellBtn";
            SellBtn.Size = new Size(295, 53);
            SellBtn.TabIndex = 4;
            SellBtn.Text = "بيع";
            SellBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            SellBtn.UseVisualStyleBackColor = false;
            SellBtn.Click += SellBtn_Click;
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Location = new Point(924, 356);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(49, 20);
            TotalLabel.TabIndex = 6;
            TotalLabel.Text = "1234$";
            // 
            // SellForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1070, 532);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "SellForm";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sell";
            ((System.ComponentModel.ISupportInitialize)SellGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView SellGridView;
        private Button AddBtn;
        private DataGridView productsGridView;
        private TextBox SearchTextBox;
        private Label label1;
        private Panel panel1;
        private Button SellBtn;
        private Label TotalLabel;
    }
}
