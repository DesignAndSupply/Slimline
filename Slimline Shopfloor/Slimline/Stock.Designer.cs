namespace Slimline_Shopfloor
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pct_icon = new System.Windows.Forms.PictureBox();
            this.grid_stock = new System.Windows.Forms.DataGridView();
            this.btn_decrease = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_increase = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grid_pallet = new System.Windows.Forms.DataGridView();
            this.btn_deduct = new System.Windows.Forms.Button();
            this.cmb_staff = new System.Windows.Forms.ComboBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_staff = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_pallet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1927, 100);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.pct_icon);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 1104);
            this.panel2.TabIndex = 12;
            // 
            // pct_icon
            // 
            this.pct_icon.Image = ((System.Drawing.Image)(resources.GetObject("pct_icon.Image")));
            this.pct_icon.Location = new System.Drawing.Point(0, 0);
            this.pct_icon.Name = "pct_icon";
            this.pct_icon.Size = new System.Drawing.Size(164, 97);
            this.pct_icon.TabIndex = 29;
            this.pct_icon.TabStop = false;
            // 
            // grid_stock
            // 
            this.grid_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grid_stock.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.grid_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_decrease,
            this.btn_increase});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_stock.DefaultCellStyle = dataGridViewCellStyle4;
            this.grid_stock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_stock.GridColor = System.Drawing.Color.CornflowerBlue;
            this.grid_stock.Location = new System.Drawing.Point(184, 119);
            this.grid_stock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grid_stock.Name = "grid_stock";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_stock.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_stock.RowHeadersVisible = false;
            this.grid_stock.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_stock.Size = new System.Drawing.Size(617, 504);
            this.grid_stock.TabIndex = 22;
            this.grid_stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_stock_CellContentClick);
            // 
            // btn_decrease
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.NullValue = "-";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.AliceBlue;
            this.btn_decrease.DefaultCellStyle = dataGridViewCellStyle2;
            this.btn_decrease.FillWeight = 50F;
            this.btn_decrease.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_decrease.HeaderText = "";
            this.btn_decrease.MinimumWidth = 50;
            this.btn_decrease.Name = "btn_decrease";
            this.btn_decrease.Width = 50;
            // 
            // btn_increase
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.NullValue = "+";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.AliceBlue;
            this.btn_increase.DefaultCellStyle = dataGridViewCellStyle3;
            this.btn_increase.FillWeight = 50F;
            this.btn_increase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_increase.HeaderText = "";
            this.btn_increase.MinimumWidth = 50;
            this.btn_increase.Name = "btn_increase";
            this.btn_increase.Width = 50;
            // 
            // grid_pallet
            // 
            this.grid_pallet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_pallet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grid_pallet.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.grid_pallet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_pallet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_pallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_pallet.DefaultCellStyle = dataGridViewCellStyle7;
            this.grid_pallet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_pallet.GridColor = System.Drawing.Color.CornflowerBlue;
            this.grid_pallet.Location = new System.Drawing.Point(807, 120);
            this.grid_pallet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grid_pallet.Name = "grid_pallet";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_pallet.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_pallet.RowHeadersVisible = false;
            this.grid_pallet.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_pallet.Size = new System.Drawing.Size(449, 504);
            this.grid_pallet.TabIndex = 23;
            // 
            // btn_deduct
            // 
            this.btn_deduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deduct.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_deduct.Image = global::Slimline_Shopfloor.Properties.Resources.subtract1;
            this.btn_deduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deduct.Location = new System.Drawing.Point(1489, 151);
            this.btn_deduct.Name = "btn_deduct";
            this.btn_deduct.Size = new System.Drawing.Size(77, 37);
            this.btn_deduct.TabIndex = 25;
            this.btn_deduct.Text = "     Deduct";
            this.btn_deduct.UseVisualStyleBackColor = true;
            this.btn_deduct.Click += new System.EventHandler(this.btn_deduct_Click);
            // 
            // cmb_staff
            // 
            this.cmb_staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_staff.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cmb_staff.FormattingEnabled = true;
            this.cmb_staff.Location = new System.Drawing.Point(1350, 120);
            this.cmb_staff.Name = "cmb_staff";
            this.cmb_staff.Size = new System.Drawing.Size(121, 21);
            this.cmb_staff.TabIndex = 26;
            // 
            // txt_quantity
            // 
            this.txt_quantity.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_quantity.Location = new System.Drawing.Point(1350, 150);
            this.txt_quantity.MaxLength = 4;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(121, 20);
            this.txt_quantity.TabIndex = 27;
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_qty.Location = new System.Drawing.Point(1284, 153);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(58, 13);
            this.lbl_qty.TabIndex = 28;
            this.lbl_qty.Text = "Quantity:";
            // 
            // lbl_staff
            // 
            this.lbl_staff.AutoSize = true;
            this.lbl_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staff.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_staff.Location = new System.Drawing.Point(1284, 124);
            this.lbl_staff.Name = "lbl_staff";
            this.lbl_staff.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_staff.Size = new System.Drawing.Size(38, 13);
            this.lbl_staff.TabIndex = 29;
            this.lbl_staff.Text = "Staff:";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_add.Image = global::Slimline_Shopfloor.Properties.Resources.Add;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(1489, 108);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(77, 37);
            this.btn_add.TabIndex = 30;
            this.btn_add.Text = "    Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1588, 653);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_staff);
            this.Controls.Add(this.lbl_qty);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.cmb_staff);
            this.Controls.Add(this.btn_deduct);
            this.Controls.Add(this.grid_pallet);
            this.Controls.Add(this.grid_stock);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pct_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_pallet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grid_stock;
        private System.Windows.Forms.DataGridView grid_pallet;
        private System.Windows.Forms.Button btn_deduct;
        private System.Windows.Forms.ComboBox cmb_staff;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Label lbl_staff;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewButtonColumn btn_decrease;
        private System.Windows.Forms.DataGridViewButtonColumn btn_increase;
        private System.Windows.Forms.PictureBox pct_icon;
    }
}