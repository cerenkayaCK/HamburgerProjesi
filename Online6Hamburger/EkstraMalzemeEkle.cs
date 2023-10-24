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
    public partial class EkstraMalzemeEkle : Form
    {
        public EkstraMalzemeEkle()
        {
            InitializeComponent();
        }

        private void btnEkstraMalzemeyiKaydet_Click(object sender, EventArgs e)
        {
            SiparisOlustur.Ekstralar.Add(new Ekstra { EkstraAdi = txtEkstraMalzemeAdi.Text, Fiyat = numericEkstraMalzemeFiyat.Value });
            MessageBox.Show("ekstra malzeme eklendi.");

        }
    }
}
