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
            bool durum = false; // en ba�ta ana formun hi� ocu�u olmad��� i�in foreach e girmez o yzden de�ikenini tan�mlad�k.

            //bu ana formun �ocuklar� i�erisinde gezelim
            foreach (Form form in this.MdiChildren) //�ocu�u olunca buraya girer.
            {
                if (form.Text == secilenForm.Text)
                {
                    durum = true; // tekrar if(!durum) a girmemesi i�in true �ektik. 

                    form.Show(); //istenen a��l�yor
                }
                else
                {
                    form.Close();  // a��k olan varsa kapat�ls�n
                }
            }
            if (!durum)// e�er ilk a��l�� ise ve hi� �ocuk yoksa. tekrar tekrar atama yapmamak i�in.
            {

                secilenForm.MdiParent = this;
                secilenForm.Show();
            }

        }

        private void sipari�Olu�turToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new SiparisOlustur());
        }

        

        private void men�EkleToolStripMenuItem_Click(object sender, EventArgs e)
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