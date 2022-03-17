using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrensible
{
    public interface IOdemeTipi
    {
         string OdemeYapabilme();
    }

    public class KrediKartiOdeme : IOdemeTipi
    {
 

        public string OdemeYapabilme()
        {
            //kredi karti ile odeme yapıldı
            return "kredi karti ile odeme yapıldı...";
        }
    }

    public class NakitOdeme : IOdemeTipi
    {
        public string OdemeYapabilme()
        {
            //nakit odeme yapıldi
            return "nakit odeme yapıldi";
        }
    }

    public class BitcoinOdeme : IOdemeTipi
    {
        public string OdemeYapabilme()
        {
            // bitcoin odeme
            return "bitcoin ile odeme yapıldi";
        }
    }
}
