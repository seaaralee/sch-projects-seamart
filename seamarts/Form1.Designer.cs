
namespace seamarts
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_kode = new System.Windows.Forms.TextBox();
            this.kode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.produk = new System.Windows.Forms.Label();
            this.txt_produk = new System.Windows.Forms.TextBox();
            this.deskripsi = new System.Windows.Forms.Label();
            this.txt_deskripsi = new System.Windows.Forms.TextBox();
            this.Harga = new System.Windows.Forms.Label();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.stock = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.seamarts = new System.Windows.Forms.Label();
            this.txt_image = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_kode
            // 
            this.txt_kode.BackColor = System.Drawing.Color.Honeydew;
            this.txt_kode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kode.ForeColor = System.Drawing.Color.OliveDrab;
            this.txt_kode.Location = new System.Drawing.Point(42, 287);
            this.txt_kode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_kode.Name = "txt_kode";
            this.txt_kode.Size = new System.Drawing.Size(204, 26);
            this.txt_kode.TabIndex = 0;
            // 
            // kode
            // 
            this.kode.AutoSize = true;
            this.kode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kode.ForeColor = System.Drawing.Color.OliveDrab;
            this.kode.Location = new System.Drawing.Point(38, 265);
            this.kode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kode.Name = "kode";
            this.kode.Size = new System.Drawing.Size(53, 19);
            this.kode.TabIndex = 1;
            this.kode.Text = "Kode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(885, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView.Location = new System.Drawing.Point(399, 170);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 75;
            this.dataGridView.Size = new System.Drawing.Size(802, 394);
            this.dataGridView.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Kode";
            this.Column1.HeaderText = "Kode";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Produk";
            this.Column2.HeaderText = "Produk";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Deskripsi";
            this.Column3.HeaderText = "Deskripsi";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Harga";
            this.Column4.HeaderText = "Harga";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Stock";
            this.Column5.HeaderText = "Stock";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Picture";
            this.Column6.HeaderText = "Picture";
            this.Column6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // produk
            // 
            this.produk.AutoSize = true;
            this.produk.BackColor = System.Drawing.Color.Transparent;
            this.produk.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produk.ForeColor = System.Drawing.Color.OliveDrab;
            this.produk.Location = new System.Drawing.Point(38, 326);
            this.produk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.produk.Name = "produk";
            this.produk.Size = new System.Drawing.Size(66, 19);
            this.produk.TabIndex = 6;
            this.produk.Text = "Produk";
            // 
            // txt_produk
            // 
            this.txt_produk.BackColor = System.Drawing.Color.Honeydew;
            this.txt_produk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_produk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_produk.ForeColor = System.Drawing.Color.OliveDrab;
            this.txt_produk.Location = new System.Drawing.Point(42, 348);
            this.txt_produk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_produk.Name = "txt_produk";
            this.txt_produk.Size = new System.Drawing.Size(204, 26);
            this.txt_produk.TabIndex = 5;
            // 
            // deskripsi
            // 
            this.deskripsi.AutoSize = true;
            this.deskripsi.BackColor = System.Drawing.Color.Transparent;
            this.deskripsi.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskripsi.ForeColor = System.Drawing.Color.OliveDrab;
            this.deskripsi.Location = new System.Drawing.Point(38, 388);
            this.deskripsi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.Size = new System.Drawing.Size(82, 19);
            this.deskripsi.TabIndex = 8;
            this.deskripsi.Text = "Deskripsi";
            // 
            // txt_deskripsi
            // 
            this.txt_deskripsi.BackColor = System.Drawing.Color.Honeydew;
            this.txt_deskripsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_deskripsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deskripsi.ForeColor = System.Drawing.Color.OliveDrab;
            this.txt_deskripsi.Location = new System.Drawing.Point(42, 410);
            this.txt_deskripsi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_deskripsi.Name = "txt_deskripsi";
            this.txt_deskripsi.Size = new System.Drawing.Size(204, 26);
            this.txt_deskripsi.TabIndex = 7;
            // 
            // Harga
            // 
            this.Harga.AutoSize = true;
            this.Harga.BackColor = System.Drawing.Color.Transparent;
            this.Harga.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Harga.ForeColor = System.Drawing.Color.OliveDrab;
            this.Harga.Location = new System.Drawing.Point(41, 451);
            this.Harga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(59, 19);
            this.Harga.TabIndex = 10;
            this.Harga.Text = "Harga";
            // 
            // txt_harga
            // 
            this.txt_harga.BackColor = System.Drawing.Color.Honeydew;
            this.txt_harga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_harga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_harga.ForeColor = System.Drawing.Color.OliveDrab;
            this.txt_harga.Location = new System.Drawing.Point(42, 473);
            this.txt_harga.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(204, 26);
            this.txt_harga.TabIndex = 9;
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.BackColor = System.Drawing.Color.Transparent;
            this.stock.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock.ForeColor = System.Drawing.Color.OliveDrab;
            this.stock.Location = new System.Drawing.Point(41, 516);
            this.stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(54, 19);
            this.stock.TabIndex = 12;
            this.stock.Text = "Stock";
            // 
            // txt_stock
            // 
            this.txt_stock.BackColor = System.Drawing.Color.Honeydew;
            this.txt_stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.ForeColor = System.Drawing.Color.OliveDrab;
            this.txt_stock.Location = new System.Drawing.Point(42, 538);
            this.txt_stock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(204, 26);
            this.txt_stock.TabIndex = 11;
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.OliveDrab;
            this.search.Location = new System.Drawing.Point(394, 116);
            this.search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(66, 19);
            this.search.TabIndex = 14;
            this.search.Text = "Search";
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.Honeydew;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.OliveDrab;
            this.txt_search.Location = new System.Drawing.Point(504, 113);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(697, 26);
            this.txt_search.TabIndex = 13;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_add.Location = new System.Drawing.Point(272, 113);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(99, 37);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_update.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_update.Location = new System.Drawing.Point(272, 170);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(99, 37);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_delete.Location = new System.Drawing.Point(272, 226);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(99, 37);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_load.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_load.Location = new System.Drawing.Point(272, 280);
            this.btn_load.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(99, 37);
            this.btn_load.TabIndex = 18;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // seamarts
            // 
            this.seamarts.AutoSize = true;
            this.seamarts.BackColor = System.Drawing.Color.Transparent;
            this.seamarts.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seamarts.ForeColor = System.Drawing.Color.OliveDrab;
            this.seamarts.Location = new System.Drawing.Point(26, 22);
            this.seamarts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seamarts.Name = "seamarts";
            this.seamarts.Size = new System.Drawing.Size(220, 47);
            this.seamarts.TabIndex = 19;
            this.seamarts.Text = "SeaMarts !";
            // 
            // txt_image
            // 
            this.txt_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_image.Location = new System.Drawing.Point(42, 203);
            this.txt_image.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_image.Name = "txt_image";
            this.txt_image.Size = new System.Drawing.Size(204, 26);
            this.txt_image.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(238, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "find ur grocery at seamart~";
            // 
            // insert
            // 
            this.insert.AutoSize = true;
            this.insert.BackColor = System.Drawing.Color.Transparent;
            this.insert.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.ForeColor = System.Drawing.Color.OliveDrab;
            this.insert.Location = new System.Drawing.Point(37, 89);
            this.insert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(63, 19);
            this.insert.TabIndex = 21;
            this.insert.Text = "Image";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::seamarts.Properties.Resources.logout__1_;
            this.pictureBox2.Location = new System.Drawing.Point(1195, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 40);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(41, 116);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(205, 127);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1246, 590);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seamarts);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.Harga);
            this.Controls.Add(this.txt_harga);
            this.Controls.Add(this.deskripsi);
            this.Controls.Add(this.txt_deskripsi);
            this.Controls.Add(this.produk);
            this.Controls.Add(this.txt_produk);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kode);
            this.Controls.Add(this.txt_kode);
            this.Controls.Add(this.txt_image);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_kode;
        private System.Windows.Forms.Label kode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label produk;
        private System.Windows.Forms.TextBox txt_produk;
        private System.Windows.Forms.Label deskripsi;
        private System.Windows.Forms.TextBox txt_deskripsi;
        private System.Windows.Forms.Label Harga;
        private System.Windows.Forms.TextBox txt_harga;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label seamarts;
        private System.Windows.Forms.TextBox txt_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label insert;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

