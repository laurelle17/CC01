using CC01.BLL;
using CC01.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{

    public partial class FrmCreateEcole : Form
    {
        private EcoleBLO ecoleBLO;
        private Ecole oldEcole;
        public FrmCreateEcole()
        {
            InitializeComponent();
            ecoleBLO = new EcoleBLO(ConfigurationManager.AppSettings["DbFolder"]);
            oldEcole = ecoleBLO.GetEcole();
            if (oldEcole != null)
            {
                email.Text = oldEcole.email;
                NomEcole.Text = oldEcole.NomEcole;
                localisation.Text = oldEcole.lieu;
                tel.Text = oldEcole.tel.ToString();
                BP.Text = oldEcole.BP;
            }

        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                checkForm( );

                Ecole newEcole = new Ecole
                    (
                        NomEcole.Text.ToUpper(),
                        BP.Text,
                        long.Parse(tel.Text),
                        email.Text,
                        localisation.Text

                    );
                ecoleBLO.CreateEcole(oldEcole, newEcole);

                MessageBox.Show
                    (
                          "Enregistrement effectué !",
                          "Confirmation",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information
                    );

                Close();


            }
            catch (TypingException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Typing error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (Exception ex)
            {
                ex.WriteToFile();
                MessageBox.Show
               (
                   "Une erreur détectée! Veuillez réessayer plus tard",
                   "Erreur",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
        }


        private void checkForm()
        {
            string text = string.Empty;
            NomEcole.BackColor = Color.White;
            email.BackColor = Color.White;
            if (!long.TryParse(tel.Text, out _))
            {
                text += "- Ce contact n'est pas valide ! \n";
                NomEcole.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(NomEcole.Text))
            {
                text += "- EEntrez le nom de l' Ecole ! \n";
                email.BackColor = Color.Pink;
            }

            if (!string.IsNullOrEmpty(text))
                throw new TypingException(text);
        }

        private void BP_Click(object sender, EventArgs e)
        {

        }

        private void lieu_Click(object sender, EventArgs e)
        {

        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
