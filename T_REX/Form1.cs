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

        private void  checaPadrao()
        {
            MatchCollection matchesEncontrados;
            String padraoEncontrado = "";
            Regex regex;

            try
            {
                regex = new Regex(this.txtRegexPattern.Text);

                if (txtRegexPattern.Text == "")
                {
                    MessageBox.Show("Informe o PADRÃO regex que será utilizado para checar o texto de entrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRegexPattern.Focus();
                    return;
                }

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
                        padraoEncontrado += padrao + "\r\n";
                    }
                }
                this.txtMatchEncontrado.Clear();
                this.txtMatchEncontrado.Text = padraoEncontrado;
                this.btnLimpar.Focus();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Verifique o padrão informado. Erro: " + Environment.NewLine + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + Environment.NewLine + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            checaPadrao();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.txtEntrada.Clear();
            this.txtMatchEncontrado.Clear();
        }
    }
}
