using System;
using System.Windows.Forms;

namespace BloodDonation
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #if !DEBUG
            Application.ThreadException += (s, e) => MessageBox.Show($"Unable to execute operation: {e.Exception.Message}", "Blood Donation",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            #endif

            int donorId = -1;

            using (var loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }

                donorId = loginForm.DonorId;
            }

            Application.Run(donorId != -1 ? (Form)new DonorForm(donorId) : new MainForm());
        }
    }
}
