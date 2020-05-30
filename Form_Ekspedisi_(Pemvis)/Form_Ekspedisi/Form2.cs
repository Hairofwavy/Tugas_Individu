using System;
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
    public partial class Form2 : Form
    {
        //public static Form1 form1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Name_Out.Text = Form1.value[1];
            Numb_Resi.Text = Form1.value[0];
            Date_Send.Text = Form1.value[2];
            number_Sender.Text = Form1.value[7];
            Name_Receiver.Text = Form1.value[3];
            Address_Re.Text = Form1.value[8];
            Numb_Re.Text = Form1.value[4];
            Ber_at.Text = Form1.value[9];
            total_harga.Text = Form1.value[5];
            BungKus.Text = Form1.value[10];
            Assu.Text = Form1.value[11];
            eks.Text = Form1.value[12];
            Name_Stuff.Text = Form1.value[6];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Close();
        }

        private void Tag_Addres_Click(object sender, EventArgs e)
        {

        }

        private void Address_Sender_Click(object sender, EventArgs e)
        {

        }
    }
}
