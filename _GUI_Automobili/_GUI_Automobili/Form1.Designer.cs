namespace _GUI_Automobili
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fajlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblProizvodjac = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblZapremina = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.tbxProizvodjac = new System.Windows.Forms.TextBox();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.gbxVrstaGoriva = new System.Windows.Forms.GroupBox();
            this.rdbGas = new System.Windows.Forms.RadioButton();
            this.rdbDizel = new System.Windows.Forms.RadioButton();
            this.rdbBenzin = new System.Windows.Forms.RadioButton();
            this.chkAtest = new System.Windows.Forms.CheckBox();
            this.lbxAutomobili = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.numZapremina = new System.Windows.Forms.NumericUpDown();
            this.datDatum = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.gbxVrstaGoriva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZapremina)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fajlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(446, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fajlToolStripMenuItem
            // 
            this.fajlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.snimiToolStripMenuItem});
            this.fajlToolStripMenuItem.Name = "fajlToolStripMenuItem";
            this.fajlToolStripMenuItem.Size = new System.Drawing.Size(53, 29);
            this.fajlToolStripMenuItem.Text = "Fajl";
            // 
            // snimiToolStripMenuItem
            // 
            this.snimiToolStripMenuItem.Name = "snimiToolStripMenuItem";
            this.snimiToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.snimiToolStripMenuItem.Text = "&Snimi";
            this.snimiToolStripMenuItem.Click += new System.EventHandler(this.snimiToolStripMenuItem_Click);
            // 
            // lblProizvodjac
            // 
            this.lblProizvodjac.AutoSize = true;
            this.lblProizvodjac.Location = new System.Drawing.Point(69, 53);
            this.lblProizvodjac.Name = "lblProizvodjac";
            this.lblProizvodjac.Size = new System.Drawing.Size(93, 20);
            this.lblProizvodjac.TabIndex = 1;
            this.lblProizvodjac.Text = "Proizvodjac:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(106, 95);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(56, 20);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model:";
            // 
            // lblZapremina
            // 
            this.lblZapremina.AutoSize = true;
            this.lblZapremina.Location = new System.Drawing.Point(19, 147);
            this.lblZapremina.Name = "lblZapremina";
            this.lblZapremina.Size = new System.Drawing.Size(143, 20);
            this.lblZapremina.TabIndex = 3;
            this.lblZapremina.Text = "Zapremina motora:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(17, 200);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(145, 20);
            this.lblDatum.TabIndex = 4;
            this.lblDatum.Text = "Datum proizvodnje:";
            // 
            // tbxProizvodjac
            // 
            this.tbxProizvodjac.Location = new System.Drawing.Point(173, 50);
            this.tbxProizvodjac.Name = "tbxProizvodjac";
            this.tbxProizvodjac.Size = new System.Drawing.Size(205, 26);
            this.tbxProizvodjac.TabIndex = 1;
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(173, 95);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(205, 26);
            this.tbxModel.TabIndex = 2;
            // 
            // gbxVrstaGoriva
            // 
            this.gbxVrstaGoriva.Controls.Add(this.rdbGas);
            this.gbxVrstaGoriva.Controls.Add(this.rdbDizel);
            this.gbxVrstaGoriva.Controls.Add(this.rdbBenzin);
            this.gbxVrstaGoriva.Location = new System.Drawing.Point(23, 238);
            this.gbxVrstaGoriva.Name = "gbxVrstaGoriva";
            this.gbxVrstaGoriva.Size = new System.Drawing.Size(355, 59);
            this.gbxVrstaGoriva.TabIndex = 9;
            this.gbxVrstaGoriva.TabStop = false;
            this.gbxVrstaGoriva.Text = "Vrsta goriva";
            // 
            // rdbGas
            // 
            this.rdbGas.AutoSize = true;
            this.rdbGas.Location = new System.Drawing.Point(261, 25);
            this.rdbGas.Name = "rdbGas";
            this.rdbGas.Size = new System.Drawing.Size(64, 24);
            this.rdbGas.TabIndex = 7;
            this.rdbGas.TabStop = true;
            this.rdbGas.Text = "Gas";
            this.rdbGas.UseVisualStyleBackColor = true;
            this.rdbGas.CheckedChanged += new System.EventHandler(this.rdbBenzin_CheckedChanged);
            // 
            // rdbDizel
            // 
            this.rdbDizel.AutoSize = true;
            this.rdbDizel.Location = new System.Drawing.Point(139, 25);
            this.rdbDizel.Name = "rdbDizel";
            this.rdbDizel.Size = new System.Drawing.Size(69, 24);
            this.rdbDizel.TabIndex = 6;
            this.rdbDizel.TabStop = true;
            this.rdbDizel.Text = "Dizel";
            this.rdbDizel.UseVisualStyleBackColor = true;
            this.rdbDizel.CheckedChanged += new System.EventHandler(this.rdbBenzin_CheckedChanged);
            // 
            // rdbBenzin
            // 
            this.rdbBenzin.AutoSize = true;
            this.rdbBenzin.Location = new System.Drawing.Point(18, 25);
            this.rdbBenzin.Name = "rdbBenzin";
            this.rdbBenzin.Size = new System.Drawing.Size(83, 24);
            this.rdbBenzin.TabIndex = 5;
            this.rdbBenzin.TabStop = true;
            this.rdbBenzin.Text = "Benzin";
            this.rdbBenzin.UseVisualStyleBackColor = true;
            this.rdbBenzin.CheckedChanged += new System.EventHandler(this.rdbBenzin_CheckedChanged);
            // 
            // chkAtest
            // 
            this.chkAtest.AutoSize = true;
            this.chkAtest.Location = new System.Drawing.Point(21, 303);
            this.chkAtest.Name = "chkAtest";
            this.chkAtest.Size = new System.Drawing.Size(102, 24);
            this.chkAtest.TabIndex = 8;
            this.chkAtest.Text = "Ima atest";
            this.chkAtest.UseVisualStyleBackColor = true;
            // 
            // lbxAutomobili
            // 
            this.lbxAutomobili.FormattingEnabled = true;
            this.lbxAutomobili.ItemHeight = 20;
            this.lbxAutomobili.Location = new System.Drawing.Point(21, 373);
            this.lbxAutomobili.Name = "lbxAutomobili";
            this.lbxAutomobili.Size = new System.Drawing.Size(398, 164);
            this.lbxAutomobili.TabIndex = 11;
            this.lbxAutomobili.DoubleClick += new System.EventHandler(this.lbxAutomobili_DoubleClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(21, 333);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(112, 34);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // numZapremina
            // 
            this.numZapremina.DecimalPlaces = 3;
            this.numZapremina.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numZapremina.Location = new System.Drawing.Point(173, 145);
            this.numZapremina.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numZapremina.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numZapremina.Name = "numZapremina";
            this.numZapremina.Size = new System.Drawing.Size(205, 26);
            this.numZapremina.TabIndex = 3;
            this.numZapremina.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // datDatum
            // 
            this.datDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datDatum.Location = new System.Drawing.Point(173, 194);
            this.datDatum.Name = "datDatum";
            this.datDatum.Size = new System.Drawing.Size(205, 26);
            this.datDatum.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 571);
            this.Controls.Add(this.datDatum);
            this.Controls.Add(this.numZapremina);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lbxAutomobili);
            this.Controls.Add(this.chkAtest);
            this.Controls.Add(this.gbxVrstaGoriva);
            this.Controls.Add(this.tbxModel);
            this.Controls.Add(this.tbxProizvodjac);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblZapremina);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblProizvodjac);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxVrstaGoriva.ResumeLayout(false);
            this.gbxVrstaGoriva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZapremina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fajlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snimiToolStripMenuItem;
        private System.Windows.Forms.Label lblProizvodjac;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblZapremina;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox tbxProizvodjac;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.GroupBox gbxVrstaGoriva;
        private System.Windows.Forms.RadioButton rdbGas;
        private System.Windows.Forms.RadioButton rdbDizel;
        private System.Windows.Forms.RadioButton rdbBenzin;
        private System.Windows.Forms.CheckBox chkAtest;
        private System.Windows.Forms.ListBox lbxAutomobili;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.NumericUpDown numZapremina;
        private System.Windows.Forms.DateTimePicker datDatum;
    }
}

