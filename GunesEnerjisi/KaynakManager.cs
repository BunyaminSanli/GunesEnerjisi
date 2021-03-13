using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesEnerjisi
{
    class KaynakManager
    {
       
        public IKaynak Karsilastir(int istenenSicaklik, Kombi kombi,  GunesEnerjisi gunesEnerjisi)
        {
            if (istenenSicaklik <= gunesEnerjisi.GetSicaklik())
            {
                return gunesEnerjisi;
            }

            else
            {
                return kombi;
            }
        }
    }
}
