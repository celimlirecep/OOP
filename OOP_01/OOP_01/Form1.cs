using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        class Kisi
        {
            string ad;//field
            string soyad;
            string yas;

            public string Ad//full property ornek
            {
                get
                {
                    return ad;//değer okuma
                }
                set
                {
                    ad = value.ToUpper();//değer yazma
                }
            }
            public string Soyad
            {
                get
                {
                    return soyad;
                }
                set
                {
                    soyad = value.ToUpper();
                }
            }

        }

        class Personel//prop türündeki örnek
        {
            string adSoyad;
            int yas;

            public string AdsSoyad { get; set; }
            public int Yas { get; set; }
        }


        class Araba
        {
            /*   string marka;
               string modeluYili;*/

            public string marka { get; set; }
            public string modelyılı { get; set; }

        }

        class ogrenci
        {
         //  public string adsoyad;
            public string AdSoyad { get; set; }
            public short Yas { get; set; }
            public string Bolum { get; set; }
            public string Sehir { get; set; }
            public double Ortalama { get; set; }

            

        }

        class orman
        {
            private string tur;
            public string Tur { get; set; }
            public int Adet { get; set; }

            public  string renk;//denemek için çevirdik
                    
            public  string Renk
            {
                get { return renk; }
                set { renk = value; }
            }



        }
        private void Form1_Load(object sender, EventArgs e)
        {
           /* Kisi ogrenci1 = new Kisi();
            ogrenci1.Ad = "osman";
            ogrenci1.Soyad = "can";
            MessageBox.Show(ogrenci1.Ad+" "+ogrenci1.Soyad);
            Personel personel1 = new Personel();
            personel1.AdsSoyad = "recep çelimli";
            personel1.Yas = 22;
            MessageBox.Show(personel1.AdsSoyad.ToUpper()+" "+personel1.Yas);
            Araba otomobil = new Araba();
            otomobil.marka = "opel";
            otomobil.modelyılı = "1997";
          */ // MessageBox.Show($"Marka {otomobil.marka}\n Model yılı={otomobil.modelyılı}");

            ogrenci ogrenci10 = new ogrenci();
            ogrenci10.AdSoyad = "muhterem sevindik";
            ogrenci10.Bolum = "Degerli taşlar";
            ogrenci10.Sehir = "Madagaskar";
            ogrenci10.Yas = 23;
            ogrenci10.Ortalama = 76;
            ekranaYaz(ogrenci10);
            buyukharfecevir(ogrenci10);
            ekranaYaz(ogrenci10);
            //  MessageBox.Show(ogrenci10.adsoyad);

            orman akdeniz = new orman();
            akdeniz.Tur = "palamut";
            akdeniz.Adet = 20;
            orman karadeniz = new orman();
            karadeniz.Tur = "meşe";
            karadeniz.Adet = 15;
            MessageBox.Show(akdeniz.Tur.ToUpper() + " " + akdeniz.Adet + "," + karadeniz.Tur.ToLower() + " " + karadeniz.Adet);
            karadeniz.Renk = "sari";
            MessageBox.Show(karadeniz.renk);


        }
        void ekranaYaz(ogrenci e)
        {

            MessageBox.Show(e.AdSoyad);
        }

        void buyukharfecevir(ogrenci o)
        {
            o.AdSoyad = o.AdSoyad.ToUpper();
        }






    }
}
