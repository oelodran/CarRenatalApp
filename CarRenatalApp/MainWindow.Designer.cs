
namespace CarRenatalApp
{
    partial class MainWindow
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
            this.tsiLoginText = new System.Windows.Forms.MenuStrip();
            this.manageVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRentalRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRentalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRentalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusLine = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsiLoginText.SuspendLayout();
            this.statusLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsiLoginText
            // 
            this.tsiLoginText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVToolStripMenuItem,
            this.manageRentalRecordsToolStripMenuItem,
            this.menageUsersToolStripMenuItem});
            this.tsiLoginText.Location = new System.Drawing.Point(0, 0);
            this.tsiLoginText.Name = "tsiLoginText";
            this.tsiLoginText.Size = new System.Drawing.Size(877, 24);
            this.tsiLoginText.TabIndex = 0;
            this.tsiLoginText.Text = "menuStrip1";
            // 
            // manageVToolStripMenuItem
            // 
            this.manageVToolStripMenuItem.Name = "manageVToolStripMenuItem";
            this.manageVToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.manageVToolStripMenuItem.Text = "Manage Vehicle Listing";
            this.manageVToolStripMenuItem.Click += new System.EventHandler(this.manageVToolStripMenuItem_Click);
            // 
            // manageRentalRecordsToolStripMenuItem
            // 
            this.manageRentalRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRentalRecordToolStripMenuItem,
            this.viewArchiveToolStripMenuItem,
            this.editRentalRecordToolStripMenuItem});
            this.manageRentalRecordsToolStripMenuItem.Name = "manageRentalRecordsToolStripMenuItem";
            this.manageRentalRecordsToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.manageRentalRecordsToolStripMenuItem.Text = "Manage Rental Records";
            // 
            // addRentalRecordToolStripMenuItem
            // 
            this.addRentalRecordToolStripMenuItem.Name = "addRentalRecordToolStripMenuItem";
            this.addRentalRecordToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addRentalRecordToolStripMenuItem.Text = "Add Rental Record";
            this.addRentalRecordToolStripMenuItem.Click += new System.EventHandler(this.addRentalRecordToolStripMenuItem_Click);
            // 
            // viewArchiveToolStripMenuItem
            // 
            this.viewArchiveToolStripMenuItem.Name = "viewArchiveToolStripMenuItem";
            this.viewArchiveToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.viewArchiveToolStripMenuItem.Text = "View Archive";
            this.viewArchiveToolStripMenuItem.Click += new System.EventHandler(this.viewArchiveToolStripMenuItem_Click);
            // 
            // editRentalRecordToolStripMenuItem
            // 
            this.editRentalRecordToolStripMenuItem.Name = "editRentalRecordToolStripMenuItem";
            this.editRentalRecordToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.editRentalRecordToolStripMenuItem.Text = "Edit Rental Record";
            // 
            // menageUsersToolStripMenuItem
            // 
            this.menageUsersToolStripMenuItem.Name = "menageUsersToolStripMenuItem";
            this.menageUsersToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.menageUsersToolStripMenuItem.Text = "Manage Users";
            this.menageUsersToolStripMenuItem.Click += new System.EventHandler(this.menageUsersToolStripMenuItem_Click);
            // 
            // statusLine
            // 
            this.statusLine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.slRole});
            this.statusLine.Location = new System.Drawing.Point(0, 480);
            this.statusLine.Name = "statusLine";
            this.statusLine.Size = new System.Drawing.Size(877, 22);
            this.statusLine.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // slRole
            // 
            this.slRole.Name = "slRole";
            this.slRole.Size = new System.Drawing.Size(0, 17);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 502);
            this.Controls.Add(this.statusLine);
            this.Controls.Add(this.tsiLoginText);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.tsiLoginText;
            this.Name = "MainWindow";
            this.Text = "Car Rental Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tsiLoginText.ResumeLayout(false);
            this.tsiLoginText.PerformLayout();
            this.statusLine.ResumeLayout(false);
            this.statusLine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip tsiLoginText;
        private System.Windows.Forms.ToolStripMenuItem manageVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRentalRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRentalRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewArchiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRentalRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menageUsersToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusLine;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel slRole;
    }
}