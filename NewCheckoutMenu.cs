using SampleCheckoutApplicationDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleCheckoutDemo
{
    public partial class NewCheckoutMenu : Form
    {
        // NewCheckoutForm code

        //Establish db DataAccess object
        DataAccess db = new DataAccess();

        public NewCheckoutMenu()
        {
            InitializeComponent();
        }
        // Cancel button click to return to main menu
        private void NewCheckoutMenu_Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            new CheckoutMenu().Show();
        }
        // New Checkout button code
        private void New_Checkout_btn_Click(object sender, EventArgs e)
        {
            // Check that required fields are entered correctly
            if(NewCheckout_FirstName_Textbox.Text == "" || NewCheckout_LastName_Textbox.Text == "" || NewCheckout_SampleCompany_Textbox.Text == "")
            {
                MessageBox.Show("Some required(*) fields are blank.");
            }
            if(NewCheckout_Phone_Textbox.Text.Length != 10)
            {
                MessageBox.Show("Invalid entry for phone number. (ex. ##########)");
            }
            // If required fields entered insert passed values into InsertCheckoutInfo method to add entry to database
            else
            {

                try
                {

                    db.InsertCheckoutInfo(NewCheckout_FirstName_Textbox.Text, NewCheckout_LastName_Textbox.Text, NewCheckout_Email_Textbox.Text,
                        String.Format("{0:(###) ###-####}", Int64.Parse(NewCheckout_Phone_Textbox.Text)), NewCheckout_SampleCompany_Textbox.Text, NewCheckout_SamplePattern_Textbox.Text,
                        NewCheckout_SampleColor_Textbox.Text);
                    MessageBox.Show("Checkout Implemented Successfully");
                    this.Hide();
                    CheckoutMenu checkoutMenu = new CheckoutMenu();
                    checkoutMenu.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }
        }
        // User presses enter with samplecolor text field selected click new checkout button
        private void NewCheckout_SampleColor_Textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                New_Checkout_btn.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
