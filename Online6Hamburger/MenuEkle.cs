using ClassLibrary;
using Online6Hamburger;
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
    public partial class MenuEkle : Form
    {
       

        public MenuEkle()
        {
            InitializeComponent();
           
           

        }



        private void btnMenuyuKaydet_Click(object sender, EventArgs e)
        {
            SiparisOlustur.Menuler.Add(new Menu { Ad = txtMenuAdi.Text,Fiyat=numericEklenenMenuFiyat.Value });

            MessageBox.Show("Ekstra malzeme başarı ile eklendi.");



        }
    }
}


