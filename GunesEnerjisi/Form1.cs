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
    public partial class HibritSistem : Form
    {
        public HibritSistem()
        {
            InitializeComponent();
        }

       
        KaynakManager kaynakManager = new KaynakManager();
        Kombi kombi = new Kombi();
        GunesEnerjisi gunesEnerjisi = new GunesEnerjisi();
        Su su = new Su();
        Ev ev = new Ev();


        private void SuButton_Click(object sender, EventArgs e)
        {
            su.SetIstenenSuSicaklik(Convert.ToInt32(SuSicaklikBox.Text));
            
            SuSicaklikGoster.Text = kaynakManager.Karsilastir(su.GetIstenenSuSicaklik(), kombi, gunesEnerjisi).Calistir(su.GetIstenenSuSicaklik()).ToString();
            string bilgi2 = kaynakManager.Karsilastir(su.GetIstenenSuSicaklik(), kombi, gunesEnerjisi).ToString();
            BilgiBox2.Text = bilgi2.Substring(14);
        }


        private void EvButton_Click(object sender, EventArgs e)
        {
            ev.SetIstenenEvSicaklik(Convert.ToInt32(EvSicaklikBox.Text));

            
            EvSicaklikGoster.Text = kaynakManager.Karsilastir(ev.GetIstenenEvSicaklik(), kombi, gunesEnerjisi).Calistir(ev.GetIstenenEvSicaklik()).ToString();
            string bilgi1 = kaynakManager.Karsilastir(ev.GetIstenenEvSicaklik(), kombi, gunesEnerjisi).ToString();
            BilgiBox1.Text = bilgi1.Substring(14);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
