using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOP_01.ozelders;

namespace OOP_01
{
    public partial class formozelders : Form
    {
        public formozelders()
        {
            InitializeComponent();
        }

        private void formozelders_Load(object sender, EventArgs e)
        {
            standartUyelik standart = new standartUyelik();
            standart.adi = "RECEP";
            standart.soyadi = "celimli";
            standart.kullanıcıAdi = "celimlirecep";
            standart.brans = Branslar.matematik.ToString();
            standart.yas = 22;
            standart.deneyimSuresi = 12;


        }
    }
}
