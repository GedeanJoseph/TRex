namespace TestaRegex
{
    partial class frmTestaRegex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestaRegex));
            this.txtRegexPattern = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtMatchEncontrado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblIsMach = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRegexPattern
            // 
            this.txtRegexPattern.Location = new System.Drawing.Point(94, 16);
            this.txtRegexPattern.Name = "txtRegexPattern";
            this.txtRegexPattern.Size = new System.Drawing.Size(603, 20);
            this.txtRegexPattern.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Regex Pattern";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(16, 100);
            this.txtEntrada.Multiline = true;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEntrada.Size = new System.Drawing.Size(341, 372);
            this.txtEntrada.TabIndex = 2;
            // 
            // txtMatchEncontrado
            // 
            this.txtMatchEncontrado.BackColor = System.Drawing.SystemColors.Window;
            this.txtMatchEncontrado.Location = new System.Drawing.Point(363, 100);
            this.txtMatchEncontrado.Multiline = true;
            this.txtMatchEncontrado.Name = "txtMatchEncontrado";
            this.txtMatchEncontrado.ReadOnly = true;
            this.txtMatchEncontrado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMatchEncontrado.Size = new System.Drawing.Size(341, 372);
            this.txtMatchEncontrado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Texto Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Texto Matched";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(515, 43);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(182, 23);
            this.btnExecute.TabIndex = 7;
            this.btnExecute.Text = "Verificar";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lblIsMach
            // 
            this.lblIsMach.AutoSize = true;
            this.lblIsMach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsMach.Location = new System.Drawing.Point(464, 82);
            this.lblIsMach.Name = "lblIsMach";
            this.lblIsMach.Size = new System.Drawing.Size(12, 16);
            this.lblIsMach.TabIndex = 8;
            this.lblIsMach.Text = ".";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(16, 478);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(182, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmTestaRegex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 507);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblIsMach);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatchEncontrado);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegexPattern);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(725, 572);
            this.MinimumSize = new System.Drawing.Size(725, 522);
            this.Name = "frmTestaRegex";
            this.Text = ".:: T-REX - Text Regex ::..";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegexPattern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.TextBox txtMatchEncontrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lblIsMach;
        private System.Windows.Forms.Button btnLimpar;
        
    }
}

