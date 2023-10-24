using ClassLibrary;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Online6Hamburger
{
    public partial class Anaform : Form
    {
        
        public Anaform()
        {
            InitializeComponent();
        }
        public void FormGoster(Form secilenForm)
        {
            secilenForm.StartPosition = 0;
            bool durum = false; // en baþta ana formun hiç ocuðu olmadýðý için foreach e girmez o yzden deðikenini tanýmladýk.

            //bu ana formun çocuklarý içerisinde gezelim
            foreach (Form form in this.MdiChildren) //Çocuðu olunca buraya girer.
            {
                if (form.Text == secilenForm.Text)
                {
                    durum = true; // tekrar if(!durum) a girmemesi için true çektik. 

                    form.Show(); //istenen açýlýyor
                }
                else
                {
                    form.Close();  // açýk olan varsa kapatýlsýn
                }
            }
            if (!durum)// eðer ilk açýlýþ ise ve hiç çocuk yoksa. tekrar tekrar atama yapmamak için.
            {

                secilenForm.MdiParent = this;
                secilenForm.Show();
            }

        }

        private void sipariþOluþturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new SiparisOlustur());
        }

        

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        FormGoster(new MenuEkle());
        } 

        private void SiparisBilgileri_Click(object sender, EventArgs e)
        {
            FormGoster(new SiparisBilgileri());
        }

        private void ekstraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new EkstraMalzemeEkle());
        }
    }
}