namespace SampleCheckoutApplicationDemo
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.RememberMe_Checkbox = new System.Windows.Forms.CheckBox();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(20, 20);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(71, 15);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "USERNAME:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(20, 72);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(71, 15);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "PASSWORD:";
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(140, 105);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(190, 35);
            this.Login_Button.TabIndex = 2;
            this.Login_Button.Text = "LOGIN";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // UsernameText
            // 
            this.UsernameText.Location = new System.Drawing.Point(130, 16);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(271, 23);
            this.UsernameText.TabIndex = 3;
            this.UsernameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsernameText_KeyDown);
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(130, 69);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(271, 23);
            this.PasswordText.TabIndex = 4;
            this.PasswordText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordText_KeyDown);
            // 
            // RememberMe_Checkbox
            // 
            this.RememberMe_Checkbox.AutoSize = true;
            this.RememberMe_Checkbox.Location = new System.Drawing.Point(20, 114);
            this.RememberMe_Checkbox.Name = "RememberMe_Checkbox";
            this.RememberMe_Checkbox.Size = new System.Drawing.Size(117, 19);
            this.RememberMe_Checkbox.TabIndex = 5;
            this.RememberMe_Checkbox.Text = "Remember Login";
            this.RememberMe_Checkbox.UseVisualStyleBackColor = true;
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(336, 102);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(114, 38);
            this.Exit_Button.TabIndex = 6;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 164);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.RememberMe_Checkbox);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label username_label;
        private Label password_label;
        private Button Login_Button;
        private TextBox UsernameText;
        private TextBox PasswordText;
        private CheckBox RememberMe_Checkbox;
        private Button Exit_Button;
    }
}