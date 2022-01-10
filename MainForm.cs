using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BloodDonation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Helper.ApplySystemFont(this);
        }

        protected override void OnLoad(EventArgs e)
        {
            PopulatePatients();
            base.OnLoad(e);
        }

        private void PopulatePatients()
        {
            patientListView.Items.Clear();

            using (var connection = Helper.CreateConnection())
            using (var command = new SqlCommand("SELECT * FROM [showpatientandbank]", connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        patientListView.Items.Add(new ListViewItem(new[]
                        {
                            Convert.ToString(reader["PatientID"]),
                            Convert.ToString(reader["PatientName"]),
                            Convert.ToString(reader["PatientBloodGroup"]),
                            Convert.ToString(reader["PatientDisease"]),
                            Convert.ToString(reader["BankName"]),
                            Convert.ToString(reader["BankAddress"])
                        }));
                    }
                }
            }

            Helper.ResizeColumns(patientListView);
        }

        private void PopulateBloodBanks()
        {
            bloodBankListView.Items.Clear();

            using (var connection = Helper.CreateConnection())
            using (var command = new SqlCommand("SELECT * FROM BloodBank", connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bloodBankListView.Items.Add(new ListViewItem(new[]
                        {
                            Convert.ToString(reader["BankID"]),
                            Convert.ToString(reader["BBName"]),
                            Convert.ToString(reader["BBAddress"]),
                        }));
                    }
                }
            }

            Helper.ResizeColumns(bloodBankListView);
        }

        private void PopulateDonors()
        {
            donorListView.Items.Clear();

            using (var connection = Helper.CreateConnection())
            using (var command = new SqlCommand("SELECT * FROM [showdonorandbank]", connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        donorListView.Items.Add(new ListViewItem(new[]
                        {
                            Convert.ToString(reader["DonorID"]),
                            Convert.ToString(reader["DonorName"]),
                            Convert.ToString(reader["DonorBloodGroup"]),
                            Convert.ToString(reader["DonorMedicalReport"]),
                            Convert.ToString(reader["DonorContactNumber"]),
                            Convert.ToString(reader["BankName"]),
                            Convert.ToString(reader["BankAddress"])
                        }));
                    }
                }
            }

            Helper.ResizeColumns(donorListView);
        }

        private void PopulateAdmins()
        {
            adminListView.Items.Clear();

            using (var connection = Helper.CreateConnection())
            using (var command = new SqlCommand("SELECT * FROM Admins", connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        adminListView.Items.Add(new ListViewItem(new[]
                        {
                            Convert.ToString(reader["AdminID"]),
                            Convert.ToString(reader["Username"]),
                            Convert.ToString(reader["Passwords"]),
                        }));
                    }
                }
            }

            Helper.ResizeColumns(adminListView);
        }

        private void OnTabSelected(object sender, TabControlEventArgs e)
        {
            if (tabControl.SelectedTab == patientsTab) PopulatePatients();
            else if (tabControl.SelectedTab == bloodBanksTab) PopulateBloodBanks();
            else if (tabControl.SelectedTab == donorsTab) PopulateDonors();
            else if (tabControl.SelectedTab == adminsTab) PopulateAdmins();
        }

        private void OnAddPatient(object sender, EventArgs e)
        {
            using (var form = new PatientForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    PopulatePatients();
            }
        }

        private void OnEditPatient(object sender, EventArgs e)
        {
            if (patientListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a patient.", "Blood Donation", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            using (var form = new PatientForm(Convert.ToInt32(patientListView.SelectedItems[0].SubItems[0].Text)))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    PopulatePatients();
            }
        }

        private void OnRemovePatient(object sender, EventArgs e)
        {
            if (patientListView.SelectedItems.Count == 0) return;

            using (var connection = Helper.CreateConnection())
            using (var command = new SqlCommand("DELETE FROM Patient WHERE PatientID=@PatientID", connection))
            {
                command.Parameters.AddWithValue("PatientID",
                    Convert.ToInt32(patientListView.SelectedItems[0].SubItems[0].Text));

                command.ExecuteNonQuery();
            }

            PopulatePatients(); 
        }

        private void OnAddBloodBank(object sender, EventArgs e)
        {
            using (var form = new BloodBankForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    PopulateBloodBanks();
            }
        }

        private void OnEditBloodBank(object sender, EventArgs e)
        {
            if (bloodBankListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a blood bank.", "Blood Donation", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            using (var form = new BloodBankForm(Convert.ToInt32(bloodBankListView.SelectedItems[0].SubItems[0].Text)))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    PopulateBloodBanks();
            }
        }

        private void OnRemoveBloodBank(object sender, EventArgs e)
        {
            if (bloodBankListView.SelectedItems.Count == 0) return;

            using (var connection = Helper.CreateConnection())
            using (var command = new SqlCommand("DELETE FROM BloodBank WHERE BankID=@BankID", connection))
            {
                command.Parameters.AddWithValue("BankID",
                    Convert.ToInt32(bloodBankListView.SelectedItems[0].SubItems[0].Text));

                command.ExecuteNonQuery();
            }

            PopulateBloodBanks();
        }

        private void OnAddDonor(object sender, EventArgs e)
        {
            using (var form = new DonorForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    PopulateDonors();
            }
        }

        private void OnEditDonor(object sender, EventArgs e)
        {
            if (donorListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a donor.", "Blood Donation", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            using (var form = new DonorForm(Convert.ToInt32(donorListView.SelectedItems[0].SubItems[0].Text)))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    PopulateDonors();
            }
        }

        private void OnRemoveDonor(object sender, EventArgs e)
        {
            if (donorListView.SelectedItems.Count == 0) return;

            using (var connection = Helper.CreateConnection())
            using (var command = new SqlCommand("DELETE FROM Donor WHERE DonorID=@DonorID", connection))
            {
                command.Parameters.AddWithValue("DonorID",
                    Convert.ToInt32(donorListView.SelectedItems[0].SubItems[0].Text));

                command.ExecuteNonQuery();
            }

            PopulateDonors();
        }

        private void OnAddAdmin(object sender, EventArgs e)
        {
            using (var form = new AdminForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    PopulateAdmins();
            }

        }

        private void OnEditAdmin(object sender, EventArgs e)
        {
            if (adminListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an administrator.", "Blood Donation", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            using (var form = new AdminForm(Convert.ToInt32(adminListView.SelectedItems[0].SubItems[0].Text)))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    PopulateAdmins();
            }
        }

        private void OnRemoveAdmin(object sender, EventArgs e)
        {
            if (adminListView.SelectedItems.Count == 0) return;

            using (var connection = Helper.CreateConnection())
            using (var command = new SqlCommand("DELETE FROM Admins WHERE AdminID=@AdminID", connection))
            {
                command.Parameters.AddWithValue("AdminID",
                    Convert.ToInt32(adminListView.SelectedItems[0].SubItems[0].Text));

                command.ExecuteNonQuery();
            }

            PopulateAdmins();
        }
    }
}
