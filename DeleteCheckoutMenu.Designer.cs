namespace SampleCheckoutDemo
{
    partial class DeleteCheckoutMenu
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
            this.DeleteCheckoutsTable = new System.Windows.Forms.DataGridView();
            this.FirstName_Label = new System.Windows.Forms.Label();
            this.LastName_Label = new System.Windows.Forms.Label();
            this.DeleteCheckoutMenu_FirstName_Input = new System.Windows.Forms.TextBox();
            this.DeleteCheckoutMenu_LastName_Input = new System.Windows.Forms.TextBox();
            this.DeleteCheckoutMenu_Search_Button = new System.Windows.Forms.Button();
            this.DeleteCheckoutMenu_Cancel_Button = new System.Windows.Forms.Button();
            this.DeleteCheckoutMenu_Delete_Button = new System.Windows.Forms.Button();
            this.DeleteCheckoutMenu_SearchAll_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteCheckoutsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Delete Checkout";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Search By Customer Name:";
            // 
            // DeleteCheckoutsTable
            // 
            this.DeleteCheckoutsTable.AllowUserToAddRows = false;
            this.DeleteCheckoutsTable.AllowUserToDeleteRows = false;
            this.DeleteCheckoutsTable.AllowUserToResizeColumns = false;
            this.DeleteCheckoutsTable.AllowUserToResizeRows = false;
            this.DeleteCheckoutsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeleteCheckoutsTable.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DeleteCheckoutsTable.Location = new System.Drawing.Point(12, 110);
            this.DeleteCheckoutsTable.Name = "DeleteCheckoutsTable";
            this.DeleteCheckoutsTable.ReadOnly = true;
            this.DeleteCheckoutsTable.RowTemplate.Height = 25;
            this.DeleteCheckoutsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeleteCheckoutsTable.Size = new System.Drawing.Size(403, 317);
            this.DeleteCheckoutsTable.TabIndex = 17;
            // 
            // FirstName_Label
            // 
            this.FirstName_Label.AutoSize = true;
            this.FirstName_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstName_Label.Location = new System.Drawing.Point(246, 41);
            this.FirstName_Label.Name = "FirstName_Label";
            this.FirstName_Label.Size = new System.Drawing.Size(99, 21);
            this.FirstName_Label.TabIndex = 18;
            this.FirstName_Label.Text = "*FirstName:";
            // 
            // LastName_Label
            // 
            this.LastName_Label.AutoSize = true;
            this.LastName_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LastName_Label.Location = new System.Drawing.Point(248, 69);
            this.LastName_Label.Name = "LastName_Label";
            this.LastName_Label.Size = new System.Drawing.Size(97, 21);
            this.LastName_Label.TabIndex = 19;
            this.LastName_Label.Text = "*LastName:";
            // 
            // DeleteCheckoutMenu_FirstName_Input
            // 
            this.DeleteCheckoutMenu_FirstName_Input.Location = new System.Drawing.Point(349, 43);
            this.DeleteCheckoutMenu_FirstName_Input.Name = "DeleteCheckoutMenu_FirstName_Input";
            this.DeleteCheckoutMenu_FirstName_Input.Size = new System.Drawing.Size(201, 23);
            this.DeleteCheckoutMenu_FirstName_Input.TabIndex = 20;
            // 
            // DeleteCheckoutMenu_LastName_Input
            // 
            this.DeleteCheckoutMenu_LastName_Input.Location = new System.Drawing.Point(349, 72);
            this.DeleteCheckoutMenu_LastName_Input.Name = "DeleteCheckoutMenu_LastName_Input";
            this.DeleteCheckoutMenu_LastName_Input.Size = new System.Drawing.Size(203, 23);
            this.DeleteCheckoutMenu_LastName_Input.TabIndex = 21;
            this.DeleteCheckoutMenu_LastName_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DeleteCheckoutMenu_LastName_Input_KeyDown);
            // 
            // DeleteCheckoutMenu_Search_Button
            // 
            this.DeleteCheckoutMenu_Search_Button.Location = new System.Drawing.Point(423, 110);
            this.DeleteCheckoutMenu_Search_Button.Name = "DeleteCheckoutMenu_Search_Button";
            this.DeleteCheckoutMenu_Search_Button.Size = new System.Drawing.Size(129, 61);
            this.DeleteCheckoutMenu_Search_Button.TabIndex = 24;
            this.DeleteCheckoutMenu_Search_Button.Text = "Search";
            this.DeleteCheckoutMenu_Search_Button.UseVisualStyleBackColor = true;
            this.DeleteCheckoutMenu_Search_Button.Click += new System.EventHandler(this.DeleteCheckoutMenu_Search_Button_Click);
            // 
            // DeleteCheckoutMenu_Cancel_Button
            // 
            this.DeleteCheckoutMenu_Cancel_Button.Location = new System.Drawing.Point(423, 348);
            this.DeleteCheckoutMenu_Cancel_Button.Name = "DeleteCheckoutMenu_Cancel_Button";
            this.DeleteCheckoutMenu_Cancel_Button.Size = new System.Drawing.Size(129, 61);
            this.DeleteCheckoutMenu_Cancel_Button.TabIndex = 25;
            this.DeleteCheckoutMenu_Cancel_Button.Text = "Cancel";
            this.DeleteCheckoutMenu_Cancel_Button.UseVisualStyleBackColor = true;
            this.DeleteCheckoutMenu_Cancel_Button.Click += new System.EventHandler(this.DeleteCheckoutMenu_Cancel_Button_Click);
            // 
            // DeleteCheckoutMenu_Delete_Button
            // 
            this.DeleteCheckoutMenu_Delete_Button.Location = new System.Drawing.Point(421, 265);
            this.DeleteCheckoutMenu_Delete_Button.Name = "DeleteCheckoutMenu_Delete_Button";
            this.DeleteCheckoutMenu_Delete_Button.Size = new System.Drawing.Size(129, 61);
            this.DeleteCheckoutMenu_Delete_Button.TabIndex = 26;
            this.DeleteCheckoutMenu_Delete_Button.Text = "Delete";
            this.DeleteCheckoutMenu_Delete_Button.UseVisualStyleBackColor = true;
            this.DeleteCheckoutMenu_Delete_Button.Click += new System.EventHandler(this.DeleteCheckoutMenu_Delete_Button_Click);
            // 
            // DeleteCheckoutMenu_SearchAll_Button
            // 
            this.DeleteCheckoutMenu_SearchAll_Button.Location = new System.Drawing.Point(423, 186);
            this.DeleteCheckoutMenu_SearchAll_Button.Name = "DeleteCheckoutMenu_SearchAll_Button";
            this.DeleteCheckoutMenu_SearchAll_Button.Size = new System.Drawing.Size(129, 61);
            this.DeleteCheckoutMenu_SearchAll_Button.TabIndex = 27;
            this.DeleteCheckoutMenu_SearchAll_Button.Text = "Search All Checkouts";
            this.DeleteCheckoutMenu_SearchAll_Button.UseVisualStyleBackColor = true;
            this.DeleteCheckoutMenu_SearchAll_Button.Click += new System.EventHandler(this.DeleteCheckoutMenu_SearchAll_Button_Click);
            // 
            // DeleteCheckoutMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 455);
            this.Controls.Add(this.DeleteCheckoutMenu_SearchAll_Button);
            this.Controls.Add(this.DeleteCheckoutMenu_Delete_Button);
            this.Controls.Add(this.DeleteCheckoutMenu_Cancel_Button);
            this.Controls.Add(this.DeleteCheckoutMenu_Search_Button);
            this.Controls.Add(this.DeleteCheckoutMenu_LastName_Input);
            this.Controls.Add(this.DeleteCheckoutMenu_FirstName_Input);
            this.Controls.Add(this.LastName_Label);
            this.Controls.Add(this.FirstName_Label);
            this.Controls.Add(this.DeleteCheckoutsTable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "DeleteCheckoutMenu";
            this.Text = "DeleteCheckoutMenu";
            ((System.ComponentModel.ISupportInitialize)(this.DeleteCheckoutsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label7;
        private DataGridView DeleteCheckoutsTable;
        private Label FirstName_Label;
        private Label LastName_Label;
        private TextBox DeleteCheckoutMenu_FirstName_Input;
        private TextBox DeleteCheckoutMenu_LastName_Input;
        private Button DeleteCheckoutMenu_Search_Button;
        private Button DeleteCheckoutMenu_Cancel_Button;
        private Button DeleteCheckoutMenu_Delete_Button;
        private Button DeleteCheckoutMenu_SearchAll_Button;
    }
}