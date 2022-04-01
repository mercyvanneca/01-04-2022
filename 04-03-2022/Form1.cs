using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_03_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Kali_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TxtBox_Bilangan1.Text);
            int num2 = int.Parse(TxtBox_Bilangan2.Text);
            int sum = num1 * num2;
            TxtBox_Hasil.Text = sum.ToString();

        }

        private void TxtBox_Bilangan1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBox_Hasil_TextChanged(object sender, EventArgs e)
        {

        }


        private void Button_Bagi_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TxtBox_Bilangan1.Text);
            int num2 = int.Parse(TxtBox_Bilangan2.Text);
            int sum = num1 / num2;
            TxtBox_Hasil.Text = sum.ToString();
        }

        private void Button_Tambah_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TxtBox_Bilangan1.Text);
            int num2 = int.Parse(TxtBox_Bilangan2.Text);
            int sum = num1 + num2;
            TxtBox_Hasil.Text = sum.ToString();
        }

        private void Button_Kurang_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TxtBox_Bilangan1.Text);
            int num2 = int.Parse(TxtBox_Bilangan2.Text);
            int sum = num1 - num2;
            TxtBox_Hasil.Text = sum.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            TxtBox_Bilangan1.Text = "";
            TxtBox_Bilangan2.Text = "";
            TxtBox_Hasil.Text = "";
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
