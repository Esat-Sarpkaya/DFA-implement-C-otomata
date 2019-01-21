using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomat_projesi
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var list_giris = new List<string>();
            var list_yol = new List<string>();
            var list_cikis = new List<string>();

			foreach (var item in listBox1.Items)
			{
				list_giris.Add(item.ToString());
			}
            foreach (var item in listBox2.Items)
            {
                list_yol.Add(item.ToString());
            }
            foreach(var item in listBox3.Items)
            {
                list_cikis.Add(item.ToString());
            }
            //foreach (var item in list)
            //{
            //	MessageBox.Show(item.ToString());
            //}
            if (textBox4.Text.Length>0 && textBox5.Text.Length>0 && textBox4.Text.Length==textBox5.Text.Length)
            {
                string istenen = textBox4.Text.ToString();
                string verilen_yol = textBox5.Text.ToString();

                string cikti = "";


                for (int i = 0; i < istenen.Length; i++)
                {
                    int output_counter = 0;
                    for (int j = 0; j < list_giris.Count; j++)
                    {
                        if (list_giris[j][0].ToString() == istenen[i].ToString() && list_yol[j][0].ToString() == verilen_yol[i].ToString())
                        {
                            cikti = cikti + list_cikis[j][0].ToString();
                            output_counter += 1;
                        }
                    }
                    if(output_counter==0)
                    {
                        cikti = cikti + "-";
                    }
                }
 
                label10.Text = istenen;
                label9.Text = verilen_yol;
                label8.Text = cikti;
                textBox4.Clear();
                textBox5.Clear();
            }
            else
                MessageBox.Show("Giriş ve Yol Bilgilerini Eksiksiz Giriniz");
		}

		private void button1_Click(object sender, EventArgs e)
		{


            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
            {
                listBox1.Items.Add(textBox1.Text.ToString());
                listBox2.Items.Add(textBox2.Text.ToString());
                listBox3.Items.Add(textBox3.Text.ToString());
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Durum bilgilerini eksiksiz giriniz");
            }
    
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            listBox1.SelectedIndex = lb.SelectedIndex;
            listBox2.SelectedIndex = lb.SelectedIndex;
            listBox3.SelectedIndex = lb.SelectedIndex;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            listBox1.SelectedIndex = lb.SelectedIndex;
            listBox2.SelectedIndex = lb.SelectedIndex;
            listBox3.SelectedIndex = lb.SelectedIndex;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            listBox1.SelectedIndex = lb.SelectedIndex;
            listBox2.SelectedIndex = lb.SelectedIndex;
            listBox3.SelectedIndex = lb.SelectedIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
