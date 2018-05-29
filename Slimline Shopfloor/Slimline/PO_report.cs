using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slimline_Shopfloor
{
    public partial class PO_report : Form
    {
        public PO_report()
        {
            InitializeComponent();
        }

        private void PO_report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PO_dataset.po_item' table. You can move, or remove it, as needed.
            //  this.po_itemTableAdapter.Fill(this.PO_dataset.po_item);
            // TODO: This line of code loads data into the 'PO_dataset.po_item' table. You can move, or remove it, as needed.
            // this.po_itemTableAdapter.Fill(this.PO_dataset.po_item);
            // TODO: This line of code loads data into the 'PO_dataset.po_item' table. You can move, or remove it, as needed.
            // this.po_itemTableAdapter.Fill(this.PO_dataset.po_item);
            // TODO: This line of code loads data into the 'PO_dataset.po_item' table. You can move, or remove it, as needed.
            if (string.IsNullOrWhiteSpace(Public.po_number))
            {
                return;
                 
            }
            else
            {
                txt_po.Text = Public.po_number;
                btn_search.PerformClick();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.po_itemTableAdapter.Fill(this.PO_dataset.po_item, Convert.ToInt32(txt_po.Text));

            this.rpt_viewer.RefreshReport();
        }

        private void txt_po_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {

                btn_search.PerformClick();
            }
        }

      
      
    }
}
