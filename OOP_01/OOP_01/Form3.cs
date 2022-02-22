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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        class ayakkabilar
        {
            public ayakkabilar(Markalar gelenmarka)
            {
                Marka = gelenmarka;
            }
            public ayakkabilar(Markalar gelenmarka,AyakkabiTipleri ayakkabitipleri)
            {
                Marka = gelenmarka;
                Ayakkabitipi = ayakkabitipleri;
            }
            public ayakkabilar(Markalar gelenmarka, AyakkabiTipleri ayakkabitipleri,Malzemetipleri malzemetipleri)
            {
                Marka = gelenmarka;
                Ayakkabitipi = ayakkabitipleri;
                malzemetipi = malzemetipi;
            }

          //  public string Marka { get; set; }
            public Markalar Marka { get; set; }
            public AyakkabiTipleri Ayakkabitipi { get; set; }
            public Malzemetipleri malzemetipi { get; set; }


        }
        private void Form3_Load(object sender, EventArgs e)
        {
           /* ayakkabilar a = new ayakkabilar();
            a.Marka = Markalar.Adidas;
          
            a.Ayakkabitipi = AyakkabiTipleri.SporAyakkabi;
            a.malzemetipi = Malzemetipleri.Kumaş;
            MessageBox.Show(a.Marka.ToString()+"\n"+a.malzemetipi.ToString())*/;
            ayakkabilar markasibelliayakkabi = new ayakkabilar(Markalar.Hummel);
            lbl1.Text = markasibelliayakkabi.Marka.ToString();
            ayakkabilar markasiveayakkabitipibelliayakkabi = new ayakkabilar(Markalar.Adidas,AyakkabiTipleri.Çizme);
            lbl1.Text = markasiveayakkabitipibelliayakkabi.Marka + " " + markasiveayakkabitipibelliayakkabi.Ayakkabitipi;


        }
    }
}
