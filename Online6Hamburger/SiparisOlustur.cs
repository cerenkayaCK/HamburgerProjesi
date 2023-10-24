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
using static System.Windows.Forms.DataFormats;

namespace Online6Hamburger
{
    public partial class SiparisOlustur : Form
    {

        public SiparisOlustur()
        {
            InitializeComponent();
            if (cboMenu.SelectedIndex == -1)
            { cboMenu.Text = "BİR MENÜ SEÇİNİZ."; }

        }

        public static List<Siparis> tumSiparisler = new List<Siparis>();
        public static List<Siparis> MevcutSiparisler = new List<Siparis>();

        public static List<Menu> Menuler = new List<Menu>()
        {
            new Menu{Ad="Big King",Fiyat=18.25M},
            new Menu{Ad="Double King Chicken",Fiyat=19.75M},
            new Menu{Ad="Steakhouse",Fiyat=22.50M},
            new Menu{Ad="Whooper",Fiyat=20.00M},
            new Menu{Ad="Whooper Jr.",Fiyat=17.75M},
            new Menu{Ad="Chicken Royal", Fiyat=21.25M}
        };

        public static List<Ekstra> Ekstralar = new List<Ekstra>()
        {
        new Ekstra{EkstraAdi="Ketçap",Fiyat=0.50M },
        new Ekstra{EkstraAdi="Mayonez",Fiyat=0.50M},
        new Ekstra{EkstraAdi="Hardal",Fiyat=0.75M},
        new Ekstra{EkstraAdi="BBQ", Fiyat=1.00M},
        new Ekstra{EkstraAdi="Ranch",Fiyat=1.00M},
        new Ekstra{EkstraAdi="Buffalo",Fiyat=1.25M}

        };

        private void cboMenu_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.SecilenMenu = (Menu)cboMenu.SelectedItem;

            if (radioBuyuk.Checked)
                siparis.Boyut = Boyut.Buyuk;
            if (radioKucuk.Checked)
                siparis.Boyut = Boyut.Kucuk;
            if (radioORTA.Checked)
                siparis.Boyut = Boyut.Orta;


            siparis.EkstraMalzeme = new List<Ekstra>();


        }

        private void MalzemeCheckBox_CheckedChanged(object? sender, EventArgs e)
        {

        }

        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            foreach (var item in Menuler)
            {
                cboMenu.Items.Add(item);
            }
            foreach (Ekstra ekstra in Ekstralar)
            {
                int sayac = 0;
                int x = 42;
                flpEkstraMalzemeler.Controls.Add(new CheckBox() { Text = ekstra.EkstraAdi, Tag = ekstra, Location = new Point(x, 421) });
                x += 114;
                sayac++;
                if (sayac > 3)
                {
                    flpEkstraMalzemeler.Controls.Add(new CheckBox() { Text = ekstra.EkstraAdi, Tag = ekstra, Location = new Point(x, 440) });
                    x += 114;
                }

            }
            foreach (Siparis item in MevcutSiparisler)
            {
                lstMevcutSiparisler.Items.Add(item);

            }
        }

        private void flpEkstraMalzemeler_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
