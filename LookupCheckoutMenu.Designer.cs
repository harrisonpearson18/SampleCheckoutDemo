namespace SampleCheckoutDemo
{
    partial class LookupCheckoutMenu
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
            this.LookupCheckoutsTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FirstName_Label = new System.Windows.Forms.Label();
            this.LastName_Label = new System.Windows.Forms.Label();
            this.LookupCheckout_FirstName_Input = new System.Windows.Forms.TextBox();
            this.LookupCheckout_LastName_Input = new System.Windows.Forms.TextBox();
            this.LookupCheckout_Search_Button = new System.Windows.Forms.Button();
            this.LookupCheckout_Cancel_Button = new System.Windows.Forms.Button();
            this.LookupCheckoutMenu_SearchAll_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LookupCheckoutsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // LookupCheckoutsTable
            // 
            this.LookupCheckoutsTable.AllowUserToAddRows = false;
            this.LookupCheckoutsTable.AllowUserToDeleteRows = false;
            this.LookupCheckoutsTable.AllowUserToResizeColumns = false;
            this.LookupCheckoutsTable.AllowUserToResizeRows = false;
            this.LookupCheckoutsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LookupCheckoutsTable.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LookupCheckoutsTable.Location = new System.Drawing.Point(12, 131);
            this.LookupCheckoutsTable.Name = "LookupCheckoutsTable";
            this.LookupCheckoutsTable.ReadOnly = true;
            this.LookupCheckoutsTable.RowTemplate.Height = 25;
            this.LookupCheckoutsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LookupCheckoutsTable.Size = new System.Drawing.Size(415, 317);
            this.LookupCheckoutsTable.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lookup Checkout";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Search By Customer Name:";
            // 
            // FirstName_Label
            // 
            this.FirstName_Label.AutoSize = true;
            this.FirstName_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstName_Label.Location = new System.Drawing.Point(266, 48);
            this.FirstName_Label.Name = "FirstName_Label";
            this.FirstName_Label.Size = new System.Drawing.Size(99, 21);
            this.FirstName_Label.TabIndex = 16;
            this.FirstName_Label.Text = "*FirstName:";
            // 
            // LastName_Label
            // 
            this.LastName_Label.AutoSize = true;
            this.LastName_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LastName_Label.Location = new System.Drawing.Point(266, 87);
            this.LastName_Label.Name = "LastName_Label";
            this.LastName_Label.Size = new System.Drawing.Size(97, 21);
            this.LastName_Label.TabIndex = 17;
            this.LastName_Label.Text = "*LastName:";
            // 
            // LookupCheckout_FirstName_Input
            // 
            this.LookupCheckout_FirstName_Input.Location = new System.Drawing.Point(371, 48);
            this.LookupCheckout_FirstName_Input.Name = "LookupCheckout_FirstName_Input";
            this.LookupCheckout_FirstName_Input.Size = new System.Drawing.Size(201, 23);
            this.LookupCheckout_FirstName_Input.TabIndex = 18;
            // 
            // LookupCheckout_LastName_Input
            // 
            this.LookupCheckout_LastName_Input.Location = new System.Drawing.Point(369, 89);
            this.LookupCheckout_LastName_Input.Name = "LookupCheckout_LastName_Input";
            this.LookupCheckout_LastName_Input.Size = new System.Drawing.Size(203, 23);
            this.LookupCheckout_LastName_Input.TabIndex = 19;
            this.LookupCheckout_LastName_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LookupCheckout_LastName_Input_KeyDown);
            // 
            // LookupCheckout_Search_Button
            // 
            this.LookupCheckout_Search_Button.Location = new System.Drawing.Point(434, 131);
            this.LookupCheckout_Search_Button.Name = "LookupCheckout_Search_Button";
            this.LookupCheckout_Search_Button.Size = new System.Drawing.Size(129, 61);
            this.LookupCheckout_Search_Button.TabIndex = 23;
            this.LookupCheckout_Search_Button.Text = "Search";
            this.LookupCheckout_Search_Button.UseVisualStyleBackColor = true;
            this.LookupCheckout_Search_Button.Click += new System.EventHandler(this.LookupCheckout_Search_Button_Click);
            // 
            // LookupCheckout_Cancel_Button
            // 
            this.LookupCheckout_Cancel_Button.Location = new System.Drawing.Point(434, 374);
            this.LookupCheckout_Cancel_Button.Name = "LookupCheckout_Cancel_Button";
            this.LookupCheckout_Cancel_Button.Size = new System.Drawing.Size(129, 61);
            this.LookupCheckout_Cancel_Button.TabIndex = 24;
            this.LookupCheckout_Cancel_Button.Text = "Cancel";
            this.LookupCheckout_Cancel_Button.UseVisualStyleBackColor = true;
            this.LookupCheckout_Cancel_Button.Click += new System.EventHandler(this.LookupCheckout_Cancel_Button_Click);
            // 
            // LookupCheckoutMenu_SearchAll_Button
            // 
            this.LookupCheckoutMenu_SearchAll_Button.Location = new System.Drawing.Point(433, 198);
            this.LookupCheckoutMenu_SearchAll_Button.Name = "LookupCheckoutMenu_SearchAll_Button";
            this.LookupCheckoutMenu_SearchAll_Button.Size = new System.Drawing.Size(129, 61);
            this.LookupCheckoutMenu_SearchAll_Button.TabIndex = 25;
            this.LookupCheckoutMenu_SearchAll_Button.Text = "Search All";
            this.LookupCheckoutMenu_SearchAll_Button.UseVisualStyleBackColor = true;
            this.LookupCheckoutMenu_SearchAll_Button.Click += new System.EventHandler(this.LookupCheckoutMenu_SearchAll_Button_Click);
            // 
            // LookupCheckoutMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 460);
            this.Controls.Add(this.LookupCheckoutMenu_SearchAll_Button);
            this.Controls.Add(this.LookupCheckout_Cancel_Button);
            this.Controls.Add(this.LookupCheckout_Search_Button);
            this.Controls.Add(this.LookupCheckout_LastName_Input);
            this.Controls.Add(this.LookupCheckout_FirstName_Input);
            this.Controls.Add(this.LastName_Label);
            this.Controls.Add(this.FirstName_Label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LookupCheckoutsTable);
            this.Name = "LookupCheckoutMenu";
            this.Text = "LookupCheckoutMenu";
            ((System.ComponentModel.ISupportInitialize)(this.LookupCheckoutsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView LookupCheckoutsTable;
        private Label label1;
        private Label label7;
        private Label FirstName_Label;
        private Label LastName_Label;
        private TextBox LookupCheckout_FirstName_Input;
        private TextBox LookupCheckout_LastName_Input;
        private Button LookupCheckout_Search_Button;
        private Button LookupCheckout_Cancel_Button;
        private Button LookupCheckoutMenu_SearchAll_Button;
    }
}