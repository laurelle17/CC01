using System;

namespace WindowsForms
{
    partial class FrmCreateEcole
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
            System.Windows.Forms.TextBox txtNomEcole;
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.Label();
            this.BP = new System.Windows.Forms.Label();
            this.localisation = new System.Windows.Forms.Label();
            this.NomEcole = new System.Windows.Forms.Label();
            this.Quitter = new System.Windows.Forms.Button();
            this.enregistrer = new System.Windows.Forms.Button();
            txtNomEcole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(2, 336);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(281, 20);
            this.textBox5.TabIndex = 31;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Chocolate;
            this.email.Location = new System.Drawing.Point(3, 317);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(106, 18);
            this.email.TabIndex = 30;
            this.email.Text = "Adresse-Mail";
            // 
            // txtNomEcole
            // 
            txtNomEcole.Location = new System.Drawing.Point(13, 46);
            txtNomEcole.Name = "txtNomEcole";
            txtNomEcole.Size = new System.Drawing.Size(281, 20);
            txtNomEcole.TabIndex = 27;
            txtNomEcole.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 179);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(281, 20);
            this.textBox3.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(2, 263);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(281, 20);
            this.textBox2.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 20);
            this.textBox1.TabIndex = 24;
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.BackColor = System.Drawing.Color.Transparent;
            this.tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel.ForeColor = System.Drawing.Color.Chocolate;
            this.tel.Location = new System.Drawing.Point(3, 238);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(67, 18);
            this.tel.TabIndex = 23;
            this.tel.Text = "Contact";
            // 
            // BP
            // 
            this.BP.AutoSize = true;
            this.BP.BackColor = System.Drawing.Color.Transparent;
            this.BP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BP.ForeColor = System.Drawing.Color.Chocolate;
            this.BP.Location = new System.Drawing.Point(3, 163);
            this.BP.Name = "BP";
            this.BP.Size = new System.Drawing.Size(109, 18);
            this.BP.TabIndex = 22;
            this.BP.Text = "Boite Postale";
            this.BP.Click += new System.EventHandler(this.BP_Click);
            // 
            // localisation
            // 
            this.localisation.AutoSize = true;
            this.localisation.BackColor = System.Drawing.Color.Transparent;
            this.localisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localisation.ForeColor = System.Drawing.Color.Chocolate;
            this.localisation.Location = new System.Drawing.Point(3, 93);
            this.localisation.Name = "localisation";
            this.localisation.Size = new System.Drawing.Size(99, 18);
            this.localisation.TabIndex = 21;
            this.localisation.Text = "Localisation";
            this.localisation.Click += new System.EventHandler(this.lieu_Click);
            // 
            // NomEcole
            // 
            this.NomEcole.AutoSize = true;
            this.NomEcole.BackColor = System.Drawing.Color.Transparent;
            this.NomEcole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomEcole.ForeColor = System.Drawing.Color.Chocolate;
            this.NomEcole.Location = new System.Drawing.Point(13, 30);
            this.NomEcole.Name = "NomEcole";
            this.NomEcole.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NomEcole.Size = new System.Drawing.Size(51, 18);
            this.NomEcole.TabIndex = 20;
            this.NomEcole.Text = "Ecole";
            // 
            // Quitter
            // 
            this.Quitter.BackColor = System.Drawing.Color.Chocolate;
            this.Quitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitter.ForeColor = System.Drawing.Color.Red;
            this.Quitter.Location = new System.Drawing.Point(189, 456);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(116, 37);
            this.Quitter.TabIndex = 19;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = false;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.Color.Chocolate;
            this.enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrer.ForeColor = System.Drawing.Color.ForestGreen;
            this.enregistrer.Location = new System.Drawing.Point(12, 456);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(116, 37);
            this.enregistrer.TabIndex = 18;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // FrmCreateEcole
            // 
            this.AcceptButton = this.enregistrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Quitter;
            this.ClientSize = new System.Drawing.Size(508, 539);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.email);
            this.Controls.Add(txtNomEcole);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.BP);
            this.Controls.Add(this.localisation);
            this.Controls.Add(this.NomEcole);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.enregistrer);
            this.Name = "FrmCreateEcole";
            this.Text = "FrmCreateEcole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Label BP;
        private System.Windows.Forms.Label NomEcole;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Label localisation;
    }
}