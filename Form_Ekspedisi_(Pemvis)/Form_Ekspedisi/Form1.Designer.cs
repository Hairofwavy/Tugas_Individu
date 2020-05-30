namespace Form_Ekspedisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Telepon_pengirim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboKota_pengirim = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nama_pengirim = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Telepon_penerima = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nama_penerima = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboKota = new System.Windows.Forms.ComboBox();
            this.comboProvinsi = new System.Windows.Forms.ComboBox();
            this.Jalan = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Kodepos = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboJenis_barang = new System.Windows.Forms.ComboBox();
            this.Berat = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.nama_barang = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.comboAsuransi = new System.Windows.Forms.ComboBox();
            this.comboJenis_bungkus = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboJenis_eks = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.No_resi = new System.Windows.Forms.TextBox();
            this.Total_biaya = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 51);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Ekspedisi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Telepon_pengirim);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboKota_pengirim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Nama_pengirim);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.groupBox1.Location = new System.Drawing.Point(15, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 145);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Pengirim";
            // 
            // Telepon_pengirim
            // 
            this.Telepon_pengirim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.Telepon_pengirim.Location = new System.Drawing.Point(123, 66);
            this.Telepon_pengirim.Name = "Telepon_pengirim";
            this.Telepon_pengirim.Size = new System.Drawing.Size(157, 27);
            this.Telepon_pengirim.TabIndex = 11;
            this.Telepon_pengirim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "No. Telepon";
            // 
            // comboKota_pengirim
            // 
            this.comboKota_pengirim.FormattingEnabled = true;
            this.comboKota_pengirim.Location = new System.Drawing.Point(123, 101);
            this.comboKota_pengirim.Name = "comboKota_pengirim";
            this.comboKota_pengirim.Size = new System.Drawing.Size(155, 27);
            this.comboKota_pengirim.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Lengkap";
            // 
            // Nama_pengirim
            // 
            this.Nama_pengirim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.Nama_pengirim.Location = new System.Drawing.Point(123, 27);
            this.Nama_pengirim.Name = "Nama_pengirim";
            this.Nama_pengirim.Size = new System.Drawing.Size(157, 27);
            this.Nama_pengirim.TabIndex = 3;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(10, 104);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(36, 19);
            this.label30.TabIndex = 3;
            this.label30.Text = "Kota ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 27);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tanggal Pengiriman";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Telepon_penerima);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.nama_penerima);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.groupBox2.Location = new System.Drawing.Point(456, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 145);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Penerima";
            // 
            // Telepon_penerima
            // 
            this.Telepon_penerima.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.Telepon_penerima.Location = new System.Drawing.Point(123, 74);
            this.Telepon_penerima.Name = "Telepon_penerima";
            this.Telepon_penerima.Size = new System.Drawing.Size(157, 27);
            this.Telepon_penerima.TabIndex = 11;
            this.Telepon_penerima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 19);
            this.label11.TabIndex = 3;
            this.label11.Text = "Nama Lengkap";
            // 
            // nama_penerima
            // 
            this.nama_penerima.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.nama_penerima.Location = new System.Drawing.Point(123, 31);
            this.nama_penerima.Name = "nama_penerima";
            this.nama_penerima.Size = new System.Drawing.Size(157, 27);
            this.nama_penerima.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "No. Telepon";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboKota);
            this.groupBox3.Controls.Add(this.comboProvinsi);
            this.groupBox3.Controls.Add(this.Jalan);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.Kodepos);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.groupBox3.Location = new System.Drawing.Point(15, 433);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 180);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alamat Pengiriman";
            // 
            // comboKota
            // 
            this.comboKota.FormattingEnabled = true;
            this.comboKota.Location = new System.Drawing.Point(123, 62);
            this.comboKota.Name = "comboKota";
            this.comboKota.Size = new System.Drawing.Size(149, 27);
            this.comboKota.TabIndex = 19;
            this.comboKota.SelectedIndexChanged += new System.EventHandler(this.comboKota_SelectedIndexChanged);
            // 
            // comboProvinsi
            // 
            this.comboProvinsi.FormattingEnabled = true;
            this.comboProvinsi.Location = new System.Drawing.Point(123, 30);
            this.comboProvinsi.Name = "comboProvinsi";
            this.comboProvinsi.Size = new System.Drawing.Size(149, 27);
            this.comboProvinsi.TabIndex = 18;
            this.comboProvinsi.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Jalan
            // 
            this.Jalan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.Jalan.Location = new System.Drawing.Point(123, 98);
            this.Jalan.Name = "Jalan";
            this.Jalan.Size = new System.Drawing.Size(149, 27);
            this.Jalan.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 19);
            this.label16.TabIndex = 13;
            this.label16.Text = "Detail Jalan";
            // 
            // Kodepos
            // 
            this.Kodepos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.Kodepos.Location = new System.Drawing.Point(123, 131);
            this.Kodepos.Name = "Kodepos";
            this.Kodepos.Size = new System.Drawing.Size(149, 27);
            this.Kodepos.TabIndex = 10;
            this.Kodepos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox12_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 19);
            this.label12.TabIndex = 7;
            this.label12.Text = "Kode Pos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 19);
            this.label14.TabIndex = 5;
            this.label14.Text = "Kota/Kabupaten";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 19);
            this.label15.TabIndex = 3;
            this.label15.Text = "Provinsi";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.comboJenis_barang);
            this.groupBox4.Controls.Add(this.Berat);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.nama_barang);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.groupBox4.Location = new System.Drawing.Point(15, 224);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(313, 180);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kg";
            // 
            // comboJenis_barang
            // 
            this.comboJenis_barang.FormattingEnabled = true;
            this.comboJenis_barang.Location = new System.Drawing.Point(131, 104);
            this.comboJenis_barang.Name = "comboJenis_barang";
            this.comboJenis_barang.Size = new System.Drawing.Size(149, 27);
            this.comboJenis_barang.TabIndex = 17;
            // 
            // Berat
            // 
            this.Berat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.Berat.Location = new System.Drawing.Point(131, 65);
            this.Berat.Name = "Berat";
            this.Berat.Size = new System.Drawing.Size(43, 27);
            this.Berat.TabIndex = 12;
            this.Berat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox16_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 19);
            this.label17.TabIndex = 5;
            this.label17.Text = "Berat";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 19);
            this.label19.TabIndex = 3;
            this.label19.Text = "Nama Barang";
            // 
            // nama_barang
            // 
            this.nama_barang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.nama_barang.Location = new System.Drawing.Point(131, 31);
            this.nama_barang.Name = "nama_barang";
            this.nama_barang.Size = new System.Drawing.Size(149, 27);
            this.nama_barang.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 107);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 19);
            this.label20.TabIndex = 8;
            this.label20.Text = "Jenis Barang";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.comboAsuransi);
            this.groupBox5.Controls.Add(this.comboJenis_bungkus);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.comboJenis_eks);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.groupBox5.Location = new System.Drawing.Point(456, 224);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(313, 180);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ekspedisi";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(18, 102);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(57, 19);
            this.label25.TabIndex = 22;
            this.label25.Text = "Asuransi";
            // 
            // comboAsuransi
            // 
            this.comboAsuransi.FormattingEnabled = true;
            this.comboAsuransi.Location = new System.Drawing.Point(131, 99);
            this.comboAsuransi.Name = "comboAsuransi";
            this.comboAsuransi.Size = new System.Drawing.Size(149, 27);
            this.comboAsuransi.TabIndex = 19;
            // 
            // comboJenis_bungkus
            // 
            this.comboJenis_bungkus.FormattingEnabled = true;
            this.comboJenis_bungkus.Location = new System.Drawing.Point(131, 66);
            this.comboJenis_bungkus.Name = "comboJenis_bungkus";
            this.comboJenis_bungkus.Size = new System.Drawing.Size(149, 27);
            this.comboJenis_bungkus.TabIndex = 21;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(19, 69);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(107, 19);
            this.label24.TabIndex = 20;
            this.label24.Text = "Jenis Pembungkus";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 19);
            this.label8.TabIndex = 19;
            // 
            // comboJenis_eks
            // 
            this.comboJenis_eks.FormattingEnabled = true;
            this.comboJenis_eks.Location = new System.Drawing.Point(131, 34);
            this.comboJenis_eks.Name = "comboJenis_eks";
            this.comboJenis_eks.Size = new System.Drawing.Size(149, 27);
            this.comboJenis_eks.TabIndex = 18;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(19, 34);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(88, 19);
            this.label28.TabIndex = 3;
            this.label28.Text = "Jenis Ekspedisi";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.dateTimePicker1);
            this.groupBox6.Controls.Add(this.label34);
            this.groupBox6.Controls.Add(this.No_resi);
            this.groupBox6.Controls.Add(this.Total_biaya);
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label29);
            this.groupBox6.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.groupBox6.Location = new System.Drawing.Point(456, 433);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(313, 180);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Detail Pengiriman";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Rp.";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(205, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 32);
            this.button1.TabIndex = 26;
            this.button1.Text = "Proses Detail";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(19, 101);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(47, 19);
            this.label34.TabIndex = 3;
            this.label34.Text = "No Resi";
            // 
            // No_resi
            // 
            this.No_resi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.No_resi.Location = new System.Drawing.Point(139, 98);
            this.No_resi.Name = "No_resi";
            this.No_resi.Size = new System.Drawing.Size(149, 27);
            this.No_resi.TabIndex = 18;
            // 
            // Total_biaya
            // 
            this.Total_biaya.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.Total_biaya.Location = new System.Drawing.Point(167, 62);
            this.Total_biaya.Name = "Total_biaya";
            this.Total_biaya.Size = new System.Drawing.Size(121, 27);
            this.Total_biaya.TabIndex = 27;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(19, 66);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(68, 19);
            this.label26.TabIndex = 22;
            this.label26.Text = "Total Biaya";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(19, 66);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(0, 19);
            this.label29.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(579, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 35);
            this.button2.TabIndex = 25;
            this.button2.Text = "Kirim";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(679, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 35);
            this.button3.TabIndex = 26;
            this.button3.Text = "Selesai";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(785, 642);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CoolEkspedisi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nama_pengirim;
        private System.Windows.Forms.TextBox Telepon_pengirim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Telepon_penerima;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox nama_penerima;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Jalan;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Kodepos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboJenis_barang;
        private System.Windows.Forms.TextBox Berat;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox nama_barang;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboKota;
        private System.Windows.Forms.ComboBox comboProvinsi;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox comboAsuransi;
        private System.Windows.Forms.ComboBox comboJenis_bungkus;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboJenis_eks;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox comboKota_pengirim;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox No_resi;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Total_biaya;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
    }
}

