using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesEnerjisi
{
    class GunesEnerjisi : IKaynak
    {

        public int Calistir(int sicaklik)
        {
            return sicaklik;
        }


        private int sicaklik = 38;

        public int GetSicaklik()
        {
            return sicaklik;
        }

        public void SetSicaklik(int value)
        {
            sicaklik = value;
        }
    }
}
