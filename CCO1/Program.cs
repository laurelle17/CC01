using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCO1
{
    class Program
    {
        public static object ConfigurationManager { get; private set; }

        static void Main(string[] args)
        {

            static void Main(string[] args)
            {
                string choice = "y";
                do
                {
                    Console.Clear();
                    Console.WriteLine("----------------------------Ajouter un Etudiant----------------------------");
                    Console.Write("Entrer l'Identifiant\t:");
                    string Identifiant = Console.ReadLine();
                    Console.Write("Entrer le nom\t:");
                    string nomEtudiant = Console.ReadLine();
                    Console.Write("Entrer la datee de naissance\t:");
                    string Date = Console.ReadLine();
                    Console.Write("Entrer le lieu de naissance\t:");
                    string lieu = Console.ReadLine();
                    Console.Write("Entrer les contacts\t:");
                    string telEt = Console.ReadLine();
                    Console.Write("Entrer l'Adresse-mail\t:");
                    string emailEt = Console.ReadLine();
                    Console.Write("Entrer le sexe\t:");
                    string sexe = Console.ReadLine();

                    /*Etudiant etudiant = new Etudiant( null);
                    EtudiantBLO e = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
                    etudiantBLO.CreateEtudiant(etudiant);

                    IEnumerable<Etudiant> etudiants = etudiantBLO.GetAllEtudiants();
                    foreach (Etudiant e in etudiants)
                    {
                        Console.WriteLine($"{p.Identifiant}\t{p.NomEtudiant}");
                    }

                    Console.Write("Créer un autre etudiant ?[y/n]:");
                    choice = Console.ReadLine();
                }
                while (choice.ToLower() != "n");
                Console.WriteLine("Program end !");

                Console.ReadKey();*/
            }
        }
    }
}
