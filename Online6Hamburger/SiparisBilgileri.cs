using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online6Hamburger
{
    public partial class SiparisBilgileri : Form
    {


        public SiparisBilgileri()
        {
            InitializeComponent();
        }
        decimal toplam = 0;
        decimal Top = 0;
        private void lstTumSiparisler_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void SiparisBilgileri_Load(object sender, EventArgs e)
        {

            if (SiparisOlustur.tumSiparisler.Count > 0)
            {

                foreach (var item in SiparisOlustur.tumSiparisler)
                {
                    lstTumSiparisler.Items.Add(item);
                }

            }

            foreach (var item in SiparisOlustur.tumSiparisler)
            {
                toplam += item.Hesapla();
            }
            lblCiro.Text = toplam.ToString();

            lblToplamSiparis.Text=SiparisOlustur.tumSiparisler.Count.ToString();


            foreach (var item in SiparisOlustur.tumSiparisler)
            {
                foreach (var ekstra in item.EkstraMalzeme)
                {
                    Top += ekstra.Fiyat;
                }
            }
            lblEkstraMalzemeGeliri.Text = Top.ToString();
        }
    }
}
