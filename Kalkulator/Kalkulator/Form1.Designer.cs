namespace Kalkulator
{
    partial class Calculator
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
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFirstOperand = new System.Windows.Forms.Label();
            this.lblSecondOperand = new System.Windows.Forms.Label();
            this.txtFirstOperand = new System.Windows.Forms.TextBox();
            this.txtSecondOperand = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(631, 119);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 26);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblFirstOperand
            // 
            this.lblFirstOperand.AutoSize = true;
            this.lblFirstOperand.Location = new System.Drawing.Point(131, 76);
            this.lblFirstOperand.Name = "lblFirstOperand";
            this.lblFirstOperand.Size = new System.Drawing.Size(94, 20);
            this.lblFirstOperand.TabIndex = 2;
            this.lblFirstOperand.Text = "1st operand";
            // 
            // lblSecondOperand
            // 
            this.lblSecondOperand.AutoSize = true;
            this.lblSecondOperand.Location = new System.Drawing.Point(276, 76);
            this.lblSecondOperand.Name = "lblSecondOperand";
            this.lblSecondOperand.Size = new System.Drawing.Size(99, 20);
            this.lblSecondOperand.TabIndex = 3;
            this.lblSecondOperand.Text = "2nd operand";
            // 
            // txtFirstOperand
            // 
            this.txtFirstOperand.Location = new System.Drawing.Point(135, 119);
            this.txtFirstOperand.Name = "txtFirstOperand";
            this.txtFirstOperand.Size = new System.Drawing.Size(98, 26);
            this.txtFirstOperand.TabIndex = 4;
            // 
            // txtSecondOperand
            // 
            this.txtSecondOperand.Location = new System.Drawing.Point(280, 119);
            this.txtSecondOperand.Name = "txtSecondOperand";
            this.txtSecondOperand.Size = new System.Drawing.Size(98, 26);
            this.txtSecondOperand.TabIndex = 5;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(435, 119);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(98, 26);
            this.txtResult.TabIndex = 8;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(431, 76);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(70, 20);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "lblResult";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Location = new System.Drawing.Point(183, 314);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(28, 30);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.AutoSize = true;
            this.btnSub.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSub.Location = new System.Drawing.Point(234, 368);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(24, 30);
            this.btnSub.TabIndex = 11;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.AutoSize = true;
            this.btnMul.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMul.Location = new System.Drawing.Point(195, 432);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(25, 30);
            this.btnMul.TabIndex = 12;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.AutoSize = true;
            this.btnDiv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDiv.Location = new System.Drawing.Point(234, 314);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(23, 30);
            this.btnDiv.TabIndex = 13;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(949, 773);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.txtSecondOperand);
            this.Controls.Add(this.txtFirstOperand);
            this.Controls.Add(this.lblSecondOperand);
            this.Controls.Add(this.lblFirstOperand);
            this.Controls.Add(this.btnClear);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Resize += new System.EventHandler(this.Calculator_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblFirstOperand;
        private System.Windows.Forms.Label lblSecondOperand;
        private System.Windows.Forms.TextBox txtFirstOperand;
        private System.Windows.Forms.TextBox txtSecondOperand;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

