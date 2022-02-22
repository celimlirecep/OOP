using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_01
{
    class ozelders

    {
        public enum Branslar
        {
            matematik, fizik, kimya, biyoloji
        }
        public class standartUyelik
        {
            public string adi { get; set; }
            public string soyadi { get; set; }
            public string kullanıcıAdi { get; set; }
            public string brans { get; set; }
           
            public short yas { get; set; }
            public short deneyimSuresi { get; set; }
            public string telefonNumarasi { set {telefonNumarasi= value; } }

          
           
           
        }

        public class proUyelik : standartUyelik
        {
            public string rozetli { get; set; }
            


          

            public void dogrudanerisim()
            {

            }

        }

        public class EliteUyelik:proUyelik
        {
           
        }










    }
}
