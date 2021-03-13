using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunesEnerjisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 4;
        KaynakManager kaynakManager = new KaynakManager();
        Kombi kombi = new Kombi();
        GunesEnerjisi gunesEnerjisi = new GunesEnerjisi();
        Su su = new Su();
        Ev ev = new Ev();
        private void SuButton_Click(object sender, EventArgs e)
        {
            su.SetIstenenSuSicaklik(Convert.ToInt32(SuSicaklikBox.Text));
            SuSicaklikGoster.Text = kaynakManager.Karsilastir(su.GetIstenenSuSicaklik(), kombi, gunesEnerjisi).Calistir(su.GetIstenenSuSicaklik()).ToString();
            BilgiBox.Text = kaynakManager.Karsilastir(su.GetIstenenSuSicaklik(), kombi, gunesEnerjisi).ToString();
        }

        private void EvButton_Click(object sender, EventArgs e)
        {
            ev.SetIstenenEvSicaklik(Convert.ToInt32(EvSicaklikBox.Text));

            //bunun olacagına ihtimal vermemistim 
            EvSicaklikGoster.Text = kaynakManager.Karsilastir(ev.GetIstenenEvSicaklik(), kombi, gunesEnerjisi).Calistir(ev.GetIstenenEvSicaklik()).ToString();
            BilgiBox.Text = kaynakManager.Karsilastir(ev.GetIstenenEvSicaklik(), kombi, gunesEnerjisi).ToString();
        }

        private void SuSicaklikBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EvSicaklikBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EvSicaklikGoster_TextChanged(object sender, EventArgs e)
        {

        }

        private void SuSicaklikGoster_TextChanged(object sender, EventArgs e)
        {

        }

        private void BilgiBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
