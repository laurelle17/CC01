using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsForms
{
    public partial class FrmEtudiantEdit : Form
    {
        public FrmEtudiantEdit()
        {
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            Form f = Form();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmEtudiantEdit_Load(object sender, EventArgs e)
        {

        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    Form f = new FrmEtudiantEdit
                    (
                        dataGridView1.SelectedRows[i].DataBoundItem as Etudiants,
                        loadData
                    );
                    f.ShowDialog();
                }
            }
        }

        private void Actualiser_Click(object sender, EventArgs e)
        {

        }
    }
}
