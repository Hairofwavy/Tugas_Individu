using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Penghitungan;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double result = 0;
        String operation = "";
        bool input_angka = true;
        bool operasi = false;
        Operasi operator_dasar = new Operasi();


        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (input_angka == true && operasi == true))
                txtDisplay.Text = "";
            input_angka = false;
            Button num = (Button)sender;
            if (num.Text == ",")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + num.Text;
            }
            else
                txtDisplay.Text = txtDisplay.Text + num.Text;
        }



        private void clear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOp.Text = "";
            result = 0;
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }

        }

        private void operator_mtkdas(object sender, EventArgs e)
        {
            if (operasi == false)
            {
                Button num = (Button)sender;
                operation = num.Text;
                result = Double.Parse(txtDisplay.Text);
                lblShowOp.Text = System.Convert.ToString(result) + " " + operation;
                txtDisplay.Text = "0";

            }
            else
            {
                switch (operation)
                {
                    case "+":
                        txtDisplay.Text = Convert.ToString(operator_dasar.tambah(result, Double.Parse(txtDisplay.Text)));
                        break;
                    case "-":
                        txtDisplay.Text = Convert.ToString(operator_dasar.kurang(result, Double.Parse(txtDisplay.Text)));
                        break;
                    case "*":
                        txtDisplay.Text = Convert.ToString(operator_dasar.perkalian(result, Double.Parse(txtDisplay.Text)));
                        break;
                    case "/":
                        txtDisplay.Text = Convert.ToString(operator_dasar.pembagian(result, Double.Parse(txtDisplay.Text)));
                        break;
                }
                Button num = (Button)sender;
                operation = num.Text;
                result = Double.Parse(txtDisplay.Text);
                lblShowOp.Text = txtDisplay.Text + " " + operation;
                txtDisplay.Text = "0";

            }
            input_angka = true; operasi = true;
        }

        private void hasil_Click(object sender, EventArgs e)
        {
            lblShowOp.Text = lblShowOp.Text + " " + txtDisplay.Text + " =";
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = Convert.ToString(operator_dasar.tambah(result, Double.Parse(txtDisplay.Text)));
                    break;
                case "-":
                    txtDisplay.Text = Convert.ToString(operator_dasar.kurang(result, Double.Parse(txtDisplay.Text)));
                    break;
                case "*":
                    txtDisplay.Text = Convert.ToString(operator_dasar.perkalian(result, Double.Parse(txtDisplay.Text)));
                    break;
                case "/":
                    txtDisplay.Text = Convert.ToString(operator_dasar.pembagian(result, Double.Parse(txtDisplay.Text)));
                    break;
            }
            input_angka = true; operasi = false;
        }

        private void ON_Click(object sender, EventArgs e)
        {
        txtDisplay.Text = "0";
        txtDisplay.Enabled = true;
        button1.Enabled = true;
        button2.Enabled = true;
        button3.Enabled = true;
        button4.Enabled = true;
        button5.Enabled = true;
        button6.Enabled = true;
        button7.Enabled = true;
        button8.Enabled = true;
        button9.Enabled = true;
        koma.Enabled = true;
        button11.Enabled = true;
        hapus.Enabled = true;
        tambah.Enabled = true;
        kurang.Enabled = true;
        kali.Enabled = true;
        bagi.Enabled = true;
        kosong.Enabled = true;
        Hasil.Enabled = true;

    }
        private void OFF_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            txtDisplay.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            koma.Enabled = false;
            button11.Enabled = false;
            hapus.Enabled = false;
            tambah.Enabled = false;
            kurang.Enabled = false;
            kali.Enabled = false;
            bagi.Enabled = false;
            kosong.Enabled = false;
            Hasil.Enabled = false;

        }
     
    }
}

