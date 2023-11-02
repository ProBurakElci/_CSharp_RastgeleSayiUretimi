using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_RastgeleSayiUretimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            //int uretilenSayi = rnd.Next();

            //this.Text = rnd.Next(20).ToString();

            //rnd.Next(20) : 0 ile 20 arasında(20 hariç) rasgele sayı üretir.
            //int uretilenSayi = rnd.Next(20);

            //rnd.Next(10, 20) : 10 ile 20 arasında(20 hariç, 10 dahil) int tipinde rasgele sayı üretir.
           
            //int uretilenSayi = rnd.Next(10, 20);

            //rnd.NextDouble(); 0.0 ile 1.0 arasında double tipinde rasgele sayı üretir.
            int uretilenSayi = rnd.Next(1, 100);
            //double uretilenSayi = rnd.NextDouble() * 10;

            lblRandomSayi.Text = uretilenSayi.ToString();

            this.Text = uretilenSayi + "$";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblRandomSayi_Click(object sender, EventArgs e)
        {

        }
    }
}
