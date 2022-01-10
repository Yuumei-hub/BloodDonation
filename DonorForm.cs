using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BloodDonation
{
    public partial class DonorForm : Form
    {
        private readonly int id;
        private readonly List<int> bankIds;

        public string Username => nameTextBox.Text;
        public string Password => passwordTextBox.Text;

        protected override void OnLoad(EventArgs e)
        {
            using (var connection = Helper.CreateConnection())
            using (var command = new SqlCommand("SELECT BankID, BBName FROM BloodBank", connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    bankIds.Add(Convert.ToInt32(reader["BankID"]));
                    bloodBankComboBox.Items.Add(Convert.ToString(reader["BBName"]));
                }
            }

            if (bankIds.Count == 0)
            {
                MessageBox.Show("Unable to find any blood banks.", "Blood Donation", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Close();
                return;
            }

            if (id != -1)
            {
                using (var connection = Helper.CreateConnection())
                using (var command = new SqlCommand("SELECT * FROM Donor WHERE DonorID=@DonorID", connection))
                {
                    command.Parameters.AddWithValue("DonorID", id);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nameTextBox.Text = Convert.ToString(reader["DonorName"]);
                            bloodGroupTextBox.Text = Convert.ToString(reader["DonorBloodGroup"]);
                            medicalReportTextBox.Text = Convert.ToString(reader["DonorMedicalReport"]);
                            addressTextBox.Text = Convert.ToString(reader["DonorAddress"]);
                            contactNumberTextBox.Text = Convert.ToString(reader["DonorContactNumber"]);
                            passwordTextBox.Text = Convert.ToString(reader["DonorPassword"]);
                            bloodBankComboBox.SelectedIndex =
                                bankIds.FindIndex(x => x == Convert.ToInt32(reader["BankID"]));

                            break;
                        }
                    }
                }
            }

            base.OnLoad(e);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                base.OnFormClosing(e);
                return;
            }

            if (string.IsNullOrEmpty(nameTextBox.Text) ||
                string.IsNullOrEmpty(bloodGroupTextBox.Text) ||
                string.IsNullOrEmpty(medicalReportTextBox.Text) ||
                string.IsNullOrEmpty(addressTextBox.Text) ||
                string.IsNullOrEmpty(contactNumberTextBox.Text) ||
                string.IsNullOrEmpty(passwordTextBox.Text) ||
                bloodBankComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please enter valid information.", "Blood Donation", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                e.Cancel = true;
                base.OnFormClosing(e);

                return;
            }

            using (var connection = Helper.CreateConnection())
            using (var command = new SqlCommand("AddorEditDonor", connection) { CommandType = CommandType.StoredProcedure })
            {
                command.Parameters.AddWithValue("DonorID", id);
                command.Parameters.AddWithValue("DonorName", nameTextBox.Text);
                command.Parameters.AddWithValue("DonorBloodGroup", bloodGroupTextBox.Text);
                command.Parameters.AddWithValue("DonorMedicalReport", medicalReportTextBox.Text);
                command.Parameters.AddWithValue("DonorAddress", addressTextBox.Text);
                command.Parameters.AddWithValue("DonorContactNumber", contactNumberTextBox.Text);
                command.Parameters.AddWithValue("DonorPassword", passwordTextBox.Text);
                command.Parameters.AddWithValue("BankID", bankIds[bloodBankComboBox.SelectedIndex]);

                command.ExecuteNonQuery();
            }

            base.OnFormClosing(e);
        }

        public DonorForm(int id = -1)
        {
            InitializeComponent();
            Helper.ApplySystemFont(this);
            Helper.CenterControls(this);

            this.id = id;
            bankIds = new List<int>();
        }
    }
}
