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
    public partial class Part_complete : Form
    {
        public Part_complete()
        {
            InitializeComponent();
            Fill_data();
        }
        void Fill_data()
        {
            DataTable t = new DataTable();
            Public.User_list.Fill(t);
            t.Columns.Add("fullname", typeof(string), "forename + ' ' +surname");
            // Bind the table to the list box
            cmbo_staff.DisplayMember = "fullname";
            cmbo_staff.ValueMember = "ID";
            cmbo_staff.DataSource = t;
            cmbo_staff.SelectedIndex = Convert.ToInt32(Public.staff_selection);
            Public.staff_id = Convert.ToInt32(cmb_staff.SelectedValue);
            Public.user_database.Close();
            


        }

        private void btn_part_complete_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txt_part_percent.Text))
            {
                MessageBox.Show("Please Enter Percent Value", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if(Convert.ToInt32(Public.Sum_of_percent_complete) > (Convert.ToDouble(txt_part_percent.Text) / 100))
            {

                MessageBox.Show("Please enter a higher value as job completion stage is less than previously entered","Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                return;

            }
            if(cmbo_staff.SelectedIndex < 0)
            {

                MessageBox.Show("Please Select a Staff Member", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            Public.order_database.Open();
            Double part_percent = Convert.ToDouble(txt_part_percent.Text) / 100;
            Public.staff_id = Convert.ToInt32(cmb_staff.SelectedValue);
            SqlCommand completion_log = new SqlCommand(Public.insert_completion_log, Public.order_database);
            SqlCommand select_time = new SqlCommand("Select time_" +Public.Operation+" From dbo.door WHERE id = @id", Public.order_database);
            SqlCommand update_door = new SqlCommand("Update dbo.door SET " + Public.operation_remaining_name + " = " + Public.operation_remaining_name + " - @op_time  WHERE id = @door_id", Public.order_database);
            SqlCommand update_department = new SqlCommand(Public.update_department_goal, Public.order_database);
            select_time.Parameters.AddWithValue("@id", Public.second_validation_door_id);
            update_door.Parameters.AddWithValue("@door_id", Public.second_validation_door_id);
            select_time.Parameters.AddWithValue("@op_time","Time_"+ Public.Operation);
            object op_time = select_time.ExecuteScalar();
            if (op_time != null)
            {
               Public.op_time = Convert.ToInt32(op_time);
              
            }
            Double time_for_part = ((part_percent - Public.Sum_of_percent_complete) * Public.quantity_same * Public.op_time);
            update_door.Parameters.AddWithValue("op_time", (time_for_part / Public.quantity_same));
            update_department.Parameters.AddWithValue("@time_for_part", (time_for_part / 60));
            completion_log.Parameters.AddWithValue("@part_time", time_for_part);
            completion_log.Parameters.AddWithValue("@id", Public.second_validation_door_id);
            completion_log.Parameters.AddWithValue("@date", DateTime.Now);
           
            completion_log.Parameters.AddWithValue("@part",  "part " + Public.Operation_log);
            completion_log.Parameters.AddWithValue("@part_status", "Complete");
            completion_log.Parameters.AddWithValue("@op", Public.Operation_log);
            completion_log.Parameters.AddWithValue("@staff_id", cmbo_staff.SelectedValue);
            completion_log.Parameters.AddWithValue("@percent",(Convert.ToDouble(txt_part_percent.Text)/100-Public.Sum_of_percent_complete));

            update_department.Parameters.AddWithValue("@date", Public.sqlFormattedDate);
          

            update_department.ExecuteNonQuery();
            completion_log.ExecuteNonQuery();
            update_door.ExecuteNonQuery();

            Public.order_database.Close();
        
            Main_menu menu = new Main_menu();
            this.Hide();
            menu.Show();
            Fill_data();
        }

        private void txt_part_percent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {

                btn_part_complete.PerformClick();



            }
        }
    }
}
