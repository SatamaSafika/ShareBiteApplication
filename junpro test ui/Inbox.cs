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

namespace junpro_test_ui
{
    public partial class Inbox : Form
    {
        private string _connectionString;
        public Inbox()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
        }

        public void SendNotificationToFollowers(int pemberiId, int announcementId)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();

                    // Get the list of follower IDs for the given pemberiId
                    List<int> followerIds = GetFollowers(conn, pemberiId);

                    // Insert notifications for each follower
                    InsertNotifications(conn, followerIds, announcementId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending notifications: {ex.Message}");
            }
        }

        // Get the follower IDs of a pemberi
        private List<int> GetFollowers(NpgsqlConnection conn, int pemberiId)
        {
            List<int> followerIds = new List<int>();

            using (var cmd = new NpgsqlCommand("SELECT follower_id FROM following WHERE followed_id = @pemberiId", conn))
            {
                cmd.Parameters.AddWithValue("pemberiId", pemberiId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        followerIds.Add(reader.GetInt32(0));
                    }
                }
            }

            return followerIds;
        }

        // Insert notifications into the notifications table
        private void InsertNotifications(NpgsqlConnection conn, List<int> followerIds, int announcementId)
        {
            using (var transaction = conn.BeginTransaction())
            {
                foreach (var followerId in followerIds)
                {
                    CreateNotification(conn, followerId, announcementId);
                }

                transaction.Commit();
            }
        }

        // Create a notification for a specific follower
        private void CreateNotification(NpgsqlConnection conn, int followerId, int announcementId)
        {
            using (var cmd = new NpgsqlCommand("INSERT INTO notifications (penerima_id, announcement_id) VALUES (@followerId, @announcementId)", conn))
            {
                cmd.Parameters.AddWithValue("followerId", followerId);
                cmd.Parameters.AddWithValue("announcementId", announcementId);

                cmd.ExecuteNonQuery();
            }
        }
    }
}

