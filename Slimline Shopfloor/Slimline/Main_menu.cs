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
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
            this.ActiveControl = txt_first_validation;
            Public.order_database.Close();
        }

        private void txt_first_validation_KeyDown(object sender, KeyEventArgs e)
        {
            

          

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                if (txt_first_validation.Text == Public.password)
                {
                    admin_menu menu = new admin_menu();
                    menu.Show();
                    return;


                }


                try
                {
                    Public.first_validation_door_id = txt_first_validation.Text.Substring(0, 5);

                    txt_first_validation.Visible = false;
                    txt_second_validation.Visible = true;
                    txt_second_validation.Focus();


                }
                catch
                {
                    MessageBox.Show("Please try again !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
              
            }
        }
       
        
        private void txt_second_validation_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                Public.order_database.Close();
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                {
                    try
                    {
                       
                        Public.second_validation_door_id = txt_second_validation.Text.Substring(0, 5);
                        SqlCommand select_quantity_same = new SqlCommand(Public.select_quantity_same, Public.order_database);
                     
                        if (Public.first_validation_door_id == Public.second_validation_door_id)
                        {


                            Public.order_database.Open();
                            string barcode = txt_second_validation.Text;
                            Public.Operation_validation = barcode.Substring(barcode.LastIndexOf('-') + 1);
                            switch (Public.Operation_validation)
                            {
                                case "f":
                                case "F":
                                    {
                                        Public.Operation = "Cutting";
                                        Public.Operation_log = "Cutting";
                                        Public.operation_remaining_name = "time_remaining_Cutting";
                                        Public.select_statment = "Select time_remaining_Cutting from dbo.door where id = @ID";
                                        Public.date_op_complete = "date_cutting_complete";

                                        break;

                                    }
                                case "g":
                                case "G":
                                    {
                                        Public.Operation = "Prep";
                                        Public.Operation_log = "Prepping";
                                        Public.operation_remaining_name = "time_remaining_prepping";
                                        Public.select_statment = "Select time_remaining_prepping from dbo.door where id = @ID";

                                        Public.date_op_complete = "date_Prepping_complete";
                                        break;

                                    }
                                case "h":
                                case "H":
                                    {
                                       
                                        Public.Operation = "Assembly";
                                        Public.Operation_log = "Assembly";
                                        Public.operation_remaining_name = "time_remianing_assembly";
                                        Public.select_statment = "Select time_remianing_assembly from dbo.door where id = @ID";

                                        Public.date_op_complete = "date_assembly_complete";
                                        break;

                                    }
                                case "I":
                                case "i":
                                    {
                                        Public.Operation = "SL_buff";
                                        Public.Operation_log = "Sl_buff";
                                        Public.operation_remaining_name = "time_remaining_sl_buff";
                                        Public.select_statment = "Select time_remaining_sl_buff from dbo.door where id = @ID";

                                        Public.date_op_complete = "date_SL_buff_complete";

                                        break;

                                    }
                                case "j":
                                case "J":
                                    {
                                        
                                        Public.Operation = "SL_Stores";
                                        Public.Operation_log = "Sl_Stores";
                                        Public.operation_remaining_name = "time_reamining_sl_stores";
                                        Public.select_statment = "Select time_reamining_sl_stores from dbo.door where id = @ID";

                                        Public.date_op_complete = "date_sl_stores_complete";
                                        break;

                                    }
                                case "k":
                                case "K":
                                    {

                                        Public.Operation = "pack";
                                        Public.Operation_log = "sl_pack";
                                        Public.operation_remaining_name = "time_remaining_pack";
                                        Public.select_statment = "Select time_remaining_pack from dbo.door where id = @ID";

                                        Public.date_op_complete = "date_pack_complete";
                                        break;

                                    }





                            }
                            SqlCommand Select_time = new SqlCommand(Public.select_statment, Public.order_database);
                            Select_time.Parameters.AddWithValue("@id", Public.second_validation_door_id);
                            select_quantity_same.Parameters.AddWithValue("@id", Public.second_validation_door_id);

                            object quantity = (Int32)select_quantity_same.ExecuteScalar();
                            object time = Select_time.ExecuteScalar();
                            if (quantity != null)
                            {
                                Public.quantity_same = Convert.ToInt32(quantity);
                            }
                            if (time != null)
                            {
                                int time_int = Convert.ToInt32(time);
                                Public.operation_time = Convert.ToString(time_int * Public.quantity_same);
                               

                            }
                            Public.order_database.Close();
                            Completion_menu menu = new Completion_menu();
                            this.ActiveControl = txt_first_validation;
                            txt_first_validation.Text = "";
                            txt_second_validation.Text = "";
                           

                            menu.Show();




                        }
                        else
                        {

                            MessageBox.Show("Please try again !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txt_first_validation.Visible = true;
                            txt_first_validation.Text = "";
                            txt_second_validation.Visible = false;
                            txt_second_validation.Text = "";
                            txt_first_validation.Focus();

                        }





                    }

                    catch (Exception ex )
                    {
                        MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_first_validation.Visible = true;
                        txt_first_validation.Text = "";
                        txt_second_validation.Text="";
                        txt_second_validation.Visible = false;
                        txt_first_validation.Focus();
                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_first_validation.Visible = true;
                txt_first_validation.Text = "";
                txt_second_validation.Text = "";
                txt_second_validation.Visible = false;
                txt_first_validation.Focus();


            }
       }

        private void btn_allocation_Click(object sender, EventArgs e)
        {
            Work_allocation menu = new Work_allocation();
            menu.Show();
            
        }

        private void btn_po_Click(object sender, EventArgs e)
        {
            Purchase_order po = new Purchase_order();
            po.Show();
            //this.Hide();
        }

       
        private void btn_packing_Click(object sender, EventArgs e)
        {
            Public.door_id = "";
            packing_report packing = new packing_report();
            packing.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            additional_info into = new additional_info();
            into.Show();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            Stock stock_menu = new Stock();
            stock_menu.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            additional_info info = new additional_info();
            info.Show();
        }
    }
}
