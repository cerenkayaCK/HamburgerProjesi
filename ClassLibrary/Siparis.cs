using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Siparis
    {
        public Menu SecilenMenu { get; set; }
        public Boyut Boyut { get; set; }
        public List<Ekstra> EkstraMalzeme { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar {  get; set; }



        public override string ToString()
        {
            return $"{SecilenMenu}";
        }
    }

}
