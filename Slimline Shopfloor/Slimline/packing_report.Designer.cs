namespace Slimline_Shopfloor
{
    partial class packing_report
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(packing_report));
            this.c_view_packing_reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packing_dataset = new Slimline_Shopfloor.packing_dataset();
            this.c_view_packing_reportTableAdapter = new Slimline_Shopfloor.packing_datasetTableAdapters.c_view_packing_reportTableAdapter();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_door = new System.Windows.Forms.TextBox();
            this.rpt_viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.view_label = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pct_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c_view_packing_reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packing_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // c_view_packing_reportBindingSource
            // 
            this.c_view_packing_reportBindingSource.DataMember = "c_view_packing_report";
            this.c_view_packing_reportBindingSource.DataSource = this.packing_dataset;
            // 
            // packing_dataset
            // 
            this.packing_dataset.DataSetName = "packing_dataset";
            this.packing_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c_view_packing_reportTableAdapter
            // 
            this.c_view_packing_reportTableAdapter.ClearBeforeFill = true;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_search.Location = new System.Drawing.Point(996, 35);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 33);
            this.btn_search.TabIndex = 18;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_door
            // 
            this.txt_door.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_door.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_door.Location = new System.Drawing.Point(1077, 41);
            this.txt_door.Name = "txt_door";
            this.txt_door.Size = new System.Drawing.Size(100, 22);
            this.txt_door.TabIndex = 17;
            this.txt_door.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_door_KeyDown);
            // 
            // rpt_viewer
            // 
            this.rpt_viewer.BackColor = System.Drawing.Color.AliceBlue;
            this.rpt_viewer.ForeColor = System.Drawing.Color.CornflowerBlue;
            reportDataSource1.Name = "packing_dataset";
            reportDataSource1.Value = this.c_view_packing_reportBindingSource;
            this.rpt_viewer.LocalReport.DataSources.Add(reportDataSource1);
            this.rpt_viewer.LocalReport.ReportEmbeddedResource = "Slimline_Shopfloor.Reports.packing_report.rdlc";
            this.rpt_viewer.Location = new System.Drawing.Point(58, 104);
            this.rpt_viewer.Name = "rpt_viewer";
            this.rpt_viewer.ServerReport.BearerToken = null;
            this.rpt_viewer.ShowBackButton = false;
            this.rpt_viewer.ShowContextMenu = false;
            this.rpt_viewer.ShowCredentialPrompts = false;
            this.rpt_viewer.ShowDocumentMapButton = false;
            this.rpt_viewer.ShowExportButton = false;
            this.rpt_viewer.ShowFindControls = false;
            this.rpt_viewer.ShowParameterPrompts = false;
            this.rpt_viewer.ShowProgress = false;
            this.rpt_viewer.ShowPromptAreaButton = false;
            this.rpt_viewer.ShowStopButton = false;
            this.rpt_viewer.Size = new System.Drawing.Size(1128, 438);
            this.rpt_viewer.TabIndex = 16;
            // 
            // view_label
            // 
            this.view_label.BackColor = System.Drawing.Color.AliceBlue;
            this.view_label.ForeColor = System.Drawing.Color.CornflowerBlue;
            reportDataSource2.Name = "packing_label";
            reportDataSource2.Value = this.c_view_packing_reportBindingSource;
            this.view_label.LocalReport.DataSources.Add(reportDataSource2);
            this.view_label.LocalReport.ReportEmbeddedResource = "Slimline_Shopfloor.Reports.packing_label.rdlc";
            this.view_label.Location = new System.Drawing.Point(790, 296);
            this.view_label.Name = "view_label";
            this.view_label.ServerReport.BearerToken = null;
            this.view_label.ShowBackButton = false;
            this.view_label.ShowExportButton = false;
            this.view_label.ShowFindControls = false;
            this.view_label.ShowPageNavigationControls = false;
            this.view_label.ShowRefreshButton = false;
            this.view_label.ShowStopButton = false;
            this.view_label.ShowZoomControl = false;
            this.view_label.Size = new System.Drawing.Size(396, 246);
            this.view_label.TabIndex = 20;
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
            // packing_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1242, 578);
            this.Controls.Add(this.pct_icon);
            this.Controls.Add(this.view_label);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_door);
            this.Controls.Add(this.rpt_viewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "packing_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Packing Label";
            this.Load += new System.EventHandler(this.packing_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c_view_packing_reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packing_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource c_view_packing_reportBindingSource;
        private packing_dataset packing_dataset;
        private packing_datasetTableAdapters.c_view_packing_reportTableAdapter c_view_packing_reportTableAdapter;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_door;
        private Microsoft.Reporting.WinForms.ReportViewer rpt_viewer;
        private Microsoft.Reporting.WinForms.ReportViewer view_label;
        private System.Windows.Forms.PictureBox pct_icon;
    }
}