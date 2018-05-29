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
    public partial class packing_report : Form
    {
        public packing_report()
        {
            InitializeComponent();
        }

        private void packing_report_Load(object sender, EventArgs e)
        {
           
            txt_door.Text = Public.door_id;
            if(txt_door.Text != "")
            {      

                btn_search.PerformClick();
                this.Hide();
            }
            this.view_label.RefreshReport();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_door.Text))
            {

                MessageBox.Show("Please Enter A Door Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            this.c_view_packing_reportTableAdapter.Fill(this.packing_dataset.c_view_packing_report,Convert.ToInt32(txt_door.Text));
           // this.c_view_packing_reportTableAdapter.Fill(this.packing_dataset.c_view_packing_report, Convert.ToInt32(txt_door.Text));
            this.rpt_viewer.RefreshReport();
            this.view_label.RefreshReport();
        }

        private void txt_door_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {

                btn_search.PerformClick();
            }
        }

       
    }
}
