using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opsionaal
{
    public partial class Form2 : Form
    {
        int i = 0;
        public Form2()
        {
            InitializeComponent();
        }

        void timer1_Tick(object sender, EventArgs e)
        {            
                if (i <= 99)
                {
                    
                    progressBar1.Value += 1;
                    angka.Text = progressBar1.Value.ToString();
                 i = progressBar1.Value;

                }
                else
                {
                timer1.Stop();
                MessageBox.Show("Proses Selesai bang");
                this.Close();
                    
                }
            
        }
    }
}
