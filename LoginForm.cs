using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BloodDonation
{
    public partial class LoginForm : Form
    {
        public int DonorId { get; protected set; } = -1;

        protected override void OnLoad(EventArgs e)
        {
            bool empty = false;

            using (var connection = Helper.CreateConnection())
            using (var command = new SqlCommand("SELECT COUNT(*) FROM Admins", connection))
                empty = Convert.ToInt32(command.ExecuteScalar()) == 0;

            if (empty)
            {
                using (var connection = Helper.CreateConnection())
                using (var command = new SqlCommand("INSERT INTO Admins VALUES('admin', 'admin')", connection))
                    command.ExecuteNonQuery();
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
                FatalError("Please enter a valid name and password.");
                return;
            }

            using (var connection = Helper.CreateConnection())
            using (var command = new SqlCommand("SELECT * FROM Donor", connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader["DonorName"].Equals(nameTextBox.Text) &&
                        reader["DonorPassword"].Equals(passwordTextBox.Text))
                    {
                        DonorId = Convert.ToInt32(reader["DonorID"]);
                        return;
                    }
                }
            }

            using (var connection = Helper.CreateConnection())
            using (var command = new SqlCommand("SELECT * FROM Admins", connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader["Username"].Equals(nameTextBox.Text) && reader["Passwords"].Equals(passwordTextBox.Text))
                        return;
                }
            }

            FatalError("Failed to find user with given credentials.");

            void FatalError(string text)
            {
                MessageBox.Show(text, "Blood Donation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                base.OnFormClosing(e);
            }
        }

        public LoginForm()
        {
            InitializeComponent();
            Helper.ApplySystemFont(this);
            Helper.CenterControls(this);
        }

        private void OnRegister(object sender, EventArgs e)
        {
            using (var form = new DonorForm())
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                nameTextBox.Text = form.Username;
                passwordTextBox.Text = form.Password;
            }
        }
    }
}
