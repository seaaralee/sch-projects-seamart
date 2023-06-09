﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Fungsi ini digunakan agar form yang tampil akan berada di tengah layar
            this.StartPosition = FormStartPosition.Manual;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            // Connection dengan Database
            string connection = "server=localhost;user id=root;password=;database=seamart_db";
            string query = "SELECT * FROM mart_db";
            // Membuat variable path folder image
            string imagePath = @"D:\sch-projects\ukk-project\seamarts\seamarts\bin\Debug\Image";
            // Membuat objek sqlconnection dengan parameter connection
            MySqlConnection connect = new MySqlConnection(connection);
            // Membuat objek sqlcommand dengan parameter query dan connect
            MySqlCommand command = new MySqlCommand(query, connect);
            // Membuat object untuk mengisi data dari database
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            // Objek command akan dieksekusi dataAdapter
            dataAdapter.SelectCommand = command;
            // Membuat objek dataTable untuk menampung hasil query
            DataTable dataTable = new DataTable();
            // Kemudian dataAdapter akan terisi oleh hasil querynya
            dataAdapter.Fill(dataTable);
            // Pada dataTable kita menambah kolom Picture dengan tipedata byte(data gambar)
            dataTable.Columns.Add("Picture", typeof(byte[]));
            // Melakukan Looping di setiap baris dataTable
            foreach (DataRow row in dataTable.Rows)
            {
                // Membuat variable filename dan filepath
                // isi dari filename = mengambil file nama yang ada pada row Image
                string filename = Path.GetFileName(row["Image"].ToString());
                // isi dari filepath = menggabungkan imagepath dan filename
                string filepath = Path.Combine(imagePath, filename);
                // jika direktori yang dituju terdapat nama file yang sama . .
                if (File.Exists(filepath))
                {
                    // maka row picture akan membaca dan menampilkan gambarnya dengan ReadAllBytes
                    row["Picture"] = File.ReadAllBytes(filepath);
                }
            }
            // Kemudian datagridview akan menampilkan data yang di tampung oleh dataTable
            dataGridView.DataSource = dataTable;
        }

        public void id_Increment()
        {
            // Connection dengan database
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=;database=seamart_db");
            // Membuat script sql
            MySqlScript script = new MySqlScript(connection, "SET @kode := 0; \r\n UPDATE mart_db SET kode = @kode := (@kode + 1); \r\n ALTER TABLE `mart_db` AUTO_INCREMENT = 1;");
            // Menjalankan script
            script.Execute();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=seamart_db";
            string query = "INSERT INTO mart_db(Produk, Deskripsi, Harga, Stock, Image) VALUES ('" + this.txt_produk.Text + "', '" + this.txt_deskripsi.Text + "', '" + this.txt_harga.Text + "', '" + this.txt_stock.Text + "',  '" + Path.GetFileName(pictureBox.ImageLocation) + "')";
            MySqlConnection connect = new MySqlConnection(connection);
            MySqlCommand command = new MySqlCommand(query, connect);
            MySqlDataReader dataReader;
            connect.Open();
            dataReader = command.ExecuteReader();
            MessageBox.Show("Successfully Data Added!");
            connect.Close();

            string fileName = Path.GetFileName(txt_image.Text);
            string destinationPath = Application.StartupPath + @"\Image\" + fileName;

            if (File.Exists(destinationPath))
            {
                // jika file sudah ada, tambahkan nomor urut pada akhir nama file
                int fileNumber = 1;
                while (File.Exists(destinationPath))
                {
                    fileName = Path.GetFileNameWithoutExtension(txt_image.Text) + $" ({fileNumber})" + Path.GetExtension(txt_image.Text);
                    destinationPath = Application.StartupPath + @"\Image\" + fileName;
                    fileNumber++;
                }
            }

            // copy file gambar ke direktori yang ditentukan
            File.Copy(txt_image.Text, destinationPath);

            // mengubah lokasi gambar pada pictureBox ke yang baru
            pictureBox.ImageLocation = destinationPath;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=seamart_db";
            string query = "UPDATE mart_db SET Produk='" + this.txt_produk.Text + "', Deskripsi='" + this.txt_deskripsi.Text + "', " + "Harga='" + this.txt_harga.Text + "', Stock='" + this.txt_stock.Text + "', Image='" + Path.GetFileName(pictureBox.ImageLocation) + "' WHERE Kode='" + this.txt_kode.Text + "'";
            MySqlConnection connect = new MySqlConnection(connection);
            MySqlCommand command = new MySqlCommand(query, connect);
            MySqlDataReader dataReader;
            connect.Open();
            dataReader = command.ExecuteReader();
            MessageBox.Show("Successfully Data Updated!");
            connect.Close();

            string fileName = Path.GetFileName(txt_image.Text);
            string destinationPath = Application.StartupPath + @"\Image\" + fileName;

            if (File.Exists(destinationPath))
            {
                // jika file sudah ada, tambahkan nomor urut pada akhir nama file
                int fileNumber = 1;
                while (File.Exists(destinationPath))
                {
                    // without extension -> image.png = image (tanpa .png)
                    // get extension, yang diambil adalah .png nya
                    fileName = Path.GetFileNameWithoutExtension(txt_image.Text) + $" ({fileNumber})" + Path.GetExtension(txt_image.Text);
                    destinationPath = Application.StartupPath + @"\Image\" + fileName;
                    fileNumber++;
                }
            }

            // copy file gambar ke direktori yang ditentukan
            File.Copy(txt_image.Text, destinationPath);

            // mengubah lokasi gambar pada pictureBox ke yang baru
            pictureBox.ImageLocation = destinationPath;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=seamart_db";
            string query = "DELETE FROM mart_db WHERE Kode='" + this.txt_kode.Text + "'";
            MySqlConnection connect = new MySqlConnection(connection);
            MySqlCommand command = new MySqlCommand(query, connect);
            MySqlDataReader dataReader;
            connect.Open();
            dataReader = command.ExecuteReader();
            MessageBox.Show("Successfully Data Deleted!");
            id_Increment();
            connect.Close();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=seamart_db";
            string query = "SELECT * FROM mart_db";
            string imagePath = @"D:\sch-projects\ukk-project\seamarts\seamarts\bin\Debug\Image";
            MySqlConnection connect = new MySqlConnection(connection);
            MySqlCommand command = new MySqlCommand(query, connect);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataTable.Columns.Add("Picture", typeof(byte[]));
            foreach (DataRow row in dataTable.Rows)
            {
                string filename = Path.GetFileName(row["Image"].ToString());
                string filepath = Path.Combine(imagePath, filename);
                if (File.Exists(filepath))
                {
                    row["Picture"] = File.ReadAllBytes(filepath);
                }
            }
            dataGridView.DataSource = dataTable;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=seamart_db";
            string imagePath = @"D:\sch-projects\ukk-project\seamarts\seamarts\bin\Debug\Image";
            MySqlConnection connect = new MySqlConnection(connection);
            MySqlDataAdapter dataAdapter;
            DataTable dataTable;
            connect.Open();
            dataAdapter = new MySqlDataAdapter("SELECT * FROM mart_db WHERE Produk LIKE '" + this.txt_search.Text + "%'", connect);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataTable.Columns.Add("Picture", typeof(byte[]));
            foreach (DataRow row in dataTable.Rows)
            {
                string filename = Path.GetFileName(row["Image"].ToString());
                string filepath = Path.Combine(imagePath, filename);
                if (File.Exists(filepath))
                {
                    row["Picture"] = File.ReadAllBytes(filepath);
                }
            }
            dataGridView.DataSource = dataTable; 
            connect.Close();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.png;) | *.jpg;*.jpeg;*.gif;*.png;";
            if (openfd.ShowDialog() == DialogResult.OK)
            {
                txt_image.Text = openfd.FileName;
                pictureBox.Image = new Bitmap(openfd.FileName);
                pictureBox.ImageLocation = openfd.FileName;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
