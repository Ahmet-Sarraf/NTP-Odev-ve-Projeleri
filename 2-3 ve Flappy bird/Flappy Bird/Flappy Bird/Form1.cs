using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        int hız = 5;
        int yerCekimi = 5;
        int puan = 0;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            kus.Top += yerCekimi;
            ustEngel.Left -= hız;
            
            altEngel.Left -= hız;
           
            puanText.Text = "Puan: " + puan;

            int engelArasiBosluk = 65; // Engeller arasındaki minimum boşluk miktarı
            int zeminYukseklik = 419;   // Zeminin üst sınırı (Top değeri)
            Random random = new Random();

            if (ustEngel.Left < 90) // Üst engel sola geçtiğinde yeniden konumlandır
            {
                ustEngel.Left = 500;
                altEngel.Left = 500;

                // Üst engelin rastgele konumunu belirle
                int ustEngelYukseklik = random.Next(-100, zeminYukseklik - engelArasiBosluk - altEngel.Height);
                ustEngel.Top = ustEngelYukseklik;

                // Alt engelin konumunu rastgele belirle, ama boşluk gereksinimini kontrol et
                int altEngelYukseklik;
                do
                {
                    altEngelYukseklik = random.Next(200, zeminYukseklik); // Alt engelin yüksekliğini rastgele belirle
                } while (altEngelYukseklik - (ustEngel.Top + ustEngel.Height) < engelArasiBosluk);

                altEngel.Top = altEngelYukseklik;

                // Puanı arttır
                puan++;
            }





            if (kus.Bounds.IntersectsWith(ustEngel.Bounds) || 
                kus.Bounds.IntersectsWith(altEngel.Bounds) || 
                kus.Bounds.IntersectsWith(zemin.Bounds) || (kus.Top < -25))
            {
                endGame();
            }

            if (puan % 10 == 0 && puan > 0)
            {
                hız++;
            }


        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yerCekimi = -5;
            }


        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yerCekimi = 5;
            }
        }

        private void endGame()
        {
            oyunSuresi.Stop();
            MessageBox.Show("Oyun Bitti" + "\n" + "Puanınız:" + puan);
        }

        private void zemin_Click(object sender, EventArgs e)
        {

        }

        private void altEngel_Click(object sender, EventArgs e)
        {

        }
       

        
        private void ustEngel_Click(object sender, EventArgs e)
        {

        }
    }
}


