using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    [Serializable]
    public class Ecole
    {
        public string NomEcole { get; set; }
        public string lieu { get; set; }
        public string tel { get; set; }
        public string BP { get; set; }
        public string email { get; set; }
        public string Logo { get; set; }

        public Ecole()
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
    }
}
