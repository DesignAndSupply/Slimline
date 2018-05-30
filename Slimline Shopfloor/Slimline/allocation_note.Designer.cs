namespace Slimline_Shopfloor
{
    partial class allocation_note
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(allocation_note));
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pct_icon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_op = new System.Windows.Forms.Label();
            this.lbl_door = new System.Windows.Forms.Label();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.btn_save_note = new System.Windows.Forms.Button();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_icon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel8.Location = new System.Drawing.Point(229, 36);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 0);
            this.panel8.TabIndex = 21;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel9.Controls.Add(this.pct_icon);
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(167, 1100);
            this.panel9.TabIndex = 22;
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
            this.panel1.Controls.Add(this.lbl_op);
            this.panel1.Controls.Add(this.lbl_door);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2000, 100);
            this.panel1.TabIndex = 23;
            // 
            // lbl_op
            // 
            this.lbl_op.AutoSize = true;
            this.lbl_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_op.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_op.Location = new System.Drawing.Point(411, 51);
            this.lbl_op.Name = "lbl_op";
            this.lbl_op.Size = new System.Drawing.Size(95, 29);
            this.lbl_op.TabIndex = 1;
            this.lbl_op.Text = "Door ID";
            this.lbl_op.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_door
            // 
            this.lbl_door.AutoSize = true;
            this.lbl_door.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_door.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_door.Location = new System.Drawing.Point(410, 15);
            this.lbl_door.Name = "lbl_door";
            this.lbl_door.Size = new System.Drawing.Size(95, 29);
            this.lbl_door.TabIndex = 0;
            this.lbl_door.Text = "Door ID";
            this.lbl_door.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_note
            // 
            this.txt_note.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_note.Location = new System.Drawing.Point(229, 176);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(572, 20);
            this.txt_note.TabIndex = 24;
            // 
            // btn_save_note
            // 
            this.btn_save_note.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_save_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_note.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_save_note.Location = new System.Drawing.Point(726, 346);
            this.btn_save_note.Name = "btn_save_note";
            this.btn_save_note.Size = new System.Drawing.Size(75, 43);
            this.btn_save_note.TabIndex = 25;
            this.btn_save_note.Text = "Save Note";
            this.btn_save_note.UseVisualStyleBackColor = false;
            this.btn_save_note.Click += new System.EventHandler(this.btn_save_note_Click);
            // 
            // allocation_note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 434);
            this.Controls.Add(this.btn_save_note);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "allocation_note";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Allocation Note";
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pct_icon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_door;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.Button btn_save_note;
        private System.Windows.Forms.Label lbl_op;
        private System.Windows.Forms.PictureBox pct_icon;
    }
}