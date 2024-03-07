using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiziUyg2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sonuc.Text = "";
            listBox1.Items.Clear();
            int Adet = int.Parse(adet.Text);
            int YD= int.Parse(yuksekDeger.Text);
            int DD=int.Parse(dusukDeger.Text);
            int İS=int.Parse(istenenSayi.Text);
            int İSA = 0;
            int[] sayilar= new int[Adet];
            Random random = new Random();

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = random.Next(DD, YD);

                listBox1.Items.Add(sayilar[i]);
            }
            foreach (int i in sayilar)
            {
                if (İS == sayilar[i])
                {
                    İSA++;
                }

            }
                //if (İSA == 0)
                //{
                //    sonuc.Text=("Sayı bulunamadı");
                //}
                //else 
                //{
                //    sonuc.Text = (İSA.ToString());
                //}
            }
    }
}
