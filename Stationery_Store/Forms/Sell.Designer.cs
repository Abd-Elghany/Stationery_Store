namespace Stationery_Store.Forms
{
    partial class SellForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SearchTextBox = new TextBox();
            label1 = new Label();
            searchBtn = new Button();
            productsGridView = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)productsGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(61, 86);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(280, 27);
            SearchTextBox.TabIndex = 0;
            SearchTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 22);
            label1.Name = "label1";
            label1.Size = new Size(276, 46);
            label1.TabIndex = 1;
            label1.Text = "ابحث بأسم الصنف";
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.DarkGray;
            searchBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBtn.Location = new Point(119, 290);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(165, 41);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "بحث";
            searchBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // productsGridView
            // 
            productsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGridView.Location = new Point(3, 6);
            productsGridView.Name = "productsGridView";
            productsGridView.RowHeadersWidth = 51;
            productsGridView.Size = new Size(394, 339);
            productsGridView.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SearchTextBox);
            panel1.Controls.Add(searchBtn);
            panel1.Location = new Point(1, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 347);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(productsGridView);
            panel2.Location = new Point(406, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(397, 348);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(623, 372);
            button1.Name = "button1";
            button1.Size = new Size(165, 41);
            button1.TabIndex = 4;
            button1.Text = "بيع";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            // 
            // SellForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "SellForm";
            Text = "Sell";
            ((System.ComponentModel.ISupportInitialize)productsGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox SearchTextBox;
        private Label label1;
        private Button searchBtn;
        private DataGridView productsGridView;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
    }
}