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

namespace junpro_test_ui
{
    public partial class Announcement : Form
    {

        private string _connectionString;
        public Announcement()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
        }

      

        // Method to get the current user's ID (this is just a placeholder, you should implement it as per your app logic)
        private int GetCurrentUserId()
        {
            // Replace with your method to get the logged-in user's ID
            return 1;  // Placeholder, assuming user with ID 1 is logged in
        }

        private void btnSendAnnounce_Click_1(object sender, EventArgs e)
        {
            // Get the current user's ID (this should be implemented according to your application's logic)
            int pemberiId = GetCurrentUserId();

            // Get the content from the textbox
            string content = tbAnnounce.Text.Trim();

            // Check if the content is not empty
            if (string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Please enter some content for the announcement.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Initialize the DatabaseHelper with the connection string
            DatabaseHelper dbHelper = new DatabaseHelper();

            // Try to create the announcement in the database
            bool announcementPosted = dbHelper.CreateAnnouncement(pemberiId, content);

            if (announcementPosted)
            {
                MessageBox.Show("Announcement posted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbAnnounce.Clear();  // Clear the textbox after posting
            }
            else
            {
                MessageBox.Show("Failed to post the announcement.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
