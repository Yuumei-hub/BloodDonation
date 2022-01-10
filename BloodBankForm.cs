using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BloodDonation
{
    public partial class BloodBankForm : Form
    {
        private int id;

        protected override void OnLoad(EventArgs e)
        {
            if (id == -1)
            {
                base.OnLoad(e);
                return;
            }

            using (var connection = Helper.CreateConnection())
            using (var command = new SqlCommand("SELECT * FROM BloodBank WHERE BankID=@BankID", connection))
            {
                command.Parameters.AddWithValue("BankID", id);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nameTextBox.Text = Convert.ToString(reader["BBName"]);
                        addressTextBox.Text = Convert.ToString(reader["BBAddress"]);

                        break;
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

            if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(addressTextBox.Text))
            {
                MessageBox.Show("Please enter a valid username and address.", "Blood Donation", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                e.Cancel = true;
                base.OnFormClosing(e);

                return;
            }

            using (var connection = Helper.CreateConnection())
            using (var command = new SqlCommand("AddorEditBloodBank", connection) { CommandType = CommandType.StoredProcedure })
            {
                command.Parameters.AddWithValue("BankID", id);
                command.Parameters.AddWithValue("BBName", nameTextBox.Text);
                command.Parameters.AddWithValue("BBAddress", addressTextBox.Text);
                command.ExecuteNonQuery();
            }

            base.OnFormClosing(e);
        }

        public BloodBankForm(int id = -1)
        {
            InitializeComponent();
            Helper.ApplySystemFont(this);
            Helper.CenterControls(this);

            this.id = id;
        }
    }
}
