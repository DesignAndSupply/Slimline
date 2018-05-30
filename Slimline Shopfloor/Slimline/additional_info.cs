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
    public partial class additional_info : Form
    {
        public additional_info()
        {
            InitializeComponent();
            Filldata();
            format();
        }
        public void format()
        {
            grid_loose_item.EnableHeadersVisualStyles = false;
            grid_loose_item.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_loose_item.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;

        }

        public void Filldata()
        {
            DataTable dt_notes = new DataTable();
            DataTable dt_items = new DataTable();
            SqlDataAdapter loose_items = new SqlDataAdapter(Public.select_loose_items, Public.order_database);
            SqlDataAdapter notes = new SqlDataAdapter(Public.select_packing_notes, Public.order_database);
            if(Public.order_database != null && Public.order_database.State == ConnectionState.Closed)
            {
                Public.order_database.Open();
            }
            
            loose_items.Fill(dt_items);
            notes.Fill(dt_notes);
            cmb_notes.DataSource = dt_notes;
            cmb_notes.DisplayMember = "description";
            cmb_notes.TabIndex = 1;
            txt_door_id.Text = Public.second_validation_door_id;

            foreach (DataRow row in dt_items.Rows)
            {
                ListViewItem item = new ListViewItem((row[1].ToString())); item.SubItems.Add((row[0].ToString()));
              
                for (int i = 1; i < dt_items.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                   

                }
                list_loose_items.Items.Add(item);
            
            }

            Public.order_database.Close();
          

          
        }

        private void pct_add_Click(object sender, EventArgs e)
        {
            try
            {
                int i = grid_loose_item.RowCount - 1;
                grid_loose_item.Rows.Add(1);
                String text = list_loose_items.SelectedItems[0].Text;
                String id = list_loose_items.SelectedItems[0].SubItems[1].Text;
                // Int32 id = Convert.ToInt32(list_loose_items.SelectedItems.);
                grid_loose_item.Rows[i].Cells[0].Value = id;
                grid_loose_item.Rows[i].Cells[1].Value = text;
                grid_loose_item.Rows[i].Cells[2].Value = 1;
                grid_loose_item.Rows[i].Cells[3].Value = cmb_notes.Text;

            }

            catch
            {

            }

        }

        private void btn_delete_all_Click(object sender, EventArgs e)
        {
            grid_loose_item.Rows.Clear();
        }

        private void btn_delete_selected_Click(object sender, EventArgs e)
        {
            try
            { 

                foreach (DataGridViewRow row in grid_loose_item.SelectedRows)
                {
                    grid_loose_item.Rows.RemoveAt(row.Index);
                }


            }
            catch
            {

            }
           
        }

        private void btn_complete_Click(object sender, EventArgs e)
        {
            if(cmb_box.SelectedItem == null)
            {


                MessageBox.Show("Please Select Number of Boxes", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmb_frame.SelectedItem == null)
            {


                MessageBox.Show("Please frame Yes/No", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (cmb_keys.SelectedItem == null)
            {


                MessageBox.Show("Please Keys Yes/No", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (cmb_pallet.SelectedItem == null)
            {


                MessageBox.Show("Please Select On pallet Yes/NO ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            SqlCommand insert_additional = new SqlCommand(Public.insert_additional, Public.order_database);
            SqlCommand insert_loose_item = new SqlCommand(Public.insert_loose_item, Public.order_database);
            if (Public.order_database != null && Public.order_database.State == ConnectionState.Closed)
            {
                Public.order_database.Open();

            }
          
           
                for (int i = 0; i < grid_loose_item.Rows.Count-1; i++)
                {

                    string note = Convert.ToString(grid_loose_item.Rows[i].Cells[3].Value);
                    Int32 loose_item_id = Convert.ToInt32(grid_loose_item.Rows[i].Cells[0].Value);
                    Int32 quantity = Convert.ToInt32(grid_loose_item.Rows[i].Cells[2].Value);
                    insert_loose_item.Parameters.Clear();
                    insert_loose_item.Parameters.AddWithValue("@door_id",Convert.ToInt32(Public.door_id));
                    insert_loose_item.Parameters.AddWithValue("@loost_item_id", loose_item_id);
                    insert_loose_item.Parameters.AddWithValue("@date", DateTime.Now);
                    insert_loose_item.Parameters.AddWithValue("@user_id", Public.staff_id);
                    insert_loose_item.Parameters.AddWithValue("@quantity", quantity);
                    insert_loose_item.Parameters.AddWithValue("@notes", note);
                    insert_loose_item.ExecuteNonQuery();



                }
            try
            {
                int keys;
                int frame;
               
                if (Convert.ToString (cmb_keys.SelectedItem) == "Yes")
                {

                    keys = -1;
                }
                else
                {
                    keys = 0;
                }
                if (Convert.ToString(cmb_frame.SelectedItem) == "Yes")
                {

                    frame = -1;
                }
                else
                {
                    frame = 0;
                }
                insert_additional.Parameters.AddWithValue("@keys",keys);
                insert_additional.Parameters.AddWithValue("@box",cmb_box.SelectedItem);
                insert_additional.Parameters.AddWithValue("@qty", Convert.ToString(cmb_pallet.SelectedItem));
                insert_additional.Parameters.AddWithValue("@frame",frame);
                insert_additional.Parameters.AddWithValue("@id", txt_door_id.Text);
                insert_additional.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"");
                return;
            }

            Public.order_database.Close();

            this.Hide();


            
        }

        private void grid_loose_item_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return) 
                {
                    return;
                }
        }
    }
}
