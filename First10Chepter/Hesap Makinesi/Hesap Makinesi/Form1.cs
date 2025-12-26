using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        bool optDurum = false;
        double sonuc = 0;
        string opt = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RakamOlay(object sender, EventArgs e)
        {

            if (txtSonuc.Text == "0" || txtSonuc.Text == "00" || optDurum )
                txtSonuc.Clear();

            optDurum = false;
            Button btn = (Button)sender;
            txtSonuc.Text += btn.Text;


        }

        private void OptHesap(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;

            l1Sonuc.Text = l1Sonuc.Text + " " + txtSonuc.Text + " " + yeniOpt;
            switch (opt)
                {
                case "+":
                    txtSonuc.Text = (sonuc + double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "-":
                    txtSonuc.Text = (sonuc - double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "*":
                    txtSonuc.Text = (sonuc * double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "/":
                    txtSonuc.Text = (sonuc / double.Parse(txtSonuc.Text)).ToString();
                    break;

            }

            sonuc = double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = yeniOpt;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
            l1Sonuc.Text = "";
            opt = "";
            sonuc = 0;
            optDurum = false;
        }

        private void esit(object sender, EventArgs e)
        {
            l1Sonuc.Text = "";
            optDurum = true;

            switch (opt)
            {
                case "+":
                    txtSonuc.Text = (sonuc + double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "-":
                    txtSonuc.Text = (sonuc - double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "*":
                    txtSonuc.Text = (sonuc * double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "/":
                    txtSonuc.Text = (sonuc / double.Parse(txtSonuc.Text)).ToString();
                    break;

            }

            sonuc = double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = "";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = "0";
            }
            else if (optDurum)
            {
                txtSonuc.Text = "0";
            }

            if (!txtSonuc.Text.Contains(","))
            {
                txtSonuc.Text += ",";
            }
            optDurum = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
