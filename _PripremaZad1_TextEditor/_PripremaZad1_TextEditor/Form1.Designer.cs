namespace _PripremaZad1_TextEditor
{
    partial class Forma
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
            this.menuObj = new System.Windows.Forms.MenuStrip();
            this.fajlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selektujSveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datumVremeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.menuObj.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuObj
            // 
            this.menuObj.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuObj.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuObj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fajlToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuObj.Location = new System.Drawing.Point(0, 0);
            this.menuObj.Name = "menuObj";
            this.menuObj.Size = new System.Drawing.Size(677, 33);
            this.menuObj.TabIndex = 0;
            this.menuObj.Text = "menuStrip1";
            // 
            // fajlToolStripMenuItem
            // 
            this.fajlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.snimiToolStripMenuItem,
            this.otvoriToolStripMenuItem});
            this.fajlToolStripMenuItem.Name = "fajlToolStripMenuItem";
            this.fajlToolStripMenuItem.Size = new System.Drawing.Size(53, 29);
            this.fajlToolStripMenuItem.Text = "&Fajl";
            // 
            // snimiToolStripMenuItem
            // 
            this.snimiToolStripMenuItem.Name = "snimiToolStripMenuItem";
            this.snimiToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.snimiToolStripMenuItem.Text = "&Snimi";
            this.snimiToolStripMenuItem.Click += new System.EventHandler(this.snimiToolStripMenuItem_Click);
            // 
            // otvoriToolStripMenuItem
            // 
            this.otvoriToolStripMenuItem.Name = "otvoriToolStripMenuItem";
            this.otvoriToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.otvoriToolStripMenuItem.Text = "&Otvori";
            this.otvoriToolStripMenuItem.Click += new System.EventHandler(this.otvoriToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selektujSveToolStripMenuItem,
            this.datumVremeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // selektujSveToolStripMenuItem
            // 
            this.selektujSveToolStripMenuItem.Name = "selektujSveToolStripMenuItem";
            this.selektujSveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.selektujSveToolStripMenuItem.Text = "Se&lektuj sve";
            this.selektujSveToolStripMenuItem.Click += new System.EventHandler(this.selektujSveToolStripMenuItem_Click);
            // 
            // datumVremeToolStripMenuItem
            // 
            this.datumVremeToolStripMenuItem.Name = "datumVremeToolStripMenuItem";
            this.datumVremeToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.datumVremeToolStripMenuItem.Text = "&Datum/Vreme";
            this.datumVremeToolStripMenuItem.Click += new System.EventHandler(this.datumVremeToolStripMenuItem_Click);
            // 
            // txtBox
            // 
            this.txtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox.Location = new System.Drawing.Point(0, 33);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(677, 593);
            this.txtBox.TabIndex = 1;
            this.txtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 626);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.menuObj);
            this.MainMenuStrip = this.menuObj;
            this.Name = "Forma";
            this.Text = "Text editor";
            this.menuObj.ResumeLayout(false);
            this.menuObj.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuObj;
        private System.Windows.Forms.ToolStripMenuItem fajlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otvoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selektujSveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datumVremeToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBox;
    }
}

