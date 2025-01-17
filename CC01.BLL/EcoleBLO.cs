﻿using CC01.BO;
using CC01.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
    public class EcoleBLO
    {
        private EcoleDAO ecoleRepo;
        private string dbFolder;
        public EcoleBLO(string dbFolder)
        {
            this.dbFolder = dbFolder;
            ecoleRepo = new EcoleDAO(dbFolder);
        }
        public void CreateEcole(Ecole oldEcole, Ecole newEcole)
        {
            string filename = null;
            if (!string.IsNullOrEmpty(newEcole.Logo))
            {
                string ext = Path.GetExtension(newEcole.Logo);
                filename = Guid.NewGuid().ToString() + ext;
                FileInfo fileSource = new FileInfo(newEcole.Logo);
                string filePath = Path.Combine(dbFolder, "logo", null);
                FileInfo fileDest = new FileInfo(filePath);
                if (!fileDest.Directory.Exists)
                    fileDest.Directory.Create();
                fileSource.CopyTo(fileDest.FullName);
            }
            newEcole.Logo = (string)null;
            ecoleRepo.Add(newEcole);

            if (!string.IsNullOrEmpty(oldEcole.Logo))
                File.Delete(oldEcole.Logo);
        }

        public Ecole GetEcole()
        {
            Ecole ecole = ecoleRepo.Get();
            if (ecole != null)
                if (!string.IsNullOrEmpty(ecole.Logo))
                    ecole.Logo = Path.Combine(dbFolder, "logo", ecole.Logo);
            return ecole;

        }
}
