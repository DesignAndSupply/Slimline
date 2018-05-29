namespace Slimline_Shopfloor
{
    partial class PO_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PO_report));
            this.po_itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PO_dataset = new Slimline_Shopfloor.PO_dataset();
            this.rpt_viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_po = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.po_itemTableAdapter = new Slimline_Shopfloor.PO_datasetTableAdapters.po_itemTableAdapter();
            this.pct_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.po_itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PO_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // po_itemBindingSource
            // 
            this.po_itemBindingSource.DataMember = "po_item";
            this.po_itemBindingSource.DataSource = this.PO_dataset;
            // 
            // PO_dataset
            // 
            this.PO_dataset.DataSetName = "PO_dataset";
            this.PO_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpt_viewer
            // 
            this.rpt_viewer.BackColor = System.Drawing.Color.AliceBlue;
            this.rpt_viewer.ForeColor = System.Drawing.Color.CornflowerBlue;
            reportDataSource1.Name = "PO_dataset";
            reportDataSource1.Value = this.po_itemBindingSource;
            this.rpt_viewer.LocalReport.DataSources.Add(reportDataSource1);
            this.rpt_viewer.LocalReport.ReportEmbeddedResource = "Slimline_Shopfloor.Reports.PO_report.rdlc";
            this.rpt_viewer.Location = new System.Drawing.Point(94, 102);
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
            this.rpt_viewer.Size = new System.Drawing.Size(705, 283);
            this.rpt_viewer.TabIndex = 0;
            // 
            // txt_po
            // 
            this.txt_po.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_po.Location = new System.Drawing.Point(669, 61);
            this.txt_po.Name = "txt_po";
            this.txt_po.Size = new System.Drawing.Size(100, 20);
            this.txt_po.TabIndex = 1;
            this.txt_po.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_po_KeyDown);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_search.Location = new System.Drawing.Point(588, 60);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // po_itemTableAdapter
            // 
            this.po_itemTableAdapter.ClearBeforeFill = true;
            // 
            // pct_logo
            // 
            this.pct_logo.Image = global::Slimline_Shopfloor.Properties.Resources.Slimline1;
            this.pct_logo.Location = new System.Drawing.Point(0, 0);
            this.pct_logo.Name = "pct_logo";
            this.pct_logo.Size = new System.Drawing.Size(164, 97);
            this.pct_logo.TabIndex = 15;
            this.pct_logo.TabStop = false;
            // 
            // PO_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(898, 525);
            this.Controls.Add(this.pct_logo);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_po);
            this.Controls.Add(this.rpt_viewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PO_report";
            this.Text = "PO Report";
            this.Load += new System.EventHandler(this.PO_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.po_itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PO_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpt_viewer;
        private System.Windows.Forms.BindingSource po_itemBindingSource;
        private PO_dataset PO_dataset;
        private PO_datasetTableAdapters.po_itemTableAdapter po_itemTableAdapter;
        private System.Windows.Forms.TextBox txt_po;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.PictureBox pct_logo;
    }
}