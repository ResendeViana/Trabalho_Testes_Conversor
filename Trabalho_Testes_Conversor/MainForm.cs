using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_Testes_Conversor.View;

namespace Trabalho_Testes_Conversor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void comprimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComprimentoForm form = new ComprimentoForm();
            form.MdiParent = this;
            form.Show();
        }

        private void áreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AreaForm form = new AreaForm();
            form.MdiParent = this;
            form.Show();
        }

        private void volumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VolumeForm form = new VolumeForm();
            form.MdiParent = this;
            form.Show();
        }

        private void massaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MassaForm form = new MassaForm();
            form.MdiParent = this;
            form.Show();
        }

        private void velocidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VelocidadeForm form = new VelocidadeForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}
