using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace OpenClosedPrensible
{
    public class OdemeSistemi
    {
        public IOdemeTipi odemeTipi;
      

        public OdemeSistemi(IOdemeTipi odemeTipi)
        {
            this.odemeTipi = odemeTipi;
        }

        public void OdemeYap()
        {
            string a =this.odemeTipi.OdemeYapabilme();
            MessageBox.Show(a);

        }
    }
}
