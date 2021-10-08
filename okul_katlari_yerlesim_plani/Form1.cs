using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace okul_katlari_yerlesim_plani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int katnumarasi;    
        private void göster_Click(object sender, EventArgs e)
        {
            katnumarasi = int.Parse(kat.Text);
            if (katnumarasi == 1)
            {
                richTextBox1.Text = " 9/A Sınıfı \n 9/B Sınıfı \n 9/C Sınıfı \n 9/D Sınıfı";
            }
            else if (katnumarasi == 2)
            {
                richTextBox1.Text = " 10/A Sınıfı \n 10/B Sınıfı \n 10/C Sınıfı \n 10/D Sınıfı";
            }
            else if (katnumarasi == 3)
            {
                richTextBox1.Text = " 11/A Sınıfı \n 11/B Sınıfı \n 11/C Sınıfı \n 11/D Sınıfı";
            }
            else
            {
                MessageBox.Show("Geçersiz rakam girdiniz, geçerli rakamlar:1,2,3");
            }

            
        }
    }
}
