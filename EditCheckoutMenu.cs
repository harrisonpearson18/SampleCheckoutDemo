using SampleCheckoutApplicationDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleCheckoutDemo
{
    // Edit Checkout Menu code
    public partial class EditCheckoutMenu : Form
    {
        DataAccess db = new DataAccess();
        public EditCheckoutMenu()
        {
            InitializeComponent();
        }
        // Cancel button to return to main menu
        private void EditCheckoutMenu_Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CheckoutMenu().ShowDialog();
        }
        // Search button click using firstname and lastname as search criteria
        private void EditCheckoutMenu_SearchButton_Click(object sender, EventArgs e)
        {
            // Checks to make sure values are entered for firstname and lastname 
            if (EditCheckoutMenu_FirstName_Input.Text == "" || EditCheckoutMenu_LastName_Input.Text == "")
            {
                MessageBox.Show("Please enter values for Firstname and Lastname");
            }
            else
            {
                // If both fields entered run GetCheckoutsSearch method passing in first and last name
                try
                {
                    var CheckoutData = db.GetCheckoutsSearch(EditCheckoutMenu_FirstName_Input.Text, EditCheckoutMenu_LastName_Input.Text);
                    SearchCheckoutsTable.DataSource = CheckoutData;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }
        }
        // Edit checkout button click to change any of the entered values
        private void EditCheckoutMenu_ChangeValues_Input_Click(object sender, EventArgs e)
        {
            try
            {
                // Condition 1 = User enters only sample company field to change
                if (EditCheckoutMenu_SampleCompany_Input.Text != "" && EditCheckoutMenu_SamplePattern_Input.Text == "" && EditCheckoutMenu_SampleColor_Input.Text == "")
                {
                    try
                    {
                        var CheckoutID = SearchCheckoutsTable.SelectedCells[0].Value.ToString();
                        int id = Int32.Parse(CheckoutID);
                        db.EditCheckoutSampleCompany(id, EditCheckoutMenu_SampleCompany_Input.Text);
                        var CheckoutData = db.GetCheckoutsSearch(EditCheckoutMenu_FirstName_Input.Text, EditCheckoutMenu_LastName_Input.Text);
                        SearchCheckoutsTable.DataSource = CheckoutData;
                        MessageBox.Show("Checkout edited successfully.");


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex);
                    }
                }
                // Condition 2 = User enteres only sample pattern to change
                if (EditCheckoutMenu_SamplePattern_Input.Text != "" && EditCheckoutMenu_SampleCompany_Input.Text == "" && EditCheckoutMenu_SampleColor_Input.Text == "")
                {
                    try
                    {
                        var CheckoutID = SearchCheckoutsTable.SelectedCells[0].Value.ToString();
                        int id = Int32.Parse(CheckoutID);
                        db.EditCheckoutSamplePattern(id, EditCheckoutMenu_SamplePattern_Input.Text);
                        var CheckoutData = db.GetCheckoutsSearch(EditCheckoutMenu_FirstName_Input.Text, EditCheckoutMenu_LastName_Input.Text);
                        SearchCheckoutsTable.DataSource = CheckoutData;
                        MessageBox.Show("Checkout edited successfully.");


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex);
                    }
                }
                // Condition 3 = User enters only sample color to change
                if (EditCheckoutMenu_SamplePattern_Input.Text == "" && EditCheckoutMenu_SampleCompany_Input.Text == "" && EditCheckoutMenu_SampleColor_Input.Text != "")
                {
                    try
                    {
                        var CheckoutID = SearchCheckoutsTable.SelectedCells[0].Value.ToString();
                        int id = Int32.Parse(CheckoutID);
                        db.EditCheckoutSampleColor(id, EditCheckoutMenu_SampleColor_Input.Text);
                        var CheckoutData = db.GetCheckoutsSearch(EditCheckoutMenu_FirstName_Input.Text, EditCheckoutMenu_LastName_Input.Text);
                        SearchCheckoutsTable.DataSource = CheckoutData;
                        MessageBox.Show("Checkout edited successfully.");


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex);
                    }
                }
                // Condition 4 = User enteres sample pattern and sample company to change
                if (EditCheckoutMenu_SamplePattern_Input.Text != "" && EditCheckoutMenu_SampleCompany_Input.Text != "" && EditCheckoutMenu_SampleColor_Input.Text == "")
                {
                    try
                    {
                        var CheckoutID = SearchCheckoutsTable.SelectedCells[0].Value.ToString();
                        int id = Int32.Parse(CheckoutID);
                        db.EditCheckoutSampleCompanyWithPattern(id, EditCheckoutMenu_SampleCompany_Input.Text, EditCheckoutMenu_SamplePattern_Input.Text);
                        var CheckoutData = db.GetCheckoutsSearch(EditCheckoutMenu_FirstName_Input.Text, EditCheckoutMenu_LastName_Input.Text);
                        SearchCheckoutsTable.DataSource = CheckoutData;
                        MessageBox.Show("Checkout edited successfully.");


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex);
                    }
                }
                // Condition 5 = User enters sample company and sample color to change
                if (EditCheckoutMenu_SamplePattern_Input.Text == "" && EditCheckoutMenu_SampleCompany_Input.Text != "" && EditCheckoutMenu_SampleColor_Input.Text != "")
                {
                    try
                    {
                        var CheckoutID = SearchCheckoutsTable.SelectedCells[0].Value.ToString();
                        int id = Int32.Parse(CheckoutID);
                        db.EditCheckoutSampleCompanyWithColor(id, EditCheckoutMenu_SampleCompany_Input.Text, EditCheckoutMenu_SampleColor_Input.Text);
                        var CheckoutData = db.GetCheckoutsSearch(EditCheckoutMenu_FirstName_Input.Text, EditCheckoutMenu_LastName_Input.Text);
                        SearchCheckoutsTable.DataSource = CheckoutData;
                        MessageBox.Show("Checkout edited successfully.");


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex);
                    }
                }
                // Condition 6 = User enters sample pattern and sample color to change
                if (EditCheckoutMenu_SamplePattern_Input.Text != "" && EditCheckoutMenu_SampleCompany_Input.Text == "" && EditCheckoutMenu_SampleColor_Input.Text != "")
                {
                    try
                    {
                        var CheckoutID = SearchCheckoutsTable.SelectedCells[0].Value.ToString();
                        int id = Int32.Parse(CheckoutID);
                        db.EditCheckoutSamplePatternWithColor(id, EditCheckoutMenu_SamplePattern_Input.Text, EditCheckoutMenu_SampleColor_Input.Text);
                        var CheckoutData = db.GetCheckoutsSearch(EditCheckoutMenu_FirstName_Input.Text, EditCheckoutMenu_LastName_Input.Text);
                        SearchCheckoutsTable.DataSource = CheckoutData;
                        MessageBox.Show("Checkout edited successfully.");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex);
                    }
                }
                // Condition 7 = User enteres values for sample pattern , company, and color to change
                if (EditCheckoutMenu_SamplePattern_Input.Text != "" && EditCheckoutMenu_SampleCompany_Input.Text != "" && EditCheckoutMenu_SampleColor_Input.Text != "")
                {
                    try
                    {
                        var CheckoutID = SearchCheckoutsTable.SelectedCells[0].Value.ToString();
                        int id = Int32.Parse(CheckoutID);
                        db.EditCheckoutAllValues(id, EditCheckoutMenu_SampleCompany_Input.Text, EditCheckoutMenu_SamplePattern_Input.Text, EditCheckoutMenu_SampleColor_Input.Text);
                        var CheckoutData = db.GetCheckoutsSearch(EditCheckoutMenu_FirstName_Input.Text, EditCheckoutMenu_LastName_Input.Text);
                        SearchCheckoutsTable.DataSource = CheckoutData;
                        MessageBox.Show("Checkout edited successfully.");


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex);
                    }
                }
                if(EditCheckoutMenu_SamplePattern_Input.Text == "" && EditCheckoutMenu_SampleCompany_Input.Text == "" && EditCheckoutMenu_SampleColor_Input.Text == "")
                {
                    MessageBox.Show("Please enter at least one value to change!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            EditCheckoutMenu_SamplePattern_Input.Clear();
            EditCheckoutMenu_SampleColor_Input.Clear();
            EditCheckoutMenu_SampleCompany_Input.Clear();
        }


        // User presses enter to click search button when firstname text field is selected
        private void EditCheckoutMenu_FirstName_Input_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EditCheckoutMenu_SearchButton.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        // User presses enter to click search button when lastname text field is selected
        private void EditCheckoutMenu_LastName_Input_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EditCheckoutMenu_SearchButton.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        // User presses enter to click change value button when sample company text field is selected
        private void EditCheckoutMenu_SampleCompany_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EditCheckoutMenu_ChangeValues_Input.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        // User presses enter to click change value button when sample pattern text field is selected
        private void EditCheckoutMenu_SamplePattern_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EditCheckoutMenu_ChangeValues_Input.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        // User presses enter to click change value button when sample color text field is selected
        private void EditCheckoutMenu_SampleColor_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EditCheckoutMenu_ChangeValues_Input.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
