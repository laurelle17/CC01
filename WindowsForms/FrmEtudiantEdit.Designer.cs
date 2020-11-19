namespace WindowsForms
{
    partial class FrmEtudiantEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomEtudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identifiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lieuNais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telEt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailEt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Quitter = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Actualiser = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Label();
            this.Imprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomEtudiant,
            this.Date,
            this.Identifiant,
            this.lieuNais,
            this.telEt,
            this.emailEt,
            this.sexe});
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.dataGridView1.Location = new System.Drawing.Point(153, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 285);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NomEtudiant
            // 
            this.NomEtudiant.HeaderText = "Nom et Prenom";
            this.NomEtudiant.Name = "NomEtudiant";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date de Naissance";
            this.Date.Name = "Date";
            // 
            // Identifiant
            // 
            this.Identifiant.HeaderText = "Identifiant";
            this.Identifiant.Name = "Identifiant";
            // 
            // lieuNais
            // 
            this.lieuNais.HeaderText = "Lieu de Naissance";
            this.lieuNais.Name = "lieuNais";
            // 
            // telEt
            // 
            this.telEt.HeaderText = "Contact";
            this.telEt.Name = "telEt";
            // 
            // emailEt
            // 
            this.emailEt.HeaderText = "Adresse-Mail";
            this.emailEt.Name = "emailEt";
            // 
            // sexe
            // 
            this.sexe.HeaderText = "Sexe";
            this.sexe.Name = "sexe";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(213, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(557, 20);
            this.textBox1.TabIndex = 17;
            // 
            // Quitter
            // 
            this.Quitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Quitter.BackColor = System.Drawing.Color.White;
            this.Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitter.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Quitter.Location = new System.Drawing.Point(19, 391);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(75, 23);
            this.Quitter.TabIndex = 16;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = false;
            // 
            // Supprimer
            // 
            this.Supprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Supprimer.BackColor = System.Drawing.Color.White;
            this.Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Supprimer.Location = new System.Drawing.Point(19, 349);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Supprimer.TabIndex = 15;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = false;
            // 
            // Actualiser
            // 
            this.Actualiser.BackColor = System.Drawing.Color.White;
            this.Actualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualiser.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Actualiser.Location = new System.Drawing.Point(19, 254);
            this.Actualiser.Name = "Actualiser";
            this.Actualiser.Size = new System.Drawing.Size(75, 23);
            this.Actualiser.TabIndex = 14;
            this.Actualiser.Text = "Actualiser";
            this.Actualiser.UseVisualStyleBackColor = false;
            this.Actualiser.Click += new System.EventHandler(this.Actualiser_Click);
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.White;
            this.Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Modifier.Location = new System.Drawing.Point(19, 204);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(75, 23);
            this.Modifier.TabIndex = 13;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.White;
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Ajouter.Location = new System.Drawing.Point(19, 154);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 12;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.BackColor = System.Drawing.Color.Transparent;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.DarkCyan;
            this.Search.Location = new System.Drawing.Point(150, 107);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(57, 16);
            this.Search.TabIndex = 19;
            this.Search.Text = "Search";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Imprimer
            // 
            this.Imprimer.BackColor = System.Drawing.Color.White;
            this.Imprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imprimer.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Imprimer.Location = new System.Drawing.Point(19, 301);
            this.Imprimer.Name = "Imprimer";
            this.Imprimer.Size = new System.Drawing.Size(75, 23);
            this.Imprimer.TabIndex = 20;
            this.Imprimer.Text = "Imprimer";
            this.Imprimer.UseVisualStyleBackColor = false;
            this.Imprimer.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmEtudiantEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsForms.Properties.Resources._43ec643e415690208f5d933cf9dcef84;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Imprimer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Actualiser);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Search);
            this.Name = "FrmEtudiantEdit";
            this.Text = "FrmEtudiantEdit";
            this.Load += new System.EventHandler(this.FrmEtudiantEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Actualiser;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button Imprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEtudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identifiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieuNais;
        private System.Windows.Forms.DataGridViewTextBoxColumn telEt;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailEt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexe;
    }
}