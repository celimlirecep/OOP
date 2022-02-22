using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOP_01.myclasses;

namespace OOP_01
{
    
    public partial class pılimorphism2 : Form
    {
        Sepet sepet = new Sepet();
        public pılimorphism2()
        {
            InitializeComponent();
        }

        private void btntekstil_Click(object sender, EventArgs e)
        {
            Tekstil tekstil = new Tekstil("gömlek",300,"ipek",3);
            sepet.Ekle(tekstil);
            dgvsepet.Rows.Add(tekstil.UrunAdi, tekstil.Fiyat, tekstil.KDVUygula());


        }

        private void btncep_Click(object sender, EventArgs e)
        {
            CepTelefonu cep = new CepTelefonu("samsung",10000,"apple");
            sepet.Ekle(cep);
            dgvsepet.Rows.Add(cep.UrunAdi, cep.Fiyat, cep.KDVUygula());
        }

        private void btnekmek_Click(object sender, EventArgs e)
        {
            Ekmek ekmek = new Ekmek("uno",100,"kepekli",400);
            sepet.Ekle(ekmek);
            dgvsepet.Rows.Add(ekmek.UrunAdi, ekmek.Fiyat, ekmek.KDVUygula());
        }
    }
}
