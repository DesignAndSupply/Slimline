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
    public partial class Completion_menu : Form
    {
        DataTable completion_log = new DataTable();

        public Completion_menu()
        {
            InitializeComponent();
            Fill_data();
            Format();
        }

        void Fill_data()

        {

            Public.order_database_view.Open();
            SqlCommand select_quantity_same = new SqlCommand(Public.select_quantity_same, Public.order_database_view);
            select_quantity_same.Parameters.AddWithValue("@ID", Public.second_validation_door_id);
            object qty_same = select_quantity_same.ExecuteScalar();
            if (qty_same!=null)
            {

                Public.quantity_same =Convert.ToInt32(qty_same);
            }
            SqlDataAdapter ada = new SqlDataAdapter(Public.select_data, Public.order_database_view);
            ada.SelectCommand.Parameters.AddWithValue("@door_id", Public.second_validation_door_id);
            ada.SelectCommand.Parameters.AddWithValue("@operation", Public.Operation_log);
            ada.Fill(completion_log);
            grid_completion_log.DataSource = completion_log;
            DataTable t = new DataTable();
            Public.User_list.Fill(t);
            t.Columns.Add("fullname", typeof(string), "forename + ' ' +surname");
            // Bind the table to the list box
            cmb_staff.DisplayMember = "fullname";
            cmb_staff.ValueMember = "ID";
            cmb_staff.DataSource = t;
            Public.staff_id = Convert.ToInt32(cmb_staff.SelectedValue);
            Public.order_database_view.Close();
            Public.user_database.Close();

            txt_door_id.Text = Public.second_validation_door_id;
            txt_operation.Text =  Public.Operation;


            double Total = 0;
            try
            {
                for (int i = 0; i < grid_completion_log.Rows.Count; ++i)
                {

                    Total += Convert.ToDouble(grid_completion_log.Rows[i].Cells[3].Value);
                 
                    txt_percent_total.Text = " " + (Total * 100) + "%".ToString();
                    Public.Sum_of_percent_complete = Total;
                }

            }
            catch { }



            grid_completion_log.Columns[3].Visible = false;


        }

        void Format()
        {

            grid_completion_log.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_completion_log.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_completion_log.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid_completion_log.EnableHeadersVisualStyles = false;

        }

        void Stock_door_check()
        {
            SqlCommand command_check_stock = new SqlCommand(Public.stock_door_check, Public.order_database);
            command_check_stock.Parameters.AddWithValue("@id", Public.second_validation_door_id);
            if (Public.order_database != null && Public.order_database.State == ConnectionState.Closed)
            {
                Public.order_database.Open();
            }
            SqlDataReader check_stock_door = command_check_stock.ExecuteReader();
            if (check_stock_door.Read())
            {
                SqlCommand update_louvre_stock = new SqlCommand(Public.update_louvre_stock, Public.order_database);
                update_louvre_stock.Parameters.AddWithValue("@qty", Public.quantity_same);
                update_louvre_stock.ExecuteNonQuery();

                check_stock_door.Close();
                

            }
            else
            {


                check_stock_door.Close();
            }
            Public.order_database.Close();
        }

        private void bt_complete_Click(object sender, EventArgs e)
        {
            if(Public.Sum_of_percent_complete == 1)
            {

                MessageBox.Show("This door is marked as complete!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // return;
            }

          DialogResult complete =  MessageBox.Show("Mark Job As Complete?", "Warning!"  , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(complete == DialogResult.Yes)
            {
                Public.order_database.Open();
                SqlCommand job_complete = new SqlCommand("Update dbo.door SET "+Public.date_op_complete+" = @date, "+ Public.operation_remaining_name +" = 0, complete_" + Public.Operation + " = -1 WHERE id = @door_id", Public.order_database);
                SqlCommand completion_log = new SqlCommand(Public.insert_completion_log, Public.order_database);
                SqlCommand department_goal = new SqlCommand(Public.update_department_goal, Public.order_database);

                job_complete.Parameters.AddWithValue("@date", DateTime.Now);
                job_complete.Parameters.AddWithValue("@door_id", Public.second_validation_door_id);
                

                completion_log.Parameters.AddWithValue("@id", Public.second_validation_door_id);
                completion_log.Parameters.AddWithValue("@date", DateTime.Now);
                completion_log.Parameters.AddWithValue("@part_time",Public.operation_time+".0");
                completion_log.Parameters.AddWithValue("@part",Public.Operation);
                completion_log.Parameters.AddWithValue("@part_status", "Complete");
                completion_log.Parameters.AddWithValue("@op", Public.Operation_log);
                completion_log.Parameters.AddWithValue("@staff_id", cmb_staff.SelectedValue.ToString());
                completion_log.Parameters.AddWithValue("@percent",1-(Public.Sum_of_percent_complete));
              
                department_goal.Parameters.AddWithValue("@date", Public.sqlFormattedDate);
                department_goal.Parameters.AddWithValue("@time_for_part", (Convert.ToDouble(Public.operation_time))/60);

                completion_log.ExecuteNonQuery();
                job_complete.ExecuteNonQuery();
                department_goal.ExecuteNonQuery();
                this.Hide();
                if(Public.Operation == "pack")
                {
                   
                    additional_info info = new additional_info();
                    info.Show();
                }
                if (Public.Operation == "SL_buff")
                {

                    //Stock_door_check();
                }

                Public.order_database.Close();
            }
            if (complete == DialogResult.No)

            {
                Public.staff_selection = cmb_staff.SelectedIndex.ToString();
                Part_complete form = new Part_complete();
                form.Show();
                this.Hide();

                
            }
        }

    }
}
