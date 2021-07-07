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
            this.lblIsMach = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRegexPattern
            // 
            this.txtRegexPattern.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegexPattern.ForeColor = System.Drawing.Color.Navy;
            this.txtRegexPattern.Location = new System.Drawing.Point(16, 25);
            this.txtRegexPattern.Name = "txtRegexPattern";
            this.txtRegexPattern.Size = new System.Drawing.Size(681, 27);
            this.txtRegexPattern.TabIndex = 0;
            this.txtRegexPattern.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegexPattern.TextChanged += new System.EventHandler(this.txtRegexPattern_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Regex Pattern";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(14, 95);
            this.txtEntrada.Multiline = true;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEntrada.Size = new System.Drawing.Size(341, 372);
            this.txtEntrada.TabIndex = 2;
            // 
            // txtMatchEncontrado
            // 
            this.txtMatchEncontrado.BackColor = System.Drawing.SystemColors.Window;
            this.txtMatchEncontrado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMatchEncontrado.Location = new System.Drawing.Point(361, 95);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            // 
            // lblIsMach
            // 
            this.lblIsMach.AutoSize = true;
            this.lblIsMach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsMach.Location = new System.Drawing.Point(464, 76);
            this.lblIsMach.Name = "lblIsMach";
            this.lblIsMach.Size = new System.Drawing.Size(12, 16);
            this.lblIsMach.TabIndex = 8;
            this.lblIsMach.Text = ".";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(12, 472);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(76, 24);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "CLEAN";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(14, 499);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(13, 16);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "-";
            // 
            // frmTestaRegex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 533);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblIsMach);
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
        private System.Windows.Forms.Label lblIsMach;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblStatus;
    }
}

