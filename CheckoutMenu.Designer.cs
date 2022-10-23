namespace SampleCheckoutDemo
{
    partial class CheckoutMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CheckoutMenuStrip = new System.Windows.Forms.MenuStrip();
            this.newCheckoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnCheckoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCheckoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookupCheckoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCheckoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckoutListLabel = new System.Windows.Forms.Label();
            this.RefreshAllCheckouts = new System.Windows.Forms.Button();
            this.exitCheckoutMenu_button = new System.Windows.Forms.Button();
            this.AllCheckoutsTable = new System.Windows.Forms.DataGridView();
            this.dataAccessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CheckoutMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllCheckoutsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccessBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckoutMenuStrip
            // 
            this.CheckoutMenuStrip.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckoutMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCheckoutToolStripMenuItem,
            this.returnCheckoutToolStripMenuItem,
            this.editCheckoutToolStripMenuItem,
            this.lookupCheckoutToolStripMenuItem,
            this.deleteCheckoutToolStripMenuItem});
            this.CheckoutMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.CheckoutMenuStrip.Name = "CheckoutMenuStrip";
            this.CheckoutMenuStrip.Size = new System.Drawing.Size(838, 33);
            this.CheckoutMenuStrip.TabIndex = 0;
            this.CheckoutMenuStrip.Text = "menuStrip1";
            // 
            // newCheckoutToolStripMenuItem
            // 
            this.newCheckoutToolStripMenuItem.Name = "newCheckoutToolStripMenuItem";
            this.newCheckoutToolStripMenuItem.Size = new System.Drawing.Size(153, 29);
            this.newCheckoutToolStripMenuItem.Text = "New Checkout";
            this.newCheckoutToolStripMenuItem.Click += new System.EventHandler(this.newCheckoutToolStripMenuItem_Click);
            // 
            // returnCheckoutToolStripMenuItem
            // 
            this.returnCheckoutToolStripMenuItem.Name = "returnCheckoutToolStripMenuItem";
            this.returnCheckoutToolStripMenuItem.Size = new System.Drawing.Size(174, 29);
            this.returnCheckoutToolStripMenuItem.Text = "Return Checkout";
            this.returnCheckoutToolStripMenuItem.Click += new System.EventHandler(this.returnCheckoutToolStripMenuItem_Click);
            // 
            // editCheckoutToolStripMenuItem
            // 
            this.editCheckoutToolStripMenuItem.Name = "editCheckoutToolStripMenuItem";
            this.editCheckoutToolStripMenuItem.Size = new System.Drawing.Size(147, 29);
            this.editCheckoutToolStripMenuItem.Text = "Edit Checkout";
            this.editCheckoutToolStripMenuItem.Click += new System.EventHandler(this.editCheckoutToolStripMenuItem_Click);
            // 
            // lookupCheckoutToolStripMenuItem
            // 
            this.lookupCheckoutToolStripMenuItem.Name = "lookupCheckoutToolStripMenuItem";
            this.lookupCheckoutToolStripMenuItem.Size = new System.Drawing.Size(182, 29);
            this.lookupCheckoutToolStripMenuItem.Text = "Lookup Checkout";
            this.lookupCheckoutToolStripMenuItem.Click += new System.EventHandler(this.lookupCheckoutToolStripMenuItem_Click);
            // 
            // deleteCheckoutToolStripMenuItem
            // 
            this.deleteCheckoutToolStripMenuItem.Name = "deleteCheckoutToolStripMenuItem";
            this.deleteCheckoutToolStripMenuItem.Size = new System.Drawing.Size(169, 29);
            this.deleteCheckoutToolStripMenuItem.Text = "Delete Checkout";
            this.deleteCheckoutToolStripMenuItem.Click += new System.EventHandler(this.deleteCheckoutToolStripMenuItem_Click);
            // 
            // CheckoutListLabel
            // 
            this.CheckoutListLabel.AutoSize = true;
            this.CheckoutListLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckoutListLabel.Location = new System.Drawing.Point(342, 89);
            this.CheckoutListLabel.Name = "CheckoutListLabel";
            this.CheckoutListLabel.Size = new System.Drawing.Size(132, 25);
            this.CheckoutListLabel.TabIndex = 2;
            this.CheckoutListLabel.Text = "All Checkouts";
            // 
            // RefreshAllCheckouts
            // 
            this.RefreshAllCheckouts.Location = new System.Drawing.Point(63, 67);
            this.RefreshAllCheckouts.Name = "RefreshAllCheckouts";
            this.RefreshAllCheckouts.Size = new System.Drawing.Size(148, 35);
            this.RefreshAllCheckouts.TabIndex = 3;
            this.RefreshAllCheckouts.Text = "Refresh Checkouts";
            this.RefreshAllCheckouts.UseVisualStyleBackColor = true;
            this.RefreshAllCheckouts.Click += new System.EventHandler(this.RefreshAllCheckouts_Click);
            // 
            // exitCheckoutMenu_button
            // 
            this.exitCheckoutMenu_button.Location = new System.Drawing.Point(636, 67);
            this.exitCheckoutMenu_button.Name = "exitCheckoutMenu_button";
            this.exitCheckoutMenu_button.Size = new System.Drawing.Size(148, 35);
            this.exitCheckoutMenu_button.TabIndex = 4;
            this.exitCheckoutMenu_button.Text = "Exit Application";
            this.exitCheckoutMenu_button.UseVisualStyleBackColor = true;
            this.exitCheckoutMenu_button.Click += new System.EventHandler(this.exitCheckoutMenu_button_Click);
            // 
            // AllCheckoutsTable
            // 
            this.AllCheckoutsTable.AllowUserToAddRows = false;
            this.AllCheckoutsTable.AllowUserToDeleteRows = false;
            this.AllCheckoutsTable.AllowUserToResizeColumns = false;
            this.AllCheckoutsTable.AllowUserToResizeRows = false;
            this.AllCheckoutsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllCheckoutsTable.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AllCheckoutsTable.Location = new System.Drawing.Point(0, 126);
            this.AllCheckoutsTable.Name = "AllCheckoutsTable";
            this.AllCheckoutsTable.ReadOnly = true;
            this.AllCheckoutsTable.RowTemplate.Height = 25;
            this.AllCheckoutsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllCheckoutsTable.Size = new System.Drawing.Size(838, 440);
            this.AllCheckoutsTable.TabIndex = 5;
            // 
            // dataAccessBindingSource
            // 
            this.dataAccessBindingSource.DataSource = typeof(SampleCheckoutApplicationDemo.DataAccess);
            // 
            // CheckoutMenu
            // 
            this.ClientSize = new System.Drawing.Size(838, 582);
            this.Controls.Add(this.AllCheckoutsTable);
            this.Controls.Add(this.exitCheckoutMenu_button);
            this.Controls.Add(this.RefreshAllCheckouts);
            this.Controls.Add(this.CheckoutListLabel);
            this.Controls.Add(this.CheckoutMenuStrip);
            this.MainMenuStrip = this.CheckoutMenuStrip;
            this.Name = "CheckoutMenu";
            this.Text = "CheckoutMenu";
            this.CheckoutMenuStrip.ResumeLayout(false);
            this.CheckoutMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllCheckoutsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccessBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip CheckoutMenuStrip;
        private ToolStripMenuItem newCheckoutToolStripMenuItem;
        private ToolStripMenuItem returnCheckoutToolStripMenuItem;
        private ToolStripMenuItem editCheckoutToolStripMenuItem;
        private ToolStripMenuItem lookupCheckoutToolStripMenuItem;
        private ToolStripMenuItem deleteCheckoutToolStripMenuItem;
        private Label CheckoutListLabel;
        private Button RefreshAllCheckouts;
        private Button exitCheckoutMenu_button;
        private DataGridView AllCheckoutsTable;
        private BindingSource dataAccessBindingSource;
    }
}