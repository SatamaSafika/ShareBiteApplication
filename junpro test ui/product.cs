using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static junpro_test_ui.Program;

namespace junpro_test_ui
{
    public partial class product : Form
    {
        private string _connectionString;
        public product()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;

        }

        private void buttonMilk_Click(object sender, EventArgs e)
        {
            foodReq form6 = new foodReq();
            form6.Show();
            this.Close();
        }

        private void btngeneralSetting_Click(object sender, EventArgs e)
        {
            ViewgeneralSetting settingsForm = new ViewgeneralSetting(Program.UserSession.LoggedInUsername);
            settingsForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inbox inbox = new Inbox();
            inbox.Show();
            this.Close();
        }

        private void lblNotifUnread_Click(object sender, EventArgs e)
        {

        }


        // Method to update unread notification indicator
        private void UpdateUnreadIndicator()
        {
            int unreadCount = GetUnreadNotificationsCount();

            // Update the Label visibility based on unread count
            lblNotifUnread.Visible = unreadCount > 0;
            lblNotifUnread.Text = unreadCount > 0 ? "." : string.Empty; // Display "." if there are unread notifications
            lblNotifUnread.ForeColor = Color.Red; // Set the color of the label to red
        }

        // Method to get the unread notifications count
        private int GetUnreadNotificationsCount()
        {
            int unreadCount = 0;

            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();

                // Query to count the unread notifications
                using (var cmd = new NpgsqlCommand(
                    "SELECT COUNT(*) FROM notifications WHERE status = 'unread'", conn))
                {
                    unreadCount = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return unreadCount;
        }

        private void product_Load(object sender, EventArgs e)
        {
            UpdateUnreadIndicator();
        }
    }
}