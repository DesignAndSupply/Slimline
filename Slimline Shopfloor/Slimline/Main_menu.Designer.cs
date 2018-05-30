namespace Slimline_Shopfloor
{
    partial class Main_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pct_icon = new System.Windows.Forms.PictureBox();
            this.btn_stock = new System.Windows.Forms.Button();
            this.btn_packing = new System.Windows.Forms.Button();
            this.btn_po = new System.Windows.Forms.Button();
            this.btn_allocation = new System.Windows.Forms.Button();
            this.txt_first_validation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_second_validation = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1927, 100);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.pct_icon);
            this.panel2.Controls.Add(this.btn_stock);
            this.panel2.Controls.Add(this.btn_packing);
            this.panel2.Controls.Add(this.btn_po);
            this.panel2.Controls.Add(this.btn_allocation);
            this.panel2.Location = new System.Drawing.Point(-2, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 1104);
            this.panel2.TabIndex = 11;
            // 
            // pct_icon
            // 
            this.pct_icon.Image = ((System.Drawing.Image)(resources.GetObject("pct_icon.Image")));
            this.pct_icon.Location = new System.Drawing.Point(0, 0);
            this.pct_icon.Name = "pct_icon";
            this.pct_icon.Size = new System.Drawing.Size(164, 97);
            this.pct_icon.TabIndex = 31;
            this.pct_icon.TabStop = false;
            // 
            // btn_stock
            // 
            this.btn_stock.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_stock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_stock.Location = new System.Drawing.Point(44, 250);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(83, 38);
            this.btn_stock.TabIndex = 30;
            this.btn_stock.Text = "Stock";
            this.btn_stock.UseVisualStyleBackColor = false;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // btn_packing
            // 
            this.btn_packing.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_packing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_packing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_packing.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_packing.Location = new System.Drawing.Point(44, 206);
            this.btn_packing.Name = "btn_packing";
            this.btn_packing.Size = new System.Drawing.Size(83, 38);
            this.btn_packing.TabIndex = 16;
            this.btn_packing.Text = "Packing Label";
            this.btn_packing.UseVisualStyleBackColor = false;
            this.btn_packing.Click += new System.EventHandler(this.btn_packing_Click);
            // 
            // btn_po
            // 
            this.btn_po.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_po.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_po.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_po.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_po.Location = new System.Drawing.Point(44, 162);
            this.btn_po.Name = "btn_po";
            this.btn_po.Size = new System.Drawing.Size(83, 38);
            this.btn_po.TabIndex = 15;
            this.btn_po.Text = "Purchase Order";
            this.btn_po.UseVisualStyleBackColor = false;
            this.btn_po.Click += new System.EventHandler(this.btn_po_Click);
            // 
            // btn_allocation
            // 
            this.btn_allocation.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_allocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_allocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_allocation.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_allocation.Location = new System.Drawing.Point(44, 118);
            this.btn_allocation.Name = "btn_allocation";
            this.btn_allocation.Size = new System.Drawing.Size(83, 38);
            this.btn_allocation.TabIndex = 0;
            this.btn_allocation.Text = "Work Allocation";
            this.btn_allocation.UseVisualStyleBackColor = false;
            this.btn_allocation.Click += new System.EventHandler(this.btn_allocation_Click);
            // 
            // txt_first_validation
            // 
            this.txt_first_validation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_first_validation.Font = new System.Drawing.Font("Free 3 of 9 Extended", 36F, System.Drawing.FontStyle.Bold);
            this.txt_first_validation.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_first_validation.Location = new System.Drawing.Point(391, 210);
            this.txt_first_validation.Name = "txt_first_validation";
            this.txt_first_validation.Size = new System.Drawing.Size(232, 44);
            this.txt_first_validation.TabIndex = 27;
            this.txt_first_validation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_first_validation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_first_validation_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(435, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 37);
            this.label2.TabIndex = 28;
            this.label2.Text = "Door ID:";
            // 
            // txt_second_validation
            // 
            this.txt_second_validation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_second_validation.Font = new System.Drawing.Font("Free 3 of 9 Extended", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_second_validation.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_second_validation.Location = new System.Drawing.Point(391, 210);
            this.txt_second_validation.Name = "txt_second_validation";
            this.txt_second_validation.Size = new System.Drawing.Size(232, 44);
            this.txt_second_validation.TabIndex = 29;
            this.txt_second_validation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_second_validation.Visible = false;
            this.txt_second_validation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_second_validation_KeyDown);
            // 
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.txt_second_validation);
            this.Controls.Add(this.txt_first_validation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pct_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_allocation;
        private System.Windows.Forms.Button btn_po;
        private System.Windows.Forms.TextBox txt_first_validation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_second_validation;
        private System.Windows.Forms.Button btn_packing;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.PictureBox pct_icon;
    }
}

