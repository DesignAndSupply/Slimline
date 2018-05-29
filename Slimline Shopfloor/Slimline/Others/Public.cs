using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Slimline_Shopfloor
{
    class Public
    {
        
        //admin
        public static string password = "password";
        public static string select_completion_log = "SELECT door_id as [Door ID] ,part_complete_date as [Complete Date],time_for_part as [Part Time] ,op AS [Operation] from dbo.door_part_completion_log WHERE (part_complete_date between @start AND @end AND op ='Cutting') " +
            "OR (part_complete_date between @start AND @end AND op ='Prepping') " +
            "OR (part_complete_date between @start AND @end AND op ='Assembly') " +
            "OR (part_complete_date between @start AND @end AND op ='SL_buff')" +
            "OR (part_complete_date between @start AND @end AND op ='SL_stores') " +
            "OR (part_complete_date between @start AND @end AND op ='SL_pack') " ;

        public static string correct_department_goal = "Update dbo.daily_department_goal SET actual_hours_slimline = @time  WHERE date_goal = @date";
        public static string select_stock_allocation = "SELECT dbo.stock.stock_code AS [Stock Code],  dbo.stock.description As [Description], dbo.stock.amount_in_stock AS [Quantity] FROM dbo.stock_category RIGHT JOIN (dbo.supplier RIGHT JOIN dbo.stock ON dbo.supplier.id = dbo.stock.supplier_id) ON dbo.stock_category.id = dbo.stock.category WHERE dbo.stock.consumable_identifier = -1  ORDER BY stock_code_int";
        public static string update_stock = "UPDATE dbo_stock SET amount_in_stock = amount_in_stock - @qty WHERE stock_code =@stock_code";
        public static string insert_stock_log_admin = "INSERT INTO dbo_stock_log (item_name, quantity, staff_name, transaction_date, stock_code, booked_out_by_id) VALUES (@description, @qty, @staff_allocated_to, @date, @stock , @staff_allocated_by)";
        public static string search_stock_description = "SELECT dbo.stock.stock_code AS [Stock Code],  dbo.stock.description As [Description], dbo.stock.amount_in_stock AS [Quantity] FROM dbo.stock_category RIGHT JOIN (dbo.supplier RIGHT JOIN dbo.stock ON dbo.supplier.id = dbo.stock.supplier_id) ON dbo.stock_category.id = dbo.stock.category WHERE dbo.stock.consumable_identifier = -1 AND  dbo.stock.description description like  '%' + @description+ '%' ORDER BY stock_code_int desc";
        public static string search_stock_code = "SELECT dbo.stock.stock_code AS [Stock Code],  dbo.stock.description As [Description], dbo.stock.amount_in_stock AS [Quantity] FROM dbo.stock_category RIGHT JOIN (dbo.supplier RIGHT JOIN dbo.stock ON dbo.supplier.id = dbo.stock.supplier_id) ON dbo.stock_category.id = dbo.stock.category WHERE dbo.stock.consumable_identifier = -1  AND stock_code = @stock_code ORDER BY stock_code_int desc";
        public static string search_stock_description_stock_code = "SELECT dbo.stock.stock_code AS [Stock Code],  dbo.stock.description As [Description], dbo.stock.amount_in_stock AS [Quantity] FROM dbo.stock_category RIGHT JOIN (dbo.supplier RIGHT JOIN dbo.stock ON dbo.supplier.id = dbo.stock.supplier_id) ON dbo.stock_category.id = dbo.stock.category WHERE dbo.stock.consumable_identifier = -1 AND  dbo.stock.description like  '%' + @description+ '%'  AND stock_code = @stock_code+ '%' ORDER BY stock_code_int desc";
        //connections
        public static SqlConnection order_database_view = new SqlConnection("Data Source = 192.168.0.150\\SQLEXPRESS;Initial Catalog = order_database; Integrated Security = False; User ID = sa; Password=Dodid1;");
        public static SqlConnection user_database = new SqlConnection("Data Source = 192.168.0.150\\SQLEXPRESS; Initial Catalog = user_info; Integrated Security = False; User ID = sa; Password=Dodid1;");
        public static SqlConnection order_database = new SqlConnection("Data Source = 192.168.0.150\\SQLEXPRESS;Initial Catalog = order_database; Integrated Security = False; User ID = sa; Password=Dodid1;");


        // Values
        public static string first_validation_door_id;
        public static string second_validation_door_id;
        public static string Operation_validation;
        public static string Operation;
        public static string Operation_log;
        public static string operation_time;
        public static string operation_remaining_name;
        public static Double Sum_of_percent_complete;
        public static Double complete_percent = (1 - Convert.ToInt32(Sum_of_percent_complete));
        public static Int32 quantity_same;
        public static Double staff_id;
        public static string date_op_complete = "date_" + Public.Operation + "_complete";
        public static Double op_time;
        public static DateTime myDateTime = DateTime.Now;
        public static string sqlFormattedDate = myDateTime.Date.ToString("yyyy-MM-dd 00:00:00");
        public static string sqlFormattedDate_end = myDateTime.Date.ToString("yyyy-MM-dd 23:59:59");
        public static string  select_statment;
        public static string door_id;
        public static string note_id;
        public static string note_department;
        public static string staff_selection;
        public static string po_number;

        //Statements
       
        public static SqlDataAdapter User_list = new SqlDataAdapter("Select id,forename,surname from dbo.[user] WHERE(((actual_department = 'cutting' Or actual_department = 'Assembly' Or actual_department = 'Prepping' Or actual_department = 'SL Buff')AND [Current] = 1  ) OR ((allocation_dept_2= 'Cutting' Or allocation_dept_2= 'Assembly' Or allocation_dept_2= 'Prepping' Or allocation_dept_2= 'SL Buff') AND [Current] = 1 ) OR((allocation_dept_3='Cutting' Or allocation_dept_3= 'Assembly' Or allocation_dept_3='Prepping' Or allocation_dept_3='SL Buff')) AND [Current] = 1)", user_database);
        public static SqlDataAdapter user_list_office = new SqlDataAdapter("Select id, forename, surname from dbo.[user] WHERE([id] = 7) OR([ID] = 24)", user_database);
        public static SqlDataAdapter User_list_pallet = new SqlDataAdapter("Select id,forename,surname from dbo.[user] WHERE(((actual_department = 'cutting' Or actual_department = 'Assembly' Or actual_department = 'Prepping' Or actual_department = 'SL Buff')AND [Current] = 1  ) OR ((allocation_dept_2= 'Cutting' Or allocation_dept_2= 'Assembly' Or allocation_dept_2= 'Prepping' Or allocation_dept_2= 'SL Buff') AND [Current] = 1 ) OR((allocation_dept_3='Cutting' Or allocation_dept_3= 'Assembly' Or allocation_dept_3='Prepping' Or allocation_dept_3='SL Buff')) OR (id = 64) OR (id = 97) AND [Current] = 1)", user_database);
        public static string update_louvre_stock = ("Update dbo.SR_addon_stock SET amount_in_stock = amount_in_stock + @qty WHERE door_id = @id ");
        public static string stock_door_check = ("Select Id FROM dbo.SR_addon_stock WHERE ID = @id ");
        public static string select_data = "SELECT Door_id AS 'Door Id', part_complete_date As 'Completion Date' , fullname as 'Staff Member',part_percent_complete ,Percent_complete as 'Percent Complete'  FROM c_view_slimline_part_completion WHERE door_id = @door_id AND op = @operation";
        public static string select_time_remaianing = "Select @op_remaining From dbo.door WHERE id = @id";
        public static string work_allocation_data = "Select * from C_view_slimline_uncomplete";
        public static string Search_allocation = "Select * from C_view_slimline_uncomplete  WHERE [Prepping Allocation] = @staff OR [SL Buff allocation] = @staff OR  [Cutting allocation] = @staff OR  [Prepping allocation] = @staff OR  [Packing allocation] = @staff ORDER BY [Packing Date], [SL Buff Date], [Assembly Date], [Date Prep], [Cutting Date]";
        public static string search_cutting = "Select  [Door ID],[Cutting allocation], [Cutting Date], [Cutting Complete], [Cutting Start Date] as [Start Date] from C_view_slimline_uncomplete  WHERE   [Cutting allocation] = @staff and [cutting complete] = 0 and department = 'cutting'";
        public static string search_buffing = "Select  [Door ID], [SL Buff allocation], [SL Buff Date], [SL Buff Complete],[Buffing Start Date] as [Start Date]   from C_view_slimline_uncomplete  WHERE   [SL Buff allocation] = @staff and [SL Buff complete] = 0 and department ='sl buff'";
        public static string search_assembly = "Select [Door ID], [Assembly allocation], [Assembly Date],  [Assembly Complete],[Assembly Start Date] as [Start Date]  from C_view_slimline_uncomplete  WHERE   [assembly allocation] = @staff and [assembly complete] = 0 and department ='assembly'";
        public static string search_prepping = "Select [Door ID], [Prepping allocation], [Date Prep],  [Prepping Complete],[Prepping Start Date] as [Start Date] from C_view_slimline_uncomplete  WHERE   [Prepping allocation] = @staff and [Prepping complete] = 0 and department ='prepping'";
        public static string search_packing = "Select  [Door ID],[Packing allocation],[Packing Date], [Packing Complete] ,[packing Start Date] as [Start Date] from C_view_slimline_uncomplete  WHERE   [packing allocation] = @staff and [Packing Complete]  = 0 and department ='packing'";
        public static string select_quantity_same = "Select quantity_same From dbo.door WHERE id = @id  ";
        public static string update_department_goal = "Update dbo.daily_department_goal SET actual_hours_slimline = actual_hours_slimline + @time_for_part  WHERE date_goal = @date;";
        public static string insert_completion_log = "Insert into dbo.door_part_completion_log (door_id,part_complete_date,time_for_part,part,part_status,op,staff_id,part_percent_complete) values(@id, @date, @part_time, @part, @part_status,@op, @staff_id, @percent)";
        public static string select_po = "SELECT id as 'ID', po_id as 'PO Number', stock_code as 'Stock Code', due_date as 'Date Due', quantity as 'Quantity', description as 'Description' FROM dbo.po_item WHERE po_id = @po ";
        //allocation 

        public static string delete_assembly_allocation = "DELETE FROM dbo.door_allocation WHERE door_id = @id AND department = 'Assembly'";
        public static string insert_assembly_allocation = "INSERT INTO dbo.door_allocation(door_id, operation_date, department, staff_id) VALUES(@id,@date,'assembly', @staff_id)";
        public static string update_assembly_allocation = "UPDATE dbo.door SET assembly_staff_allocation = @staff_name WHERE id = @id";

        public static string delete_prepping_allocation = "DELETE FROM dbo.door_allocation WHERE door_id = @id AND department = 'prepping'";
        public static string insert_prepping_allocation = "INSERT INTO dbo.door_allocation(door_id, operation_date, department, staff_id) VALUES(@id,@date,'prepping', @staff_id)";
        public static string update_prepping_allocation = "UPDATE dbo.door SET prep_staff_allocation = @staff_name WHERE id = @id";

        public static string delete_cutting_allocation = "DELETE FROM  dbo.door_allocation WHERE door_id = @id AND department = 'SL Buff'";
        public static string insert_cutting_allocation = "INSERT INTO  dbo.door_allocation(door_id, operation_date, department, staff_id) VALUES(@id,@date,'SL BUFF', @staff_id)";
        public static string update_cutting_allocation = "UPDATE dbo.door SET cut_staff_allocation = @staff_name WHERE id = @id";

        public static string delete_sl_buff_allocation = "DELETE FROM  dbo.door_allocation WHERE door_id = @id AND department = 'SL Buff'";
        public static string update_sl_buff_allocation = "UPDATE dbo.door SET sl_buff_staff_allocation = @staff_name WHERE id = @id";
        public static string insert_sl_buff_allocation = "INSERT INTO dbo.door_allocation(door_id, operation_date, department, staff_id) VALUES(@id,@date,'SL BUFF', @staff_id)";

        public static string mark_taken_packing = "UPDATE dbo.door_allocation SET started_pack = @date WHERE door_id = @door_id  and department ='packing'";
        public static string mark_taken_cutting = "UPDATE dbo.door_allocation SET started_cut = @date WHERE door_id = @door_id and department ='cutting'";
        public static string mark_taken_prepping = "UPDATE dbo.door_allocation SET started_prep =  @date WHERE door_id= @door_id and department ='prepping'";
        public static string mark_taken_assembly = "UPDATE dbo.door_allocation SET started_assembly = @date WHERE door_id= @door_id and department ='assembly'";
        public static string mark_taken_buffing = "UPDATE dbo.door_allocation SET started_sl_buff = @date WHERE door_id= @door_id and department ='SL buff'";

        public static string mark_paused_packing = "UPDATE dbo.door_allocation SET started_pack = null WHERE door_id = @door_id and  department ='packing'";
        public static string mark_paused_cutting = "UPDATE dbo.door_allocation SET started_cut = null WHERE door_id = @door_id and department ='cutting'";
        public static string mark_paused_prepping = "UPDATE dbo.door_allocation SET started_prep =  null WHERE door_id= @door_id and department ='prepping'";
        public static string mark_paused_assembly = "UPDATE dbo.door_allocation SET started_assembly = null WHERE door_id= @door_id and department ='assembly'";
        public static string mark_paused_buffing = "UPDATE dbo.door_allocation SET started_sl_buff = null WHERE door_id= @door_id and department ='SL buff'";

        public static string insert_stopped_packing = "Insert into dbo.door_stoppages (action, action_time,department,door_id,staff_id) values('Paused',@date,'Packing' , @door_id, @staff_id)";
        public static string insert_stopped_cutting = "Insert into dbo.door_stoppages (action, action_time,department,door_id,staff_id) values('Paused',@date,'Cutting' , @door_id, @staff_id)";
        public static string insert_stopped_prepping = "Insert into dbo.door_stoppages (action, action_time,department,door_id,staff_id) values('Paused',@date,'Prepping' , @door_id, @staff_id)";
        public static string insert_stopped_assembly = "Insert into dbo.door_stoppages (action, action_time,department,door_id,staff_id) values('Paused',@date,'Assembly' , @door_id, @staff_id)";
        public static string insert_stopped_buffing = "Insert into dbo.door_stoppages (action, action_time,department,door_id,staff_id) values('Paused',@date,'Buffing' , @door_id, @staff_id)";

        public static string insert_started_packing = "Insert into dbo.door_stoppages (action, action_time,department,door_id,staff_id) values('Live',@date,'Packing' , @door_id, @staff_id)";
        public static string insert_started_cutting = "Insert into dbo.door_stoppages (action, action_time,department,door_id,staff_id) values('Live',@date,'Cutting' , @door_id, @staff_id)";
        public static string insert_started_prepping = "Insert into dbo.door_stoppages (action, action_time,department,door_id,staff_id) values('Live',@date,'Prepping' , @door_id, @staff_id)";
        public static string insert_started_assembly = "Insert into dbo.door_stoppages (action, action_time,department,door_id,staff_id) values('Live',@date,'Assembly' , @door_id, @staff_id)";
        public static string insert_started_buffing = "Insert into dbo.door_stoppages (action, action_time,department,door_id,staff_id) values('Live',@date,'Buffing' , @door_id, @staff_id)";

        //additional info 


        public static string select_loose_items = "Select * from dbo.loose_items";
        public static string select_packing_notes = "SELECT id,description FROM dbo.loose_item_packing_note";
        public static string insert_loose_item = "INSERT INTO dbo.loose_item_to_door (door_id, loose_item_id, [date], user_id, quantity, [note]) VALUES (@door_id,@loost_item_id, @date, @user_id, @quantity,@notes)";
        public static string insert_additional = "UPDATE dbo.door_transport SET keys_in_frame = @keys, welded_frame = @frame, boxes = @box, welded_frame_quantity = @qty WHERE door_id = @Id ";

        //stock
        public static string select_quantity_same_sr_addon = "SELECT door.quantity_same FROM door INNER JOIN SR_addon_stock ON door.id = SR_addon_stock.door_id WHERE(door.id = @id) AND(door.status_id = '1' OR  door.status_id = '2')";
        public static string select_stock = "SELECT id AS [Stock ID], door_id As [Door ID], description AS [Description], amount_in_stock AS [Quantity] , low_order_level As [Low Level] FROM dbo.SR_addon_stock";
        public static string increase_stock = "Update dbo.SR_addon_stock SET amount_in_stock = amount_in_stock + 1 WHERE id = @id";
        public static string decrease_stock = "Update dbo.SR_addon_stock  SET amount_in_stock = amount_in_stock - 1 WHERE id = @id";
        public static string select_pallet = "SELECT id As [ID], update_by as [Update By], date_of_update As [Date], amount As [Amount], stock_in_out As [In/Out] FROM dbo.pallet_stock_log ORDER BY date_of_update DESC";
        public static string increase_pallet = "UPDATE dbo.pallet_stock SET current_stock = current_stock + @quantity WHERE id = 1";
        public static string decrease_pallet = "UPDATE dbo.pallet_stock SET current_stock = current_stock - @quantity WHERE id = 1";
        public static string insert_additional_pallet = "INSERT INTO dbo.pallet_stock_log (update_by,date_of_update,amount,stock_in_out) VALUES (@staff,@date,@quantity,'IN')";
        public static string insert_subtract_pallet = "INSERT INTO dbo.pallet_stock_log (update_by,date_of_update,amount,stock_in_out) VALUES (@staff,@date,@quantity,'OUT')";
        public static string insert_stock_log = "INSERT INTO dbo.stock_log (item_name,quantity,staff_name,staff_dept, transaction_date,staff_number,booked_out_by_id) VALUES ('Pallet',@quantity,@staff,'Slimline',@date,@staff_id,@booked)";
        public static string update_stock_door = "Update dbo.door SET date_cutting =@cutting_date, date_prep = @prepping_date, date_assembly = @assembly_date, date_sl_buff =@SL_buff_date, cut_staff_allocation = null, prep_staff_allocation = null, assembly_staff_allocation = null ,sl_buff_staff_allocation = null , status_id = 1 WHERE id = @ID";
        public static string default_time = "SELECT door_type.default_time_cutting, door_type.default_time_assembly, door_type.default_time_pack, door_type.default_time_SL_buff FROM door RIGHT OUTER JOIN door_type ON door.door_type_id = door_type.id WHERE door.id = @id";



    }
}

