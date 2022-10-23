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
    public partial class LookupCheckoutMenu : Form
    {
        DataAccess db = new DataAccess();
        public LookupCheckoutMenu()
        {
            InitializeComponent();
        }
        // Cancel button to return to checkout menu
        private void LookupCheckout_Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            new CheckoutMenu().Show();
        }
        // Search button using firstname and lastname criteria
        private void LookupCheckout_Search_Button_Click(object sender, EventArgs e)
        {
            if (LookupCheckout_FirstName_Input.Text == "" || LookupCheckout_LastName_Input.Text == "")
            {
                MessageBox.Show("Please enter values for Firstname and Lastname");
            }
            else
            {
                try
                {
                    var CheckoutData = db.GetCheckoutsSearch(LookupCheckout_FirstName_Input.Text, LookupCheckout_LastName_Input.Text);
                    LookupCheckoutsTable.DataSource = CheckoutData;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }
        }
        // User press enter with last name text field selected to click search button
        private void LookupCheckout_LastName_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LookupCheckout_Search_Button.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        // Search All checkouts button
        private void LookupCheckoutMenu_SearchAll_Button_Click(object sender, EventArgs e)
        {
            try
            {
                var CheckoutData = db.GetAllCheckouts();
                LookupCheckoutsTable.DataSource = CheckoutData;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}
