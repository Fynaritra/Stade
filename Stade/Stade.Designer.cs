namespace Stade
{
    partial class Stade
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
            this.nom = new System.Windows.Forms.Label();
            this.lieu = new System.Windows.Forms.Label();
            this.nomstade = new System.Windows.Forms.TextBox();
            this.lieustade = new System.Windows.Forms.TextBox();
            this.annuler = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.enregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(21, 23);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(32, 13);
            this.nom.TabIndex = 0;
            this.nom.Text = "Nom ";
            // 
            // lieu
            // 
            this.lieu.AutoSize = true;
            this.lieu.Location = new System.Drawing.Point(21, 64);
            this.lieu.Name = "lieu";
            this.lieu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lieu.Size = new System.Drawing.Size(27, 13);
            this.lieu.TabIndex = 1;
            this.lieu.Text = "Lieu";
            // 
            // nomstade
            // 
            this.nomstade.Location = new System.Drawing.Point(141, 23);
            this.nomstade.Name = "nomstade";
            this.nomstade.Size = new System.Drawing.Size(100, 20);
            this.nomstade.TabIndex = 2;
            // 
            // lieustade
            // 
            this.lieustade.Location = new System.Drawing.Point(141, 61);
            this.lieustade.Name = "lieustade";
            this.lieustade.Size = new System.Drawing.Size(100, 20);
            this.lieustade.TabIndex = 3;
            // 
            // annuler
            // 
            this.annuler.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.annuler.Location = new System.Drawing.Point(2, 105);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 36);
            this.annuler.TabIndex = 4;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = false;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // fermer
            // 
            this.fermer.Location = new System.Drawing.Point(186, 104);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(85, 38);
            this.fermer.TabIndex = 5;
            this.fermer.Text = "Fermer la fenêtre";
            this.fermer.UseVisualStyleBackColor = true;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enregistrer.Location = new System.Drawing.Point(96, 103);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(75, 38);
            this.enregistrer.TabIndex = 6;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // Stade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 171);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.lieustade);
            this.Controls.Add(this.nomstade);
            this.Controls.Add(this.lieu);
            this.Controls.Add(this.nom);
            this.Name = "Stade";
            this.Text = "Stade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label lieu;
        private System.Windows.Forms.TextBox nomstade;
        private System.Windows.Forms.TextBox lieustade;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Button enregistrer;
    }
}