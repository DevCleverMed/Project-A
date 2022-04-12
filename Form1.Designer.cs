namespace MohammedHamdani
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMatricule = new System.Windows.Forms.Label();
            this.labelCoDe = new System.Windows.Forms.Label();
            this.textBoxCodeSE = new System.Windows.Forms.TextBox();
            this.textBoxMat = new System.Windows.Forms.TextBox();
            this.bttnConexion = new System.Windows.Forms.Button();
            this.bttnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMatricule
            // 
            this.labelMatricule.AutoSize = true;
            this.labelMatricule.Location = new System.Drawing.Point(68, 128);
            this.labelMatricule.Name = "labelMatricule";
            this.labelMatricule.Size = new System.Drawing.Size(73, 20);
            this.labelMatricule.TabIndex = 0;
            this.labelMatricule.Text = "Matricule";
            // 
            // labelCoDe
            // 
            this.labelCoDe.AutoSize = true;
            this.labelCoDe.Location = new System.Drawing.Point(68, 253);
            this.labelCoDe.Name = "labelCoDe";
            this.labelCoDe.Size = new System.Drawing.Size(98, 20);
            this.labelCoDe.TabIndex = 1;
            this.labelCoDe.Text = "Code Secret";
            // 
            // textBoxCodeSE
            // 
            this.textBoxCodeSE.Location = new System.Drawing.Point(247, 253);
            this.textBoxCodeSE.Name = "textBoxCodeSE";
            this.textBoxCodeSE.Size = new System.Drawing.Size(290, 26);
            this.textBoxCodeSE.TabIndex = 2;
            // 
            // textBoxMat
            // 
            this.textBoxMat.Location = new System.Drawing.Point(247, 128);
            this.textBoxMat.Name = "textBoxMat";
            this.textBoxMat.Size = new System.Drawing.Size(290, 26);
            this.textBoxMat.TabIndex = 3;
            // 
            // bttnConexion
            // 
            this.bttnConexion.Location = new System.Drawing.Point(532, 373);
            this.bttnConexion.Name = "bttnConexion";
            this.bttnConexion.Size = new System.Drawing.Size(230, 47);
            this.bttnConexion.TabIndex = 4;
            this.bttnConexion.Text = "Connexion";
            this.bttnConexion.UseVisualStyleBackColor = true;
            this.bttnConexion.Click += new System.EventHandler(this.bttnConexion_Click);
            // 
            // bttnAnnuler
            // 
            this.bttnAnnuler.Location = new System.Drawing.Point(105, 373);
            this.bttnAnnuler.Name = "bttnAnnuler";
            this.bttnAnnuler.Size = new System.Drawing.Size(201, 47);
            this.bttnAnnuler.TabIndex = 5;
            this.bttnAnnuler.Text = "Annuler";
            this.bttnAnnuler.UseVisualStyleBackColor = true;
            this.bttnAnnuler.Click += new System.EventHandler(this.bttnAnnuler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 530);
            this.Controls.Add(this.bttnAnnuler);
            this.Controls.Add(this.bttnConexion);
            this.Controls.Add(this.textBoxMat);
            this.Controls.Add(this.textBoxCodeSE);
            this.Controls.Add(this.labelCoDe);
            this.Controls.Add(this.labelMatricule);
            this.Name = "Form1";
            this.Text = "Authentification";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMatricule;
        private System.Windows.Forms.Label labelCoDe;
        private System.Windows.Forms.TextBox textBoxCodeSE;
        private System.Windows.Forms.TextBox textBoxMat;
        private System.Windows.Forms.Button bttnConexion;
        private System.Windows.Forms.Button bttnAnnuler;
    }
}

