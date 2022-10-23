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
    public partial class DeleteCheckoutMenu : Form
    {
        DataAccess db = new DataAccess();
        public DeleteCheckoutMenu()
        {
            InitializeComponent();
        }
        // Cancel button to return to main menu
        private void DeleteCheckoutMenu_Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            new CheckoutMenu().Show();
        }
        // Search button code
        private void DeleteCheckoutMenu_Search_Button_Click(object sender, EventArgs e)
        {
            // Check user enters first and last name values
            if (DeleteCheckoutMenu_FirstName_Input.Text == "" || DeleteCheckoutMenu_LastName_Input.Text == "")
            {
                MessageBox.Show("Please enter values for Firstname and Lastname");
            }
            else
            {
                // If values entered correctly, populate datagrid with active checkouts matching search criteria using GetCheckoutsSearch method
                try
                {
                    var CheckoutData = db.GetCheckoutsSearch(DeleteCheckoutMenu_FirstName_Input.Text, DeleteCheckoutMenu_LastName_Input.Text);
                    DeleteCheckoutsTable.DataSource = CheckoutData;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }
        }
        // Delete checkout button code
        private void DeleteCheckoutMenu_Delete_Button_Click(object sender, EventArgs e)
        {
            // Using row selected, pulls Checkout_ID to pass into DeleteCheckout method
            try
            {
                var CheckoutID = DeleteCheckoutsTable.SelectedCells[0].Value.ToString();
                int id = Int32.Parse(CheckoutID);
                db.DeleteCheckout(id);
                MessageBox.Show("Checkout deleted successfully.");
                if(DeleteCheckoutMenu_FirstName_Input.Text == "" && DeleteCheckoutMenu_LastName_Input.Text == "")
                {
                    var CheckoutData = db.GetAllCheckouts();
                    DeleteCheckoutsTable.DataSource = CheckoutData;
                }
                else
                {
                    var CheckoutData = db.GetCheckoutsSearch(DeleteCheckoutMenu_FirstName_Input.Text, DeleteCheckoutMenu_LastName_Input.Text);
                    DeleteCheckoutsTable.DataSource = CheckoutData;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
        // Search all button , uses GetAllCheckouts() method
        private void DeleteCheckoutMenu_SearchAll_Button_Click(object sender, EventArgs e)
        {
            var CheckoutData = db.GetAllCheckouts();
            DeleteCheckoutsTable.DataSource = CheckoutData;

        }
        // User presses enter with last name text field selected to click search button
        private void DeleteCheckoutMenu_LastName_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DeleteCheckoutMenu_Search_Button.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
