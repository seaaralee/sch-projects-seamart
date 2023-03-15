using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace seamarts
{
    public partial class Login : Form
    {
        private MySqlCommand command;
        private MySqlDataReader readData;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Fungsi ini digunakan agar form yang tampil akan berada di tengah layar
            this.StartPosition = FormStartPosition.Manual;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // Connection dengan Database
            MySqlConnection connect = new MySqlConnection();
            connect.ConnectionString = "server=localhost;user=root;password=;database=seamart_db";
            connect.Open();
            // Membuat variabel command yang berisi query SQL
            command = new MySqlCommand("SELECT * FROM auth_db WHERE username='" + this.txt_username.Text + "' AND password='" + this.txt_password.Text + "'", connect);
            // Untuk menjalankan query yang ada pada variable command dan dibungkus dengan variable readData
            readData = command.ExecuteReader();
            // fungsi ini untuk membaca data yang ada di database
            readData.Read();
            
            if (readData.HasRows)
            {
                // ini akan dijalankan jika data yang di inputkan benar dan sesuai yang ada di database
                Form1 crud = new Form1();
                crud.Show();
                this.Hide();
            }
            else
            {
                // jika salah maka akan muncul message box
                MessageBox.Show("Sorry Username or Password doesn't match!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
