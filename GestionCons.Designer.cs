namespace MohammedHamdani
{
    partial class GestionCons
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
            this.labelMat = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPren = new System.Windows.Forms.Label();
            this.labelComp = new System.Windows.Forms.Label();
            this.labelNb = new System.Windows.Forms.Label();
            this.textBoxNb = new System.Windows.Forms.TextBox();
            this.textBoxPren = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxMatr = new System.Windows.Forms.TextBox();
            this.comboBoxComp = new System.Windows.Forms.ComboBox();
            this.buttonChercher = new System.Windows.Forms.Button();
            this.buttonModi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMat
            // 
            this.labelMat.AutoSize = true;
            this.labelMat.Location = new System.Drawing.Point(37, 36);
            this.labelMat.Name = "labelMat";
            this.labelMat.Size = new System.Drawing.Size(73, 20);
            this.labelMat.TabIndex = 0;
            this.labelMat.Text = "Matricule";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(37, 107);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(42, 20);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom";
            // 
            // labelPren
            // 
            this.labelPren.AutoSize = true;
            this.labelPren.Location = new System.Drawing.Point(37, 168);
            this.labelPren.Name = "labelPren";
            this.labelPren.Size = new System.Drawing.Size(64, 20);
            this.labelPren.TabIndex = 2;
            this.labelPren.Text = "Prenom";
            // 
            // labelComp
            // 
            this.labelComp.AutoSize = true;
            this.labelComp.Location = new System.Drawing.Point(37, 242);
            this.labelComp.Name = "labelComp";
            this.labelComp.Size = new System.Drawing.Size(76, 20);
            this.labelComp.TabIndex = 3;
            this.labelComp.Text = "Compexe";
            // 
            // labelNb
            // 
            this.labelNb.AutoSize = true;
            this.labelNb.Location = new System.Drawing.Point(37, 322);
            this.labelNb.Name = "labelNb";
            this.labelNb.Size = new System.Drawing.Size(72, 20);
            this.labelNb.TabIndex = 4;
            this.labelNb.Text = "Nb Visite";
            // 
            // textBoxNb
            // 
            this.textBoxNb.Location = new System.Drawing.Point(209, 322);
            this.textBoxNb.Name = "textBoxNb";
            this.textBoxNb.Size = new System.Drawing.Size(315, 26);
            this.textBoxNb.TabIndex = 5;
            // 
            // textBoxPren
            // 
            this.textBoxPren.Location = new System.Drawing.Point(209, 178);
            this.textBoxPren.Name = "textBoxPren";
            this.textBoxPren.Size = new System.Drawing.Size(315, 26);
            this.textBoxPren.TabIndex = 6;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(209, 117);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(315, 26);
            this.textBoxNom.TabIndex = 7;
            // 
            // textBoxMatr
            // 
            this.textBoxMatr.Location = new System.Drawing.Point(209, 36);
            this.textBoxMatr.Name = "textBoxMatr";
            this.textBoxMatr.Size = new System.Drawing.Size(315, 26);
            this.textBoxMatr.TabIndex = 8;
            // 
            // comboBoxComp
            // 
            this.comboBoxComp.FormattingEnabled = true;
            this.comboBoxComp.Location = new System.Drawing.Point(209, 242);
            this.comboBoxComp.Name = "comboBoxComp";
            this.comboBoxComp.Size = new System.Drawing.Size(315, 28);
            this.comboBoxComp.TabIndex = 9;
            // 
            // buttonChercher
            // 
            this.buttonChercher.Location = new System.Drawing.Point(736, 36);
            this.buttonChercher.Name = "buttonChercher";
            this.buttonChercher.Size = new System.Drawing.Size(257, 50);
            this.buttonChercher.TabIndex = 10;
            this.buttonChercher.Text = "Chercher";
            this.buttonChercher.UseVisualStyleBackColor = true;
            this.buttonChercher.Click += new System.EventHandler(this.buttonChercher_Click);
            // 
            // buttonModi
            // 
            this.buttonModi.Location = new System.Drawing.Point(96, 433);
            this.buttonModi.Name = "buttonModi";
            this.buttonModi.Size = new System.Drawing.Size(333, 54);
            this.buttonModi.TabIndex = 11;
            this.buttonModi.Text = "Modifier";
            this.buttonModi.UseVisualStyleBackColor = true;
            this.buttonModi.Click += new System.EventHandler(this.buttonModi_Click);
            // 
            // GestionCons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 554);
            this.Controls.Add(this.buttonModi);
            this.Controls.Add(this.buttonChercher);
            this.Controls.Add(this.comboBoxComp);
            this.Controls.Add(this.textBoxMatr);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxPren);
            this.Controls.Add(this.textBoxNb);
            this.Controls.Add(this.labelNb);
            this.Controls.Add(this.labelComp);
            this.Controls.Add(this.labelPren);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelMat);
            this.Name = "GestionCons";
            this.Text = "GestionCons";
            this.Load += new System.EventHandler(this.GestionCons_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMat;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPren;
        private System.Windows.Forms.Label labelComp;
        private System.Windows.Forms.Label labelNb;
        private System.Windows.Forms.TextBox textBoxNb;
        private System.Windows.Forms.TextBox textBoxPren;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxMatr;
        private System.Windows.Forms.ComboBox comboBoxComp;
        private System.Windows.Forms.Button buttonChercher;
        private System.Windows.Forms.Button buttonModi;
    }
}