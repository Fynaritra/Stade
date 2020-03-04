namespace Stade
{
    partial class Reservation
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
            this.lieu = new System.Windows.Forms.Label();
            this.evenements = new System.Windows.Forms.ComboBox();
            this.chaises = new System.Windows.Forms.Label();
            this.labelZone = new System.Windows.Forms.Label();
            this.zone = new System.Windows.Forms.ComboBox();
            this.reservationpaint = new System.Windows.Forms.Panel();
            this.coordinates = new System.Windows.Forms.TextBox();
            this.sieges = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            this.quantite = new System.Windows.Forms.TextBox();
            this.personne = new System.Windows.Forms.Label();
            this.proprio = new System.Windows.Forms.TextBox();
            this.annuler = new System.Windows.Forms.Button();
            this.reserver = new System.Windows.Forms.Button();
            this.dateReservation = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.reservationpaint.SuspendLayout();
            this.SuspendLayout();
            // 
            // lieu
            // 
            this.lieu.AutoSize = true;
            this.lieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lieu.Location = new System.Drawing.Point(78, 0);
            this.lieu.Name = "lieu";
            this.lieu.Size = new System.Drawing.Size(75, 15);
            this.lieu.TabIndex = 3;
            this.lieu.Text = "Evénements";
            // 
            // evenements
            // 
            this.evenements.BackColor = System.Drawing.SystemColors.Window;
            this.evenements.FormattingEnabled = true;
            this.evenements.Location = new System.Drawing.Point(27, 18);
            this.evenements.Name = "evenements";
            this.evenements.Size = new System.Drawing.Size(190, 21);
            this.evenements.TabIndex = 13;
            this.evenements.Tag = "";
            this.evenements.SelectedIndexChanged += new System.EventHandler(this.evenements_SelectedIndexChanged);
            // 
            // chaises
            // 
            this.chaises.AutoSize = true;
            this.chaises.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chaises.Location = new System.Drawing.Point(71, 105);
            this.chaises.Name = "chaises";
            this.chaises.Size = new System.Drawing.Size(102, 15);
            this.chaises.TabIndex = 14;
            this.chaises.Text = "Sièges à réserver";
            // 
            // labelZone
            // 
            this.labelZone.AutoSize = true;
            this.labelZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZone.Location = new System.Drawing.Point(78, 51);
            this.labelZone.Name = "labelZone";
            this.labelZone.Size = new System.Drawing.Size(41, 15);
            this.labelZone.TabIndex = 15;
            this.labelZone.Text = "Zones";
            // 
            // zone
            // 
            this.zone.BackColor = System.Drawing.SystemColors.Window;
            this.zone.FormattingEnabled = true;
            this.zone.Location = new System.Drawing.Point(27, 69);
            this.zone.Name = "zone";
            this.zone.Size = new System.Drawing.Size(190, 21);
            this.zone.TabIndex = 16;
            this.zone.Tag = "";
            // 
            // reservationpaint
            // 
            this.reservationpaint.BackColor = System.Drawing.SystemColors.Window;
            this.reservationpaint.Controls.Add(this.coordinates);
            this.reservationpaint.Location = new System.Drawing.Point(254, 12);
            this.reservationpaint.Name = "reservationpaint";
            this.reservationpaint.Size = new System.Drawing.Size(1027, 463);
            this.reservationpaint.TabIndex = 17;
            // 
            // coordinates
            // 
            this.coordinates.Location = new System.Drawing.Point(-156, 290);
            this.coordinates.Name = "coordinates";
            this.coordinates.Size = new System.Drawing.Size(141, 20);
            this.coordinates.TabIndex = 17;
            // 
            // sieges
            // 
            this.sieges.Location = new System.Drawing.Point(27, 123);
            this.sieges.Name = "sieges";
            this.sieges.Size = new System.Drawing.Size(190, 20);
            this.sieges.TabIndex = 18;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(65, 157);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(108, 15);
            this.nombre.TabIndex = 19;
            this.nombre.Text = "Nombre de sièges";
            // 
            // quantite
            // 
            this.quantite.Location = new System.Drawing.Point(27, 175);
            this.quantite.Name = "quantite";
            this.quantite.Size = new System.Drawing.Size(190, 20);
            this.quantite.TabIndex = 20;
            // 
            // personne
            // 
            this.personne.AutoSize = true;
            this.personne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personne.Location = new System.Drawing.Point(65, 209);
            this.personne.Name = "personne";
            this.personne.Size = new System.Drawing.Size(69, 15);
            this.personne.TabIndex = 21;
            this.personne.Text = "Au nom de:";
            // 
            // proprio
            // 
            this.proprio.Location = new System.Drawing.Point(27, 227);
            this.proprio.Name = "proprio";
            this.proprio.Size = new System.Drawing.Size(190, 20);
            this.proprio.TabIndex = 22;
            // 
            // annuler
            // 
            this.annuler.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.annuler.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler.ForeColor = System.Drawing.Color.Red;
            this.annuler.Location = new System.Drawing.Point(27, 468);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(83, 32);
            this.annuler.TabIndex = 23;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = false;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // reserver
            // 
            this.reserver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserver.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.reserver.Location = new System.Drawing.Point(135, 468);
            this.reserver.Name = "reserver";
            this.reserver.Size = new System.Drawing.Size(82, 32);
            this.reserver.TabIndex = 24;
            this.reserver.Text = "Réserver";
            this.reserver.UseVisualStyleBackColor = true;
            this.reserver.Click += new System.EventHandler(this.reserver_Click);
            // 
            // dateReservation
            // 
            this.dateReservation.Location = new System.Drawing.Point(6, 294);
            this.dateReservation.Name = "dateReservation";
            this.dateReservation.TabIndex = 25;
            this.dateReservation.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dateReservation_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Date de réservation";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateReservation);
            this.Controls.Add(this.reserver);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.proprio);
            this.Controls.Add(this.personne);
            this.Controls.Add(this.quantite);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.sieges);
            this.Controls.Add(this.reservationpaint);
            this.Controls.Add(this.zone);
            this.Controls.Add(this.labelZone);
            this.Controls.Add(this.chaises);
            this.Controls.Add(this.evenements);
            this.Controls.Add(this.lieu);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.reservationpaint.ResumeLayout(false);
            this.reservationpaint.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lieu;
        private System.Windows.Forms.ComboBox evenements;
        private System.Windows.Forms.Label chaises;
        private System.Windows.Forms.Label labelZone;
        private System.Windows.Forms.ComboBox zone;
        private System.Windows.Forms.Panel reservationpaint;
        private System.Windows.Forms.TextBox coordinates;
        private System.Windows.Forms.TextBox sieges;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.TextBox quantite;
        private System.Windows.Forms.Label personne;
        private System.Windows.Forms.TextBox proprio;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button reserver;
        private System.Windows.Forms.MonthCalendar dateReservation;
        private System.Windows.Forms.Label label1;
    }
}