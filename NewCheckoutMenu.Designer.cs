namespace SampleCheckoutDemo
{
    partial class NewCheckoutMenu
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
            this.New_Checkout_btn = new System.Windows.Forms.Button();
            this.NewCheckoutMenu_Cancel_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstName_Label = new System.Windows.Forms.Label();
            this.LastName_Label = new System.Windows.Forms.Label();
            this.NewCheckout_FirstName_Textbox = new System.Windows.Forms.TextBox();
            this.NewCheckout_LastName_Textbox = new System.Windows.Forms.TextBox();
            this.Email_Label = new System.Windows.Forms.Label();
            this.Phone_Label = new System.Windows.Forms.Label();
            this.NewCheckout_Email_Textbox = new System.Windows.Forms.TextBox();
            this.NewCheckout_Phone_Textbox = new System.Windows.Forms.TextBox();
            this.Company_Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Pattern_Label = new System.Windows.Forms.Label();
            this.Color_Label = new System.Windows.Forms.Label();
            this.NewCheckout_SampleCompany_Textbox = new System.Windows.Forms.TextBox();
            this.NewCheckout_SamplePattern_Textbox = new System.Windows.Forms.TextBox();
            this.NewCheckout_SampleColor_Textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // New_Checkout_btn
            // 
            this.New_Checkout_btn.Location = new System.Drawing.Point(430, 403);
            this.New_Checkout_btn.Name = "New_Checkout_btn";
            this.New_Checkout_btn.Size = new System.Drawing.Size(170, 47);
            this.New_Checkout_btn.TabIndex = 0;
            this.New_Checkout_btn.Text = "Add New Checkout";
            this.New_Checkout_btn.UseVisualStyleBackColor = true;
            this.New_Checkout_btn.Click += new System.EventHandler(this.New_Checkout_btn_Click);
            // 
            // NewCheckoutMenu_Cancel_btn
            // 
            this.NewCheckoutMenu_Cancel_btn.Location = new System.Drawing.Point(12, 403);
            this.NewCheckoutMenu_Cancel_btn.Name = "NewCheckoutMenu_Cancel_btn";
            this.NewCheckoutMenu_Cancel_btn.Size = new System.Drawing.Size(170, 47);
            this.NewCheckoutMenu_Cancel_btn.TabIndex = 1;
            this.NewCheckoutMenu_Cancel_btn.Text = "Cancel";
            this.NewCheckoutMenu_Cancel_btn.UseVisualStyleBackColor = true;
            this.NewCheckoutMenu_Cancel_btn.Click += new System.EventHandler(this.NewCheckoutMenu_Cancel_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Checkout";
            // 
            // FirstName_Label
            // 
            this.FirstName_Label.AutoSize = true;
            this.FirstName_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstName_Label.Location = new System.Drawing.Point(26, 94);
            this.FirstName_Label.Name = "FirstName_Label";
            this.FirstName_Label.Size = new System.Drawing.Size(99, 21);
            this.FirstName_Label.TabIndex = 3;
            this.FirstName_Label.Text = "*FirstName:";
            // 
            // LastName_Label
            // 
            this.LastName_Label.AutoSize = true;
            this.LastName_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LastName_Label.Location = new System.Drawing.Point(297, 92);
            this.LastName_Label.Name = "LastName_Label";
            this.LastName_Label.Size = new System.Drawing.Size(97, 21);
            this.LastName_Label.TabIndex = 4;
            this.LastName_Label.Text = "*LastName:";
            // 
            // NewCheckout_FirstName_Textbox
            // 
            this.NewCheckout_FirstName_Textbox.Location = new System.Drawing.Point(124, 94);
            this.NewCheckout_FirstName_Textbox.Name = "NewCheckout_FirstName_Textbox";
            this.NewCheckout_FirstName_Textbox.Size = new System.Drawing.Size(153, 23);
            this.NewCheckout_FirstName_Textbox.TabIndex = 5;
            // 
            // NewCheckout_LastName_Textbox
            // 
            this.NewCheckout_LastName_Textbox.Location = new System.Drawing.Point(400, 94);
            this.NewCheckout_LastName_Textbox.Name = "NewCheckout_LastName_Textbox";
            this.NewCheckout_LastName_Textbox.Size = new System.Drawing.Size(153, 23);
            this.NewCheckout_LastName_Textbox.TabIndex = 6;
            // 
            // Email_Label
            // 
            this.Email_Label.AutoSize = true;
            this.Email_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Email_Label.Location = new System.Drawing.Point(61, 142);
            this.Email_Label.Name = "Email_Label";
            this.Email_Label.Size = new System.Drawing.Size(57, 21);
            this.Email_Label.TabIndex = 7;
            this.Email_Label.Text = "Email:";
            // 
            // Phone_Label
            // 
            this.Phone_Label.AutoSize = true;
            this.Phone_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Phone_Label.Location = new System.Drawing.Point(331, 138);
            this.Phone_Label.Name = "Phone_Label";
            this.Phone_Label.Size = new System.Drawing.Size(63, 21);
            this.Phone_Label.TabIndex = 8;
            this.Phone_Label.Text = "Phone:";
            // 
            // NewCheckout_Email_Textbox
            // 
            this.NewCheckout_Email_Textbox.Location = new System.Drawing.Point(124, 140);
            this.NewCheckout_Email_Textbox.Name = "NewCheckout_Email_Textbox";
            this.NewCheckout_Email_Textbox.Size = new System.Drawing.Size(153, 23);
            this.NewCheckout_Email_Textbox.TabIndex = 9;
            // 
            // NewCheckout_Phone_Textbox
            // 
            this.NewCheckout_Phone_Textbox.Location = new System.Drawing.Point(400, 136);
            this.NewCheckout_Phone_Textbox.Name = "NewCheckout_Phone_Textbox";
            this.NewCheckout_Phone_Textbox.Size = new System.Drawing.Size(153, 23);
            this.NewCheckout_Phone_Textbox.TabIndex = 10;
            // 
            // Company_Label
            // 
            this.Company_Label.AutoSize = true;
            this.Company_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Company_Label.Location = new System.Drawing.Point(52, 249);
            this.Company_Label.Name = "Company_Label";
            this.Company_Label.Size = new System.Drawing.Size(155, 21);
            this.Company_Label.TabIndex = 11;
            this.Company_Label.Text = "*Sample Company:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(236, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sample Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(227, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Customer Info";
            // 
            // Pattern_Label
            // 
            this.Pattern_Label.AutoSize = true;
            this.Pattern_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pattern_Label.Location = new System.Drawing.Point(76, 288);
            this.Pattern_Label.Name = "Pattern_Label";
            this.Pattern_Label.Size = new System.Drawing.Size(131, 21);
            this.Pattern_Label.TabIndex = 14;
            this.Pattern_Label.Text = "Sample Pattern:";
            // 
            // Color_Label
            // 
            this.Color_Label.AutoSize = true;
            this.Color_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Color_Label.Location = new System.Drawing.Point(90, 328);
            this.Color_Label.Name = "Color_Label";
            this.Color_Label.Size = new System.Drawing.Size(117, 21);
            this.Color_Label.TabIndex = 15;
            this.Color_Label.Text = "Sample Color:";
            // 
            // NewCheckout_SampleCompany_Textbox
            // 
            this.NewCheckout_SampleCompany_Textbox.Location = new System.Drawing.Point(227, 251);
            this.NewCheckout_SampleCompany_Textbox.Name = "NewCheckout_SampleCompany_Textbox";
            this.NewCheckout_SampleCompany_Textbox.Size = new System.Drawing.Size(153, 23);
            this.NewCheckout_SampleCompany_Textbox.TabIndex = 16;
            // 
            // NewCheckout_SamplePattern_Textbox
            // 
            this.NewCheckout_SamplePattern_Textbox.Location = new System.Drawing.Point(227, 286);
            this.NewCheckout_SamplePattern_Textbox.Name = "NewCheckout_SamplePattern_Textbox";
            this.NewCheckout_SamplePattern_Textbox.Size = new System.Drawing.Size(153, 23);
            this.NewCheckout_SamplePattern_Textbox.TabIndex = 17;
            // 
            // NewCheckout_SampleColor_Textbox
            // 
            this.NewCheckout_SampleColor_Textbox.Location = new System.Drawing.Point(227, 326);
            this.NewCheckout_SampleColor_Textbox.Name = "NewCheckout_SampleColor_Textbox";
            this.NewCheckout_SampleColor_Textbox.Size = new System.Drawing.Size(153, 23);
            this.NewCheckout_SampleColor_Textbox.TabIndex = 18;
            this.NewCheckout_SampleColor_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewCheckout_SampleColor_Textbox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(410, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "10-Digit (Dont format)";
            // 
            // NewCheckoutMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewCheckout_SampleColor_Textbox);
            this.Controls.Add(this.NewCheckout_SamplePattern_Textbox);
            this.Controls.Add(this.NewCheckout_SampleCompany_Textbox);
            this.Controls.Add(this.Color_Label);
            this.Controls.Add(this.Pattern_Label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Company_Label);
            this.Controls.Add(this.NewCheckout_Phone_Textbox);
            this.Controls.Add(this.NewCheckout_Email_Textbox);
            this.Controls.Add(this.Phone_Label);
            this.Controls.Add(this.Email_Label);
            this.Controls.Add(this.NewCheckout_LastName_Textbox);
            this.Controls.Add(this.NewCheckout_FirstName_Textbox);
            this.Controls.Add(this.LastName_Label);
            this.Controls.Add(this.FirstName_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewCheckoutMenu_Cancel_btn);
            this.Controls.Add(this.New_Checkout_btn);
            this.Name = "NewCheckoutMenu";
            this.Text = "New Checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button New_Checkout_btn;
        private Button NewCheckoutMenu_Cancel_btn;
        private Label label1;
        private Label FirstName_Label;
        private Label LastName_Label;
        private TextBox NewCheckout_FirstName_Textbox;
        private TextBox NewCheckout_LastName_Textbox;
        private Label Email_Label;
        private Label Phone_Label;
        private TextBox NewCheckout_Email_Textbox;
        private TextBox NewCheckout_Phone_Textbox;
        private Label Company_Label;
        private Label label6;
        private Label label7;
        private Label Pattern_Label;
        private Label Color_Label;
        private TextBox NewCheckout_SampleCompany_Textbox;
        private TextBox NewCheckout_SamplePattern_Textbox;
        private TextBox NewCheckout_SampleColor_Textbox;
        private Label label2;
    }
}