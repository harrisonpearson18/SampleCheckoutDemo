using MySql.Data.MySqlClient;
using SampleCheckoutApplicationDemo;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SampleCheckoutDemo
{
    public partial class CheckoutMenu : Form
    {
        // Checkout main menu code
        // Establish db object of DataAccess class
        DataAccess db = new DataAccess();

        public CheckoutMenu()
        {
            // Upon initialization send user to login form to get verified
            while (Verified.verified == false)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                if (Verified.exitApp == true)
                {
                    Application.Exit();
                    break;
                }
            }
            // If User is verified proceed with application
            InitializeComponent();
            // Auto populate datagrid with all checkouts using GetAllCheckouts() method
            var CheckoutData = db.GetAllCheckouts();
            AllCheckoutsTable.DataSource = CheckoutData;
        }
        // Refresh Checkouts button click
        private void ShowAllCheckouts_Button_Click(object sender, EventArgs e)
        {
            var CheckoutData = db.GetAllCheckouts();
            AllCheckoutsTable.DataSource = CheckoutData;
        }
        // Refresh Checkouts button click (duplicate)
        private void RefreshAllCheckouts_Click(object sender, EventArgs e)
        {
            var CheckoutData = db.GetAllCheckouts();
            AllCheckoutsTable.DataSource = CheckoutData;
        }
        // Toolbar click to send user to NewCheckoutMenu form
        private void newCheckoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NewCheckoutMenu().ShowDialog();
        }
        // Ensure app exit code
        private void CheckoutMenu_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Verified.exitApp = true;
            Application.Exit();
            Environment.Exit(0);
        }
        // Ensure app exit code
        private void exitCheckoutMenu_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }
        // Toolbar click to send user to ReturnCheckout form
        private void returnCheckoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ReturnCheckoutMenu().ShowDialog();
        }
        // Toolbar click to send user to EditCheckout form
        private void editCheckoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditCheckoutMenu().ShowDialog();
        }
        // Toolbar click to send user to LookupCheckout form
        private void lookupCheckoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LookupCheckoutMenu().ShowDialog();
        }
        // Toolbar click to send user to DeleteCheckout form
        private void deleteCheckoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DeleteCheckoutMenu().ShowDialog();
        }
    }
}