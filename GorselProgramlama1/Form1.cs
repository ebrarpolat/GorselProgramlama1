using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlama1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yas;
            string cinsiyet;
            yas = Convert.ToInt32(textBox1.Text);


            if (radioButton1.Checked)
            {
                cinsiyet = "KADIN";
                if (yas < 18)
                {
                    label1.Text = ("18 Yaşından küçüksünüz izniniz yok.");

                }
                else if (yas >= 18)
                {
                    label1.Text = ("Merhaba Hanımefendi, Hoşgeldiniz");
                }
            }
            else if (radioButton2.Checked)
            {
                cinsiyet = "ERKEK";
                if (yas < 18)
                {
                    label1.Text = ("18 Yaşından küçüksünüz izniniz yok.");

                }
                else if (yas >= 18)
                {
                    label1.Text = ("Merhaba Beyefendi, Hoşgeldiniz");
                }
            }
        }
    }
}
