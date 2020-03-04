namespace Stade
{
    partial class Evenement
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
            this.components = new System.ComponentModel.Container();
            this.lieux = new System.Windows.Forms.ComboBox();
            this.lieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lieu = new System.Windows.Forms.Label();
            this.daty = new System.Windows.Forms.Label();
            this.calendrier = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.annuler = new System.Windows.Forms.Button();
            this.enregistrement = new System.Windows.Forms.Button();
            this.paintstade = new System.Windows.Forms.Panel();
            this.affichage = new System.Windows.Forms.Button();
            this.closeWindow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lieuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lieux
            // 
            this.lieux.BackColor = System.Drawing.SystemColors.Window;
            this.lieux.DisplayMember = "ClassLieu.nom";
            this.lieux.FormattingEnabled = true;
            this.lieux.Location = new System.Drawing.Point(12, 41);
            this.lieux.Name = "lieux";
            this.lieux.Size = new System.Drawing.Size(227, 21);
            this.lieux.TabIndex = 0;
            this.lieux.Tag = "";
            this.lieux.ValueMember = "ClassLieu.nom";
            this.lieux.SelectedIndexChanged += new System.EventHandler(this.lieux_SelectedIndexChanged);
            // 
            // lieuBindingSource
            // 
            this.lieuBindingSource.DataMember = "Lieu";
            // 
            // lieu
            // 
            this.lieu.AutoSize = true;
            this.lieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lieu.Location = new System.Drawing.Point(67, 9);
            this.lieu.Name = "lieu";
            this.lieu.Size = new System.Drawing.Size(118, 15);
            this.lieu.TabIndex = 1;
            this.lieu.Text = "Lieu de l\'événement";
            // 
            // daty
            // 
            this.daty.AutoSize = true;
            this.daty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daty.Location = new System.Drawing.Point(67, 86);
            this.daty.Name = "daty";
            this.daty.Size = new System.Drawing.Size(33, 15);
            this.daty.TabIndex = 2;
            this.daty.Text = "Date";
            // 
            // calendrier
            // 
            this.calendrier.Location = new System.Drawing.Point(12, 123);
            this.calendrier.Name = "calendrier";
            this.calendrier.TabIndex = 3;
            this.calendrier.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendrier_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom de l\'événement";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(12, 342);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(227, 20);
            this.nom.TabIndex = 5;
            // 
            // annuler
            // 
            this.annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler.Location = new System.Drawing.Point(29, 419);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 23);
            this.annuler.TabIndex = 8;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // enregistrement
            // 
            this.enregistrement.BackColor = System.Drawing.SystemColors.Control;
            this.enregistrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrement.Location = new System.Drawing.Point(181, 390);
            this.enregistrement.Name = "enregistrement";
            this.enregistrement.Size = new System.Drawing.Size(75, 23);
            this.enregistrement.TabIndex = 9;
            this.enregistrement.Text = "Enregistrer";
            this.enregistrement.UseVisualStyleBackColor = false;
            this.enregistrement.Click += new System.EventHandler(this.enregistrement_Click);
            // 
            // paintstade
            // 
            this.paintstade.BackColor = System.Drawing.SystemColors.Window;
            this.paintstade.Location = new System.Drawing.Point(262, 9);
            this.paintstade.Name = "paintstade";
            this.paintstade.Size = new System.Drawing.Size(960, 433);
            this.paintstade.TabIndex = 10;
            this.paintstade.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintstade_MouseDown);
            // 
            // affichage
            // 
            this.affichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.affichage.Location = new System.Drawing.Point(29, 390);
            this.affichage.Name = "affichage";
            this.affichage.Size = new System.Drawing.Size(75, 23);
            this.affichage.TabIndex = 11;
            this.affichage.Text = "Afficher ";
            this.affichage.UseVisualStyleBackColor = true;
            this.affichage.Click += new System.EventHandler(this.affichage_Click);
            // 
            // closeWindow
            // 
            this.closeWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeWindow.Location = new System.Drawing.Point(181, 416);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(75, 23);
            this.closeWindow.TabIndex = 12;
            this.closeWindow.Text = "Fermer";
            this.closeWindow.UseVisualStyleBackColor = true;
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // Evenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 451);
            this.Controls.Add(this.closeWindow);
            this.Controls.Add(this.affichage);
            this.Controls.Add(this.paintstade);
            this.Controls.Add(this.enregistrement);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calendrier);
            this.Controls.Add(this.daty);
            this.Controls.Add(this.lieu);
            this.Controls.Add(this.lieux);
            this.Name = "Evenement";
            this.Text = "Evenement";
            this.Load += new System.EventHandler(this.Evenement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lieuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lieux;
        private System.Windows.Forms.Label lieu;
        private System.Windows.Forms.Label daty;
        private System.Windows.Forms.MonthCalendar calendrier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button enregistrement;
        private System.Windows.Forms.Panel paintstade;
        private System.Windows.Forms.Button affichage;
        private System.Windows.Forms.BindingSource lieuBindingSource;
        private System.Windows.Forms.Button closeWindow;
    }
}