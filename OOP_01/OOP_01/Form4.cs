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
    public partial class Form4 : Form
    {
        class Insanlar
        {
            public string Adsoyad { get; set; }
            public short Boy { get; set; }
            public double Kilo { get; set; }

        }

        class ogernciler : Insanlar
        {
            public int ogrNo { get; set; }
            public string Ikametgah { get; set; }


        }

        class baululer : ogernciler
        {
            public string bolum { get; set; }
            public string cinsiyet { get; set; }


        }

        public Form4()
        {
            InitializeComponent();
        }
        

        private void Form4_Load(object sender, EventArgs e)
        {

            Insanlar insan1 = new Insanlar();
            ogernciler ogernci1 = new ogernciler();
            ogernci1.Adsoyad = "reco";
            baululer ba = new baululer();
            ba.Adsoyad = "agla";
            ba.Ikametgah = "sdfsd";






        }
    }
}
