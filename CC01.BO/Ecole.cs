using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class Ecole
    {
        private string v1;
        private string text1;
        private long v2;
        private string text2;
        private string text3;

        public string NomEcole { get; set; }
        public string lieu { get; set; }
        public string tel { get; set; }
        public string BP { get; set; }
        public string email { get; set; }
        public string Logo { get; set; }

        public Ecole(string v)
        {

        }

        public Ecole(string nomEcole, string lieu, long v, string tel, string bP, string email)
        {
            NomEcole = nomEcole;
            this.lieu = lieu;
            this.tel = tel;
            BP = bP;
            this.email = email;
        }

        public Ecole(string v1, string text1, long v2, string text2, string text3)
        {
            this.v1 = v1;
            this.text1 = text1;
            this.v2 = v2;
            this.text2 = text2;
            this.text3 = text3;
        }
    }
}
