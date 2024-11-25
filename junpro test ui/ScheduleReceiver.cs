using System;
using System.Data;
using System.Windows.Forms;
using Npgsql; // Pastikan menambahkan paket Npgsql untuk koneksi PostgreSQL

namespace junpro_test_ui
{
    public partial class ScheduleReceiver : Form
    {
        private int LoggedInReceiverID;

        // Constructor dengan parameter ID penerima
        public ScheduleReceiver(int receiverID)
        {
            InitializeComponent();
            LoggedInReceiverID = receiverID;
            this.Load += new EventHandler(ScheduleReceiver_Load); // Menghubungkan event Load
        }

        public ScheduleReceiver()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi; // atau AutoScaleMode.None
        }

        // Event Load untuk mengambil dan menampilkan data terfilter
        private void ScheduleReceiver_Load(object sender, EventArgs e)
        {
            LoadFilteredScheduleData();
        }

        // Metode untuk mengambil data jadwal terfilter
        private void LoadFilteredScheduleData()
        {
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=tiara95!;Database=sharebite";
            string query = "SELECT * FROM schedule WHERE schedule_id = @scheduleID"; // Pastikan kolomnya benar

            using (var connection = new NpgsqlConnection(connectionString))
            {
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@scheduleID", LoggedInReceiverID);

                    var adapter = new NpgsqlDataAdapter(command);
                    var dataTable = new DataTable();

                    try
                    {
                        connection.Open();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable; // Tampilkan data di DataGridView
                        }
                        else
                        {
                            // Jika tidak ada data, tampilkan pesan di dalam DataGridView
                            dataGridView1.Rows.Clear();
                            dataGridView1.ColumnCount = 1; // Pastikan hanya ada satu kolom untuk pesan
                            dataGridView1.Columns[0].Name = "Message";
                            dataGridView1.Rows.Add("Akun ini tidak memiliki schedule.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan baris yang diklik adalah baris yang valid
            {
                // Mengambil nilai dari kolom tertentu (misalnya, schedule_id)
                var scheduleId = dataGridView1.Rows[e.RowIndex].Cells["schedule_id"].Value?.ToString();

                if (!string.IsNullOrEmpty(scheduleId))
                {
                    // Menampilkan informasi atau melakukan tindakan dengan scheduleId
                    MessageBox.Show("Schedule ID yang dipilih: " + scheduleId);

                    // Contoh: buka form lain atau tampilkan detail dari schedule yang dipilih
                    ShowScheduleDetails(scheduleId);
                }
                else
                {
                    MessageBox.Show("Schedule ID tidak ditemukan di baris yang dipilih.");
                }
            }
        }

        // Fungsi untuk menampilkan detail berdasarkan schedule_id
        private void ShowScheduleDetails(string scheduleId)
        {
            // Misalnya, buka form baru atau tampilkan detail
            MessageBox.Show("Tampilkan detail untuk Schedule ID: " + scheduleId);

            // Contoh membuka form baru dengan detail (Jika form detail ada)
            // var detailForm = new ScheduleDetailForm(scheduleId);
            // detailForm.Show();
        }

        // Tombol untuk membuka form Product
        private void button1_Click(object sender, EventArgs e)
        {
            product Product = new product();
            Product.Show();
            this.Close();  // Menutup form ScheduleReceiver
        }

        // Tombol untuk membuka form Dashboard
        private void button2_Click(object sender, EventArgs e)
        {
            dashboard Dashboard = new dashboard();
            Dashboard.Show();
            this.Close();  // Menutup form ScheduleReceiver
        }
    }
}
