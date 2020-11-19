namespace WindowsForms
{
    partial class FrmCreateEtudiant
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
            this.enregistrer = new System.Windows.Forms.Button();
            this.Quitter = new System.Windows.Forms.Button();
            this.nomEtudiant = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.lieuNais = new System.Windows.Forms.Label();
            this.Identifiant = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.sexe = new System.Windows.Forms.Label();
            this.telEt = new System.Windows.Forms.Label();
            this.emailEt = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.Color.Chocolate;
            this.enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrer.ForeColor = System.Drawing.Color.ForestGreen;
            this.enregistrer.Location = new System.Drawing.Point(11, 485);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(116, 37);
            this.enregistrer.TabIndex = 0;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.button1_Click);
            // 
            // Quitter
            // 
            this.Quitter.BackColor = System.Drawing.Color.Chocolate;
            this.Quitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitter.ForeColor = System.Drawing.Color.Red;
            this.Quitter.Location = new System.Drawing.Point(188, 485);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(116, 37);
            this.Quitter.TabIndex = 1;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = false;
            this.Quitter.Click += new System.EventHandler(this.button2_Click);
            // 
            // nomEtudiant
            // 
            this.nomEtudiant.AutoSize = true;
            this.nomEtudiant.BackColor = System.Drawing.Color.Transparent;
            this.nomEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomEtudiant.ForeColor = System.Drawing.Color.Chocolate;
            this.nomEtudiant.Location = new System.Drawing.Point(12, 59);
            this.nomEtudiant.Name = "nomEtudiant";
            this.nomEtudiant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nomEtudiant.Size = new System.Drawing.Size(127, 18);
            this.nomEtudiant.TabIndex = 2;
            this.nomEtudiant.Text = "Nom et Prénom";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.Chocolate;
            this.date.Location = new System.Drawing.Point(9, 121);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(150, 18);
            this.date.TabIndex = 3;
            this.date.Text = "Date de Naissance";
            this.date.Click += new System.EventHandler(this.label2_Click);
            // 
            // lieuNais
            // 
            this.lieuNais.AutoSize = true;
            this.lieuNais.BackColor = System.Drawing.Color.Transparent;
            this.lieuNais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lieuNais.ForeColor = System.Drawing.Color.Chocolate;
            this.lieuNais.Location = new System.Drawing.Point(9, 183);
            this.lieuNais.Name = "lieuNais";
            this.lieuNais.Size = new System.Drawing.Size(146, 18);
            this.lieuNais.TabIndex = 4;
            this.lieuNais.Text = "Lieu de Naissance";
            this.lieuNais.Click += new System.EventHandler(this.label3_Click);
            // 
            // Identifiant
            // 
            this.Identifiant.AutoSize = true;
            this.Identifiant.BackColor = System.Drawing.Color.Transparent;
            this.Identifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Identifiant.ForeColor = System.Drawing.Color.Chocolate;
            this.Identifiant.Location = new System.Drawing.Point(12, 243);
            this.Identifiant.Name = "Identifiant";
            this.Identifiant.Size = new System.Drawing.Size(80, 18);
            this.Identifiant.TabIndex = 7;
            this.Identifiant.Text = "Identifiant";
            this.Identifiant.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 268);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(281, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 199);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(281, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 75);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(281, 20);
            this.textBox4.TabIndex = 11;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // sexe
            // 
            this.sexe.AutoSize = true;
            this.sexe.BackColor = System.Drawing.Color.Transparent;
            this.sexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexe.ForeColor = System.Drawing.Color.Chocolate;
            this.sexe.Location = new System.Drawing.Point(12, 362);
            this.sexe.Name = "sexe";
            this.sexe.Size = new System.Drawing.Size(45, 18);
            this.sexe.TabIndex = 12;
            this.sexe.Text = "Sexe";
            // 
            // telEt
            // 
            this.telEt.AutoSize = true;
            this.telEt.BackColor = System.Drawing.Color.Transparent;
            this.telEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telEt.ForeColor = System.Drawing.Color.Chocolate;
            this.telEt.Location = new System.Drawing.Point(12, 417);
            this.telEt.Name = "telEt";
            this.telEt.Size = new System.Drawing.Size(67, 18);
            this.telEt.TabIndex = 13;
            this.telEt.Text = "Contact";
            this.telEt.Click += new System.EventHandler(this.telEt_Click);
            // 
            // emailEt
            // 
            this.emailEt.AutoSize = true;
            this.emailEt.BackColor = System.Drawing.Color.Transparent;
            this.emailEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailEt.ForeColor = System.Drawing.Color.Chocolate;
            this.emailEt.Location = new System.Drawing.Point(12, 301);
            this.emailEt.Name = "emailEt";
            this.emailEt.Size = new System.Drawing.Size(106, 18);
            this.emailEt.TabIndex = 14;
            this.emailEt.Text = "Adresse-Mail";
            this.emailEt.Click += new System.EventHandler(this.emailEt_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(11, 320);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(281, 20);
            this.textBox5.TabIndex = 15;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(11, 378);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(281, 20);
            this.textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(11, 433);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(281, 20);
            this.textBox7.TabIndex = 17;
            // 
            // FrmCreateEtudiant
            // 
            this.AcceptButton = this.enregistrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsForms.Properties.Resources.xxik79P_L;
            this.CancelButton = this.Quitter;
            this.ClientSize = new System.Drawing.Size(475, 534);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.emailEt);
            this.Controls.Add(this.telEt);
            this.Controls.Add(this.sexe);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Identifiant);
            this.Controls.Add(this.lieuNais);
            this.Controls.Add(this.date);
            this.Controls.Add(this.nomEtudiant);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.enregistrer);
            this.Name = "FrmCreateEtudiant";
            this.Text = "FrmCreateEtudiant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.Label nomEtudiant;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label lieuNais;
        private System.Windows.Forms.Label Identifiant;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label sexe;
        private System.Windows.Forms.Label telEt;
        private System.Windows.Forms.Label emailEt;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
    }
}