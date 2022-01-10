using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BloodDonation
{
    public partial class AdminForm : Form
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
            using (var command = new SqlCommand("SELECT * FROM Admins WHERE AdminID=@AdminID", connection))
            {
                command.Parameters.AddWithValue("AdminID", id);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nameTextBox.Text = Convert.ToString(reader["Username"]);
                        passwordTextBox.Text = Convert.ToString(reader["Passwords"]);

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

            if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Please enter a valid name and password.", "Blood Donation", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                e.Cancel = true;
                base.OnFormClosing(e);

                return;
            }

            using (var connection = Helper.CreateConnection())
            using (var command = new SqlCommand("AddorEditAdmins", connection) { CommandType = CommandType.StoredProcedure })
            {
                command.Parameters.AddWithValue("AdminID", id);
                command.Parameters.AddWithValue("Username", nameTextBox.Text);
                command.Parameters.AddWithValue("Passwords", passwordTextBox.Text);
                command.ExecuteNonQuery();
            }

            base.OnFormClosing(e);
        }

        public AdminForm(int id = -1)
        {
            InitializeComponent();
            Helper.ApplySystemFont(this);
            Helper.CenterControls(this);

            this.id = id;
        }
    }
}
