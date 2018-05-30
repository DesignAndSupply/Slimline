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
    public partial class admin_menu : Form
    {
        public static DataTable dt_stock_allocation = new DataTable();
        public static DataTable dt_shopfloor_staff= new DataTable();
        public static DataTable dt_office_staff = new DataTable();

        public admin_menu()
        {
            InitializeComponent();
            Fill_data();
        }

        void Fill_data()
        {
            Public.order_database.Close();
            Public.order_database.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapater = new SqlDataAdapter(Public.select_completion_log, Public.order_database);
            adapater.SelectCommand.Parameters.AddWithValue("@start", Public.sqlFormattedDate);
            adapater.SelectCommand.Parameters.AddWithValue("@end", Public.sqlFormattedDate_end);
            adapater.Fill(dt);
            completion_log.DataSource = dt;

            double total = 0;

            for (int i = 0; i < completion_log.Rows.Count; ++i)
            {

                total += Convert.ToDouble(completion_log.Rows[i].Cells[2].Value);

              
            }
            double total_hours =  Math.Round(total/60, 2,MidpointRounding.AwayFromZero) ;
            txt_total.Text = total_hours.ToString();
            Public.order_database.Close();



            completion_log.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            completion_log.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            completion_log.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            completion_log.EnableHeadersVisualStyles = false;
            tab_admin.Appearance = TabAppearance.FlatButtons; tab_admin.ItemSize = new Size(0, 1); tab_admin.SizeMode = TabSizeMode.Fixed;
        }

        void Format()
        {

            grid_item_selection.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_item_selection.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_item_selection.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid_item_selection.EnableHeadersVisualStyles = false;
            grid_items.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_items.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_items.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid_items.EnableHeadersVisualStyles = false;
            grid_item_selection.Columns[0].Width = 70;
            grid_item_selection.Columns[1].Width = 250;
            grid_item_selection.Columns[2].Width = 70;
        }

        void Allocation_data_fill()
        {
            dt_shopfloor_staff.Clear();
            dt_shopfloor_staff.Columns.Clear();
            Public.user_database.Open();
            Public.User_list.Fill(dt_shopfloor_staff);
            dt_shopfloor_staff.Columns.Add("fullname", typeof(string), "forename + ' ' +surname");
            cmb_allocated_to.DisplayMember = "fullname";
            cmb_allocated_to.ValueMember = "ID";
            cmb_allocated_to.DataSource = dt_shopfloor_staff;
            cmb_allocated_to.TabIndex = 1;
            cmb_allocated_to.SelectedIndex = -1;


            dt_office_staff.Clear();
            dt_office_staff.Columns.Clear();
            Public.user_list_office.Fill(dt_office_staff);
            dt_office_staff.Columns.Add("fullname", typeof(string), "forename + ' ' +surname");
            cmb_allocated_by.DisplayMember = "fullname";
            cmb_allocated_by.ValueMember = "ID";
            cmb_allocated_by.DataSource = dt_office_staff;
            cmb_allocated_by.TabIndex = 1;
            cmb_allocated_by.SelectedIndex = -1;
            Public.user_database.Close();


            dt_stock_allocation.Clear();
            SqlDataAdapter select_stock_allocation = new SqlDataAdapter(Public.select_stock_allocation, Public.order_database);
            select_stock_allocation.Fill(dt_stock_allocation);
            grid_item_selection.DataSource = dt_stock_allocation;
            Public.order_database.Close();

            Format();


        }

        void Search_stock()
        {
            if (Public.order_database != null && Public.order_database.State == ConnectionState.Closed)
            {

                Public.order_database.Open();
            }
            if (txt_description.Text != "" && txt_stock_code.Text != "")
            {
                dt_stock_allocation.Clear();
                SqlDataAdapter search_stock_description_stock_code = new SqlDataAdapter(Public.search_stock_description_stock_code, Public.order_database);
                search_stock_description_stock_code.SelectCommand.Parameters.AddWithValue("@description", txt_description.Text.ToString());
                search_stock_description_stock_code.SelectCommand.Parameters.AddWithValue("@stock_code",Convert.ToInt32(txt_stock_code.Text.ToString()));
                search_stock_description_stock_code.Fill(dt_stock_allocation);
              


            }
            if (txt_description.Text != "" && txt_stock_code.Text == "")
            {

                dt_stock_allocation.Clear();
                SqlDataAdapter search_stock_description = new SqlDataAdapter(Public.search_stock_description, Public.order_database);
                search_stock_description.SelectCommand.Parameters.AddWithValue("@description", txt_description.Text.ToString());
                search_stock_description.SelectCommand.Parameters.AddWithValue("@stock_code", Convert.ToInt32(txt_stock_code.Text.ToString()));
                search_stock_description.Fill(dt_stock_allocation);

             
            }
            if ( txt_stock_code.Text != "" && txt_description.Text== "")
            {

                dt_stock_allocation.Clear();

                SqlDataAdapter search_stock_code = new SqlDataAdapter(Public.search_stock_code, Public.order_database);
                search_stock_code.SelectCommand.Parameters.AddWithValue("@description", txt_description.Text.ToString());
                search_stock_code.SelectCommand.Parameters.AddWithValue("@stock_code", Convert.ToInt32(txt_stock_code.Text.ToString()));
                search_stock_code.Fill(dt_stock_allocation);
            
               
            }
            if(txt_stock_code.Text=="" && txt_description.Text=="")
            {
                dt_stock_allocation.Clear();
                SqlDataAdapter select_stock_allocation = new SqlDataAdapter(Public.select_stock_allocation, Public.order_database);
                select_stock_allocation.Fill(dt_stock_allocation);
                grid_item_selection.DataSource = dt_stock_allocation;
              

            }
            if (Public.order_database != null && Public.order_database.State == ConnectionState.Open)
            {

                Public.order_database.Close();
            }
            Format();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            SqlCommand update_department_goal = new SqlCommand(Public.correct_department_goal, Public.order_database);
            if (Public.order_database != null && Public.order_database.State == ConnectionState.Closed)
            {
                Public.order_database.Open();

            }
            update_department_goal.Parameters.AddWithValue("@date", Public.sqlFormattedDate);
            update_department_goal.Parameters.AddWithValue("@time", txt_total.Text);
            update_department_goal.ExecuteNonQuery();
            Public.order_database.Close();
            MessageBox.Show("Department Goal Succesfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Hide();
        }

        private void pct_add_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grid_item_selection.SelectedRows)
            {
                int i = grid_items.RowCount - 1;
                int r = Convert.ToInt32(row.Index);
                grid_items.Rows.Add(1);
                String stock_code = grid_item_selection.Rows[r].Cells[0].Value.ToString();
                String description = grid_item_selection.Rows[r].Cells[1].Value.ToString();
                // Int32 id = Convert.ToInt32(list_loose_items.SelectedItems.);
                grid_items.Rows[i].Cells[0].Value = stock_code;
                grid_items.Rows[i].Cells[1].Value = description;
                grid_items.Rows[i].Cells[2].Value = "1";
            }
           
        }

        private void btn_allocate_Click(object sender, EventArgs e)
        {
            Allocation_data_fill();
            tab_admin.SelectedTab = tab_stock_allocation;
        }

        private void btn_deduction_log_Click(object sender, EventArgs e)
        {
            tab_admin.SelectedTab = tab_daily_goals;
        }

        private void btn_complete_Click(object sender, EventArgs e)
        {

            List<string> empty = new List<string>();

            if (cmb_allocated_by.Text.ToString() == "")
            {

                MessageBox.Show("Please Choose Staff Allocated By", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;


            }

            if (cmb_allocated_to.Text.ToString() == "")
            {

                MessageBox.Show("Please Choose Staff To Allocate Stock To", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;


            }

            for (int i = 0; i < grid_items.Rows.Count - 1; i++)
            {

              
               
                if (grid_items.Rows[i].Cells[2].Value == null) 
                {

                    empty.Add(i+1 + " , ");

                }


            }

            if (empty.Count > 0)
            {

                var message = string.Join(Environment.NewLine, empty);
                
                MessageBox.Show("           Please Choose Quantity to Deduct in row      " + message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            for (int i = 0; i < grid_items.Rows.Count - 1; i++)
            {
                
                string stock_code = grid_items.Rows[i].Cells[0].Value.ToString();
                string description = grid_items.Rows[i].Cells[1].Value.ToString();
                string qty = grid_items.Rows[i].Cells[2].Value.ToString();
                string allocated_to = cmb_allocated_to.Text;
                string allocated_by = cmb_allocated_by.SelectedValue.ToString();
                SqlCommand update_stock = new SqlCommand(Public.update_stock, Public.order_database);
                SqlCommand insert_stock_log_admin = new SqlCommand(Public.insert_stock_log_admin, Public.order_database);
                update_stock.Parameters.AddWithValue("@qty", qty);
                update_stock.Parameters.AddWithValue("@stock_code", stock_code);
                insert_stock_log_admin.Parameters.AddWithValue("@description", description);
                insert_stock_log_admin.Parameters.AddWithValue("@qty", qty);
                insert_stock_log_admin.Parameters.AddWithValue("@staff_allocated_to", allocated_to);
                insert_stock_log_admin.Parameters.AddWithValue("@date", DateTime.Now);
                insert_stock_log_admin.Parameters.AddWithValue("@stock", stock_code);
                insert_stock_log_admin.Parameters.AddWithValue("@staff_allocated_by", allocated_by);
            }
           
        }

        private void pct_search_stock_Click(object sender, EventArgs e)
        {
            Search_stock();
        }

        private void txt_stock_code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {

                Search_stock();

            }
        }

        private void txt_description_KeyDown(object sender, KeyEventArgs e)
        {
            Search_stock();
        }

        private void pct_clear_Click(object sender, EventArgs e)
        {
            txt_description.Text = "";
            txt_stock_code.Text = "";
            Search_stock();
        }

        private void completion_log_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_delete_selected_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (DataGridViewRow row in grid_items.SelectedRows)
                {
                    grid_items.Rows.RemoveAt(row.Index);
                }


            }
            catch
            {

            }
        }

        private void btn_delete_all_Click(object sender, EventArgs e)
        {

            grid_items.Rows.Clear();
        }
    }
}
