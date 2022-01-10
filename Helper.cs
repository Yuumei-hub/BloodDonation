using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BloodDonation
{
    public static class Helper
    {
        public static SqlConnection CreateConnection()
        {
            var connection = new SqlConnection(
                @"Data Source=DESKTOP-MFNJNKA\SQLEXPRESS;Initial Catalog=BloodDonation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //@"Data Source=DESKTOP-35IGE88;Initial Catalog=BloodDonation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            return connection;
        }

        public static void ResizeColumns(ListView listView)
        {
            foreach (ColumnHeader column in listView.Columns)
                column.Width = -2;
        }

        public static void ApplySystemFont( Control control )
        {
            if (control == null)
                return;

            control.Font = SystemFonts.MessageBoxFont;

            foreach ( var childControl in control.Controls.OfType<Control>() )
                ApplySystemFont( childControl );
        }

        public static void CenterControls(Control control)
        {
            UpdateLocations(control);

            void UpdateLocations(Control childControl)
            {
                if (childControl == null || !childControl.HasChildren)
                    return;

                if (childControl.Controls.Count == 1)
                {
                    UpdateLocations(childControl.Controls[0]);
                    return;
                }

                int minX = int.MaxValue;
                int maxX = int.MinValue;
                int minY = int.MaxValue;
                int maxY = int.MinValue;

                foreach (var alsoChildControl in childControl.Controls.Cast<Control>())
                {
                    if (alsoChildControl is Label label)
                        label.Location = new Point(8, label.Location.Y);

                    minX = Math.Min(alsoChildControl.Location.X, minX);
                    maxX = Math.Max(alsoChildControl.Location.X + alsoChildControl.ClientSize.Width, maxX);
                    minY = Math.Min(alsoChildControl.Location.Y, minY);
                    maxY = Math.Max(alsoChildControl.Location.Y + alsoChildControl.ClientSize.Height, maxY);
                }

                int width = maxX - minX;
                int height = maxY - minY;
                int x = Math.Max(0, (childControl.ClientSize.Width - width) / 2);
                int y = Math.Max(0, (childControl.ClientSize.Height - height) / 2);

                foreach (var alsoChildControl in childControl.Controls.Cast<Control>())
                {
                    alsoChildControl.Location = new Point(
                        alsoChildControl.Location.X - minX + x,
                        alsoChildControl.Location.Y - minY + y);

                    UpdateLocations(alsoChildControl);
                }
            }
        }

        public static void ResizeListViewColumns(Control control)
        {
            ProcessRecursively(control);

            void ProcessRecursively(Control childControl)
            {
                if (childControl is ListView listView && listView.Columns.Count > 0)
                {
                    listView.BeginUpdate();
                    listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.None);

                    int width = listView.ClientSize.Width / listView.Columns.Count;
                    foreach (var column in listView.Columns.Cast<ColumnHeader>()) 
                        column.Width = width;

                    listView.EndUpdate();
                }

                foreach (var alsoChildControl in childControl.Controls.Cast<Control>())
                    ProcessRecursively(alsoChildControl);
            }

        }
    }
}