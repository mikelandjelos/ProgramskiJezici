namespace _PripremaZad3_Dictionary
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
            this.lblEng = new System.Windows.Forms.Label();
            this.tbxEng = new System.Windows.Forms.TextBox();
            this.btnEng = new System.Windows.Forms.Button();
            this.lbxEng = new System.Windows.Forms.ListBox();
            this.lbxSrb = new System.Windows.Forms.ListBox();
            this.btnSrb = new System.Windows.Forms.Button();
            this.tbxSrb = new System.Windows.Forms.TextBox();
            this.lblSrb = new System.Windows.Forms.Label();
            this.btnUkloniEng = new System.Windows.Forms.Button();
            this.btnUkloniSrb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEng
            // 
            this.lblEng.AutoSize = true;
            this.lblEng.Location = new System.Drawing.Point(12, 9);
            this.lblEng.Name = "lblEng";
            this.lblEng.Size = new System.Drawing.Size(145, 20);
            this.lblEng.TabIndex = 0;
            this.lblEng.Text = "Rec na engleskom:";
            // 
            // tbxEng
            // 
            this.tbxEng.Location = new System.Drawing.Point(12, 32);
            this.tbxEng.Name = "tbxEng";
            this.tbxEng.Size = new System.Drawing.Size(224, 26);
            this.tbxEng.TabIndex = 1;
            // 
            // btnEng
            // 
            this.btnEng.Location = new System.Drawing.Point(12, 64);
            this.btnEng.Name = "btnEng";
            this.btnEng.Size = new System.Drawing.Size(124, 37);
            this.btnEng.TabIndex = 2;
            this.btnEng.Text = "Dodaj";
            this.btnEng.UseVisualStyleBackColor = true;
            this.btnEng.Click += new System.EventHandler(this.btnEng_Click);
            // 
            // lbxEng
            // 
            this.lbxEng.FormattingEnabled = true;
            this.lbxEng.ItemHeight = 20;
            this.lbxEng.Location = new System.Drawing.Point(12, 178);
            this.lbxEng.Name = "lbxEng";
            this.lbxEng.Size = new System.Drawing.Size(249, 484);
            this.lbxEng.TabIndex = 3;
            this.lbxEng.DoubleClick += new System.EventHandler(this.lbxEng_DoubleClick);
            // 
            // lbxSrb
            // 
            this.lbxSrb.FormattingEnabled = true;
            this.lbxSrb.ItemHeight = 20;
            this.lbxSrb.Location = new System.Drawing.Point(314, 178);
            this.lbxSrb.Name = "lbxSrb";
            this.lbxSrb.Size = new System.Drawing.Size(249, 484);
            this.lbxSrb.TabIndex = 7;
            this.lbxSrb.DoubleClick += new System.EventHandler(this.lbxSrb_DoubleClick);
            // 
            // btnSrb
            // 
            this.btnSrb.Location = new System.Drawing.Point(314, 64);
            this.btnSrb.Name = "btnSrb";
            this.btnSrb.Size = new System.Drawing.Size(124, 37);
            this.btnSrb.TabIndex = 6;
            this.btnSrb.Text = "Dodaj";
            this.btnSrb.UseVisualStyleBackColor = true;
            this.btnSrb.Click += new System.EventHandler(this.btnSrb_Click);
            // 
            // tbxSrb
            // 
            this.tbxSrb.Location = new System.Drawing.Point(314, 32);
            this.tbxSrb.Name = "tbxSrb";
            this.tbxSrb.Size = new System.Drawing.Size(224, 26);
            this.tbxSrb.TabIndex = 5;
            // 
            // lblSrb
            // 
            this.lblSrb.AutoSize = true;
            this.lblSrb.Location = new System.Drawing.Point(314, 9);
            this.lblSrb.Name = "lblSrb";
            this.lblSrb.Size = new System.Drawing.Size(145, 20);
            this.lblSrb.TabIndex = 4;
            this.lblSrb.Text = "Rec na engleskom:";
            // 
            // btnUkloniEng
            // 
            this.btnUkloniEng.Location = new System.Drawing.Point(12, 107);
            this.btnUkloniEng.Name = "btnUkloniEng";
            this.btnUkloniEng.Size = new System.Drawing.Size(124, 37);
            this.btnUkloniEng.TabIndex = 8;
            this.btnUkloniEng.Text = "Ukloni";
            this.btnUkloniEng.UseVisualStyleBackColor = true;
            this.btnUkloniEng.Click += new System.EventHandler(this.btnUkloniEng_Click);
            // 
            // btnUkloniSrb
            // 
            this.btnUkloniSrb.Location = new System.Drawing.Point(314, 107);
            this.btnUkloniSrb.Name = "btnUkloniSrb";
            this.btnUkloniSrb.Size = new System.Drawing.Size(124, 37);
            this.btnUkloniSrb.TabIndex = 9;
            this.btnUkloniSrb.Text = "Ukloni";
            this.btnUkloniSrb.UseVisualStyleBackColor = true;
            this.btnUkloniSrb.Click += new System.EventHandler(this.btnUkloniSrb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 674);
            this.Controls.Add(this.btnUkloniSrb);
            this.Controls.Add(this.btnUkloniEng);
            this.Controls.Add(this.lbxSrb);
            this.Controls.Add(this.btnSrb);
            this.Controls.Add(this.tbxSrb);
            this.Controls.Add(this.lblSrb);
            this.Controls.Add(this.lbxEng);
            this.Controls.Add(this.btnEng);
            this.Controls.Add(this.tbxEng);
            this.Controls.Add(this.lblEng);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEng;
        private System.Windows.Forms.TextBox tbxEng;
        private System.Windows.Forms.Button btnEng;
        private System.Windows.Forms.ListBox lbxEng;
        private System.Windows.Forms.ListBox lbxSrb;
        private System.Windows.Forms.Button btnSrb;
        private System.Windows.Forms.TextBox tbxSrb;
        private System.Windows.Forms.Label lblSrb;
        private System.Windows.Forms.Button btnUkloniEng;
        private System.Windows.Forms.Button btnUkloniSrb;
    }
}

