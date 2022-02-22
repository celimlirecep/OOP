/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_01
{
    public partial class polimorphism : Form
    {
        public polimorphism()
        {
            InitializeComponent();
        }

       *//* public class Urun
        {
            public string UrunAdi { get; set; }
            public double Fiyat { get; set; }
            public virtual double KDVUygula() {
                return Fiyat * 1.08;//default olarak %8 kadeve uygulanıyor
            }
            public Urun()
            {

            }
            public Urun(string uAd,double uFiyat)
            {
                UrunAdi = uAd;
                Fiyat = uFiyat;
            }

        }

        class Tekstil : Urun
        {
            public string kumasTuru { get; set; }
            public short beden { get; set; }
            public string ureticiFirma { get; set; }
            public Tekstil(string tAd,double tFiyat,string tKumasTuru,short tBeden)
            {
                UrunAdi = tAd;
                Fiyat = tFiyat;
                kumasTuru = tKumasTuru;
                beden = tBeden;
            }



        }
        class CepTelefonu:Urun
        {
            public string Ozellikler { get; set; }
            public string Marka { get; set; }

            public CepTelefonu(string cAd,double cFiyat,string cMarka)
            {
                UrunAdi = cAd;
                Fiyat = cFiyat;
                Marka = cMarka;
            }
        }

        class Ekmek:Urun
        {
            public string EkmekTuru { get; set; }
            public double Gramaj { get; set; }
            public Ekmek(string eAd,double eFiyat,string eEkmekTuru,double eGramaj)
            {
                UrunAdi = eAd;
                Fiyat = eFiyat;
                EkmekTuru = eEkmekTuru;
                Gramaj = eGramaj;
            }
            public override double KDVUygula()
            {
                return Fiyat * 1.01;
            }
        }


        class Sepet
        {
            List<Urun> urunler = new List<Urun>();
            public double ToplamTutar()
            {
                double toplamFiyat = 0;
                foreach (Urun item in urunler)
                {
                    toplamFiyat += item.KDVUygula();
                }
                return toplamFiyat;
            }
            public void Ekle(Urun yeniUrun)
            {
                urunler.Add(yeniUrun);


            }
       *//*
        }

        private void polimorphism_Load(object sender, EventArgs e)
      *//*  {
            Sepet sepet = new Sepet();
            Ekmek ekmek = new Ekmek("UNO",1000,"TAVA",220);
            Tekstil tekstil = new Tekstil("pantolon", 135, "keten", 42);
            Tekstil tekstil1 = new Tekstil("hırka", 195, "ipek", 46);
            CepTelefonu cepTelefonu = new CepTelefonu("galax a3", 4900, "samsung");
            sepet.Ekle(ekmek);
            sepet.Ekle(tekstil);
            sepet.Ekle(tekstil);
            sepet.Ekle(cepTelefonu);
            MessageBox.Show($"Sepetteki ürünlerin toplam tutarı: {sepet.ToplamTutar().ToString()}");
        }*//*
    }
}
*/