using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BloodDonation
{
    public partial class PatientForm : Form
    {
        private readonly int id;
        private readonly List<int> bankIds;

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
                using (var command = new SqlCommand("SELECT * FROM Patient WHERE PatientID=@PatientID", connection))
                {
                    command.Parameters.AddWithValue("PatientID", id);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nameTextBox.Text = Convert.ToString(reader["PatientName"]);
                            bloodGroupTextBox.Text = Convert.ToString(reader["PatientBloodGroup"]);
                            diseaseTextBox.Text = Convert.ToString(reader["PatientDisease"]);
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
                string.IsNullOrEmpty(diseaseTextBox.Text) ||
                bloodBankComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please enter valid information.", "Blood Donation", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                e.Cancel = true;
                base.OnFormClosing(e);

                return;
            }

            using (var connection = Helper.CreateConnection())
            using (var command = new SqlCommand("AddorEditPatient", connection) { CommandType = CommandType.StoredProcedure })
            {
                command.Parameters.AddWithValue("PatientID", id);
                command.Parameters.AddWithValue("PatientName", nameTextBox.Text);
                command.Parameters.AddWithValue("PatientBloodGroup", bloodGroupTextBox.Text);
                command.Parameters.AddWithValue("PatientDisease", diseaseTextBox.Text);
                command.Parameters.AddWithValue("BankID", bankIds[bloodBankComboBox.SelectedIndex]);

                command.ExecuteNonQuery();
            }

            base.OnFormClosing(e);
        }

        public PatientForm(int id = -1)
        {
            InitializeComponent();
            Helper.ApplySystemFont(this);
            Helper.CenterControls(this);

            this.id = id;
            bankIds = new List<int>();
        }
    }
}
