namespace ArtGallery.View
{
    partial class VAngajat
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
            this.buttonCauta = new System.Windows.Forms.Button();
            this.labelInformatieCautata = new System.Windows.Forms.Label();
            this.textBoxInformatieCautata = new System.Windows.Forms.TextBox();
            this.comboBoxCriteriu = new System.Windows.Forms.ComboBox();
            this.labelCriteriuFiltrare = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelListaOpere = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Titlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnRealizare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDisplayUsername = new System.Windows.Forms.Label();
            this.textBoxTehnica = new System.Windows.Forms.TextBox();
            this.textBoxGen_Tip = new System.Windows.Forms.TextBox();
            this.labelTehnica = new System.Windows.Forms.Label();
            this.labelGen_Tip = new System.Windows.Forms.Label();
            this.textBoxAnRealizare = new System.Windows.Forms.TextBox();
            this.textBoxNumeArtist = new System.Windows.Forms.TextBox();
            this.textBoxTitlu = new System.Windows.Forms.TextBox();
            this.labelAnRealizare = new System.Windows.Forms.Label();
            this.labelNumeArtist = new System.Windows.Forms.Label();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.labelTipOpera = new System.Windows.Forms.Label();
            this.comboBoxTipOpera = new System.Windows.Forms.ComboBox();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdauga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCauta
            // 
            this.buttonCauta.Location = new System.Drawing.Point(28, 561);
            this.buttonCauta.Name = "buttonCauta";
            this.buttonCauta.Size = new System.Drawing.Size(75, 23);
            this.buttonCauta.TabIndex = 15;
            this.buttonCauta.Text = "Cauta";
            this.buttonCauta.UseVisualStyleBackColor = true;
            // 
            // labelInformatieCautata
            // 
            this.labelInformatieCautata.AutoSize = true;
            this.labelInformatieCautata.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformatieCautata.Location = new System.Drawing.Point(25, 485);
            this.labelInformatieCautata.Name = "labelInformatieCautata";
            this.labelInformatieCautata.Size = new System.Drawing.Size(296, 29);
            this.labelInformatieCautata.TabIndex = 14;
            this.labelInformatieCautata.Text = "INFORMATIE CAUTATA";
            // 
            // textBoxInformatieCautata
            // 
            this.textBoxInformatieCautata.Location = new System.Drawing.Point(28, 517);
            this.textBoxInformatieCautata.Name = "textBoxInformatieCautata";
            this.textBoxInformatieCautata.Size = new System.Drawing.Size(100, 22);
            this.textBoxInformatieCautata.TabIndex = 13;
            // 
            // comboBoxCriteriu
            // 
            this.comboBoxCriteriu.FormattingEnabled = true;
            this.comboBoxCriteriu.Items.AddRange(new object[] {
            "Nume artist",
            "Tip opera"});
            this.comboBoxCriteriu.Location = new System.Drawing.Point(28, 443);
            this.comboBoxCriteriu.Name = "comboBoxCriteriu";
            this.comboBoxCriteriu.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCriteriu.TabIndex = 12;
            // 
            // labelCriteriuFiltrare
            // 
            this.labelCriteriuFiltrare.AutoSize = true;
            this.labelCriteriuFiltrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCriteriuFiltrare.Location = new System.Drawing.Point(25, 402);
            this.labelCriteriuFiltrare.Name = "labelCriteriuFiltrare";
            this.labelCriteriuFiltrare.Size = new System.Drawing.Size(263, 29);
            this.labelCriteriuFiltrare.TabIndex = 11;
            this.labelCriteriuFiltrare.Text = "CRITERIU FILTRARE";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(220, 348);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // labelListaOpere
            // 
            this.labelListaOpere.AutoSize = true;
            this.labelListaOpere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaOpere.Location = new System.Drawing.Point(124, 25);
            this.labelListaOpere.Name = "labelListaOpere";
            this.labelListaOpere.Size = new System.Drawing.Size(276, 26);
            this.labelListaOpere.TabIndex = 9;
            this.labelListaOpere.Text = "LISTA OPERE DE ARTA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titlu,
            this.NumeArtist,
            this.AnRealizare});
            this.dataGridView1.Location = new System.Drawing.Point(30, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(483, 258);
            this.dataGridView1.TabIndex = 8;
            // 
            // Titlu
            // 
            this.Titlu.HeaderText = "Titlu Opera";
            this.Titlu.Name = "Titlu";
            this.Titlu.Width = 150;
            // 
            // NumeArtist
            // 
            this.NumeArtist.HeaderText = "Nume Artist";
            this.NumeArtist.Name = "NumeArtist";
            this.NumeArtist.Width = 150;
            // 
            // AnRealizare
            // 
            this.AnRealizare.HeaderText = "An Realizare Opera";
            this.AnRealizare.Name = "AnRealizare";
            // 
            // labelDisplayUsername
            // 
            this.labelDisplayUsername.AutoSize = true;
            this.labelDisplayUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayUsername.Location = new System.Drawing.Point(960, 14);
            this.labelDisplayUsername.Name = "labelDisplayUsername";
            this.labelDisplayUsername.Size = new System.Drawing.Size(128, 29);
            this.labelDisplayUsername.TabIndex = 40;
            this.labelDisplayUsername.Text = "username";
            // 
            // textBoxTehnica
            // 
            this.textBoxTehnica.Location = new System.Drawing.Point(844, 392);
            this.textBoxTehnica.Name = "textBoxTehnica";
            this.textBoxTehnica.Size = new System.Drawing.Size(216, 22);
            this.textBoxTehnica.TabIndex = 39;
            // 
            // textBoxGen_Tip
            // 
            this.textBoxGen_Tip.Location = new System.Drawing.Point(844, 346);
            this.textBoxGen_Tip.Name = "textBoxGen_Tip";
            this.textBoxGen_Tip.Size = new System.Drawing.Size(216, 22);
            this.textBoxGen_Tip.TabIndex = 38;
            // 
            // labelTehnica
            // 
            this.labelTehnica.AutoSize = true;
            this.labelTehnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTehnica.Location = new System.Drawing.Point(731, 385);
            this.labelTehnica.Name = "labelTehnica";
            this.labelTehnica.Size = new System.Drawing.Size(107, 29);
            this.labelTehnica.TabIndex = 37;
            this.labelTehnica.Text = "Tehnica";
            // 
            // labelGen_Tip
            // 
            this.labelGen_Tip.AutoSize = true;
            this.labelGen_Tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGen_Tip.Location = new System.Drawing.Point(525, 339);
            this.labelGen_Tip.Name = "labelGen_Tip";
            this.labelGen_Tip.Size = new System.Drawing.Size(313, 29);
            this.labelGen_Tip.TabIndex = 36;
            this.labelGen_Tip.Text = "Gen Pictura/Tip Sculptura";
            // 
            // textBoxAnRealizare
            // 
            this.textBoxAnRealizare.Location = new System.Drawing.Point(844, 259);
            this.textBoxAnRealizare.Name = "textBoxAnRealizare";
            this.textBoxAnRealizare.Size = new System.Drawing.Size(216, 22);
            this.textBoxAnRealizare.TabIndex = 35;
            // 
            // textBoxNumeArtist
            // 
            this.textBoxNumeArtist.Location = new System.Drawing.Point(844, 213);
            this.textBoxNumeArtist.Name = "textBoxNumeArtist";
            this.textBoxNumeArtist.Size = new System.Drawing.Size(216, 22);
            this.textBoxNumeArtist.TabIndex = 34;
            // 
            // textBoxTitlu
            // 
            this.textBoxTitlu.Location = new System.Drawing.Point(844, 167);
            this.textBoxTitlu.Name = "textBoxTitlu";
            this.textBoxTitlu.Size = new System.Drawing.Size(216, 22);
            this.textBoxTitlu.TabIndex = 33;
            // 
            // labelAnRealizare
            // 
            this.labelAnRealizare.AutoSize = true;
            this.labelAnRealizare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnRealizare.Location = new System.Drawing.Point(686, 252);
            this.labelAnRealizare.Name = "labelAnRealizare";
            this.labelAnRealizare.Size = new System.Drawing.Size(152, 29);
            this.labelAnRealizare.TabIndex = 32;
            this.labelAnRealizare.Text = "An realizare";
            // 
            // labelNumeArtist
            // 
            this.labelNumeArtist.AutoSize = true;
            this.labelNumeArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeArtist.Location = new System.Drawing.Point(690, 206);
            this.labelNumeArtist.Name = "labelNumeArtist";
            this.labelNumeArtist.Size = new System.Drawing.Size(148, 29);
            this.labelNumeArtist.TabIndex = 31;
            this.labelNumeArtist.Text = "Nume Artist";
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlu.Location = new System.Drawing.Point(773, 160);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(65, 29);
            this.labelTitlu.TabIndex = 30;
            this.labelTitlu.Text = "Titlu";
            // 
            // labelTipOpera
            // 
            this.labelTipOpera.AutoSize = true;
            this.labelTipOpera.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipOpera.Location = new System.Drawing.Point(711, 92);
            this.labelTipOpera.Name = "labelTipOpera";
            this.labelTipOpera.Size = new System.Drawing.Size(127, 29);
            this.labelTipOpera.TabIndex = 29;
            this.labelTipOpera.Text = "Tip opera";
            // 
            // comboBoxTipOpera
            // 
            this.comboBoxTipOpera.FormattingEnabled = true;
            this.comboBoxTipOpera.Items.AddRange(new object[] {
            "Opera de Arta",
            "Tablou",
            "Sculptura"});
            this.comboBoxTipOpera.Location = new System.Drawing.Point(844, 99);
            this.comboBoxTipOpera.Name = "comboBoxTipOpera";
            this.comboBoxTipOpera.Size = new System.Drawing.Size(216, 24);
            this.comboBoxTipOpera.TabIndex = 28;
            // 
            // buttonSterge
            // 
            this.buttonSterge.Location = new System.Drawing.Point(550, 196);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(75, 23);
            this.buttonSterge.TabIndex = 27;
            this.buttonSterge.Text = "Sterge";
            this.buttonSterge.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(550, 149);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 26;
            this.buttonEdit.Text = "Editeaza";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(550, 98);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(75, 23);
            this.buttonAdauga.TabIndex = 25;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            // 
            // VAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 705);
            this.Controls.Add(this.labelDisplayUsername);
            this.Controls.Add(this.textBoxTehnica);
            this.Controls.Add(this.textBoxGen_Tip);
            this.Controls.Add(this.labelTehnica);
            this.Controls.Add(this.labelGen_Tip);
            this.Controls.Add(this.textBoxAnRealizare);
            this.Controls.Add(this.textBoxNumeArtist);
            this.Controls.Add(this.textBoxTitlu);
            this.Controls.Add(this.labelAnRealizare);
            this.Controls.Add(this.labelNumeArtist);
            this.Controls.Add(this.labelTitlu);
            this.Controls.Add(this.labelTipOpera);
            this.Controls.Add(this.comboBoxTipOpera);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.buttonCauta);
            this.Controls.Add(this.labelInformatieCautata);
            this.Controls.Add(this.textBoxInformatieCautata);
            this.Controls.Add(this.comboBoxCriteriu);
            this.Controls.Add(this.labelCriteriuFiltrare);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelListaOpere);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VAngajat";
            this.Text = "VOpereArtaAngajat";
            this.Load += new System.EventHandler(this.VAngajat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCauta;
        private System.Windows.Forms.Label labelInformatieCautata;
        private System.Windows.Forms.TextBox textBoxInformatieCautata;
        private System.Windows.Forms.ComboBox comboBoxCriteriu;
        private System.Windows.Forms.Label labelCriteriuFiltrare;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelListaOpere;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnRealizare;
        private System.Windows.Forms.Label labelDisplayUsername;
        private System.Windows.Forms.TextBox textBoxTehnica;
        private System.Windows.Forms.TextBox textBoxGen_Tip;
        private System.Windows.Forms.Label labelTehnica;
        private System.Windows.Forms.Label labelGen_Tip;
        private System.Windows.Forms.TextBox textBoxAnRealizare;
        private System.Windows.Forms.TextBox textBoxNumeArtist;
        private System.Windows.Forms.TextBox textBoxTitlu;
        private System.Windows.Forms.Label labelAnRealizare;
        private System.Windows.Forms.Label labelNumeArtist;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Label labelTipOpera;
        private System.Windows.Forms.ComboBox comboBoxTipOpera;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdauga;
    }
}