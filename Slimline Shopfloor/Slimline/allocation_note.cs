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
    public partial class allocation_note : Form
    {
        public allocation_note()
        {
            InitializeComponent();

           
           lbl_door.Text = "Door ID : " + Public.note_id ;
           lbl_op.Text = Public.note_department + " Notes";
            Public.order_database.Close();
        }

        private void btn_save_note_Click(object sender, EventArgs e)
        {
            try
            {


                Public.order_database.Open();
                switch (Public.note_department)
                {
                    case "Cutting":

                        {
                            SqlCommand update_notes = new SqlCommand("UPDATE dbo.door SET cutting_note = @note WHERE id = @ID", Public.order_database);
                            update_notes.Parameters.AddWithValue("@note", txt_note.Text);
                            update_notes.Parameters.AddWithValue("@id", Public.note_id);
                            update_notes.ExecuteNonQuery();

                            break;

                        }
                    case "Prepping":
                        {
                            SqlCommand update_notes = new SqlCommand("UPDATE dbo.door SET prepping_note = @note WHERE id = @ID", Public.order_database);
                            update_notes.Parameters.AddWithValue("@note", txt_note.Text);
                            update_notes.Parameters.AddWithValue("@id", Public.note_id);
                            update_notes.ExecuteNonQuery();
                            break;

                        }
                    case "Packing":
                        {

                            SqlCommand update_notes = new SqlCommand("UPDATE dbo.door SET packing_note = @note WHERE id = @ID", Public.order_database);
                            update_notes.Parameters.AddWithValue("@note", txt_note.Text);
                            update_notes.Parameters.AddWithValue("@id", Public.note_id);
                            update_notes.ExecuteNonQuery();
                            break;

                        }
                    case "SL_buff":
                        {
                            SqlCommand update_notes = new SqlCommand("UPDATE dbo.door SET sl_buff_note = @note WHERE id = @ID", Public.order_database);
                            update_notes.Parameters.AddWithValue("@note", txt_note.Text);
                            update_notes.Parameters.AddWithValue("@id", Public.note_id);
                            update_notes.ExecuteNonQuery();

                            break;

                        }
                    case "Assembly":

                        {
                            SqlCommand update_notes = new SqlCommand("UPDATE dbo.door SET assembly_note = @note WHERE id = @ID", Public.order_database);
                            update_notes.Parameters.AddWithValue("@note", txt_note.Text);
                            update_notes.Parameters.AddWithValue("@id", Public.note_id);
                            update_notes.ExecuteNonQuery();
                            break;

                        }

                }

                this.Hide();

            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.ToString(), "");
            }



        }

       
    }
}
