namespace Stade
{
    partial class Accueil
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
            this.Stade = new System.Windows.Forms.Button();
            this.reserver = new System.Windows.Forms.Button();
            this.zone = new System.Windows.Forms.Button();
            this.evenement = new System.Windows.Forms.Button();
            this.graphe = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Stade
            // 
            this.Stade.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Stade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stade.Location = new System.Drawing.Point(24, 47);
            this.Stade.Name = "Stade";
            this.Stade.Size = new System.Drawing.Size(128, 35);
            this.Stade.TabIndex = 6;
            this.Stade.Text = "Nouveau lieu";
            this.Stade.UseVisualStyleBackColor = false;
            this.Stade.Click += new System.EventHandler(this.Stade_Click);
            // 
            // reserver
            // 
            this.reserver.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserver.Location = new System.Drawing.Point(24, 120);
            this.reserver.Name = "reserver";
            this.reserver.Size = new System.Drawing.Size(128, 40);
            this.reserver.TabIndex = 8;
            this.reserver.Text = "Réserver places";
            this.reserver.UseVisualStyleBackColor = false;
            this.reserver.Click += new System.EventHandler(this.reserver_Click);
            // 
            // zone
            // 
            this.zone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone.Location = new System.Drawing.Point(363, 47);
            this.zone.Name = "zone";
            this.zone.Size = new System.Drawing.Size(118, 35);
            this.zone.TabIndex = 9;
            this.zone.Text = "Ajouter zones";
            this.zone.UseVisualStyleBackColor = false;
            this.zone.Click += new System.EventHandler(this.zone_Click);
            // 
            // evenement
            // 
            this.evenement.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.evenement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evenement.Location = new System.Drawing.Point(192, 47);
            this.evenement.Name = "evenement";
            this.evenement.Size = new System.Drawing.Size(128, 35);
            this.evenement.TabIndex = 10;
            this.evenement.Text = "Nouveau stade";
            this.evenement.UseVisualStyleBackColor = false;
            this.evenement.Click += new System.EventHandler(this.evenement_Click);
            // 
            // graphe
            // 
            this.graphe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.graphe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphe.Location = new System.Drawing.Point(192, 120);
            this.graphe.Name = "graphe";
            this.graphe.Size = new System.Drawing.Size(128, 40);
            this.graphe.TabIndex = 11;
            this.graphe.Text = "Courbe";
            this.graphe.UseVisualStyleBackColor = false;
            this.graphe.Click += new System.EventHandler(this.recherche_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Green;
            this.title.Location = new System.Drawing.Point(120, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(240, 20);
            this.title.TabIndex = 12;
            this.title.Text = "Gestion de places d\'événements";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(532, 194);
            this.Controls.Add(this.title);
            this.Controls.Add(this.graphe);
            this.Controls.Add(this.evenement);
            this.Controls.Add(this.zone);
            this.Controls.Add(this.reserver);
            this.Controls.Add(this.Stade);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Stade;
        private System.Windows.Forms.Button reserver;
        private System.Windows.Forms.Button zone;
        private System.Windows.Forms.Button evenement;
        private System.Windows.Forms.Button graphe;
        private System.Windows.Forms.Label title;
    }
}

