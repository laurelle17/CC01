using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    [Serializable]
    public class Etudiant
    {
        public string NomEtudiant { get; set; }
        public string Date { get; set; }
        public string Identifiant { get; set; }
        public string LieuNais { get; set; }
        public string telEt { get; set; }
        public string emailEt { get; set; }
        public string sexe { get; set; }


        public Etudiant()
        {

        }
        public Etudiant(string nomEtudiant, string date, string identifiant, string lieuNais, string telEt, string emailEt, string sexe)
        {
            NomEtudiant = nomEtudiant;
            Date = date;
            Identifiant = identifiant;
            LieuNais = lieuNais;
            this.telEt = telEt;
            this.emailEt = emailEt;
            this.sexe = sexe;
        }

        public override bool Equals(object obj)
        {
            return obj is Etudiant etudiant &&
                   Identifiant == etudiant.Identifiant;
        }

        public override int GetHashCode()
        {
            return -574969646 + EqualityComparer<string>.Default.GetHashCode(Identifiant);
        }

        public void Remove(Etudiant etudiants)
        {
            throw new NotImplementedException();
        }
    }
}
