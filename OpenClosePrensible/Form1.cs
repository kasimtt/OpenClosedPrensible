using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenClosedPrensible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = comboBox1.Text;
            
            if(a == "nakit")
            {

                OdemeSistemi odemeSistemi = new OdemeSistemi(new NakitOdeme());
                odemeSistemi.OdemeYap();
                

            }
            else if (a=="kredi kartı")
            {
                OdemeSistemi odemeSistemi = new OdemeSistemi(new KrediKartiOdeme());
                odemeSistemi.OdemeYap();
            }
            else if(a == "bitcoin")
            {
                OdemeSistemi odemeSistemi = new OdemeSistemi(new BitcoinOdeme());
                odemeSistemi.OdemeYap();
            }
            
           


        }
    }
}
