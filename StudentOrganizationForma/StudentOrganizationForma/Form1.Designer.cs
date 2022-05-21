namespace StudentOrganizationForma
{
    partial class Form1
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblBrInd = new System.Windows.Forms.Label();
            this.numBrInd = new System.Windows.Forms.NumericUpDown();
            this.tbxPrezime = new System.Windows.Forms.TextBox();
            this.tbxIme = new System.Windows.Forms.TextBox();
            this.gbxNivoStud = new System.Windows.Forms.GroupBox();
            this.rdbDoktorske = new System.Windows.Forms.RadioButton();
            this.rdbOsnovne = new System.Windows.Forms.RadioButton();
            this.rdbMaster = new System.Windows.Forms.RadioButton();
            this.lblGodStud = new System.Windows.Forms.Label();
            this.lblProsek = new System.Windows.Forms.Label();
            this.numGodStud = new System.Windows.Forms.NumericUpDown();
            this.numProsek = new System.Windows.Forms.NumericUpDown();
            this.cbxBudzet = new System.Windows.Forms.CheckBox();
            this.lblDatRodj = new System.Windows.Forms.Label();
            this.datRodj = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.lbxStudenti = new System.Windows.Forms.ListBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fajlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sacuvajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucitajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numBrInd)).BeginInit();
            this.gbxNivoStud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGodStud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProsek)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(140, 50);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(40, 20);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(110, 98);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(70, 20);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblBrInd
            // 
            this.lblBrInd.AutoSize = true;
            this.lblBrInd.Location = new System.Drawing.Point(80, 146);
            this.lblBrInd.Name = "lblBrInd";
            this.lblBrInd.Size = new System.Drawing.Size(100, 20);
            this.lblBrInd.TabIndex = 2;
            this.lblBrInd.Text = "Broj indeksa:";
            // 
            // numBrInd
            // 
            this.numBrInd.Location = new System.Drawing.Point(186, 144);
            this.numBrInd.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numBrInd.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBrInd.Name = "numBrInd";
            this.numBrInd.Size = new System.Drawing.Size(135, 26);
            this.numBrInd.TabIndex = 3;
            this.numBrInd.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // tbxPrezime
            // 
            this.tbxPrezime.Location = new System.Drawing.Point(186, 95);
            this.tbxPrezime.Name = "tbxPrezime";
            this.tbxPrezime.Size = new System.Drawing.Size(135, 26);
            this.tbxPrezime.TabIndex = 4;
            // 
            // tbxIme
            // 
            this.tbxIme.Location = new System.Drawing.Point(186, 47);
            this.tbxIme.Name = "tbxIme";
            this.tbxIme.Size = new System.Drawing.Size(135, 26);
            this.tbxIme.TabIndex = 5;
            // 
            // gbxNivoStud
            // 
            this.gbxNivoStud.Controls.Add(this.rdbDoktorske);
            this.gbxNivoStud.Controls.Add(this.rdbOsnovne);
            this.gbxNivoStud.Controls.Add(this.rdbMaster);
            this.gbxNivoStud.Location = new System.Drawing.Point(16, 176);
            this.gbxNivoStud.Name = "gbxNivoStud";
            this.gbxNivoStud.Size = new System.Drawing.Size(313, 63);
            this.gbxNivoStud.TabIndex = 6;
            this.gbxNivoStud.TabStop = false;
            this.gbxNivoStud.Text = "Nivo studija:";
            // 
            // rdbDoktorske
            // 
            this.rdbDoktorske.AutoSize = true;
            this.rdbDoktorske.Location = new System.Drawing.Point(198, 25);
            this.rdbDoktorske.Name = "rdbDoktorske";
            this.rdbDoktorske.Size = new System.Drawing.Size(107, 24);
            this.rdbDoktorske.TabIndex = 9;
            this.rdbDoktorske.TabStop = true;
            this.rdbDoktorske.Text = "Doktorske";
            this.rdbDoktorske.UseVisualStyleBackColor = true;
            this.rdbDoktorske.CheckedChanged += new System.EventHandler(this.rdbOsnovne_CheckedChanged);
            // 
            // rdbOsnovne
            // 
            this.rdbOsnovne.AutoSize = true;
            this.rdbOsnovne.Location = new System.Drawing.Point(6, 25);
            this.rdbOsnovne.Name = "rdbOsnovne";
            this.rdbOsnovne.Size = new System.Drawing.Size(97, 24);
            this.rdbOsnovne.TabIndex = 7;
            this.rdbOsnovne.TabStop = true;
            this.rdbOsnovne.Text = "Osnovne";
            this.rdbOsnovne.UseVisualStyleBackColor = true;
            this.rdbOsnovne.CheckedChanged += new System.EventHandler(this.rdbOsnovne_CheckedChanged);
            // 
            // rdbMaster
            // 
            this.rdbMaster.AutoSize = true;
            this.rdbMaster.Location = new System.Drawing.Point(109, 25);
            this.rdbMaster.Name = "rdbMaster";
            this.rdbMaster.Size = new System.Drawing.Size(83, 24);
            this.rdbMaster.TabIndex = 8;
            this.rdbMaster.TabStop = true;
            this.rdbMaster.Text = "Master";
            this.rdbMaster.UseVisualStyleBackColor = true;
            this.rdbMaster.CheckedChanged += new System.EventHandler(this.rdbOsnovne_CheckedChanged);
            // 
            // lblGodStud
            // 
            this.lblGodStud.AutoSize = true;
            this.lblGodStud.Location = new System.Drawing.Point(68, 247);
            this.lblGodStud.Name = "lblGodStud";
            this.lblGodStud.Size = new System.Drawing.Size(115, 20);
            this.lblGodStud.TabIndex = 7;
            this.lblGodStud.Text = "Godina studija:";
            // 
            // lblProsek
            // 
            this.lblProsek.AutoSize = true;
            this.lblProsek.Location = new System.Drawing.Point(121, 280);
            this.lblProsek.Name = "lblProsek";
            this.lblProsek.Size = new System.Drawing.Size(62, 20);
            this.lblProsek.TabIndex = 8;
            this.lblProsek.Text = "Prosek:";
            // 
            // numGodStud
            // 
            this.numGodStud.Location = new System.Drawing.Point(189, 245);
            this.numGodStud.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numGodStud.Name = "numGodStud";
            this.numGodStud.Size = new System.Drawing.Size(135, 26);
            this.numGodStud.TabIndex = 9;
            // 
            // numProsek
            // 
            this.numProsek.DecimalPlaces = 2;
            this.numProsek.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numProsek.Location = new System.Drawing.Point(189, 280);
            this.numProsek.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numProsek.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numProsek.Name = "numProsek";
            this.numProsek.Size = new System.Drawing.Size(135, 26);
            this.numProsek.TabIndex = 10;
            this.numProsek.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cbxBudzet
            // 
            this.cbxBudzet.AutoSize = true;
            this.cbxBudzet.Location = new System.Drawing.Point(140, 321);
            this.cbxBudzet.Name = "cbxBudzet";
            this.cbxBudzet.Size = new System.Drawing.Size(198, 24);
            this.cbxBudzet.TabIndex = 11;
            this.cbxBudzet.Text = "Finansiranje iz budzeta";
            this.cbxBudzet.UseVisualStyleBackColor = true;
            // 
            // lblDatRodj
            // 
            this.lblDatRodj.AutoSize = true;
            this.lblDatRodj.Location = new System.Drawing.Point(59, 361);
            this.lblDatRodj.Name = "lblDatRodj";
            this.lblDatRodj.Size = new System.Drawing.Size(121, 20);
            this.lblDatRodj.TabIndex = 12;
            this.lblDatRodj.Text = "Datum rodjenja:";
            // 
            // datRodj
            // 
            this.datRodj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datRodj.Location = new System.Drawing.Point(186, 356);
            this.datRodj.Name = "datRodj";
            this.datRodj.Size = new System.Drawing.Size(143, 26);
            this.datRodj.TabIndex = 13;
            // 
            // btnDodaj
            // 
            this.btnDodaj.AutoSize = true;
            this.btnDodaj.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDodaj.Location = new System.Drawing.Point(77, 396);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(61, 30);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.AutoSize = true;
            this.btnObrisi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnObrisi.Location = new System.Drawing.Point(144, 396);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(59, 30);
            this.btnObrisi.TabIndex = 15;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnProsledi
            // 
            this.btnProsledi.AutoSize = true;
            this.btnProsledi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProsledi.Location = new System.Drawing.Point(209, 396);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(120, 30);
            this.btnProsledi.TabIndex = 16;
            this.btnProsledi.Text = "Prosledi u listu";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // lbxStudenti
            // 
            this.lbxStudenti.FormattingEnabled = true;
            this.lbxStudenti.ItemHeight = 20;
            this.lbxStudenti.Location = new System.Drawing.Point(16, 437);
            this.lbxStudenti.Name = "lbxStudenti";
            this.lbxStudenti.Size = new System.Drawing.Size(308, 104);
            this.lbxStudenti.TabIndex = 18;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.AutoSize = true;
            this.btnSacuvaj.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSacuvaj.Location = new System.Drawing.Point(181, 547);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 30);
            this.btnSacuvaj.TabIndex = 19;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.AutoSize = true;
            this.btnUcitaj.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUcitaj.Location = new System.Drawing.Point(262, 547);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(59, 30);
            this.btnUcitaj.TabIndex = 20;
            this.btnUcitaj.Text = "Ucitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fajlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(350, 33);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fajlToolStripMenuItem
            // 
            this.fajlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sacuvajToolStripMenuItem,
            this.ucitajToolStripMenuItem});
            this.fajlToolStripMenuItem.Name = "fajlToolStripMenuItem";
            this.fajlToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fajlToolStripMenuItem.Size = new System.Drawing.Size(53, 29);
            this.fajlToolStripMenuItem.Text = "&Fajl";
            // 
            // sacuvajToolStripMenuItem
            // 
            this.sacuvajToolStripMenuItem.Name = "sacuvajToolStripMenuItem";
            this.sacuvajToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sacuvajToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.sacuvajToolStripMenuItem.Text = "&Sacuvaj";
            // 
            // ucitajToolStripMenuItem
            // 
            this.ucitajToolStripMenuItem.Name = "ucitajToolStripMenuItem";
            this.ucitajToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.ucitajToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.ucitajToolStripMenuItem.Text = "&Ucitaj";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 594);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.lbxStudenti);
            this.Controls.Add(this.btnProsledi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.datRodj);
            this.Controls.Add(this.lblDatRodj);
            this.Controls.Add(this.cbxBudzet);
            this.Controls.Add(this.numProsek);
            this.Controls.Add(this.numGodStud);
            this.Controls.Add(this.lblProsek);
            this.Controls.Add(this.lblGodStud);
            this.Controls.Add(this.gbxNivoStud);
            this.Controls.Add(this.tbxIme);
            this.Controls.Add(this.tbxPrezime);
            this.Controls.Add(this.numBrInd);
            this.Controls.Add(this.lblBrInd);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numBrInd)).EndInit();
            this.gbxNivoStud.ResumeLayout(false);
            this.gbxNivoStud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGodStud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProsek)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblBrInd;
        private System.Windows.Forms.NumericUpDown numBrInd;
        private System.Windows.Forms.TextBox tbxPrezime;
        private System.Windows.Forms.TextBox tbxIme;
        private System.Windows.Forms.GroupBox gbxNivoStud;
        private System.Windows.Forms.RadioButton rdbDoktorske;
        private System.Windows.Forms.RadioButton rdbOsnovne;
        private System.Windows.Forms.RadioButton rdbMaster;
        private System.Windows.Forms.Label lblGodStud;
        private System.Windows.Forms.Label lblProsek;
        private System.Windows.Forms.NumericUpDown numGodStud;
        private System.Windows.Forms.NumericUpDown numProsek;
        private System.Windows.Forms.CheckBox cbxBudzet;
        private System.Windows.Forms.Label lblDatRodj;
        private System.Windows.Forms.DateTimePicker datRodj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.ListBox lbxStudenti;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fajlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sacuvajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ucitajToolStripMenuItem;
    }
}

