using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Painter
{
    public partial class Form1 : Form
    {
        Bitmap kagit;      
        Graphics ressam;   
        bool ciziyorMu = false; 
        Point baslangicNoktasi; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kagit = new Bitmap(Tuval.Width, Tuval.Height);

            ressam = Graphics.FromImage(kagit);

            ressam.Clear(Color.White);

            Tuval.Image = kagit;

            Siyah.Checked = true;
            Orta.Checked = true;
        }

        private Color SeciliRengiAl()
        {
            if (Silgi.Checked) return Color.White; 
            if (Kırmızı.Checked) return Color.Red;
            if (Mavi.Checked) return Color.Blue;
            if (Yesil.Checked) return Color.Green; 
            return Color.Black;
        }

        private int SeciliBoyutuAl()
        {
            if (Minik.Checked) return 3;
            if (Kocaman.Checked) return 15;
            return 8;
        }

        private void Tuval_MouseDown(object sender, MouseEventArgs e)
        {
            ciziyorMu = true; 
            baslangicNoktasi = e.Location; 
        }

        private void Tuval_MouseMove(object sender, MouseEventArgs e)
        {
            if (ciziyorMu)
            {
                Pen kalem = new Pen(SeciliRengiAl(), SeciliBoyutuAl());

                kalem.StartCap = LineCap.Round;
                kalem.EndCap = LineCap.Round;

                Point bitisNoktasi = e.Location;
                ressam.DrawLine(kalem, baslangicNoktasi, bitisNoktasi);

                Tuval.Invalidate();

                baslangicNoktasi = bitisNoktasi;
            }
        }

        private void Tuval_MouseUp(object sender, MouseEventArgs e)
        {
            ciziyorMu = false; 
        }

        private void Temizle_Click_1(object sender, EventArgs e)
        {
            ressam.Clear(Color.White);
            Tuval.Invalidate();
        }

    }
}