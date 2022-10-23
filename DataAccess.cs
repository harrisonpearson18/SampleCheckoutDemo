using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using SampleCheckoutDemo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SampleCheckoutApplicationDemo
{
    public class DataAccess
    {
        // DataAccess class to facilitate actions across the application

        // GetLogin method to verify user login against LoginId database using ValidLogin stored procedure
        public bool GetLogin(string username, string password)
        {

            using (IDbConnection conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB")))
            {            
                string procedure = "ValidLogin";
                MySqlConnection con = new MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB"));
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(procedure, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("username_login", username);
                cmd.Parameters.AddWithValue("password_login", password);
                cmd.Parameters.Add("?yes_no", MySqlDbType.Int32);
                cmd.Parameters["?yes_no"].Direction = ParameterDirection.Output;
                int i = cmd.ExecuteNonQuery();
                object answer = cmd.Parameters["?yes_no"].Value;
                Type typ = answer.GetType();
                int status = (int)answer;
                con.Close();
                if (status == 1)
                {
                    Verified.verified= true;
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        // GetAllCheckouts method to return datatable to populate datagrids in application with all current checkouts in database using SelectAllCheckouts procedure
        public DataTable GetAllCheckouts()
        {
            using (IDbConnection conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB")))
            {
                string procedure = "SelectAllCheckouts";
                MySqlConnection con = new MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB"));
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(procedure, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                con.Close();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable ds = new DataTable();
                    adapter.Fill(ds);
                    var source = new BindingSource();
                    source.DataSource = ds;
                    return ds;
                }
            }
        }
        // InsertCheckoutInfo method to insert FirstName, LastName, Email, Phone, Sample Company,
        // Sample Pattern, and Sample Color inputs along with return status as false and the current date for checkout date into sql database
        // using InsertCheckout stored procedure
        public void InsertCheckoutInfo(string FirstName, string LastName, string Email, string PhoneNumber, string SampleCompany, string SamplePattern, string SampleColor)
        {

            using (IDbConnection conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB")))
            {
                var i = DateTime.Today;
                string procedure = "InsertCheckout";
                MySqlConnection con = new MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB"));
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(procedure, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("FirstName_Input", FirstName);
                cmd.Parameters.AddWithValue("LastName_Input", LastName);
                cmd.Parameters.AddWithValue("Email_Input", Email);
                cmd.Parameters.AddWithValue("PhoneNumber_Input", PhoneNumber);
                cmd.Parameters.AddWithValue("SampleCompany_Input", SampleCompany);
                cmd.Parameters.AddWithValue("SamplePattern_Input", SamplePattern);
                cmd.Parameters.AddWithValue("SampleColor_Input", SampleColor);
                cmd.Parameters.AddWithValue("ReturnStatus", 1);
                cmd.Parameters.AddWithValue("CheckoutDate", i);
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }
        // GetActiveCheckouts method to return datatable with all active checkouts, where ReturnStatus = 1 using SelectAllCheckouts_CheckedOut stored procedure
        public DataTable GetActiveCheckouts()
        {
            using (IDbConnection conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB")))
            {
                string procedure = "SelectAllCheckouts_CheckedOut";
                MySqlConnection con = new MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB"));
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(procedure, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                con.Close();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable ds = new DataTable();
                    adapter.Fill(ds);
                    var source = new BindingSource();
                    source.DataSource = ds;
                    return ds;
                }
            }
        }
        // GetActiveCheckoutsSearch method to display checked out samples meeting firstname and lastname criteria (return status = 1) using ReturnCheckoutLookup stored procedure
        public DataTable GetActiveCheckoutsSearch(string FirstName, string LastName)
        {
            using (IDbConnection conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB")))
            {
                var i = DateTime.Today;
                string procedure = "ReturnCheckoutLookup";
                MySqlConnection con = new MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB"));
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(procedure, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("FirstName_Input", FirstName);
                cmd.Parameters.AddWithValue("LastName_Input", LastName);
                cmd.Parameters.AddWithValue("ReturnStatus", 1);
                cmd.ExecuteNonQuery();
                con.Close();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable ds = new DataTable();
                    adapter.Fill(ds);
                    var source = new BindingSource();
                    source.DataSource = ds;
                    return ds;
                }
            }
        }
        // GetCheckoutsSearch method to return all returned and checked out sample by given customer name using SearchCheckouts stored procedure
        public DataTable GetCheckoutsSearch(string FirstName, string LastName)
        {
            using (IDbConnection conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB")))
            {
                string procedure = "SearchCheckouts";
                MySqlConnection con = new MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB"));
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(procedure, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("FirstName_Input", FirstName);
                cmd.Parameters.AddWithValue("LastName_Input", LastName);
                cmd.ExecuteNonQuery();
                con.Close();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable ds = new DataTable();
                    adapter.Fill(ds);
                    var source = new BindingSource();
                    source.DataSource = ds;
                    return ds;
                }

            }
        }
        // ReturnSelectedCheckout method to pull selected row Checkout_ID to update ReturnStatus and CheckinDate using ReturnCheckout stored procedure
        public void ReturnSelectedCheckout(int CheckoutID)
        {
            using (IDbConnection conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB")))
            {
                var i = DateTime.Today;
                string procedure = "ReturnCheckout";
                MySqlConnection con = new MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB"));
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(procedure, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Checkout_ID_Input", CheckoutID);
                cmd.Parameters.AddWithValue("ReturnStatus", 0);
                cmd.Parameters.AddWithValue("CheckInDate_Input", i);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        // EditCheckoutSampleCompany method to only change sample company of given entry using EditCheckout_OnlyCompany procedure
        public void EditCheckoutSampleCompany(int CheckoutID, string SampleCompany)
        {
            using (IDbConnection conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB")))
            {

                string procedure = "EditCheckout_OnlyCompany";
                MySqlConnection con = new MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB"));
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(procedure, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Checkout_ID_Input", CheckoutID);
                cmd.Parameters.AddWithValue("SampleCompany_Input", SampleCompany);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        // EditCheckoutSamplePattern method to only change sample pattern of given entry using EditCheckout_OnlySamplePattern procedure

        public void EditCheckoutSamplePattern(int CheckoutID, string SamplePattern)
        {
            using (IDbConnection conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB")))
            {

                string procedure = "EditCheckout_OnlySamplePattern";
                MySqlConnection con = new MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB"));
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(procedure, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Checkout_ID_Input", CheckoutID);
                cmd.Parameters.AddWithValue("SamplePattern_Input", SamplePattern);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        // EditCheckoutSampleColor method to only change sample pattern of given entry using EditCheckout_OnlySampleColor procedure

        public void EditCheckoutSampleColor(int CheckoutID, string SampleColor)
        {
            // Method to insert FirstName, LastName, Email, Phone, Sample Company, Sample Pattern, and Sample Color inputs along with return status as false and the current date for checkout date into sql database

            using (IDbConnection conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB")))
            {

                string procedure = "EditCheckout_OnlySampleColor";
                MySqlConnection con = new MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB"));
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(procedure, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Checkout_ID_Input", CheckoutID);
                cmd.Parameters.AddWithValue("SampleColor_Input", SampleColor);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        // EditCheckoutSampleCompanyWithPattern method to change sample pattern & company of given entry using EditCheckout_SampleCompanyWithPattern procedure

        public void EditCheckoutSampleCompanyWithPattern(int CheckoutID, string SampleCompany, string SamplePattern)
        {
            using (IDbConnection conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB")))
            {

                string procedure = "EditCheckout_SampleCompanyWithPattern";
                MySqlConnection con = new MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB"));
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(procedure, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Checkout_ID_Input", CheckoutID);
                cmd.Parameters.AddWithValue("SampleCompany_Input", SampleCompany);
                cmd.Parameters.AddWithValue("SamplePattern_Input", SamplePattern);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        // EditCheckoutSampleCompanyWithColor method to change sample color & company of given entry using EditCheckout_SampleCompanyWithColor procedure

        public void EditCheckoutSampleCompanyWithColor(int CheckoutID, string SampleCompany, string SampleColor)
        {
            using (IDbConnection conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB")))
            {

                string procedure = "EditCheckout_SampleCompanyWithColor";
                MySqlConnection con = new MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB"));
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(procedure, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Checkout_ID_Input", CheckoutID);
                cmd.Parameters.AddWithValue("SampleCompany_Input", SampleCompany);
                cmd.Parameters.AddWithValue("SampleColor_Input", SampleColor);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        // EditCheckoutSamplePatternWithColor method to change sample pattern & company of given entry using EditCheckout_SamplePatternWithColor procedure

        public void EditCheckoutSamplePatternWithColor(int CheckoutID, string SamplePattern, string SampleColor)
        {
            using (IDbConnection conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB")))
            {

                string procedure = "EditCheckout_SamplePatternWithColor";
                MySqlConnection con = new MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB"));
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(procedure, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Checkout_ID_Input", CheckoutID);
                cmd.Parameters.AddWithValue("SamplePattern_Input", SamplePattern);
                cmd.Parameters.AddWithValue("SampleColor_Input", SampleColor);
                cmd.ExecuteNonQuery(); 
                con.Close();
            }
        }
        // EditCheckoutAllValues method to change sample company, pattern, and color of selected entry using EditCheckout_AllValue procedure
        public void EditCheckoutAllValues(int CheckoutID, string SampleCompany, string SamplePattern, string SampleColor)
        {
            using (IDbConnection conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB")))
            {

                string procedure = "EditCheckout_AllValues";
                MySqlConnection con = new MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB"));
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(procedure, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Checkout_ID_Input", CheckoutID);
                cmd.Parameters.AddWithValue("SampleCompany_Input", SampleCompany);
                cmd.Parameters.AddWithValue("SamplePattern_Input", SamplePattern);
                cmd.Parameters.AddWithValue("SampleColor_Input", SampleColor);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        // DeleteCheckout method to delete given row using checkoutid with DeleteCheckoutEntry stored procedure
        public void DeleteCheckout(int CheckoutID)
        {

            using (IDbConnection conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB")))
            {

                string procedure = "DeleteCheckoutEntry";
                MySqlConnection con = new MySqlConnection(ConnectionHelper.CnnVal("CheckoutDB"));
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(procedure, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Checkout_ID_Input", CheckoutID);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }

}
