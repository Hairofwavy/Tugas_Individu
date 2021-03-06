﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Ekspedisi
{
    public partial class Form1 : Form
    {
        //inisilisasi fungsi
        public static string[] value = new String[20];
        public static int[] rumus = new int[10];
        //------------------------------------------

       //insialisasi pengacak resi 
        Random rand = new Random();
        char[] karakter = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz12345678".ToArray();
        string output;

        void generator(int a)
        {
            output = null;
            for(int i = 0; i < a; i++)
            {
                output += karakter[rand.Next(0, karakter.Length)];
            }
            No_resi.Text = output;
        }

 /*       private berat()
        {
            //rumus berat barang
            int b = int.Parse(textBox16.Text) * 10000;
        }*/

        public Form1()
        {
            InitializeComponent();
            comboProvinsi.Items.AddRange(new Object[] { "Jawa Timur", "Jawa Tengah"});
            comboJenis_barang.Items.AddRange(new Object[] { "Mudah Pecah", "Tidak Mudah Pecah"});
            comboJenis_eks.Items.AddRange(new Object[] { "Reguler", "Ekspress" });
            comboJenis_bungkus.Items.AddRange(new Object[] { "Bubble Wrap", "Kayu", "Tidak Ada" });
            comboAsuransi.Items.AddRange(new Object[] { "Secure 1","Secure 2", "Tidak Ada" });
            comboKota_pengirim.Items.AddRange(new Object[] { "Surabaya", "Blitar", "Semarang", "Wonosobo","Kediri"});
        }

        public void IsEmpty(System.Windows.Forms.TextBox a)
        {
            a.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            value[0] = No_resi.Text;//no resi
            value[1] = Nama_pengirim.Text;//nama pengirim
            value[2] = dateTimePicker1.Text;//tanggal
            value[3] = nama_penerima.Text;//nama penerima
            value[4] = Telepon_penerima.Text;//nomor telepon
            value[5] = Total_biaya.Text;//total harga 
            value[6] = nama_barang.Text;//nama barang
            value[7] = Telepon_pengirim.Text;//nomor Pengirim
            value[8] = comboKota.Text;//nomor telepon
            value[9] = Berat.Text;//berat
            value[10] = comboJenis_bungkus.Text;//bungkus
            value[11] = comboAsuransi.Text;//asuransi
            value[12] = comboJenis_eks.Text;//Ekspedisi

            if (Nama_pengirim.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            
            else if (Telepon_pengirim.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (Telepon_penerima.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (No_resi.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (nama_penerima.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (Total_biaya.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (Kodepos.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (Jalan.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (Berat.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (nama_barang.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            
            else if (comboJenis_barang.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (comboProvinsi.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (comboKota.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (comboJenis_eks.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (comboJenis_bungkus.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (comboAsuransi.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (comboKota_pengirim.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else if (Telepon_penerima.Text == "")
            {
                String message = "Data Harus Diisi Semua";
                MessageBox.Show(message);
            }
            else
            {
                Form2 pindah = new Form2();
                pindah.Show();
                this.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object nilai = comboProvinsi.SelectedItem;
            String Province = nilai.ToString();
            if (Province == "Jawa Timur") 
            {
                comboKota.Items.Clear();
                comboKota.Items.AddRange(new object[] { "Surabaya", "Blitar","Kediri" });
            }
            else 
            {
                comboKota.Items.Clear();
                comboKota.Items.AddRange(new object[] { "Wonosobo", "Semarang" });
            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generator(12);

            int harga;

            //berat
            rumus[0] = int.Parse(Berat.Text) * 10000;

            //rumus jenis ekspedisi
            if (comboJenis_eks.Text == "Reguler")
            {
                rumus[2] = 10000;
            }
            else
            {
                rumus[2] = 12000;
            }

            //rumus jenis pembungkus
            if (comboJenis_bungkus.Text == "Bubble Wrap")
            {
                rumus[3] = 5000;
            }
            else if (comboJenis_bungkus.Text == "Kayu")
            {
                rumus[3] = 20000;
            }
            else
            {
                rumus[3] = 0;
            }

            //rumus asuransi
            if (comboAsuransi.Text == "Secure 1")
            {
                rumus[4] = 1000;
            } 
            else if(comboAsuransi.Text == "Secure 2")
            {
                rumus[4] = 5000;
            }
            else
            {
                rumus[4] = 0;
            }

            //rumus ongkir
            if (comboKota.Text == "Surabaya" && comboKota_pengirim.Text == "Blitar" || comboKota.Text == "Blitar" && comboKota_pengirim.Text == "Surabaya")
            {
                rumus[5] = 17000;
            }
            if (comboKota.Text == "Surabaya" && comboKota_pengirim.Text == "Kediri" || comboKota.Text == "Kediri" && comboKota_pengirim.Text == "Surabaya")
            {
                rumus[5] = 15000;
            }
            if (comboKota.Text == "Surabaya" && comboKota_pengirim.Text == "Semarang" || comboKota.Text == "Semarang" && comboKota_pengirim.Text == "Surabaya")
            {
                rumus[5] = 25000;
            }
            if (comboKota.Text == "Surabaya" && comboKota_pengirim.Text == "Wonosobo" || comboKota.Text == "Wonosoobo" && comboKota_pengirim.Text == "Surabaya")
            {
                rumus[5] = 27000;
            }
            if (comboKota.Text == "Blitar" && comboKota_pengirim.Text == "Kediri" || comboKota.Text == "Kediri" && comboKota_pengirim.Text == "Blitar")
            {
                rumus[5] = 12000;
            }
            if (comboKota.Text == "Blitar" && comboKota_pengirim.Text == "Semarang" || comboKota.Text == "Semarang" && comboKota_pengirim.Text == "Blitar")
            {
                rumus[5] = 18000;
            }
            if (comboKota.Text == "Blitar" && comboKota_pengirim.Text == "Wonosobo" || comboKota.Text == "Wonosobo" && comboKota_pengirim.Text == "Blitar")
            {
                rumus[5] = 17000;
            }
            if (comboKota.Text == "Kediri" && comboKota_pengirim.Text == "Semarang" || comboKota.Text == "Semarang" && comboKota_pengirim.Text == "Kediri")
            {
                rumus[5] = 19000;
            }
            if (comboKota.Text == "Kediri" && comboKota_pengirim.Text == "Wonosobo" || comboKota.Text == "Wonosobo" && comboKota_pengirim.Text == "Kediri")
            {
                rumus[5] = 20000;
            }
            if (comboKota.Text == "Wonosobo" && comboKota_pengirim.Text == "Semarang" || comboKota.Text == "Semarang" && comboKota_pengirim.Text == "Wonosobo")
            {
                rumus[5] = 10000;
            }
            else 
            {
                rumus[5] = 5000;
            }

            //Rumus Total Harga
            harga = rumus[1] + rumus[2] + rumus[3] + rumus[4] + rumus[5] + rumus[0];
            Total_biaya.Text = harga.ToString();
        }

        private void comboKota_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
