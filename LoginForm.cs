using SampleCheckoutDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleCheckoutApplicationDemo
{
    public partial class LoginForm : Form
    {
        // Login Form Code
        public LoginForm()
        {
            InitializeComponent();
        }
        // Login button code, checks to see remember box is marker, if marked store username and password in property settings, if not clear
        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (RememberMe_Checkbox.Checked == true)
            {
                SampleCheckoutDemo.Properties.Settings.Default.UserName = UsernameText.Text;
                SampleCheckoutDemo.Properties.Settings.Default.Password = PasswordText.Text;
                SampleCheckoutDemo.Properties.Settings.Default.Checkbox = RememberMe_Checkbox.Checked;
                SampleCheckoutDemo.Properties.Settings.Default.Save();
            }
            if (RememberMe_Checkbox.Checked == false)
            {
                SampleCheckoutDemo.Properties.Settings.Default.UserName = "";
                SampleCheckoutDemo.Properties.Settings.Default.Password = "";
                SampleCheckoutDemo.Properties.Settings.Default.Save();
            }
            // Establish db DataAccess object
            DataAccess db = new DataAccess();
            // Using GetLogin method, check entered values against loginid database
            bool status = db.GetLogin(UsernameText.Text, PasswordText.Text);
            if(status == true)
            {
                MessageBox.Show("Login Success.");
                UsernameText.Text = "";
                PasswordText.Text = "";
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect.");
                PasswordText.Text = "";
            }
        }
        // On load populate username/password fields with remembered settings
        private void LoginForm_Load(object sender, EventArgs e)
        {
            if(SampleCheckoutDemo.Properties.Settings.Default.UserName != String.Empty)
            {
                UsernameText.Text = SampleCheckoutDemo.Properties.Settings.Default.UserName;
                PasswordText.Text = SampleCheckoutDemo.Properties.Settings.Default.Password;
                RememberMe_Checkbox.Checked = SampleCheckoutDemo.Properties.Settings.Default.Checkbox;
            }
        }
        // User click enter with username text field selected to click login button
        private void UsernameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_Button.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        // User click enter with password text field selected to click login button
        private void PasswordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_Button.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        // Ensure Applciation exit when no verified
        private void LoginForm_FormClosed(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        // Ensure application exit on exit button click
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Verified.exitApp = true;
            Application.Exit();
        }
    }
}
