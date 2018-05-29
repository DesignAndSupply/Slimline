using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Slimline_Shopfloor
{
    public partial class Purchase_order : Form
    {

        DataTable po = new DataTable();
        public Purchase_order()
        {
            InitializeComponent();
           
        }

        private void pct_search_Click(object sender, EventArgs e)
        {
            

            try
            {



                SqlDataAdapter select_po = new SqlDataAdapter(Public.select_po, Public.order_database);
                
                select_po.SelectCommand.Parameters.AddWithValue("po", txt_po.Text);
                select_po.Fill(po);
                grid_po.DataSource = po;
                Format();
             

            }

            catch (Exception)
            {



                // messagebox

            }



        }
        void Format()
        {

            grid_po.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_po.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_po.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid_po.EnableHeadersVisualStyles = false;
          
           
        }

        private void pct_report_Click(object sender, EventArgs e)
        {
            Public.po_number = txt_po.Text;
            PO_report report = new PO_report();
            report.Show();
        }
    }
}
