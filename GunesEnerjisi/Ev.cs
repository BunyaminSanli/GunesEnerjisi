using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesEnerjisi
{
    class Ev
    {
        private int evSicaklik;

        public int GetEvSicaklik()
        {
            return evSicaklik;
        }


        private int istenenEvSicaklik;

        public int GetIstenenEvSicaklik()
        {
            return istenenEvSicaklik;
        }

        public void SetIstenenEvSicaklik(int value)
        { 
            istenenEvSicaklik = value;
        }

       
    }
}
