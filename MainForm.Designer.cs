namespace BloodDonation
{
    partial class MainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.patientsTab = new System.Windows.Forms.TabPage();
            this.removePatientButton = new System.Windows.Forms.Button();
            this.editPatientButton = new System.Windows.Forms.Button();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.patientListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bloodBanksTab = new System.Windows.Forms.TabPage();
            this.removeBloodBankButton = new System.Windows.Forms.Button();
            this.editBloodBankButton = new System.Windows.Forms.Button();
            this.addBloodBankButton = new System.Windows.Forms.Button();
            this.bloodBankListView = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.donorsTab = new System.Windows.Forms.TabPage();
            this.removeDonorButton = new System.Windows.Forms.Button();
            this.editDonorButton = new System.Windows.Forms.Button();
            this.addDonorButton = new System.Windows.Forms.Button();
            this.donorListView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adminsTab = new System.Windows.Forms.TabPage();
            this.removeAdminButton = new System.Windows.Forms.Button();
            this.editAdminButton = new System.Windows.Forms.Button();
            this.addAdminButton = new System.Windows.Forms.Button();
            this.adminListView = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl.SuspendLayout();
            this.patientsTab.SuspendLayout();
            this.bloodBanksTab.SuspendLayout();
            this.donorsTab.SuspendLayout();
            this.adminsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.patientsTab);
            this.tabControl.Controls.Add(this.bloodBanksTab);
            this.tabControl.Controls.Add(this.donorsTab);
            this.tabControl.Controls.Add(this.adminsTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(625, 402);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabStop = false;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.OnTabSelected);
            // 
            // patientsTab
            // 
            this.patientsTab.Controls.Add(this.removePatientButton);
            this.patientsTab.Controls.Add(this.editPatientButton);
            this.patientsTab.Controls.Add(this.addPatientButton);
            this.patientsTab.Controls.Add(this.patientListView);
            this.patientsTab.Location = new System.Drawing.Point(4, 22);
            this.patientsTab.Name = "patientsTab";
            this.patientsTab.Padding = new System.Windows.Forms.Padding(3);
            this.patientsTab.Size = new System.Drawing.Size(617, 376);
            this.patientsTab.TabIndex = 0;
            this.patientsTab.Text = "Patients";
            this.patientsTab.UseVisualStyleBackColor = true;
            // 
            // removePatientButton
            // 
            this.removePatientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removePatientButton.Location = new System.Drawing.Point(170, 345);
            this.removePatientButton.Name = "removePatientButton";
            this.removePatientButton.Size = new System.Drawing.Size(75, 23);
            this.removePatientButton.TabIndex = 3;
            this.removePatientButton.Text = "Remove";
            this.removePatientButton.UseVisualStyleBackColor = true;
            this.removePatientButton.Click += new System.EventHandler(this.OnRemovePatient);
            // 
            // editPatientButton
            // 
            this.editPatientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editPatientButton.Location = new System.Drawing.Point(89, 345);
            this.editPatientButton.Name = "editPatientButton";
            this.editPatientButton.Size = new System.Drawing.Size(75, 23);
            this.editPatientButton.TabIndex = 2;
            this.editPatientButton.Text = "Edit";
            this.editPatientButton.UseVisualStyleBackColor = true;
            this.editPatientButton.Click += new System.EventHandler(this.OnEditPatient);
            // 
            // addPatientButton
            // 
            this.addPatientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addPatientButton.Location = new System.Drawing.Point(8, 345);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(75, 23);
            this.addPatientButton.TabIndex = 1;
            this.addPatientButton.Text = "Add";
            this.addPatientButton.UseVisualStyleBackColor = true;
            this.addPatientButton.Click += new System.EventHandler(this.OnAddPatient);
            // 
            // patientListView
            // 
            this.patientListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patientListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader18});
            this.patientListView.FullRowSelect = true;
            this.patientListView.HideSelection = false;
            this.patientListView.Location = new System.Drawing.Point(8, 6);
            this.patientListView.MultiSelect = false;
            this.patientListView.Name = "patientListView";
            this.patientListView.Size = new System.Drawing.Size(601, 333);
            this.patientListView.TabIndex = 0;
            this.patientListView.UseCompatibleStateImageBehavior = false;
            this.patientListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Blood Group";
            this.columnHeader3.Width = 99;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Disease";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Blood Bank";
            this.columnHeader5.Width = 107;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Blood Bank Address";
            this.columnHeader18.Width = 117;
            // 
            // bloodBanksTab
            // 
            this.bloodBanksTab.Controls.Add(this.removeBloodBankButton);
            this.bloodBanksTab.Controls.Add(this.editBloodBankButton);
            this.bloodBanksTab.Controls.Add(this.addBloodBankButton);
            this.bloodBanksTab.Controls.Add(this.bloodBankListView);
            this.bloodBanksTab.Location = new System.Drawing.Point(4, 22);
            this.bloodBanksTab.Name = "bloodBanksTab";
            this.bloodBanksTab.Padding = new System.Windows.Forms.Padding(3);
            this.bloodBanksTab.Size = new System.Drawing.Size(617, 376);
            this.bloodBanksTab.TabIndex = 3;
            this.bloodBanksTab.Text = "Blood Banks";
            this.bloodBanksTab.UseVisualStyleBackColor = true;
            // 
            // removeBloodBankButton
            // 
            this.removeBloodBankButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeBloodBankButton.Location = new System.Drawing.Point(170, 345);
            this.removeBloodBankButton.Name = "removeBloodBankButton";
            this.removeBloodBankButton.Size = new System.Drawing.Size(75, 23);
            this.removeBloodBankButton.TabIndex = 7;
            this.removeBloodBankButton.Text = "Remove";
            this.removeBloodBankButton.UseVisualStyleBackColor = true;
            this.removeBloodBankButton.Click += new System.EventHandler(this.OnRemoveBloodBank);
            // 
            // editBloodBankButton
            // 
            this.editBloodBankButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editBloodBankButton.Location = new System.Drawing.Point(89, 345);
            this.editBloodBankButton.Name = "editBloodBankButton";
            this.editBloodBankButton.Size = new System.Drawing.Size(75, 23);
            this.editBloodBankButton.TabIndex = 6;
            this.editBloodBankButton.Text = "Edit";
            this.editBloodBankButton.UseVisualStyleBackColor = true;
            this.editBloodBankButton.Click += new System.EventHandler(this.OnEditBloodBank);
            // 
            // addBloodBankButton
            // 
            this.addBloodBankButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addBloodBankButton.Location = new System.Drawing.Point(8, 345);
            this.addBloodBankButton.Name = "addBloodBankButton";
            this.addBloodBankButton.Size = new System.Drawing.Size(75, 23);
            this.addBloodBankButton.TabIndex = 5;
            this.addBloodBankButton.Text = "Add";
            this.addBloodBankButton.UseVisualStyleBackColor = true;
            this.addBloodBankButton.Click += new System.EventHandler(this.OnAddBloodBank);
            // 
            // bloodBankListView
            // 
            this.bloodBankListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bloodBankListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.bloodBankListView.FullRowSelect = true;
            this.bloodBankListView.HideSelection = false;
            this.bloodBankListView.Location = new System.Drawing.Point(8, 6);
            this.bloodBankListView.MultiSelect = false;
            this.bloodBankListView.Name = "bloodBankListView";
            this.bloodBankListView.Size = new System.Drawing.Size(601, 333);
            this.bloodBankListView.TabIndex = 4;
            this.bloodBankListView.UseCompatibleStateImageBehavior = false;
            this.bloodBankListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "ID";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Name";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Address";
            // 
            // donorsTab
            // 
            this.donorsTab.Controls.Add(this.removeDonorButton);
            this.donorsTab.Controls.Add(this.editDonorButton);
            this.donorsTab.Controls.Add(this.addDonorButton);
            this.donorsTab.Controls.Add(this.donorListView);
            this.donorsTab.Location = new System.Drawing.Point(4, 22);
            this.donorsTab.Name = "donorsTab";
            this.donorsTab.Padding = new System.Windows.Forms.Padding(3);
            this.donorsTab.Size = new System.Drawing.Size(617, 376);
            this.donorsTab.TabIndex = 1;
            this.donorsTab.Text = "Donors";
            this.donorsTab.UseVisualStyleBackColor = true;
            // 
            // removeDonorButton
            // 
            this.removeDonorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeDonorButton.Location = new System.Drawing.Point(170, 345);
            this.removeDonorButton.Name = "removeDonorButton";
            this.removeDonorButton.Size = new System.Drawing.Size(75, 23);
            this.removeDonorButton.TabIndex = 7;
            this.removeDonorButton.Text = "Remove";
            this.removeDonorButton.UseVisualStyleBackColor = true;
            this.removeDonorButton.Click += new System.EventHandler(this.OnRemoveDonor);
            // 
            // editDonorButton
            // 
            this.editDonorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editDonorButton.Location = new System.Drawing.Point(89, 345);
            this.editDonorButton.Name = "editDonorButton";
            this.editDonorButton.Size = new System.Drawing.Size(75, 23);
            this.editDonorButton.TabIndex = 6;
            this.editDonorButton.Text = "Edit";
            this.editDonorButton.UseVisualStyleBackColor = true;
            this.editDonorButton.Click += new System.EventHandler(this.OnEditDonor);
            // 
            // addDonorButton
            // 
            this.addDonorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addDonorButton.Location = new System.Drawing.Point(8, 345);
            this.addDonorButton.Name = "addDonorButton";
            this.addDonorButton.Size = new System.Drawing.Size(75, 23);
            this.addDonorButton.TabIndex = 5;
            this.addDonorButton.Text = "Add";
            this.addDonorButton.UseVisualStyleBackColor = true;
            this.addDonorButton.Click += new System.EventHandler(this.OnAddDonor);
            // 
            // donorListView
            // 
            this.donorListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.donorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader19});
            this.donorListView.FullRowSelect = true;
            this.donorListView.HideSelection = false;
            this.donorListView.Location = new System.Drawing.Point(8, 6);
            this.donorListView.MultiSelect = false;
            this.donorListView.Name = "donorListView";
            this.donorListView.Size = new System.Drawing.Size(601, 333);
            this.donorListView.TabIndex = 4;
            this.donorListView.UseCompatibleStateImageBehavior = false;
            this.donorListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Name";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Blood Group";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Medical Report";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Contact Number";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Blood Bank";
            // 
            // adminsTab
            // 
            this.adminsTab.Controls.Add(this.removeAdminButton);
            this.adminsTab.Controls.Add(this.editAdminButton);
            this.adminsTab.Controls.Add(this.addAdminButton);
            this.adminsTab.Controls.Add(this.adminListView);
            this.adminsTab.Location = new System.Drawing.Point(4, 22);
            this.adminsTab.Name = "adminsTab";
            this.adminsTab.Padding = new System.Windows.Forms.Padding(3);
            this.adminsTab.Size = new System.Drawing.Size(617, 376);
            this.adminsTab.TabIndex = 2;
            this.adminsTab.Text = "Administrators";
            this.adminsTab.UseVisualStyleBackColor = true;
            // 
            // removeAdminButton
            // 
            this.removeAdminButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeAdminButton.Location = new System.Drawing.Point(170, 345);
            this.removeAdminButton.Name = "removeAdminButton";
            this.removeAdminButton.Size = new System.Drawing.Size(75, 23);
            this.removeAdminButton.TabIndex = 3;
            this.removeAdminButton.Text = "Remove";
            this.removeAdminButton.UseVisualStyleBackColor = true;
            this.removeAdminButton.Click += new System.EventHandler(this.OnRemoveAdmin);
            // 
            // editAdminButton
            // 
            this.editAdminButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editAdminButton.Location = new System.Drawing.Point(89, 345);
            this.editAdminButton.Name = "editAdminButton";
            this.editAdminButton.Size = new System.Drawing.Size(75, 23);
            this.editAdminButton.TabIndex = 2;
            this.editAdminButton.Text = "Edit";
            this.editAdminButton.UseVisualStyleBackColor = true;
            this.editAdminButton.Click += new System.EventHandler(this.OnEditAdmin);
            // 
            // addAdminButton
            // 
            this.addAdminButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addAdminButton.Location = new System.Drawing.Point(8, 345);
            this.addAdminButton.Name = "addAdminButton";
            this.addAdminButton.Size = new System.Drawing.Size(75, 23);
            this.addAdminButton.TabIndex = 1;
            this.addAdminButton.Text = "Add";
            this.addAdminButton.UseVisualStyleBackColor = true;
            this.addAdminButton.Click += new System.EventHandler(this.OnAddAdmin);
            // 
            // adminListView
            // 
            this.adminListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17});
            this.adminListView.FullRowSelect = true;
            this.adminListView.HideSelection = false;
            this.adminListView.Location = new System.Drawing.Point(8, 6);
            this.adminListView.MultiSelect = false;
            this.adminListView.Name = "adminListView";
            this.adminListView.Size = new System.Drawing.Size(601, 333);
            this.adminListView.TabIndex = 0;
            this.adminListView.UseCompatibleStateImageBehavior = false;
            this.adminListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "ID";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Name";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Blood Bank Address";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 402);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood Donation";
            this.tabControl.ResumeLayout(false);
            this.patientsTab.ResumeLayout(false);
            this.bloodBanksTab.ResumeLayout(false);
            this.donorsTab.ResumeLayout(false);
            this.adminsTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage patientsTab;
        private System.Windows.Forms.TabPage donorsTab;
        private System.Windows.Forms.Button removePatientButton;
        private System.Windows.Forms.Button editPatientButton;
        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.ListView patientListView;
        private System.Windows.Forms.TabPage adminsTab;
        private System.Windows.Forms.Button removeAdminButton;
        private System.Windows.Forms.Button editAdminButton;
        private System.Windows.Forms.Button addAdminButton;
        private System.Windows.Forms.ListView adminListView;
        private System.Windows.Forms.TabPage bloodBanksTab;
        private System.Windows.Forms.Button removeBloodBankButton;
        private System.Windows.Forms.Button editBloodBankButton;
        private System.Windows.Forms.Button addBloodBankButton;
        private System.Windows.Forms.ListView bloodBankListView;
        private System.Windows.Forms.Button removeDonorButton;
        private System.Windows.Forms.Button editDonorButton;
        private System.Windows.Forms.Button addDonorButton;
        private System.Windows.Forms.ListView donorListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
    }
}

