using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araba_Yarısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            int x1 = pictureBox1.Location.X;
            int y1 = pictureBox1.Location.Y;

            int x2 = pictureBox2.Location.X;
            int y2 = pictureBox2.Location.Y;


            if (e.KeyCode == Keys.Up)
                y1 -= 5;
            if (e.KeyCode == Keys.W)
                y2 -= 5;

            pictureBox1.Location = new Point(x1, y1);
            pictureBox2.Location = new Point(x2, y2);


            if (y1 < 0)
            {
                MessageBox.Show("Tebrikler Beyaz Araba Kazandı");
             
            }
            if (y2 < 0)
            {
                MessageBox.Show("Tebrikler Kırmızı Araba Kazandı");

            }
        }
    }
}
