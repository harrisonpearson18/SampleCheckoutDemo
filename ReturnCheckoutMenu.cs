using SampleCheckoutApplicationDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleCheckoutDemo
{
    public partial class ReturnCheckoutMenu : Form
    {
        // Return Checkout Menu Form
        // Establish db as new DataAccess class object
        DataAccess db = new DataAccess();
        public ReturnCheckoutMenu()
        {
            InitializeComponent();
            // Auto populate datagrid with active checkouts
            var CheckoutData = db.GetActiveCheckouts();
            ReturnCheckoutsTable.DataSource = CheckoutData;
        }
        // Search button code
        private void ReturnCheckout_SearchInfo_Button_Click(object sender, EventArgs e)
        {
            // Checks that first and last name values are entered
            if(ReturnCheckout_FirstName_Input.Text == "" && ReturnCheckout_LastName_Input.Text == "")
            {
                MessageBox.Show("Please enter values for Firstname and Lastname");
            }
            else
            {
                // If both name fields are entered properly populate datagrid with active checkouts meeting search criteria
                try
                {
                    var CheckoutData = db.GetActiveCheckoutsSearch(ReturnCheckout_FirstName_Input.Text, ReturnCheckout_LastName_Input.Text);
                    ReturnCheckoutsTable.DataSource = CheckoutData;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }
        }
        // Cancel button to return to main menu
        private void ReturnCheckoutMenu_Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            new CheckoutMenu().Show();
        }
        // Return Checkout button
        private void ReturnCheckoutMenu_Return_Button_Click(object sender, EventArgs e)
        {
            // Using selected row, pulls Checkout_ID to update ReturnStatus in database using ReturnSelectedCheckout(int CheckoutID) method
            try
            {
                var CheckoutID = ReturnCheckoutsTable.SelectedCells[0].Value.ToString();
                int id = Int32.Parse(CheckoutID);
                db.ReturnSelectedCheckout(id);
                var CheckoutData = db.GetActiveCheckouts();
                ReturnCheckoutsTable.DataSource = CheckoutData;
                MessageBox.Show("Checkout returned successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
        // User presses enter with last name text field to click search button
        private void ReturnCheckout_LastName_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ReturnCheckout_SearchInfo_Button.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        // Search button to fill grid with all active checkouts using GetActiveCheckouts method
        private void ReturnCheckoutMenu_SearchAll_Button_Click(object sender, EventArgs e)
        {

            try
            {
                var CheckoutData = db.GetActiveCheckouts();
                ReturnCheckoutsTable.DataSource = CheckoutData;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}
