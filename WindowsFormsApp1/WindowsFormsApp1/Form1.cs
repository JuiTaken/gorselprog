using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int s1, s2, sonuc;
                s1 = Convert.ToInt32(textBox1.Text);
                s2 = Convert.ToInt32(textBox2.Text);
                if (radioButton1.Checked)
                {
                    sonuc = s1 - s2;
                    label3.Text = "SONUÇ = " + sonuc;

                }
                else if (radioButton2.Checked)
                {
                    sonuc = s1 * s2;
                    label3.Text = "SONUÇ = " + sonuc;
                }
                else if (radioButton3.Checked)
                {
                    sonuc = s1 + s2;

                    label3.Text = "SONUÇ = " + sonuc;
                }
                else if (radioButton4.Checked)
                {
                    sonuc = s1 / s2;

                    label3.Text = "SONUÇ = " + sonuc;
                }
                else label3.Text = "Lütfen Geçerli Bir İşlem Giriniz !";
            }

            else
                label3.Text = "Lütfen Tüm alanları doldurunuz !";
            

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
