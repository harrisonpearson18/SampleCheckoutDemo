namespace SampleCheckoutDemo
{
    partial class EditCheckoutMenu
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
            this.SearchCheckoutsTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lastlabel = new System.Windows.Forms.Label();
            this.firstlabel = new System.Windows.Forms.Label();
            this.EditCheckoutMenu_FirstName_Input = new System.Windows.Forms.TextBox();
            this.EditCheckoutMenu_LastName_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditCheckoutMenu_SampleCompany_Input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EditCheckoutMenu_SamplePattern_Input = new System.Windows.Forms.TextBox();
            this.EditCheckoutMenu_SampleColor_Input = new System.Windows.Forms.TextBox();
            this.EditCheckoutMenu_ChangeValues_Input = new System.Windows.Forms.Button();
            this.EditCheckoutMenu_Cancel_Button = new System.Windows.Forms.Button();
            this.EditCheckoutMenu_SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SearchCheckoutsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchCheckoutsTable
            // 
            this.SearchCheckoutsTable.AllowUserToAddRows = false;
            this.SearchCheckoutsTable.AllowUserToDeleteRows = false;
            this.SearchCheckoutsTable.AllowUserToResizeColumns = false;
            this.SearchCheckoutsTable.AllowUserToResizeRows = false;
            this.SearchCheckoutsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchCheckoutsTable.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SearchCheckoutsTable.Location = new System.Drawing.Point(256, 152);
            this.SearchCheckoutsTable.Name = "SearchCheckoutsTable";
            this.SearchCheckoutsTable.ReadOnly = true;
            this.SearchCheckoutsTable.RowTemplate.Height = 25;
            this.SearchCheckoutsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchCheckoutsTable.Size = new System.Drawing.Size(339, 309);
            this.SearchCheckoutsTable.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Edit Checkout";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(360, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Search by Name:";
            // 
            // lastlabel
            // 
            this.lastlabel.AutoSize = true;
            this.lastlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastlabel.Location = new System.Drawing.Point(273, 80);
            this.lastlabel.Name = "lastlabel";
            this.lastlabel.Size = new System.Drawing.Size(97, 21);
            this.lastlabel.TabIndex = 15;
            this.lastlabel.Text = "*LastName:";
            // 
            // firstlabel
            // 
            this.firstlabel.AutoSize = true;
            this.firstlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstlabel.Location = new System.Drawing.Point(273, 45);
            this.firstlabel.Name = "firstlabel";
            this.firstlabel.Size = new System.Drawing.Size(99, 21);
            this.firstlabel.TabIndex = 16;
            this.firstlabel.Text = "*FirstName:";
            // 
            // EditCheckoutMenu_FirstName_Input
            // 
            this.EditCheckoutMenu_FirstName_Input.Location = new System.Drawing.Point(378, 45);
            this.EditCheckoutMenu_FirstName_Input.Name = "EditCheckoutMenu_FirstName_Input";
            this.EditCheckoutMenu_FirstName_Input.Size = new System.Drawing.Size(217, 23);
            this.EditCheckoutMenu_FirstName_Input.TabIndex = 17;
            this.EditCheckoutMenu_FirstName_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditCheckoutMenu_FirstName_Input_KeyDown_1);
            // 
            // EditCheckoutMenu_LastName_Input
            // 
            this.EditCheckoutMenu_LastName_Input.Location = new System.Drawing.Point(378, 78);
            this.EditCheckoutMenu_LastName_Input.Name = "EditCheckoutMenu_LastName_Input";
            this.EditCheckoutMenu_LastName_Input.Size = new System.Drawing.Size(217, 23);
            this.EditCheckoutMenu_LastName_Input.TabIndex = 18;
            this.EditCheckoutMenu_LastName_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditCheckoutMenu_LastName_Input_KeyDown_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Values to Change:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(33, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "(with row selected)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(48, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Sample Company:";
            // 
            // EditCheckoutMenu_SampleCompany_Input
            // 
            this.EditCheckoutMenu_SampleCompany_Input.Location = new System.Drawing.Point(12, 136);
            this.EditCheckoutMenu_SampleCompany_Input.Name = "EditCheckoutMenu_SampleCompany_Input";
            this.EditCheckoutMenu_SampleCompany_Input.Size = new System.Drawing.Size(217, 23);
            this.EditCheckoutMenu_SampleCompany_Input.TabIndex = 22;
            this.EditCheckoutMenu_SampleCompany_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditCheckoutMenu_SampleCompany_Input_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(48, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Sample Pattern:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(48, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Sample Color:";
            // 
            // EditCheckoutMenu_SamplePattern_Input
            // 
            this.EditCheckoutMenu_SamplePattern_Input.Location = new System.Drawing.Point(12, 196);
            this.EditCheckoutMenu_SamplePattern_Input.Name = "EditCheckoutMenu_SamplePattern_Input";
            this.EditCheckoutMenu_SamplePattern_Input.Size = new System.Drawing.Size(217, 23);
            this.EditCheckoutMenu_SamplePattern_Input.TabIndex = 25;
            this.EditCheckoutMenu_SamplePattern_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditCheckoutMenu_SamplePattern_Input_KeyDown);
            // 
            // EditCheckoutMenu_SampleColor_Input
            // 
            this.EditCheckoutMenu_SampleColor_Input.Location = new System.Drawing.Point(12, 257);
            this.EditCheckoutMenu_SampleColor_Input.Name = "EditCheckoutMenu_SampleColor_Input";
            this.EditCheckoutMenu_SampleColor_Input.Size = new System.Drawing.Size(217, 23);
            this.EditCheckoutMenu_SampleColor_Input.TabIndex = 26;
            this.EditCheckoutMenu_SampleColor_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditCheckoutMenu_SampleColor_Input_KeyDown);
            // 
            // EditCheckoutMenu_ChangeValues_Input
            // 
            this.EditCheckoutMenu_ChangeValues_Input.Location = new System.Drawing.Point(39, 302);
            this.EditCheckoutMenu_ChangeValues_Input.Name = "EditCheckoutMenu_ChangeValues_Input";
            this.EditCheckoutMenu_ChangeValues_Input.Size = new System.Drawing.Size(164, 62);
            this.EditCheckoutMenu_ChangeValues_Input.TabIndex = 27;
            this.EditCheckoutMenu_ChangeValues_Input.Text = "Change Values";
            this.EditCheckoutMenu_ChangeValues_Input.UseVisualStyleBackColor = true;
            this.EditCheckoutMenu_ChangeValues_Input.Click += new System.EventHandler(this.EditCheckoutMenu_ChangeValues_Input_Click);
            // 
            // EditCheckoutMenu_Cancel_Button
            // 
            this.EditCheckoutMenu_Cancel_Button.Location = new System.Drawing.Point(39, 376);
            this.EditCheckoutMenu_Cancel_Button.Name = "EditCheckoutMenu_Cancel_Button";
            this.EditCheckoutMenu_Cancel_Button.Size = new System.Drawing.Size(164, 62);
            this.EditCheckoutMenu_Cancel_Button.TabIndex = 28;
            this.EditCheckoutMenu_Cancel_Button.Text = "Cancel";
            this.EditCheckoutMenu_Cancel_Button.UseVisualStyleBackColor = true;
            this.EditCheckoutMenu_Cancel_Button.Click += new System.EventHandler(this.EditCheckoutMenu_Cancel_Button_Click);
            // 
            // EditCheckoutMenu_SearchButton
            // 
            this.EditCheckoutMenu_SearchButton.Location = new System.Drawing.Point(395, 107);
            this.EditCheckoutMenu_SearchButton.Name = "EditCheckoutMenu_SearchButton";
            this.EditCheckoutMenu_SearchButton.Size = new System.Drawing.Size(174, 35);
            this.EditCheckoutMenu_SearchButton.TabIndex = 29;
            this.EditCheckoutMenu_SearchButton.Text = "Search";
            this.EditCheckoutMenu_SearchButton.UseVisualStyleBackColor = true;
            this.EditCheckoutMenu_SearchButton.Click += new System.EventHandler(this.EditCheckoutMenu_SearchButton_Click);
            // 
            // EditCheckoutMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 473);
            this.Controls.Add(this.EditCheckoutMenu_SearchButton);
            this.Controls.Add(this.EditCheckoutMenu_Cancel_Button);
            this.Controls.Add(this.EditCheckoutMenu_ChangeValues_Input);
            this.Controls.Add(this.EditCheckoutMenu_SampleColor_Input);
            this.Controls.Add(this.EditCheckoutMenu_SamplePattern_Input);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EditCheckoutMenu_SampleCompany_Input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditCheckoutMenu_LastName_Input);
            this.Controls.Add(this.EditCheckoutMenu_FirstName_Input);
            this.Controls.Add(this.firstlabel);
            this.Controls.Add(this.lastlabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchCheckoutsTable);
            this.Name = "EditCheckoutMenu";
            this.Text = "EditCheckoutMenu";
            ((System.ComponentModel.ISupportInitialize)(this.SearchCheckoutsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView SearchCheckoutsTable;
        private Label label1;
        private Label label7;
        private Label lastlabel;
        private Label firstlabel;
        private TextBox EditCheckoutMenu_FirstName_Input;
        private TextBox EditCheckoutMenu_LastName_Input;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox EditCheckoutMenu_SampleCompany_Input;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button EditCheckoutMenu_ChangeValues_Input;
        private Button EditCheckoutMenu_Cancel_Button;
        private TextBox EditCheckoutMenu_SamplePattern_Input;
        private TextBox EditCheckoutMenu_SampleColor_Input;
        private Button EditCheckoutMenu_SearchButton;
    }
}