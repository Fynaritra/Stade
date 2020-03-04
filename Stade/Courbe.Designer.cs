namespace Stade
{
    partial class Courbe
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
            this.paintGraphe = new System.Windows.Forms.Panel();
            this.labelEvenement = new System.Windows.Forms.Label();
            this.evenements = new System.Windows.Forms.ComboBox();
            this.voir = new System.Windows.Forms.Button();
            this.tableau = new System.Windows.Forms.DataGridView();
            this.medias = new System.Windows.Forms.DataGridView();
            this.evenementdbDataSet = new evenementdbDataSet();
            this.mediaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediaTableAdapter = new evenementdbDataSetTableAdapters.MediaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenementdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // paintGraphe
            // 
            this.paintGraphe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.paintGraphe.Location = new System.Drawing.Point(12, 47);
            this.paintGraphe.Name = "paintGraphe";
            this.paintGraphe.Size = new System.Drawing.Size(715, 370);
            this.paintGraphe.TabIndex = 0;
            this.paintGraphe.Paint += new System.Windows.Forms.PaintEventHandler(this.paintGraphe_Paint);
            // 
            // labelEvenement
            // 
            this.labelEvenement.AutoSize = true;
            this.labelEvenement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvenement.Location = new System.Drawing.Point(8, 13);
            this.labelEvenement.Name = "labelEvenement";
            this.labelEvenement.Size = new System.Drawing.Size(98, 20);
            this.labelEvenement.TabIndex = 1;
            this.labelEvenement.Text = "Evénements";
            // 
            // evenements
            // 
            this.evenements.FormattingEnabled = true;
            this.evenements.Location = new System.Drawing.Point(112, 15);
            this.evenements.Name = "evenements";
            this.evenements.Size = new System.Drawing.Size(203, 21);
            this.evenements.TabIndex = 2;
            // 
            // voir
            // 
            this.voir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.voir.Font = new System.Drawing.Font("Arial", 10F);
            this.voir.Location = new System.Drawing.Point(334, 7);
            this.voir.Name = "voir";
            this.voir.Size = new System.Drawing.Size(96, 34);
            this.voir.TabIndex = 3;
            this.voir.Text = "Voir graphe";
            this.voir.UseVisualStyleBackColor = false;
            this.voir.Click += new System.EventHandler(this.voir_Click);
            // 
            // tableau
            // 
            this.tableau.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Location = new System.Drawing.Point(743, 67);
            this.tableau.Name = "tableau";
            this.tableau.Size = new System.Drawing.Size(271, 171);
            this.tableau.TabIndex = 0;
            // 
            // medias
            // 
            this.medias.AutoGenerateColumns = false;
            this.medias.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.medias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn});
            this.medias.DataSource = this.mediaBindingSource;
            this.medias.Location = new System.Drawing.Point(743, 289);
            this.medias.Name = "medias";
            this.medias.Size = new System.Drawing.Size(271, 128);
            this.medias.TabIndex = 4;
            // 
            // evenementdbDataSet
            // 
            this.evenementdbDataSet.DataSetName = "evenementdbDataSet";
            this.evenementdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mediaBindingSource
            // 
            this.mediaBindingSource.DataMember = "Media";
            this.mediaBindingSource.DataSource = this.evenementdbDataSet;
            // 
            // mediaTableAdapter
            // 
            this.mediaTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(740, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Liste des médias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(740, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Classement";
            // 
            // Courbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 429);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.medias);
            this.Controls.Add(this.tableau);
            this.Controls.Add(this.voir);
            this.Controls.Add(this.evenements);
            this.Controls.Add(this.labelEvenement);
            this.Controls.Add(this.paintGraphe);
            this.Name = "Courbe";
            this.Text = "Courbe";
            this.Load += new System.EventHandler(this.Courbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenementdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paintGraphe;
        private System.Windows.Forms.Label labelEvenement;
        private System.Windows.Forms.ComboBox evenements;
        private System.Windows.Forms.Button voir;
        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.DataGridView medias;
        private evenementdbDataSet evenementdbDataSet;
        private System.Windows.Forms.BindingSource mediaBindingSource;
        private evenementdbDataSetTableAdapters.MediaTableAdapter mediaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}