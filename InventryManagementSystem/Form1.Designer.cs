namespace InventryManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ItemGrid = new DataGridView();
            AddBtn = new Button();
            PriceBtn = new Button();
            ItemName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            PriceNum = new NumericUpDown();
            groupBox1 = new GroupBox();
            QtyNum = new NumericUpDown();
            label4 = new Label();
            ProfitUnit = new NumericUpDown();
            QtyBtn = new Button();
            ProfitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ItemGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceNum).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QtyNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProfitUnit).BeginInit();
            SuspendLayout();
            // 
            // ItemGrid
            // 
            ItemGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ItemGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemGrid.Location = new Point(430, 69);
            ItemGrid.Name = "ItemGrid";
            ItemGrid.RowHeadersWidth = 62;
            ItemGrid.Size = new Size(1114, 310);
            ItemGrid.TabIndex = 0;
            ItemGrid.CellContentClick += ItemGrid_CellContentClick;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.DodgerBlue;
            AddBtn.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = SystemColors.ButtonHighlight;
            AddBtn.Location = new Point(35, 417);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(345, 50);
            AddBtn.TabIndex = 4;
            AddBtn.Text = "ADD ITEM";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += button1_Click;
            // 
            // PriceBtn
            // 
            PriceBtn.BackColor = Color.SeaGreen;
            PriceBtn.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PriceBtn.ForeColor = Color.White;
            PriceBtn.Location = new Point(813, 417);
            PriceBtn.Name = "PriceBtn";
            PriceBtn.Size = new Size(345, 50);
            PriceBtn.TabIndex = 5;
            PriceBtn.Text = "CHANGE PRICE";
            PriceBtn.UseVisualStyleBackColor = false;
            PriceBtn.Click += button2_Click;
            // 
            // ItemName
            // 
            ItemName.Location = new Point(27, 64);
            ItemName.Name = "ItemName";
            ItemName.Size = new Size(287, 31);
            ItemName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 37);
            label1.Name = "label1";
            label1.Size = new Size(110, 24);
            label1.TabIndex = 3;
            label1.Text = "Item Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 112);
            label2.Name = "label2";
            label2.Size = new Size(97, 24);
            label2.TabIndex = 4;
            label2.Text = "Price/Unit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 183);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 6;
            label3.Text = "Quantity";
            // 
            // PriceNum
            // 
            PriceNum.Location = new Point(27, 139);
            PriceNum.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            PriceNum.Name = "PriceNum";
            PriceNum.Size = new Size(287, 31);
            PriceNum.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(QtyNum);
            groupBox1.Controls.Add(ItemName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(PriceNum);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(35, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 259);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "ITEM";
            // 
            // QtyNum
            // 
            QtyNum.Location = new Point(27, 210);
            QtyNum.Name = "QtyNum";
            QtyNum.Size = new Size(287, 31);
            QtyNum.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 355);
            label4.Name = "label4";
            label4.Size = new Size(114, 24);
            label4.TabIndex = 8;
            label4.Text = "Profit/Unit :";
            // 
            // ProfitUnit
            // 
            ProfitUnit.Location = new Point(145, 353);
            ProfitUnit.Name = "ProfitUnit";
            ProfitUnit.Size = new Size(235, 31);
            ProfitUnit.TabIndex = 9;
            // 
            // QtyBtn
            // 
            QtyBtn.BackColor = Color.Goldenrod;
            QtyBtn.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QtyBtn.ForeColor = Color.White;
            QtyBtn.Location = new Point(430, 417);
            QtyBtn.Name = "QtyBtn";
            QtyBtn.Size = new Size(345, 50);
            QtyBtn.TabIndex = 10;
            QtyBtn.Text = "CHANGE QTY";
            QtyBtn.UseVisualStyleBackColor = false;
            QtyBtn.Click += QtyBtn_Click;
            // 
            // ProfitBtn
            // 
            ProfitBtn.BackColor = Color.OrangeRed;
            ProfitBtn.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProfitBtn.ForeColor = Color.White;
            ProfitBtn.Location = new Point(1199, 417);
            ProfitBtn.Name = "ProfitBtn";
            ProfitBtn.Size = new Size(345, 50);
            ProfitBtn.TabIndex = 11;
            ProfitBtn.Text = "CHANGE PROFIT";
            ProfitBtn.UseVisualStyleBackColor = false;
            ProfitBtn.Click += ProfitBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1579, 584);
            Controls.Add(ProfitBtn);
            Controls.Add(QtyBtn);
            Controls.Add(ProfitUnit);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(PriceBtn);
            Controls.Add(AddBtn);
            Controls.Add(ItemGrid);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ItemGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceNum).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QtyNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProfitUnit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ItemGrid;
        private Button CreateBtn;
        private Button AddBtn;
        private TextBox ItemName;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown PriceNum;
        private GroupBox groupBox1;
        private NumericUpDown QtyNum;
        private Label label4;
        private NumericUpDown ProfitUnit;
        private Button RemBtn;
        private Button ChangeBtn;
        private Button QtyBtn;
        private Button PriceBtn;
        private Button ProfitBtn;
    }
}
