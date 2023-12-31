﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public decimal ToplamTutar { get; set; }


        public override string ToString()
        {

            string ekstralar = "";

            foreach (var item in EkstraMalzeme)
            {
                ekstralar += item.EkstraAdi;
            }


            return "Menu: " + SecilenMenu + "\n" + "Boyut: " + Boyut + "\n" + "Eksta Malzeme " + ekstralar + "\n" + "Adet : " + Adet + "\n" + "Toplam Tutar" + ToplamTutar;

        }

        public decimal Hesapla()
        {
            decimal malzemeFiyat = 0;
            foreach (var item in EkstraMalzeme)
            {
                malzemeFiyat += item.Fiyat;
            }


            decimal boyutFiyat;
            if (Boyut.Kucuk == Boyut) boyutFiyat = 0;
            else if (Boyut.Orta == Boyut) boyutFiyat = 5;
            else boyutFiyat = 10;


            return (SecilenMenu.Fiyat + boyutFiyat + malzemeFiyat)*Adet;


        }

        

    }
}


