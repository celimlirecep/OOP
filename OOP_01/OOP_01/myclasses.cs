using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_01
{
    class myclasses
    {
        

        public class Urun
        {
            public string UrunAdi { get; set; }
            public double Fiyat { get; set; }
            public virtual double KDVUygula()
            {
                return Fiyat * 1.1;//default olarak %8 kadeve uygulanıyor
            }
            public Urun()
            {

            }
            public Urun(string uAd, double uFiyat)
            {
                UrunAdi = uAd;
                Fiyat = uFiyat;
            }

        }

        public class Tekstil : Urun
        {
            public string kumasTuru { get; set; }
            public short beden { get; set; }
            public string ureticiFirma { get; set; }
            public Tekstil(string tAd, double tFiyat, string tKumasTuru, short tBeden)
            {
                UrunAdi = tAd;
                Fiyat = tFiyat;
                kumasTuru = tKumasTuru;
                beden = tBeden;
            }



        }
        public class CepTelefonu : Urun
        {
            public string Ozellikler { get; set; }
            public string Marka { get; set; }

            public CepTelefonu(string cAd, double cFiyat, string cMarka)
            {
                UrunAdi = cAd;
                Fiyat = cFiyat;
                Marka = cMarka;
            }
        }

        public class Ekmek : Urun
        {
            public string EkmekTuru { get; set; }
            public double Gramaj { get; set; }
            public Ekmek(string eAd, double eFiyat, string eEkmekTuru, double eGramaj)
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


       public  class Sepet
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

        }

        //*** özel ders uygulamasi
        /*
         * üç üyelik paketti olucak
         * 1-stanfart uyelik
         * 2-pro uyelik
         * 3-Elite uyelik
         * 
         * 
         * Standar olarak her uyede olması gerekn ozellikler
         * 
         * adı, soyadı
         * Kullanıcı adı
         * branşı(matematik,fizik,kimya,biyoloji)
         * yaşı
         * deneyim suresi
         * Herkese açık olmayacak şekilde telefon numarsı
         * 
         * *****(Pro uyelerde olması beklenen ozellikler)
         * onaylı üye olduğunu gösteren rozet
         * ana sayfada görünntülenme
         * herkese açık telefon numarsı
         * ders almak isteyenlere direk erişmek(metot)
         * 
         * 
         * *****Elite üyelerde olması gereken özellikler:ek:
         * Arama sonuçlarında üstte yer alma(method)
         * önerilme(method)
         * 
         * 
         * 
         */

    }
}
