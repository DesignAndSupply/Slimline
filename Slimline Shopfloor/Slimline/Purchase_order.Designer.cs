namespace Slimline_Shopfloor
{
    partial class Purchase_order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase_order));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pct_icon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pct_report = new System.Windows.Forms.PictureBox();
            this.txt_po = new System.Windows.Forms.TextBox();
            this.lbl_door_id = new System.Windows.Forms.Label();
            this.grid_po = new System.Windows.Forms.DataGridView();
            this.pct_search = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_icon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_po)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_search)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.pct_icon);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 1100);
            this.panel2.TabIndex = 13;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.pct_report);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2000, 100);
            this.panel1.TabIndex = 12;
            // 
            // pct_report
            // 
            this.pct_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_report.Image = global::Slimline_Shopfloor.Properties.Resources.report2;
            this.pct_report.Location = new System.Drawing.Point(818, 12);
            this.pct_report.Name = "pct_report";
            this.pct_report.Size = new System.Drawing.Size(54, 50);
            this.pct_report.TabIndex = 0;
            this.pct_report.TabStop = false;
            this.pct_report.Click += new System.EventHandler(this.pct_report_Click);
            // 
            // txt_po
            // 
            this.txt_po.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_po.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_po.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_po.Location = new System.Drawing.Point(358, 138);
            this.txt_po.Multiline = true;
            this.txt_po.Name = "txt_po";
            this.txt_po.Size = new System.Drawing.Size(290, 44);
            this.txt_po.TabIndex = 15;
            this.txt_po.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_door_id
            // 
            this.lbl_door_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_door_id.AutoSize = true;
            this.lbl_door_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_door_id.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_door_id.Location = new System.Drawing.Point(440, 110);
            this.lbl_door_id.Name = "lbl_door_id";
            this.lbl_door_id.Size = new System.Drawing.Size(139, 25);
            this.lbl_door_id.TabIndex = 16;
            this.lbl_door_id.Text = "PO Number:";
            // 
            // grid_po
            // 
            this.grid_po.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.grid_po.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_po.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_po.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_po.DefaultCellStyle = dataGridViewCellStyle4;
            this.grid_po.GridColor = System.Drawing.Color.CornflowerBlue;
            this.grid_po.Location = new System.Drawing.Point(208, 239);
            this.grid_po.Name = "grid_po";
            this.grid_po.RowHeadersVisible = false;
            this.grid_po.Size = new System.Drawing.Size(630, 150);
            this.grid_po.TabIndex = 17;
            // 
            // pct_search
            // 
            this.pct_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pct_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_search.Image = global::Slimline_Shopfloor.Properties.Resources.search1;
            this.pct_search.Location = new System.Drawing.Point(635, 130);
            this.pct_search.Name = "pct_search";
            this.pct_search.Size = new System.Drawing.Size(85, 64);
            this.pct_search.TabIndex = 18;
            this.pct_search.TabStop = false;
            this.pct_search.Click += new System.EventHandler(this.pct_search_Click);
            // 
            // Purchase_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.txt_po);
            this.Controls.Add(this.pct_search);
            this.Controls.Add(this.grid_po);
            this.Controls.Add(this.lbl_door_id);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Purchase_order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pct_icon)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pct_report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_po)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_po;
        private System.Windows.Forms.Label lbl_door_id;
        private System.Windows.Forms.DataGridView grid_po;
        private System.Windows.Forms.PictureBox pct_search;
        private System.Windows.Forms.PictureBox pct_report;
        private System.Windows.Forms.PictureBox pct_icon;
    }
}