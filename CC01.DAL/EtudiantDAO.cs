using CC01.BO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.DAL
{
    public class EtudiantDAO
    {
        private static List<Etudiant> etudiants;
        private const string FILE_NAME = @"etudiant.json";
        private readonly string dbFolder;
        private FileInfo file;
        public EtudiantDAO(string dbFolder)
        {
            this.dbFolder = dbFolder;
            file = new FileInfo(Path.Combine(this.dbFolder, FILE_NAME));
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            if (!file.Exists)
            {
                file.Create().Close();
                file.Refresh();
            }
            if (file.Length > 0)
            {
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    etudiants = JsonConvert.DeserializeObject<List<Etudiant>>(json);
                }
            }
            if (etudiants == null)
            {
                etudiants = new List<Etudiant>();
            }
        }

        public void Set(Etudiant oldEtudiant, Etudiant newEtudiant, Etudiant newEtudiants)
        {
            var oldIndex = etudiants.IndexOf(oldEtudiant);
            var newIndex = etudiants.IndexOf(newEtudiant);
            if (oldIndex < 0)
                throw new KeyNotFoundException("Cet étudiant a déjà été enregistré !");
            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("This product reference already exists !");
            etudiants[oldIndex] = newEtudiant;
            Save();
        }

        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(etudiants);
                sw.WriteLine(json);
            }
        }

        private void Add(Etudiant etudiants)
        {
            var index = EtudiantDAO.etudiants.IndexOf(etudiants);
            if (index >= 0)
                throw new DuplicateNameException("Cet identifiant d'étudiant existe déjà");
            EtudiantDAO.etudiants.Add(etudiants);
            Save();
        }

        public void Remove(Etudiant etudiants)
        {
            etudiants.Remove(etudiants);//base sur Product.Equals redefini
            Save();
        }

        public IEnumerable<Etudiant> Find()
        {
            return new List<Etudiant>(etudiants);
        }

        public IEnumerable<Etudiant> Find(Func<Etudiant, bool> predicate)
        {
            return new List<Etudiant>(etudiants.Where(predicate).ToArray());
        }
    }
}
