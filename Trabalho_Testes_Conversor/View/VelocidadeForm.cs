using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Testes_Conversor.View
{
    public partial class VelocidadeForm : Form
    {
        public VelocidadeForm()
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
    }
}
