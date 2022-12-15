using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == null || textBox1.Text == " " || textBox1.Text == " ")
            {
                MessageBox.Show("Lütfen Bilgi Giriniz");
            }
            else
            {

                listBox1.Items.Add(textBox1.Text.ToUpper());
                textBox1.Focus();

            }
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox2.Text == null || textBox2.Text == " " || textBox2.Text == " ")
            {
                MessageBox.Show("Lütfen Bilgi Giriniz");
            }
            else
            {

                listBox2.Items.Add(textBox2.Text.ToUpper());
                textBox2.Focus();

            }
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            System.Collections.ArrayList askeradaylari = new System.Collections.ArrayList();
            System.Collections.ArrayList iller = new System.Collections.ArrayList();
            Random rasgele = new Random();
            askeradaylari.AddRange(listBox1.Items);
            iller.AddRange(listBox2.Items);
            if (askeradaylari.Count == iller.Count)
{
int askersayisi = askeradaylari.Count;

for (int i = 0; i < askersayisi; i++) { int gelenaday = rasgele.Next(0, askeradaylari.Count); int gelenil = rasgele.Next(0, iller.Count); listBox3.Items.Add(askeradaylari[gelenaday].ToString() + " " +iller[gelenil].ToString()); askeradaylari.RemoveAt(gelenaday); iller.RemoveAt(gelenil); } } 
{


int askersayisi = askeradaylari.Count;

                System.Collections.ArrayList YedekListeiller = new System.Collections.ArrayList();
YedekListeiller.AddRange(iller);

for (int i = 0; i < askersayisi; i++) { int gelenaday = rasgele.Next(0, askeradaylari.Count); int gelenil; if (iller.Count != 0) { gelenil = rasgele.Next(0, iller.Count); listBox3.Items.Add(askeradaylari[gelenaday].ToString() + " " + iller[gelenil].ToString()); iller.RemoveAt(gelenil); } else { gelenil = rasgele.Next(0, YedekListeiller.Count); listBox3.Items.Add(askeradaylari[gelenaday].ToString() + " " + YedekListeiller[gelenil].ToString()); } askeradaylari.RemoveAt(gelenaday); } } 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("KASTAMONU");
        }
    }
}
