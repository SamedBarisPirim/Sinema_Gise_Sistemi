using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaSatıs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int odenecektutar=0;
        private void button2_Click(object sender, EventArgs e)
        {
            int hesap,adet,misir,su,gazoz,toplam;
            misir = Convert.ToInt32(textBox2.Text);
            su = Convert.ToInt32(textBox3.Text);
            gazoz = Convert.ToInt32(textBox4.Text);
            if (comboBox1.SelectedIndex == 0)
            {
                adet = Convert.ToInt32(textBox1.Text);
                hesap = 18 * adet;
                toplam = hesap + 5 * misir + su * 3 + gazoz * 7;
                label15.Text = "Tutar :" + toplam.ToString() + "TL";
                odenecektutar = odenecektutar + toplam;
                label16.Text = "Kasa :" + odenecektutar.ToString() + "TL";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                adet = Convert.ToInt32(textBox1.Text);
                hesap = 14 * adet;
                toplam = hesap + 5 * misir + su * 3 + gazoz * 7;
                label15.Text = "Tutar :" + toplam.ToString() + "TL";
                odenecektutar = odenecektutar + toplam;
                label16.Text = "Kasa :" + odenecektutar.ToString() + "TL";

            
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                adet = Convert.ToInt32(textBox1.Text);
                hesap = 10 * adet;
                toplam = hesap + 5 * misir + su * 3 + gazoz * 7;
                label15.Text = "Tutar :"+ toplam.ToString() + "TL";
                odenecektutar = odenecektutar + toplam;
                label16.Text = "Kasa :"+ odenecektutar.ToString() + "TL";

            }
            
            
            

            


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
    }
}
