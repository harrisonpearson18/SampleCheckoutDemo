namespace SampleCheckoutDemo
{
    partial class ReturnCheckoutMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FirstName_Label = new System.Windows.Forms.Label();
            this.LastName_Label = new System.Windows.Forms.Label();
            this.ReturnCheckout_FirstName_Input = new System.Windows.Forms.TextBox();
            this.ReturnCheckout_LastName_Input = new System.Windows.Forms.TextBox();
            this.ReturnCheckoutsTable = new System.Windows.Forms.DataGridView();
            this.ReturnCheckoutMenu_Cancel_Button = new System.Windows.Forms.Button();
            this.ReturnCheckoutMenu_Return_Button = new System.Windows.Forms.Button();
            this.ReturnCheckout_SearchInfo_Button = new System.Windows.Forms.Button();
            this.ReturnCheckoutMenu_SearchAll_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnCheckoutsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Return Checkout";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Search By Customer Name:";
            // 
            // FirstName_Label
            // 
            this.FirstName_Label.AutoSize = true;
            this.FirstName_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstName_Label.Location = new System.Drawing.Point(295, 44);
            this.FirstName_Label.Name = "FirstName_Label";
            this.FirstName_Label.Size = new System.Drawing.Size(99, 21);
            this.FirstName_Label.TabIndex = 15;
            this.FirstName_Label.Text = "*FirstName:";
            // 
            // LastName_Label
            // 
            this.LastName_Label.AutoSize = true;
            this.LastName_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LastName_Label.Location = new System.Drawing.Point(295, 79);
            this.LastName_Label.Name = "LastName_Label";
            this.LastName_Label.Size = new System.Drawing.Size(97, 21);
            this.LastName_Label.TabIndex = 16;
            this.LastName_Label.Text = "*LastName:";
            // 
            // ReturnCheckout_FirstName_Input
            // 
            this.ReturnCheckout_FirstName_Input.Location = new System.Drawing.Point(400, 46);
            this.ReturnCheckout_FirstName_Input.Name = "ReturnCheckout_FirstName_Input";
            this.ReturnCheckout_FirstName_Input.Size = new System.Drawing.Size(201, 23);
            this.ReturnCheckout_FirstName_Input.TabIndex = 17;
            // 
            // ReturnCheckout_LastName_Input
            // 
            this.ReturnCheckout_LastName_Input.Location = new System.Drawing.Point(398, 81);
            this.ReturnCheckout_LastName_Input.Name = "ReturnCheckout_LastName_Input";
            this.ReturnCheckout_LastName_Input.Size = new System.Drawing.Size(203, 23);
            this.ReturnCheckout_LastName_Input.TabIndex = 18;
            this.ReturnCheckout_LastName_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReturnCheckout_LastName_Input_KeyDown);
            // 
            // ReturnCheckoutsTable
            // 
            this.ReturnCheckoutsTable.AllowUserToAddRows = false;
            this.ReturnCheckoutsTable.AllowUserToDeleteRows = false;
            this.ReturnCheckoutsTable.AllowUserToResizeColumns = false;
            this.ReturnCheckoutsTable.AllowUserToResizeRows = false;
            this.ReturnCheckoutsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnCheckoutsTable.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ReturnCheckoutsTable.Location = new System.Drawing.Point(12, 135);
            this.ReturnCheckoutsTable.Name = "ReturnCheckoutsTable";
            this.ReturnCheckoutsTable.ReadOnly = true;
            this.ReturnCheckoutsTable.RowTemplate.Height = 25;
            this.ReturnCheckoutsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReturnCheckoutsTable.Size = new System.Drawing.Size(426, 333);
            this.ReturnCheckoutsTable.TabIndex = 19;
            // 
            // ReturnCheckoutMenu_Cancel_Button
            // 
            this.ReturnCheckoutMenu_Cancel_Button.Location = new System.Drawing.Point(463, 390);
            this.ReturnCheckoutMenu_Cancel_Button.Name = "ReturnCheckoutMenu_Cancel_Button";
            this.ReturnCheckoutMenu_Cancel_Button.Size = new System.Drawing.Size(129, 61);
            this.ReturnCheckoutMenu_Cancel_Button.TabIndex = 20;
            this.ReturnCheckoutMenu_Cancel_Button.Text = "Cancel";
            this.ReturnCheckoutMenu_Cancel_Button.UseVisualStyleBackColor = true;
            this.ReturnCheckoutMenu_Cancel_Button.Click += new System.EventHandler(this.ReturnCheckoutMenu_Cancel_Button_Click);
            // 
            // ReturnCheckoutMenu_Return_Button
            // 
            this.ReturnCheckoutMenu_Return_Button.Location = new System.Drawing.Point(463, 308);
            this.ReturnCheckoutMenu_Return_Button.Name = "ReturnCheckoutMenu_Return_Button";
            this.ReturnCheckoutMenu_Return_Button.Size = new System.Drawing.Size(129, 61);
            this.ReturnCheckoutMenu_Return_Button.TabIndex = 21;
            this.ReturnCheckoutMenu_Return_Button.Text = "Return Selected";
            this.ReturnCheckoutMenu_Return_Button.UseVisualStyleBackColor = true;
            this.ReturnCheckoutMenu_Return_Button.Click += new System.EventHandler(this.ReturnCheckoutMenu_Return_Button_Click);
            // 
            // ReturnCheckout_SearchInfo_Button
            // 
            this.ReturnCheckout_SearchInfo_Button.Location = new System.Drawing.Point(463, 135);
            this.ReturnCheckout_SearchInfo_Button.Name = "ReturnCheckout_SearchInfo_Button";
            this.ReturnCheckout_SearchInfo_Button.Size = new System.Drawing.Size(129, 61);
            this.ReturnCheckout_SearchInfo_Button.TabIndex = 22;
            this.ReturnCheckout_SearchInfo_Button.Text = "Search";
            this.ReturnCheckout_SearchInfo_Button.UseVisualStyleBackColor = true;
            this.ReturnCheckout_SearchInfo_Button.Click += new System.EventHandler(this.ReturnCheckout_SearchInfo_Button_Click);
            // 
            // ReturnCheckoutMenu_SearchAll_Button
            // 
            this.ReturnCheckoutMenu_SearchAll_Button.Location = new System.Drawing.Point(463, 218);
            this.ReturnCheckoutMenu_SearchAll_Button.Name = "ReturnCheckoutMenu_SearchAll_Button";
            this.ReturnCheckoutMenu_SearchAll_Button.Size = new System.Drawing.Size(129, 61);
            this.ReturnCheckoutMenu_SearchAll_Button.TabIndex = 23;
            this.ReturnCheckoutMenu_SearchAll_Button.Text = "Search All";
            this.ReturnCheckoutMenu_SearchAll_Button.UseVisualStyleBackColor = true;
            this.ReturnCheckoutMenu_SearchAll_Button.Click += new System.EventHandler(this.ReturnCheckoutMenu_SearchAll_Button_Click);
            // 
            // ReturnCheckoutMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 480);
            this.Controls.Add(this.ReturnCheckoutMenu_SearchAll_Button);
            this.Controls.Add(this.ReturnCheckout_SearchInfo_Button);
            this.Controls.Add(this.ReturnCheckoutMenu_Return_Button);
            this.Controls.Add(this.ReturnCheckoutMenu_Cancel_Button);
            this.Controls.Add(this.ReturnCheckoutsTable);
            this.Controls.Add(this.ReturnCheckout_LastName_Input);
            this.Controls.Add(this.ReturnCheckout_FirstName_Input);
            this.Controls.Add(this.LastName_Label);
            this.Controls.Add(this.FirstName_Label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "ReturnCheckoutMenu";
            this.Text = "ReturnCheckoutMenu";
            ((System.ComponentModel.ISupportInitialize)(this.ReturnCheckoutsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label7;
        private Label FirstName_Label;
        private Label LastName_Label;
        private TextBox ReturnCheckout_FirstName_Input;
        private TextBox ReturnCheckout_LastName_Input;
        private DataGridView ReturnCheckoutsTable;
        private Button ReturnCheckoutMenu_Cancel_Button;
        private Button ReturnCheckoutMenu_Return_Button;
        private Button ReturnCheckout_SearchInfo_Button;
        private Button ReturnCheckoutMenu_SearchAll_Button;
    }
}