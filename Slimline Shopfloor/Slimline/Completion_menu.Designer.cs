namespace Slimline_Shopfloor
{
    partial class Completion_menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Completion_menu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pct_logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_staff = new System.Windows.Forms.ComboBox();
            this.txt_door_id = new System.Windows.Forms.TextBox();
            this.lbl_door = new System.Windows.Forms.Label();
            this.Lbl_staff = new System.Windows.Forms.Label();
            this.lbl_operation = new System.Windows.Forms.Label();
            this.grid_completion_log = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_operation = new System.Windows.Forms.TextBox();
            this.txt_percent_total = new System.Windows.Forms.TextBox();
            this.bt_complete = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_completion_log)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.pct_logo);
            this.panel2.Location = new System.Drawing.Point(-1, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 463);
            this.panel2.TabIndex = 13;
            // 
            // pct_logo
            // 
            this.pct_logo.Image = global::Slimline_Shopfloor.Properties.Resources.Slimline1;
            this.pct_logo.Location = new System.Drawing.Point(0, 0);
            this.pct_logo.Name = "pct_logo";
            this.pct_logo.Size = new System.Drawing.Size(164, 97);
            this.pct_logo.TabIndex = 14;
            this.pct_logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 100);
            this.panel1.TabIndex = 12;
            this.panel1.Click += new System.EventHandler(this.bt_complete_Click);
            // 
            // cmb_staff
            // 
            this.cmb_staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_staff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_staff.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cmb_staff.FormattingEnabled = true;
            this.cmb_staff.Location = new System.Drawing.Point(750, 172);
            this.cmb_staff.Name = "cmb_staff";
            this.cmb_staff.Size = new System.Drawing.Size(121, 21);
            this.cmb_staff.TabIndex = 14;
            // 
            // txt_door_id
            // 
            this.txt_door_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_door_id.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_door_id.Location = new System.Drawing.Point(751, 146);
            this.txt_door_id.Name = "txt_door_id";
            this.txt_door_id.Size = new System.Drawing.Size(121, 20);
            this.txt_door_id.TabIndex = 15;
            // 
            // lbl_door
            // 
            this.lbl_door.AutoSize = true;
            this.lbl_door.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_door.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_door.Location = new System.Drawing.Point(670, 147);
            this.lbl_door.Name = "lbl_door";
            this.lbl_door.Size = new System.Drawing.Size(65, 16);
            this.lbl_door.TabIndex = 18;
            this.lbl_door.Text = "Door ID:";
            // 
            // Lbl_staff
            // 
            this.Lbl_staff.AutoSize = true;
            this.Lbl_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_staff.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Lbl_staff.Location = new System.Drawing.Point(670, 174);
            this.Lbl_staff.Name = "Lbl_staff";
            this.Lbl_staff.Size = new System.Drawing.Size(43, 16);
            this.Lbl_staff.TabIndex = 19;
            this.Lbl_staff.Text = "Staff:";
            // 
            // lbl_operation
            // 
            this.lbl_operation.AutoSize = true;
            this.lbl_operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_operation.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_operation.Location = new System.Drawing.Point(670, 198);
            this.lbl_operation.Name = "lbl_operation";
            this.lbl_operation.Size = new System.Drawing.Size(80, 16);
            this.lbl_operation.TabIndex = 20;
            this.lbl_operation.Text = "Operation:";
            // 
            // grid_completion_log
            // 
            this.grid_completion_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_completion_log.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grid_completion_log.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.grid_completion_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_completion_log.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_completion_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_completion_log.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_completion_log.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_completion_log.GridColor = System.Drawing.Color.CornflowerBlue;
            this.grid_completion_log.Location = new System.Drawing.Point(181, 146);
            this.grid_completion_log.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grid_completion_log.Name = "grid_completion_log";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_completion_log.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_completion_log.RowHeadersVisible = false;
            this.grid_completion_log.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_completion_log.Size = new System.Drawing.Size(491, 295);
            this.grid_completion_log.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(635, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Total Complete:";
            // 
            // txt_operation
            // 
            this.txt_operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_operation.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_operation.Location = new System.Drawing.Point(751, 199);
            this.txt_operation.Name = "txt_operation";
            this.txt_operation.Size = new System.Drawing.Size(121, 20);
            this.txt_operation.TabIndex = 16;
            // 
            // txt_percent_total
            // 
            this.txt_percent_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txt_percent_total.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_percent_total.Location = new System.Drawing.Point(751, 225);
            this.txt_percent_total.Name = "txt_percent_total";
            this.txt_percent_total.Size = new System.Drawing.Size(121, 20);
            this.txt_percent_total.TabIndex = 23;
            // 
            // bt_complete
            // 
            this.bt_complete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_complete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_complete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_complete.ForeColor = System.Drawing.Color.AliceBlue;
            this.bt_complete.Image = global::Slimline_Shopfloor.Properties.Resources.tick21;
            this.bt_complete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_complete.Location = new System.Drawing.Point(738, 389);
            this.bt_complete.Name = "bt_complete";
            this.bt_complete.Size = new System.Drawing.Size(95, 38);
            this.bt_complete.TabIndex = 22;
            this.bt_complete.Text = "    Complete";
            this.bt_complete.UseVisualStyleBackColor = false;
            this.bt_complete.Click += new System.EventHandler(this.bt_complete_Click);
            // 
            // Completion_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_percent_total);
            this.Controls.Add(this.bt_complete);
            this.Controls.Add(this.grid_completion_log);
            this.Controls.Add(this.lbl_operation);
            this.Controls.Add(this.Lbl_staff);
            this.Controls.Add(this.lbl_door);
            this.Controls.Add(this.txt_operation);
            this.Controls.Add(this.txt_door_id);
            this.Controls.Add(this.cmb_staff);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Completion_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Completion_menu";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_completion_log)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pct_logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_staff;
        private System.Windows.Forms.TextBox txt_door_id;
        private System.Windows.Forms.Label lbl_door;
        private System.Windows.Forms.Label Lbl_staff;
        private System.Windows.Forms.Label lbl_operation;
        private System.Windows.Forms.DataGridView grid_completion_log;
        private System.Windows.Forms.Button bt_complete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_operation;
        private System.Windows.Forms.TextBox txt_percent_total;
    }
}