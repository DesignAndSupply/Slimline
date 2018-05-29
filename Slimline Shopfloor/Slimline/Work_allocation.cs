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
    public partial class Work_allocation : Form
    {
        public DataTable dt = new DataTable();
        public DataTable dt_assembly = new DataTable();
        public DataTable dt_buffing = new DataTable();
        public DataTable dt_packing = new DataTable();
        public DataTable dt_cutting = new DataTable();
        public DataTable dt_prepping = new DataTable();

        public Work_allocation()
        {
            InitializeComponent();
            Fill_data();
            Format();
        }
        void Fill_data()

        {

            //MessageBox.Show("fuk off");

            //DataTable assembly = new DataTable();
            //DataTable cutting = new DataTable();
            //DataTable prepping = new DataTable();
            //DataTable sl_buff = new DataTable();
            DataTable search = new DataTable();

            //Public.User_list.Fill(assembly);
            //Public.User_list.Fill(cutting);
            //Public.User_list.Fill(prepping);
            //Public.User_list.Fill(sl_buff);
            Public.User_list.Fill(search);

            //assembly.Columns.Add("fullname", typeof(string), "forename + ' ' +surname");
            //cutting.Columns.Add("fullname", typeof(string), "forename + ' ' +surname");
            //prepping.Columns.Add("fullname", typeof(string), "forename + ' ' +surname");
            //sl_buff.Columns.Add("fullname", typeof(string), "forename + ' ' +surname");
            search.Columns.Add("fullname", typeof(string), "forename + ' ' +surname");

            //cmb_assembly.DisplayMember = "fullname";
            //cmb_assembly.ValueMember = "ID";
            //cmb_assembly.DataSource = assembly;
            //cmb_assembly.TabIndex = 1;

            //cmb_cutting.DisplayMember = "fullname";
            //cmb_cutting.ValueMember = "ID";
            //cmb_cutting.DataSource = cutting;
            //cmb_cutting.TabIndex = 1;

            //cmb_prepping.DisplayMember = "fullname";
            //cmb_prepping.ValueMember = "ID";
            //cmb_prepping.DataSource = prepping;
            //cmb_prepping.TabIndex = 1;

            //cmb_sl_buff.DisplayMember = "fullname";
            //cmb_sl_buff.ValueMember = "ID";
            //cmb_sl_buff.DataSource = sl_buff;
            //cmb_sl_buff.TabIndex = 1;

            cmb_search.DisplayMember = "fullname";
            cmb_search.ValueMember = "ID";
            cmb_search.DataSource = search;
            cmb_search.TabIndex = 1;

            //Public.user_database.Close();
            Public.order_database_view.Open();
            SqlDataAdapter ada = new SqlDataAdapter(Public.work_allocation_data, Public.order_database_view);
            DataTable dt = new DataTable();
            dt.Clear();
            ada.Fill(dt);
            work_allocation_table.DataSource = dt;

            Public.order_database_view.Close();

        }

        void Format()
        {


            work_allocation_table.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            work_allocation_table.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            work_allocation_table.EnableHeadersVisualStyles = false;

            grid_cutting.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_cutting.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_cutting.EnableHeadersVisualStyles = false;

            grid_packing.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_packing.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_packing.EnableHeadersVisualStyles = false;

            grid_assembly.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_assembly.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_assembly.EnableHeadersVisualStyles = false;


            grid_prepping.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_prepping.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_prepping.EnableHeadersVisualStyles = false;

            grid_buff.ColumnHeadersDefaultCellStyle.ForeColor = Color.CornflowerBlue;
            grid_buff.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            grid_buff.EnableHeadersVisualStyles = false;

           
        }

        private void btn_allocate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_door.Text))
            {

                MessageBox.Show("Please Enter Door ID!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            Public.order_database_view.Open();


            if (cmb_assembly.DisplayMember != null)
            {

                SqlCommand update_assembly = new SqlCommand(Public.update_assembly_allocation, Public.order_database_view);
                update_assembly.Parameters.AddWithValue("@ID", txt_door.Text);
                update_assembly.Parameters.AddWithValue("@staff_name", cmb_assembly.Text);


                SqlCommand delete_assembly = new SqlCommand(Public.delete_assembly_allocation, Public.order_database_view);
                delete_assembly.Parameters.AddWithValue("@ID", txt_door.Text);

                SqlCommand insert_assembly = new SqlCommand(Public.insert_assembly_allocation, Public.order_database_view);
                insert_assembly.Parameters.AddWithValue("@ID", txt_door.Text);
                insert_assembly.Parameters.AddWithValue("@date", DateTime.Now);
                insert_assembly.Parameters.AddWithValue("@staff_id", cmb_assembly.SelectedValue);

                update_assembly.ExecuteNonQuery();
                delete_assembly.ExecuteNonQuery();
                insert_assembly.ExecuteNonQuery();

            }

            if (cmb_prepping.DisplayMember != null)
            {

                SqlCommand update_prepping = new SqlCommand(Public.update_prepping_allocation, Public.order_database_view);
                update_prepping.Parameters.AddWithValue("@ID", txt_door.Text);
                update_prepping.Parameters.AddWithValue("@staff_name", cmb_prepping.Text);

                SqlCommand delete_prepping = new SqlCommand(Public.delete_prepping_allocation, Public.order_database_view);
                delete_prepping.Parameters.AddWithValue("@ID", txt_door.Text);

                SqlCommand insert_prepping = new SqlCommand(Public.insert_prepping_allocation, Public.order_database_view);
                insert_prepping.Parameters.AddWithValue("@ID", txt_door.Text);
                insert_prepping.Parameters.AddWithValue("@date", DateTime.Now);
                insert_prepping.Parameters.AddWithValue("@staff_id", cmb_prepping.SelectedValue);

                update_prepping.ExecuteNonQuery();
                delete_prepping.ExecuteNonQuery();
                insert_prepping.ExecuteNonQuery();




                if (cmb_cutting.DisplayMember != null)
                {

                    SqlCommand update_cutting = new SqlCommand(Public.update_cutting_allocation, Public.order_database_view);
                    update_cutting.Parameters.AddWithValue("@ID", txt_door.Text);
                    update_cutting.Parameters.AddWithValue("@staff_name", cmb_cutting.Text);

                    SqlCommand delete_cutting = new SqlCommand(Public.delete_cutting_allocation, Public.order_database_view);
                    delete_cutting.Parameters.AddWithValue("@ID", txt_door.Text);

                    SqlCommand insert_cutting = new SqlCommand(Public.insert_cutting_allocation, Public.order_database_view);
                    insert_cutting.Parameters.AddWithValue("@ID", txt_door.Text);
                    insert_cutting.Parameters.AddWithValue("@date", DateTime.Now);
                    insert_cutting.Parameters.AddWithValue("@staff_id", cmb_cutting.SelectedValue);


                    update_cutting.ExecuteNonQuery();
                    delete_cutting.ExecuteNonQuery();
                    insert_cutting.ExecuteNonQuery();

                }

                if (cmb_sl_buff.DisplayMember != null)
                {

                    SqlCommand update_Sl_buff = new SqlCommand(Public.update_assembly_allocation, Public.order_database_view);
                    update_Sl_buff.Parameters.AddWithValue("@ID", txt_door.Text);
                    update_Sl_buff.Parameters.AddWithValue("@staff_name", cmb_sl_buff.Text);

                    SqlCommand delete_Sl_buff = new SqlCommand(Public.delete_sl_buff_allocation, Public.order_database_view);
                    delete_Sl_buff.Parameters.AddWithValue("@ID", txt_door.Text);

                    SqlCommand insert_Sl_buff = new SqlCommand(Public.insert_sl_buff_allocation, Public.order_database_view);
                    insert_Sl_buff.Parameters.AddWithValue("@ID", txt_door.Text);
                    insert_Sl_buff.Parameters.AddWithValue("@date", DateTime.Now);
                    insert_Sl_buff.Parameters.AddWithValue("@staff_id", cmb_sl_buff.SelectedValue);

                    update_Sl_buff.ExecuteNonQuery();
                    delete_Sl_buff.ExecuteNonQuery();
                    insert_Sl_buff.ExecuteNonQuery();

                }


                Public.order_database_view.Close();

                MessageBox.Show("   Allocation Completed!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);




            }
        }

        private void pct_search_Click(object sender, EventArgs e)
        {
            dt_buffing.Clear();
            dt_assembly.Clear();
            dt_cutting.Clear();
            dt_packing.Clear();
            dt_prepping.Clear();
            Public.order_database_view.Open();
            work_allocation_table.Visible = false;
            grid_assembly.Visible = true;
            grid_buff.Visible = true;
            grid_cutting.Visible = true;
            grid_packing.Visible = true;
            grid_prepping.Visible = true;
            lbl_assemble.Visible = true;
            lbl_buff.Visible = true;
            lbl_cut.Visible = true;
            lbl_packing.Visible = true;
            lbl_prep.Visible = true;
            SqlDataAdapter search_buffing = new SqlDataAdapter(Public.search_buffing, Public.order_database_view);
            SqlDataAdapter search_cutting = new SqlDataAdapter(Public.search_cutting, Public.order_database_view);
            SqlDataAdapter search_assembly = new SqlDataAdapter(Public.search_assembly, Public.order_database_view);
            SqlDataAdapter search_packing = new SqlDataAdapter(Public.search_packing, Public.order_database_view);
            SqlDataAdapter search_prepping = new SqlDataAdapter(Public.search_prepping, Public.order_database_view);
            search_buffing.SelectCommand.Parameters.AddWithValue("@staff", cmb_search.Text);
            search_cutting.SelectCommand.Parameters.AddWithValue("@staff", cmb_search.Text);
            search_assembly.SelectCommand.Parameters.AddWithValue("@staff", cmb_search.Text);
            search_packing.SelectCommand.Parameters.AddWithValue("@staff", cmb_search.Text);
            search_prepping.SelectCommand.Parameters.AddWithValue("@staff", cmb_search.Text);
            search_buffing.Fill(dt_buffing);
            search_cutting.Fill(dt_cutting);
            search_assembly.Fill(dt_assembly);
            search_packing.Fill(dt_packing);
            search_prepping.Fill(dt_prepping);
            grid_assembly.DataSource = dt_assembly;
            grid_buff.DataSource = dt_buffing;
            grid_cutting.DataSource = dt_cutting;
            grid_packing.DataSource = dt_packing;
            grid_prepping.DataSource = dt_prepping;
            Public.order_database_view.Close();


            btn_buffing_note.DisplayIndex = grid_buff.ColumnCount - 1;
            btn_cutting_note.DisplayIndex = grid_cutting.ColumnCount - 1;
            btn_prepping_note.DisplayIndex = grid_prepping.ColumnCount - 1;
            btn_assembly_note.DisplayIndex = grid_assembly.ColumnCount - 1;
            btn_packing_note.DisplayIndex = grid_packing.ColumnCount - 1;
            btn_print.DisplayIndex = grid_packing.ColumnCount - 1;
            btn_taken_assembly.DisplayIndex = grid_assembly.ColumnCount - 2;
            btn_taken_buffing.DisplayIndex = grid_buff.ColumnCount - 2;
            btn_taken_cutting.DisplayIndex = grid_cutting.ColumnCount - 2;
            btn_taken_packing.DisplayIndex = grid_packing.ColumnCount - 3;
            btn_taken_prepping.DisplayIndex = grid_prepping.ColumnCount - 2;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            work_allocation_table.Visible = true;
            grid_assembly.Visible = false;
            grid_buff.Visible = false;
            grid_cutting.Visible = false;
            grid_packing.Visible = false;
            grid_prepping.Visible = false;
            lbl_assemble.Visible = false;
            lbl_buff.Visible = false;
            lbl_cut.Visible = false;
            lbl_packing.Visible = false;
            lbl_prep.Visible = false;
            Fill_data();
        }

        private void grid_packing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid_packing.Columns["btn_print"].Index && e.RowIndex >= 0)

                try
                {
                    int i = e.RowIndex;

                    Public.door_id = dt_packing.Rows[i][0].ToString();
                    packing_report packing = new packing_report();
                    packing.Show();
                    

                }
                catch
                {


                }
             if (e.ColumnIndex == grid_packing.Columns["btn_packing_note"].Index && e.RowIndex >= 0)

                    try
                    {
                    int i = e.RowIndex;

                     Public.note_id = dt_packing.Rows[i][0].ToString();
                     Public.note_department = "Packing";
                     allocation_note note_menu = new allocation_note();
                    
                     note_menu.Show();


                    }
                    catch
                    {


                    }

            else if (e.ColumnIndex == grid_packing.Columns["btn_taken_packing"].Index && e.RowIndex >= 0)

                try
                {
                  
                   
                    int i = e.RowIndex;
                    string date = dt_packing.Rows[i][4].ToString();
                    string door_id = dt_packing.Rows[i][0].ToString();
                    if (date != "")
                    {
                        DialogResult complete = MessageBox.Show("That Door is already taken, Mark as Paused?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (complete == DialogResult.Yes)
                        {
                            if (Public.order_database != null && Public.order_database.State == ConnectionState.Closed)
                            {

                                Public.order_database.Open();
                            }
                            SqlCommand mark_paused_packing = new SqlCommand (Public.mark_paused_packing, Public.order_database);
                            SqlCommand insert_stopped_packing = new SqlCommand(Public.insert_stopped_packing, Public.order_database);
                            mark_paused_packing.Parameters.AddWithValue("@door_id",door_id );
                            insert_stopped_packing.Parameters.AddWithValue("@staff_id", cmb_search.SelectedValue);
                            insert_stopped_packing.Parameters.AddWithValue("@door_id", door_id);
                            insert_stopped_packing.Parameters.AddWithValue("@date", DateTime.Now);
                            mark_paused_packing.ExecuteNonQuery();
                            insert_stopped_packing.ExecuteNonQuery();
                            Public.order_database.Close();
                            pct_search_Click(sender, e);
                            return;

                        }
                        else
                        {
                            return;
                        }

                    }
                    SqlCommand insert_started_packing = new SqlCommand(Public.insert_started_packing, Public.order_database);
                    SqlCommand mark_taken = new SqlCommand(Public.mark_taken_packing, Public.order_database);
                    if (Public.order_database != null && Public.order_database.State == ConnectionState.Closed)
                    {

                        Public.order_database.Open();
                    }
                    mark_taken.Parameters.AddWithValue("@date", DateTime.Now);
                    mark_taken.Parameters.AddWithValue("@door_id", door_id);
                    insert_started_packing.Parameters.AddWithValue("@staff_id", cmb_search.SelectedValue);
                    insert_started_packing.Parameters.AddWithValue("@door_id", door_id);
                    insert_started_packing.Parameters.AddWithValue("@date", DateTime.Now);
                    insert_started_packing.ExecuteNonQuery();
                    mark_taken.ExecuteNonQuery();
                    MessageBox.Show("Door " + door_id + " Marked as taken", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Public.order_database.Close();
                    pct_search_Click(sender, e);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    if (Public.order_database != null && Public.order_database.State == ConnectionState.Open)
                    {

                        Public.order_database.Close();
                    }
                }


        }

        private void grid_buff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid_buff.Columns["btn_buffing_note"].Index && e.RowIndex >= 0)

                try
                {
                    int i = e.RowIndex;
                    Public.note_id = dt_buffing.Rows[i][0].ToString();
                    Public.note_department = "SL_buff";
                    allocation_note note_menu = new allocation_note();
                    
                    note_menu.Show();

                }
                catch
                {
                    

                }

           
            else if (e.ColumnIndex == grid_buff.Columns["btn_taken_buffing"].Index && e.RowIndex >= 0)

                try
                {
                    int i = e.RowIndex;
                    string date = dt_buffing.Rows[i][4].ToString();
                    string door_id = Public.note_id = dt_buffing.Rows[i][0].ToString();
                    if (date != "")
                    {
                        DialogResult complete = MessageBox.Show("That Door is already taken, Mark as Paused?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (complete == DialogResult.Yes)
                        {
                            if (Public.order_database != null && Public.order_database.State == ConnectionState.Closed)
                            {

                                Public.order_database.Open();
                            }
                            SqlCommand mark_paused_buffing = new SqlCommand(Public.mark_paused_buffing, Public.order_database);
                            SqlCommand insert_stopped_buffing = new SqlCommand(Public.insert_stopped_buffing, Public.order_database);
                            mark_paused_buffing.Parameters.AddWithValue("@door_id", door_id);
                            insert_stopped_buffing.Parameters.AddWithValue("@staff_id", cmb_search.SelectedValue);
                            insert_stopped_buffing.Parameters.AddWithValue("@door_id", door_id);
                            insert_stopped_buffing.Parameters.AddWithValue("@date", DateTime.Now);
                            mark_paused_buffing.ExecuteNonQuery();
                            insert_stopped_buffing.ExecuteNonQuery();
                            Public.order_database.Close();
                            pct_search_Click(sender, e);
                            return;

                        }
                        else
                        {
                            return;
                        }

                    }
                    SqlCommand mark_taken = new SqlCommand(Public.mark_taken_buffing, Public.order_database);
                    SqlCommand insert_started_buffing = new SqlCommand(Public.insert_started_buffing, Public.order_database);
                    if (Public.order_database != null && Public.order_database.State == ConnectionState.Closed)
                    {

                        Public.order_database.Open();
                    }
                    insert_started_buffing.Parameters.AddWithValue("@staff_id", cmb_search.SelectedValue);
                    insert_started_buffing.Parameters.AddWithValue("@door_id", door_id);
                    insert_started_buffing.Parameters.AddWithValue("@date", DateTime.Now);
                    mark_taken.Parameters.AddWithValue("@date", DateTime.Now);
                    mark_taken.Parameters.AddWithValue("@door_id", door_id);
                    mark_taken.ExecuteNonQuery();
                    insert_started_buffing.ExecuteNonQuery();
                    MessageBox.Show("Door " + door_id + " Marked as taken", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Public.order_database.Close();
                    pct_search_Click(sender, e);

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    if (Public.order_database != null && Public.order_database.State == ConnectionState.Open)
                    {

                        Public.order_database.Close();
                    }
                }


        }

        private void grid_cutting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid_cutting.Columns["btn_cutting_note"].Index && e.RowIndex >= 0)

                try
                {
                    int i = e.RowIndex;
                    string  door_id = dt_cutting.Rows[i][0].ToString();
                    Public.note_department = "Cutting";
                    allocation_note note_menu = new allocation_note();
                    note_menu.Show();

                }

                catch
                {


                }

           
            else if (e.ColumnIndex == grid_cutting.Columns["btn_taken_cutting"].Index && e.RowIndex >= 0)

                try
                {
                    int i = e.RowIndex;
                    string date = dt_cutting.Rows[i][4].ToString();
                    string door_id = Public.note_id = dt_cutting.Rows[i][0].ToString();
                    if (date != "")
                    {
                        DialogResult complete = MessageBox.Show("That Door is already taken, Mark as Paused?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (complete == DialogResult.Yes)
                        {
                            if (Public.order_database != null && Public.order_database.State == ConnectionState.Closed)
                            {

                                Public.order_database.Open();
                            }
                            SqlCommand mark_paused_cutting = new SqlCommand(Public.mark_paused_cutting, Public.order_database);
                            SqlCommand insert_stopped_cutting = new SqlCommand(Public.insert_stopped_cutting, Public.order_database);
                            mark_paused_cutting.Parameters.AddWithValue("@door_id", door_id);
                            insert_stopped_cutting.Parameters.AddWithValue("@staff_id", cmb_search.SelectedValue);
                            insert_stopped_cutting.Parameters.AddWithValue("@door_id", door_id);
                            insert_stopped_cutting.Parameters.AddWithValue("@date", DateTime.Now);
                            mark_paused_cutting.ExecuteNonQuery();
                            insert_stopped_cutting.ExecuteNonQuery();
                            Public.order_database.Close();
                            pct_search_Click(sender, e);
                            return;

                        }
                        else
                        {
                            return;
                        }

                    }
                    SqlCommand mark_taken = new SqlCommand(Public.mark_taken_cutting, Public.order_database);
                    SqlCommand insert_started_cutting = new SqlCommand(Public.insert_started_cutting, Public.order_database);
                    Public.order_database.Open();
                    mark_taken.Parameters.AddWithValue("@date", DateTime.Now);
                    mark_taken.Parameters.AddWithValue("@door_id", door_id);
                    insert_started_cutting.Parameters.AddWithValue("@staff_id", cmb_search.SelectedValue);
                    insert_started_cutting.Parameters.AddWithValue("@door_id", door_id);
                    insert_started_cutting.Parameters.AddWithValue("@date", DateTime.Now);
                    mark_taken.ExecuteNonQuery();
                    insert_started_cutting.ExecuteNonQuery();
                    MessageBox.Show("Door " + door_id + " Marked as taken", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Public.order_database.Close();
                    pct_search_Click(sender, e);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    if (Public.order_database != null && Public.order_database.State == ConnectionState.Open)
                    {

                        Public.order_database.Close();
                    }
                }

        }

        private void grid_assembly_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == grid_assembly.Columns["btn_assembly_note"].Index && e.RowIndex >= 0)

                try
                {
                    int i = e.RowIndex;
                    Public.note_id = dt_assembly.Rows[i][0].ToString();
                    Public.note_department = "Assembly";
                    allocation_note note_menu = new allocation_note();
                    note_menu.Show();

                }
                catch
                {
                    if (Public.order_database != null && Public.order_database.State == ConnectionState.Open)
                    {

                        Public.order_database.Close();
                    }

                }
            else if (e.ColumnIndex == grid_assembly.Columns["btn_taken_assembly"].Index && e.RowIndex >= 0)

                try
                {
                    int i = e.RowIndex;
                    string date = dt_assembly.Rows[i][4].ToString();
                    string door_id = Public.note_id = dt_assembly.Rows[i][0].ToString();
                    if (date != "")
                    {
                        DialogResult complete = MessageBox.Show("That Door is already taken, Mark as Paused?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (complete == DialogResult.Yes)
                        {
                            Public.order_database.Open();
                            SqlCommand mark_paused_assembly = new SqlCommand(Public.mark_paused_assembly, Public.order_database);
                            SqlCommand insert_stopped_assembly = new SqlCommand(Public.insert_stopped_assembly, Public.order_database);
                            mark_paused_assembly.Parameters.AddWithValue("@door_id", door_id);
                            insert_stopped_assembly.Parameters.AddWithValue("@staff_id", cmb_search.SelectedValue);
                            insert_stopped_assembly.Parameters.AddWithValue("@door_id", door_id);
                            insert_stopped_assembly.Parameters.AddWithValue("@date", DateTime.Now);
                            mark_paused_assembly.ExecuteNonQuery();
                            insert_stopped_assembly.ExecuteNonQuery();
                            Public.order_database.Close();
                            pct_search_Click(sender, e);
                            return;

                        }
                        else
                        {
                            return;
                        }

                    }
                    SqlCommand mark_taken = new SqlCommand(Public.mark_taken_assembly, Public.order_database);
                    SqlCommand insert_started_assembly = new SqlCommand(Public.insert_started_assembly, Public.order_database);
                    if (Public.order_database != null && Public.order_database.State == ConnectionState.Closed)
                    {

                        Public.order_database.Open();
                    }
                    mark_taken.Parameters.AddWithValue("@date", DateTime.Now);
                    mark_taken.Parameters.AddWithValue("@door_id", door_id);
                    insert_started_assembly.Parameters.AddWithValue("@staff_id", cmb_search.SelectedValue);
                    insert_started_assembly.Parameters.AddWithValue("@door_id", door_id);
                    insert_started_assembly.Parameters.AddWithValue("@date", DateTime.Now);
                    mark_taken.ExecuteNonQuery();
                    insert_started_assembly.ExecuteNonQuery();
                    MessageBox.Show("Door " + door_id + " Marked as taken", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Public.order_database.Close();
                    pct_search_Click(sender, e);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    if (Public.order_database != null && Public.order_database.State == ConnectionState.Open)
                    {

                        Public.order_database.Close();
                    }
                }


        }

        private void grid_prepping_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == grid_prepping.Columns["btn_prepping_note"].Index && e.RowIndex >= 0)

                try
                {
                    int i = e.RowIndex;
                    Public.note_id = dt_prepping.Rows[i][0].ToString();
                    Public.note_department = "Prepping";
                    allocation_note note_menu = new allocation_note();
                    note_menu.Show();

                }
                catch
                {


                }
            else if (e.ColumnIndex == grid_prepping.Columns["btn_taken_prepping"].Index && e.RowIndex >= 0)

                try
                {
                    int i = e.RowIndex;
                    string date = dt_prepping.Rows[i][4].ToString();
                    string door_id = Public.note_id = dt_prepping.Rows[i][0].ToString();
                    if (date != "")
                    {
                        DialogResult complete = MessageBox.Show("That Door is already taken, Mark as Paused?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (complete == DialogResult.Yes)
                        {
                            if (Public.order_database != null && Public.order_database.State == ConnectionState.Closed)
                            {

                                Public.order_database.Open();
                            }
                            SqlCommand mark_paused_prepping = new SqlCommand(Public.mark_paused_prepping, Public.order_database);
                            SqlCommand insert_stopped_prepping = new SqlCommand(Public.insert_stopped_prepping, Public.order_database);
                            mark_paused_prepping.Parameters.AddWithValue("@door_id", door_id);
                            insert_stopped_prepping.Parameters.AddWithValue("@staff_id", cmb_search.SelectedValue);
                            insert_stopped_prepping.Parameters.AddWithValue("@door_id", door_id);
                            insert_stopped_prepping.Parameters.AddWithValue("@date", DateTime.Now);
                            mark_paused_prepping.ExecuteNonQuery();
                            insert_stopped_prepping.ExecuteNonQuery();
                            Public.order_database.Close();
                            pct_search_Click(sender, e);
                            return;


                        }
                        else
                        {
                            return;
                        }

                    }
                    SqlCommand mark_taken = new SqlCommand(Public.mark_taken_prepping, Public.order_database);
                    SqlCommand insert_started_prepping = new SqlCommand(Public.insert_started_prepping, Public.order_database);
                    if (Public.order_database != null && Public.order_database.State == ConnectionState.Closed)
                    {

                        Public.order_database.Open();
                    }
                    mark_taken.Parameters.AddWithValue("@date", DateTime.Now);
                    mark_taken.Parameters.AddWithValue("@door_id", door_id);
                    insert_started_prepping.Parameters.AddWithValue("@staff_id", cmb_search.SelectedValue);
                    insert_started_prepping.Parameters.AddWithValue("@door_id", door_id);
                    insert_started_prepping.Parameters.AddWithValue("@date", DateTime.Now);
                    insert_started_prepping.ExecuteNonQuery();
                    mark_taken.ExecuteNonQuery();
                    MessageBox.Show("Door " + door_id + " Marked as taken", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Public.order_database.Close();
                    pct_search_Click(sender, e);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    if(Public.order_database != null && Public.order_database.State == ConnectionState.Open)
                    {

                        Public.order_database.Close();
                    }

                }

        }

       
    }
}
