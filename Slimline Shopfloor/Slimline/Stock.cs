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
    public partial class Stock : Form
    {
        public DataTable dt_stock = new DataTable();
        public DataTable dt_pallet = new DataTable();
        public DataTable dt_staff = new DataTable();
       

        public Stock()
        {
            InitializeComponent();
            Fill_data();
            Format();
        }

        public void Fill_data()
        {
            dt_staff.Clear();
            dt_stock.Clear();
            SqlDataAdapter select_stock = new SqlDataAdapter(Public.select_stock, Public.order_database);
            SqlDataAdapter select_pallet = new SqlDataAdapter(Public.select_pallet, Public.order_database);
            if (Public.order_database != null && Public.order_database.State == ConnectionState.Closed)
            {
                Public.order_database.Open();
            }
           
            select_stock.Fill(dt_stock);
            select_pallet.Fill(dt_pallet);
            grid_stock.DataSource = dt_stock;
            grid_pallet.DataSource = dt_pallet;
            Public.order_database.Close();

            Public.user_database.Open();
            Public.User_list_pallet.Fill(dt_staff);

            dt_staff.Columns.Add("fullname", typeof(string), "forename + ' ' +surname");

            cmb_staff.DisplayMember = "fullname";
            cmb_staff.ValueMember = "id";
            cmb_staff.DataSource = dt_staff;
            cmb_staff.TabIndex = 1;
            Public.user_database.Close();
        }

        public void refresh_data()
        {
         dt_stock.Clear();
         dt_pallet.Clear();
       

         SqlDataAdapter select_stock = new SqlDataAdapter(Public.select_stock, Public.order_database);
         SqlDataAdapter select_pallet = new SqlDataAdapter(Public.select_pallet, Public.order_database);
         select_stock.Fill(dt_stock);
         select_pallet.Fill(dt_pallet);

         grid_pallet.DataSource = dt_pallet;
         grid_stock.DataSource = dt_stock;
         Public.order_database.Close();
         
        }

        public void Format()
        {


            grid_stock.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_stock.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_stock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid_stock.EnableHeadersVisualStyles = false;
            grid_pallet.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_pallet.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_pallet.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid_pallet.EnableHeadersVisualStyles = false;
            btn_decrease.DisplayIndex = grid_stock.ColumnCount - 1;
            btn_increase.DisplayIndex = grid_stock.ColumnCount - 1;
        }

        private void grid_stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == grid_stock.Columns["btn_increase"].Index && e.RowIndex >= 0)

                try
                {
                
                    int i = e.RowIndex;
                    string id = dt_stock.Rows[i]["stock id"].ToString();

                    if (Public.order_database != null && Public.order_database.State == ConnectionState.Closed)
                    {
                        Public.order_database.Open();
                    }

                    SqlCommand increase_stock = new SqlCommand(Public.increase_stock, Public.order_database);
                    increase_stock.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                    increase_stock.ExecuteNonQuery();
                 
                    refresh_data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "");

                }
            if (e.ColumnIndex == grid_stock.Columns["btn_decrease"].Index && e.RowIndex >= 0)

                try
                {
                    int i = e.RowIndex;
                    int id = Convert.ToInt32(dt_stock.Rows[i]["stock id"].ToString());
                    int door_id = Convert.ToInt32(dt_stock.Rows[i]["Door ID"].ToString());
                    int low_level = Convert.ToInt32(dt_stock.Rows[i]["Low Level"].ToString());
                    Int32 qty;
                    SqlCommand command_check_reorder = new SqlCommand(Public.select_quantity_same_sr_addon, Public.order_database);
                    command_check_reorder.Parameters.AddWithValue("@id",door_id);
                   
                    if (Public.order_database != null && Public.order_database.State == ConnectionState.Closed)
                    {
                        Public.order_database.Open();

                    }
                    SqlDataReader reader_check_reorder = command_check_reorder.ExecuteReader();
                    if (reader_check_reorder.Read())
                    {

                        qty = Convert.ToInt32(reader_check_reorder["quantity_same"]);
                        MessageBox.Show(qty.ToString(), "");
                        reader_check_reorder.Close();
                        ;

                    }
                    else
                    {

                        qty = 0;
                        reader_check_reorder.Close();
                    }
                    
                   
                    SqlCommand increase_stock = new SqlCommand(Public.decrease_stock, Public.order_database);
                    increase_stock.Parameters.AddWithValue("@id",Convert.ToInt32(id));
                    increase_stock.ExecuteNonQuery();
                    refresh_data();

                    int Updated_amount_in_stock = Convert.ToInt32(dt_stock.Rows[i][3].ToString());
                    if(low_level>=(qty+Updated_amount_in_stock))
                    {
                        if (Public.order_database != null && Public.order_database.State == ConnectionState.Closed)
                        {
                            Public.order_database.Open();
                                                       
                        }
                        List<DayOfWeek> daysOfWeek = new List<DayOfWeek>();
                        List<DateTime> day = Functions.ProcessDate(daysOfWeek);
                        DateTime Cutting_date = Convert.ToDateTime(day[0]);
                        DateTime Prepping_date = Convert.ToDateTime(day[1]);
                        DateTime Assembly_date = Convert.ToDateTime(day[2]);
                        DateTime SL_buff_date = Convert.ToDateTime(day[3]);
                        DataTable dt_default_time = new DataTable();
                        SqlDataAdapter default_time = new SqlDataAdapter(Public.default_time, Public.order_database);
                        default_time.SelectCommand.Parameters.AddWithValue("@id", door_id);
                        default_time.Fill(dt_default_time);
                        string Cutting_time = dt_default_time.Rows[0][0].ToString();
                        string assembly_time = dt_default_time.Rows[0][1].ToString();
                        string packing_time = dt_default_time.Rows[0][2].ToString();
                        string sl_buff_time = dt_default_time.Rows[0][3].ToString();

                        SqlCommand update_stock_door = new SqlCommand(Public.update_stock_door, Public.order_database);
                        update_stock_door.Parameters.AddWithValue("@cutting_date", Cutting_date);
                        update_stock_door.Parameters.AddWithValue("@Prepping_date", Prepping_date);
                        update_stock_door.Parameters.AddWithValue("@Assembly_date", Assembly_date);
                        update_stock_door.Parameters.AddWithValue("@SL_buff_date", SL_buff_date);
                        update_stock_door.Parameters.AddWithValue("@id", door_id);
                        update_stock_door.ExecuteNonQuery();
                        Public.order_database.Close();
                    }
                    else
                    {
                  

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "");

                }
        }
        
        private void btn_deduct_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_quantity.Text))
            {
                MessageBox.Show("Please Enter A Quantity", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
           
            SqlCommand update_amount = new SqlCommand(Public.decrease_pallet, Public.order_database);
            SqlCommand insert_subtract_pallet = new SqlCommand(Public.insert_subtract_pallet, Public.order_database);
            SqlCommand insert_stock_log = new SqlCommand(Public.insert_stock_log, Public.order_database);
            update_amount.Parameters.AddWithValue("@quantity", txt_quantity.Text);
            insert_subtract_pallet.Parameters.AddWithValue("@staff", cmb_staff.Text);
            insert_subtract_pallet.Parameters.AddWithValue("@date", DateTime.Now);
            insert_subtract_pallet.Parameters.AddWithValue("@quantity", txt_quantity.Text);
            insert_stock_log.Parameters.AddWithValue("@quantity", txt_quantity.Text);
            insert_stock_log.Parameters.AddWithValue("@staff", cmb_staff.Text);
            insert_stock_log.Parameters.AddWithValue("@date",DateTime.Today);
            insert_stock_log.Parameters.AddWithValue("@staff_id",cmb_staff.SelectedValue);
            insert_stock_log.Parameters.AddWithValue("@booked", cmb_staff.SelectedValue);
      

            DialogResult result = MessageBox.Show("Subtracting " + txt_quantity.Text + " Pallets, Is this Correct?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Public.order_database.Open();
                update_amount.ExecuteNonQuery();
                insert_subtract_pallet.ExecuteNonQuery();
                insert_stock_log.ExecuteNonQuery();
       
                refresh_data();
            }
            else
            {
                return;
            }
           
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_quantity.Text))
            {
                MessageBox.Show("Please Enter A Quantity", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            SqlCommand update_amount = new SqlCommand(Public.increase_pallet, Public.order_database);
            SqlCommand insert_additional_pallet = new SqlCommand(Public.insert_additional_pallet, Public.order_database);
            SqlCommand insert_stock_log = new SqlCommand(Public.insert_stock_log, Public.order_database);
            update_amount.Parameters.AddWithValue("@quantity", txt_quantity.Text);
            insert_additional_pallet.Parameters.AddWithValue("@staff", cmb_staff.Text);
            insert_additional_pallet.Parameters.AddWithValue("@date", DateTime.Now);
            insert_additional_pallet.Parameters.AddWithValue("@quantity", txt_quantity.Text);
            insert_stock_log.Parameters.AddWithValue("@quantity", txt_quantity.Text);
            insert_stock_log.Parameters.AddWithValue("@staff", cmb_staff.Text);
            insert_stock_log.Parameters.AddWithValue("@date", DateTime.Today);
            insert_stock_log.Parameters.AddWithValue("@staff_id", cmb_staff.SelectedValue);
            insert_stock_log.Parameters.AddWithValue("@booked", cmb_staff.SelectedValue);


            DialogResult result = MessageBox.Show("Adding " + txt_quantity.Text + " Pallets, Is this Correct?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Public.order_database.Open();
                update_amount.ExecuteNonQuery();
                insert_additional_pallet.ExecuteNonQuery();
                insert_stock_log.ExecuteNonQuery();

                refresh_data();
            }
            else
            {
                return;
            }

            
        }

      
    }
}
