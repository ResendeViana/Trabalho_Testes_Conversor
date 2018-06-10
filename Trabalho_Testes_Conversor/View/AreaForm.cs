using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_Testes_Conversor.BusinessLayer;

namespace Trabalho_Testes_Conversor.View
{
    public partial class AreaForm : Form
    {
        public AreaForm()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtImperial.Text = string.Empty;
            txtMetrico.Text = string.Empty;

            txtImperial.Enabled = true;
            txtMetrico.Enabled = true;
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double valor = 0;
            if (!string.IsNullOrWhiteSpace(txtImperial.Text))
            {
                valor = OperacoesPadrao.ConvertDoubleCustom(txtImperial.Text);
                if (valor < 0)
                {
                    MessageBox.Show("Valor Informado Invalido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }

                MessageBox.Show(
                    string.Format("Resultado da conversão: {0} {2} = {1} {3}", txtImperial.Text, OperacoesMatematicas.SqydToM2(valor), "SqYd", "M²"),
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                LimparCampos();
            }
            else if (!string.IsNullOrWhiteSpace(txtMetrico.Text))
            {
                valor = OperacoesPadrao.ConvertDoubleCustom(txtMetrico.Text);
                if (valor < 0)
                {
                    MessageBox.Show("Valor Informado Invalido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show(
                    string.Format("Resultado da conversão: {0} {2} = {1} {3}", txtMetrico.Text, OperacoesMatematicas.M2ToSqyd(valor), "M²", "SqYd"),
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                LimparCampos();
            }
            else
            {
                MessageBox.Show("Valor Informado Invalido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMetrico_TextChanged(object sender, EventArgs e)
        {
            txtImperial.Text = string.Empty;

        }

        private void ComprimentoForm_TextChanged(object sender, EventArgs e)
        {
            txtMetrico.Text = string.Empty;

        }
    }
}
