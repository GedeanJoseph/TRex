using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestaRegex
{
    public partial class frmTestaRegex : Form
    {
        public frmTestaRegex()
        {
            InitializeComponent();
        }

        private void  patternValidate()
        {
            MatchCollection matchesEncontrados;
            var  padraoEncontrado = new StringBuilder(); 
            Regex regex;

            try
            {
                regex = new Regex(this.txtRegexPattern.Text);

                if (txtEntrada.Text == "")
                {
                    MessageBox.Show("Informe um texto de entrada para ser verificado pelo padrão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEntrada.Focus();
                    return;
                }

                matchesEncontrados = regex.Matches(this.txtEntrada.Text);

                if (matchesEncontrados.Count > 0)
                {
                    lblIsMach.BackColor = Color.Green;
                    lblIsMach.Text = "Is Match!";
                    lblIsMach.ForeColor = Color.White;
                }
                else
                {
                    lblIsMach.BackColor = Color.Red;
                    lblIsMach.Text = "No Matches!";
                    lblIsMach.ForeColor = Color.White;
                }

                foreach (Match padrao in matchesEncontrados)
                {
                    if (padrao.Length > 0)
                    {
                        padraoEncontrado.AppendLine(padrao.Value);
                    }
                }

                lblStatus.Text = "";

                this.txtMatchEncontrado.Clear();
                this.txtMatchEncontrado.Text = padraoEncontrado.ToString();
                this.btnLimpar.Focus();
                padraoEncontrado.Clear();
                txtRegexPattern.Focus();
            }
            catch (ArgumentException ex)
            {
                lblStatus.Text = $"Pattern Error: {ex.Message}.";
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Unespected Error: {ex.Message}.";
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            patternValidate();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.txtEntrada.Clear();
            this.txtMatchEncontrado.Clear();
            this.txtRegexPattern.Clear();
        }

        private void txtRegexPattern_TextChanged(object sender, EventArgs e)
        {
            patternValidate();
        }
    }
}
