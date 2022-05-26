namespace _GUI_Filmovi
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblReditelj = new System.Windows.Forms.Label();
            this.lblOcena = new System.Windows.Forms.Label();
            this.lblZanr = new System.Windows.Forms.Label();
            this.lblMinUzr = new System.Windows.Forms.Label();
            this.tbxNaslov = new System.Windows.Forms.TextBox();
            this.tbxReditelj = new System.Windows.Forms.TextBox();
            this.numOcena = new System.Windows.Forms.NumericUpDown();
            this.numMinUzr = new System.Windows.Forms.NumericUpDown();
            this.datDatum = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lbxFilmovi = new System.Windows.Forms.ListBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.cmbxZanr = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numOcena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinUzr)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Location = new System.Drawing.Point(87, 23);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(60, 20);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Naslov:";
            // 
            // lblReditelj
            // 
            this.lblReditelj.AutoSize = true;
            this.lblReditelj.Location = new System.Drawing.Point(81, 55);
            this.lblReditelj.Name = "lblReditelj";
            this.lblReditelj.Size = new System.Drawing.Size(66, 20);
            this.lblReditelj.TabIndex = 1;
            this.lblReditelj.Text = "Reditelj:";
            // 
            // lblOcena
            // 
            this.lblOcena.AutoSize = true;
            this.lblOcena.Location = new System.Drawing.Point(87, 89);
            this.lblOcena.Name = "lblOcena";
            this.lblOcena.Size = new System.Drawing.Size(60, 20);
            this.lblOcena.TabIndex = 2;
            this.lblOcena.Text = "Ocena:";
            // 
            // lblZanr
            // 
            this.lblZanr.AutoSize = true;
            this.lblZanr.Location = new System.Drawing.Point(101, 122);
            this.lblZanr.Name = "lblZanr";
            this.lblZanr.Size = new System.Drawing.Size(46, 20);
            this.lblZanr.TabIndex = 3;
            this.lblZanr.Text = "Zanr:";
            // 
            // lblMinUzr
            // 
            this.lblMinUzr.AutoSize = true;
            this.lblMinUzr.Location = new System.Drawing.Point(21, 196);
            this.lblMinUzr.Name = "lblMinUzr";
            this.lblMinUzr.Size = new System.Drawing.Size(126, 20);
            this.lblMinUzr.TabIndex = 4;
            this.lblMinUzr.Text = "Minimalni uzrast:";
            // 
            // tbxNaslov
            // 
            this.tbxNaslov.Location = new System.Drawing.Point(153, 17);
            this.tbxNaslov.Name = "tbxNaslov";
            this.tbxNaslov.Size = new System.Drawing.Size(278, 26);
            this.tbxNaslov.TabIndex = 5;
            // 
            // tbxReditelj
            // 
            this.tbxReditelj.Location = new System.Drawing.Point(153, 49);
            this.tbxReditelj.Name = "tbxReditelj";
            this.tbxReditelj.Size = new System.Drawing.Size(278, 26);
            this.tbxReditelj.TabIndex = 6;
            // 
            // numOcena
            // 
            this.numOcena.DecimalPlaces = 1;
            this.numOcena.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numOcena.Location = new System.Drawing.Point(153, 87);
            this.numOcena.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numOcena.Name = "numOcena";
            this.numOcena.Size = new System.Drawing.Size(163, 26);
            this.numOcena.TabIndex = 7;
            // 
            // numMinUzr
            // 
            this.numMinUzr.Location = new System.Drawing.Point(153, 190);
            this.numMinUzr.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.numMinUzr.Name = "numMinUzr";
            this.numMinUzr.Size = new System.Drawing.Size(157, 26);
            this.numMinUzr.TabIndex = 8;
            // 
            // datDatum
            // 
            this.datDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datDatum.Location = new System.Drawing.Point(153, 156);
            this.datDatum.Name = "datDatum";
            this.datDatum.Size = new System.Drawing.Size(139, 26);
            this.datDatum.TabIndex = 9;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(25, 239);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(103, 32);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lbxFilmovi
            // 
            this.lbxFilmovi.FormattingEnabled = true;
            this.lbxFilmovi.HorizontalScrollbar = true;
            this.lbxFilmovi.ItemHeight = 20;
            this.lbxFilmovi.Location = new System.Drawing.Point(25, 291);
            this.lbxFilmovi.Name = "lbxFilmovi";
            this.lbxFilmovi.Size = new System.Drawing.Size(487, 144);
            this.lbxFilmovi.TabIndex = 11;
            this.lbxFilmovi.DoubleClick += new System.EventHandler(this.lbxFilmovi_DoubleClick);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(17, 160);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(130, 20);
            this.lblDatum.TabIndex = 12;
            this.lblDatum.Text = "Datum premijere:";
            // 
            // cmbxZanr
            // 
            this.cmbxZanr.FormattingEnabled = true;
            this.cmbxZanr.Location = new System.Drawing.Point(153, 122);
            this.cmbxZanr.Name = "cmbxZanr";
            this.cmbxZanr.Size = new System.Drawing.Size(163, 28);
            this.cmbxZanr.TabIndex = 13;
            this.cmbxZanr.SelectedIndexChanged += new System.EventHandler(this.cmbxZanr_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 490);
            this.Controls.Add(this.cmbxZanr);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lbxFilmovi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.datDatum);
            this.Controls.Add(this.numMinUzr);
            this.Controls.Add(this.numOcena);
            this.Controls.Add(this.tbxReditelj);
            this.Controls.Add(this.tbxNaslov);
            this.Controls.Add(this.lblMinUzr);
            this.Controls.Add(this.lblZanr);
            this.Controls.Add(this.lblOcena);
            this.Controls.Add(this.lblReditelj);
            this.Controls.Add(this.lblNaslov);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numOcena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinUzr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblReditelj;
        private System.Windows.Forms.Label lblOcena;
        private System.Windows.Forms.Label lblZanr;
        private System.Windows.Forms.Label lblMinUzr;
        private System.Windows.Forms.TextBox tbxNaslov;
        private System.Windows.Forms.TextBox tbxReditelj;
        private System.Windows.Forms.NumericUpDown numOcena;
        private System.Windows.Forms.NumericUpDown numMinUzr;
        private System.Windows.Forms.DateTimePicker datDatum;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox lbxFilmovi;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.ComboBox cmbxZanr;
    }
}

