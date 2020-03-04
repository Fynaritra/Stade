namespace Stade
{
    partial class Zone
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
            this.paintzone = new System.Windows.Forms.Panel();
            this.coordinates = new System.Windows.Forms.TextBox();
            this.lieu = new System.Windows.Forms.Label();
            this.evenements = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nomZone = new System.Windows.Forms.TextBox();
            this.enregistrer = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.espacement = new System.Windows.Forms.Label();
            this.espace = new System.Windows.Forms.TextBox();
            this.large = new System.Windows.Forms.Label();
            this.longue = new System.Windows.Forms.Label();
            this.longueur = new System.Windows.Forms.TextBox();
            this.largeur = new System.Windows.Forms.TextBox();
            this.direc = new System.Windows.Forms.Label();
            this.direction = new System.Windows.Forms.ComboBox();
            this.vert = new System.Windows.Forms.Label();
            this.sensvertical = new System.Windows.Forms.ComboBox();
            this.horiz = new System.Windows.Forms.Label();
            this.senshorizontal = new System.Windows.Forms.ComboBox();
            this.beginning = new System.Windows.Forms.Label();
            this.debutnum = new System.Windows.Forms.TextBox();
            this.simulation = new System.Windows.Forms.Button();
            this.buttonchaises = new System.Windows.Forms.Button();
            this.afficher = new System.Windows.Forms.Button();
            this.init = new System.Windows.Forms.Button();
            this.remplissage = new System.Windows.Forms.Label();
            this.taux = new System.Windows.Forms.TextBox();
            this.pu = new System.Windows.Forms.Label();
            this.argent = new System.Windows.Forms.Label();
            this.gain = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.paintzone.SuspendLayout();
            this.SuspendLayout();
            // 
            // paintzone
            // 
            this.paintzone.BackColor = System.Drawing.SystemColors.Window;
            this.paintzone.Controls.Add(this.coordinates);
            this.paintzone.Location = new System.Drawing.Point(334, 28);
            this.paintzone.Name = "paintzone";
            this.paintzone.Size = new System.Drawing.Size(960, 433);
            this.paintzone.TabIndex = 11;
            this.paintzone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paintzone_MouseClick);
            this.paintzone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintzone_MouseDown);
            // 
            // coordinates
            // 
            this.coordinates.Location = new System.Drawing.Point(-156, 290);
            this.coordinates.Name = "coordinates";
            this.coordinates.Size = new System.Drawing.Size(141, 20);
            this.coordinates.TabIndex = 17;
            // 
            // lieu
            // 
            this.lieu.AutoSize = true;
            this.lieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lieu.Location = new System.Drawing.Point(12, 8);
            this.lieu.Name = "lieu";
            this.lieu.Size = new System.Drawing.Size(75, 15);
            this.lieu.TabIndex = 2;
            this.lieu.Text = "Evénements";
            // 
            // evenements
            // 
            this.evenements.BackColor = System.Drawing.SystemColors.Window;
            this.evenements.FormattingEnabled = true;
            this.evenements.Location = new System.Drawing.Point(3, 27);
            this.evenements.Name = "evenements";
            this.evenements.Size = new System.Drawing.Size(141, 21);
            this.evenements.TabIndex = 12;
            this.evenements.Tag = "";
            this.evenements.SelectedIndexChanged += new System.EventHandler(this.evenements_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nom de la zone";
            // 
            // nomZone
            // 
            this.nomZone.Location = new System.Drawing.Point(174, 28);
            this.nomZone.Name = "nomZone";
            this.nomZone.Size = new System.Drawing.Size(141, 20);
            this.nomZone.TabIndex = 14;
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrer.Location = new System.Drawing.Point(179, 392);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(121, 30);
            this.enregistrer.TabIndex = 18;
            this.enregistrer.Text = "Ajouter zone";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // annuler
            // 
            this.annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler.Location = new System.Drawing.Point(179, 464);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(121, 31);
            this.annuler.TabIndex = 19;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // espacement
            // 
            this.espacement.AutoSize = true;
            this.espacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.espacement.Location = new System.Drawing.Point(171, 131);
            this.espacement.Name = "espacement";
            this.espacement.Size = new System.Drawing.Size(144, 15);
            this.espacement.TabIndex = 20;
            this.espacement.Text = "Espacement des chaises";
            // 
            // espace
            // 
            this.espace.Location = new System.Drawing.Point(174, 158);
            this.espace.Name = "espace";
            this.espace.Size = new System.Drawing.Size(141, 20);
            this.espace.TabIndex = 21;
            // 
            // large
            // 
            this.large.AutoSize = true;
            this.large.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.large.Location = new System.Drawing.Point(12, 329);
            this.large.Name = "large";
            this.large.Size = new System.Drawing.Size(118, 15);
            this.large.TabIndex = 22;
            this.large.Text = "Largeur des chaises";
            // 
            // longue
            // 
            this.longue.AutoSize = true;
            this.longue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longue.Location = new System.Drawing.Point(197, 329);
            this.longue.Name = "longue";
            this.longue.Size = new System.Drawing.Size(60, 15);
            this.longue.TabIndex = 23;
            this.longue.Text = "Longueur";
            // 
            // longueur
            // 
            this.longueur.Location = new System.Drawing.Point(174, 357);
            this.longueur.Name = "longueur";
            this.longueur.Size = new System.Drawing.Size(141, 20);
            this.longueur.TabIndex = 24;
            // 
            // largeur
            // 
            this.largeur.Location = new System.Drawing.Point(3, 357);
            this.largeur.Name = "largeur";
            this.largeur.Size = new System.Drawing.Size(141, 20);
            this.largeur.TabIndex = 25;
            // 
            // direc
            // 
            this.direc.AutoSize = true;
            this.direc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direc.Location = new System.Drawing.Point(171, 198);
            this.direc.Name = "direc";
            this.direc.Size = new System.Drawing.Size(149, 15);
            this.direc.TabIndex = 26;
            this.direc.Text = "Direction de numérotation";
            // 
            // direction
            // 
            this.direction.BackColor = System.Drawing.SystemColors.Window;
            this.direction.FormattingEnabled = true;
            this.direction.Items.AddRange(new object[] {
            "Verticale",
            "Horizontale"});
            this.direction.Location = new System.Drawing.Point(174, 225);
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(141, 21);
            this.direction.TabIndex = 27;
            this.direction.Tag = "";
            // 
            // vert
            // 
            this.vert.AutoSize = true;
            this.vert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vert.Location = new System.Drawing.Point(197, 265);
            this.vert.Name = "vert";
            this.vert.Size = new System.Drawing.Size(76, 15);
            this.vert.TabIndex = 28;
            this.vert.Text = "Sens vertical";
            // 
            // sensvertical
            // 
            this.sensvertical.BackColor = System.Drawing.SystemColors.Window;
            this.sensvertical.FormattingEnabled = true;
            this.sensvertical.Items.AddRange(new object[] {
            "Haut-Bas",
            "Bas-Haut"});
            this.sensvertical.Location = new System.Drawing.Point(174, 292);
            this.sensvertical.Name = "sensvertical";
            this.sensvertical.Size = new System.Drawing.Size(141, 21);
            this.sensvertical.TabIndex = 29;
            this.sensvertical.Tag = "";
            // 
            // horiz
            // 
            this.horiz.AutoSize = true;
            this.horiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horiz.Location = new System.Drawing.Point(12, 265);
            this.horiz.Name = "horiz";
            this.horiz.Size = new System.Drawing.Size(92, 15);
            this.horiz.TabIndex = 30;
            this.horiz.Text = "Sens horizontal";
            // 
            // senshorizontal
            // 
            this.senshorizontal.BackColor = System.Drawing.SystemColors.Window;
            this.senshorizontal.FormattingEnabled = true;
            this.senshorizontal.Items.AddRange(new object[] {
            "Droite-Gauche",
            "Gauche-Droite"});
            this.senshorizontal.Location = new System.Drawing.Point(3, 292);
            this.senshorizontal.Name = "senshorizontal";
            this.senshorizontal.Size = new System.Drawing.Size(141, 21);
            this.senshorizontal.TabIndex = 31;
            this.senshorizontal.Tag = "";
            // 
            // beginning
            // 
            this.beginning.AutoSize = true;
            this.beginning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginning.Location = new System.Drawing.Point(9, 198);
            this.beginning.Name = "beginning";
            this.beginning.Size = new System.Drawing.Size(133, 15);
            this.beginning.TabIndex = 32;
            this.beginning.Text = "Début de numérotation";
            // 
            // debutnum
            // 
            this.debutnum.Location = new System.Drawing.Point(3, 225);
            this.debutnum.Name = "debutnum";
            this.debutnum.Size = new System.Drawing.Size(141, 20);
            this.debutnum.TabIndex = 33;
            // 
            // simulation
            // 
            this.simulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simulation.Location = new System.Drawing.Point(12, 428);
            this.simulation.Name = "simulation";
            this.simulation.Size = new System.Drawing.Size(121, 30);
            this.simulation.TabIndex = 34;
            this.simulation.Text = "Simuler";
            this.simulation.UseVisualStyleBackColor = true;
            this.simulation.Click += new System.EventHandler(this.simulation_Click);
            // 
            // buttonchaises
            // 
            this.buttonchaises.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonchaises.Location = new System.Drawing.Point(179, 428);
            this.buttonchaises.Name = "buttonchaises";
            this.buttonchaises.Size = new System.Drawing.Size(121, 30);
            this.buttonchaises.TabIndex = 35;
            this.buttonchaises.Text = "Enregistrer chaises";
            this.buttonchaises.UseVisualStyleBackColor = true;
            this.buttonchaises.Click += new System.EventHandler(this.buttonchaises_Click);
            // 
            // afficher
            // 
            this.afficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afficher.Location = new System.Drawing.Point(12, 392);
            this.afficher.Name = "afficher";
            this.afficher.Size = new System.Drawing.Size(121, 30);
            this.afficher.TabIndex = 36;
            this.afficher.Text = "Afficher";
            this.afficher.UseVisualStyleBackColor = true;
            this.afficher.Click += new System.EventHandler(this.afficher_Click);
            // 
            // init
            // 
            this.init.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.init.Location = new System.Drawing.Point(12, 464);
            this.init.Name = "init";
            this.init.Size = new System.Drawing.Size(121, 31);
            this.init.TabIndex = 37;
            this.init.Text = "Réinitialiser";
            this.init.UseVisualStyleBackColor = true;
            this.init.Click += new System.EventHandler(this.init_Click);
            // 
            // remplissage
            // 
            this.remplissage.AutoSize = true;
            this.remplissage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remplissage.Location = new System.Drawing.Point(12, 131);
            this.remplissage.Name = "remplissage";
            this.remplissage.Size = new System.Drawing.Size(105, 15);
            this.remplissage.TabIndex = 21;
            this.remplissage.Text = "Taux remplissage";
            // 
            // taux
            // 
            this.taux.Location = new System.Drawing.Point(3, 158);
            this.taux.Name = "taux";
            this.taux.Size = new System.Drawing.Size(141, 20);
            this.taux.TabIndex = 38;
            // 
            // pu
            // 
            this.pu.AutoSize = true;
            this.pu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pu.Location = new System.Drawing.Point(12, 62);
            this.pu.Name = "pu";
            this.pu.Size = new System.Drawing.Size(72, 15);
            this.pu.TabIndex = 39;
            this.pu.Text = "Prix unitaire";
            // 
            // argent
            // 
            this.argent.AutoSize = true;
            this.argent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.argent.Location = new System.Drawing.Point(197, 62);
            this.argent.Name = "argent";
            this.argent.Size = new System.Drawing.Size(83, 15);
            this.argent.TabIndex = 40;
            this.argent.Text = "Gain potentiel";
            // 
            // gain
            // 
            this.gain.Location = new System.Drawing.Point(174, 94);
            this.gain.Name = "gain";
            this.gain.Size = new System.Drawing.Size(141, 20);
            this.gain.TabIndex = 41;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(3, 94);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(141, 20);
            this.price.TabIndex = 42;
            // 
            // Zone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 527);
            this.Controls.Add(this.price);
            this.Controls.Add(this.gain);
            this.Controls.Add(this.argent);
            this.Controls.Add(this.pu);
            this.Controls.Add(this.taux);
            this.Controls.Add(this.remplissage);
            this.Controls.Add(this.init);
            this.Controls.Add(this.afficher);
            this.Controls.Add(this.buttonchaises);
            this.Controls.Add(this.simulation);
            this.Controls.Add(this.debutnum);
            this.Controls.Add(this.beginning);
            this.Controls.Add(this.senshorizontal);
            this.Controls.Add(this.horiz);
            this.Controls.Add(this.sensvertical);
            this.Controls.Add(this.vert);
            this.Controls.Add(this.direction);
            this.Controls.Add(this.direc);
            this.Controls.Add(this.largeur);
            this.Controls.Add(this.longueur);
            this.Controls.Add(this.longue);
            this.Controls.Add(this.large);
            this.Controls.Add(this.espace);
            this.Controls.Add(this.espacement);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.nomZone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.evenements);
            this.Controls.Add(this.lieu);
            this.Controls.Add(this.paintzone);
            this.Name = "Zone";
            this.Text = "Zone";
            this.Load += new System.EventHandler(this.Zone_Load);
            this.paintzone.ResumeLayout(false);
            this.paintzone.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paintzone;
        private System.Windows.Forms.Label lieu;
        private System.Windows.Forms.ComboBox evenements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomZone;
        private System.Windows.Forms.TextBox coordinates;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Label espacement;
        private System.Windows.Forms.TextBox espace;
        private System.Windows.Forms.Label large;
        private System.Windows.Forms.Label longue;
        private System.Windows.Forms.TextBox longueur;
        private System.Windows.Forms.TextBox largeur;
        private System.Windows.Forms.Label direc;
        private System.Windows.Forms.ComboBox direction;
        private System.Windows.Forms.Label vert;
        private System.Windows.Forms.ComboBox sensvertical;
        private System.Windows.Forms.Label horiz;
        private System.Windows.Forms.ComboBox senshorizontal;
        private System.Windows.Forms.Label beginning;
        private System.Windows.Forms.TextBox debutnum;
        private System.Windows.Forms.Button simulation;
        private System.Windows.Forms.Button buttonchaises;
        private System.Windows.Forms.Button afficher;
        private System.Windows.Forms.Button init;
        private System.Windows.Forms.Label remplissage;
        private System.Windows.Forms.TextBox taux;
        private System.Windows.Forms.Label pu;
        private System.Windows.Forms.Label argent;
        private System.Windows.Forms.TextBox gain;
        private System.Windows.Forms.TextBox price;
    }
}