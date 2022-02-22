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
    class ogrenci
    {
        /// <summary>
        /// Bu overlooad default degeri 15 olarak yazdırır
        /// </summary>
        public ogrenci()//clasla aynı isimle olmak zorunda
        {
            yas = 15;//default olarak başladığı deger

        }
        /// <summary>
        ///  Bu constructor metodu yaşı sizin belirlemenizi saglar
        /// </summary>
        /// <param name="gelenyas"></param>
        public ogrenci(short gelenyas)//short yas)
        {
            //this.yas = yas;
            yas = gelenyas;
        }


        string ad;
        short yas;
        public string  AD
        {
            get { return ad; }
            set { ad = value; }
        }
   

        public short Yas
        {
            get { return yas; }
            set { yas = value; }
        }


    }

    class ayakabi
    {
        public ayakabi()
        {
            marka = "adidas";
        
        }

        private string marka;

        public string Marka
        {
            get { return marka; }
          
        }

        private int numara;

        public int Numara
        {
            get { return numara; }
            set { numara = value; }
        }

        private string cinsiyet;

        public string Cinsiyet
        {
           
            set { cinsiyet = value; }
        }




    }

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            /*     ogrenci ogrenci1 = new ogrenci();
                 ogrenci1.AD = "recep";

                 ogrenci ogrenci2 = new ogrenci();
                 ogrenci2.AD = "hilal";
              //   ogrenci2.Yas = 23;
                 MessageBox.Show($"{ogrenci2.AD} \n {ogrenci2.Yas}");
                 ogrenci ogrenci3 = new ogrenci(17);
                 MessageBox.Show(ogrenci3.Yas.ToString());
     */

            ayakabi ayakabi1 = new ayakabi();
            ayakabi1.Numara = 42;
            MessageBox.Show(ayakabi1.Marka+" "+ayakabi1.Numara);
            ayakabi1.Cinsiyet = "kadin";
            




        }
    }
}
