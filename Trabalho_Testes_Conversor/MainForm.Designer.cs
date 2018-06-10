namespace Trabalho_Testes_Conversor
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.comprimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.áreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.massaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.velocidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprimentoToolStripMenuItem,
            this.áreaToolStripMenuItem,
            this.volumeToolStripMenuItem,
            this.massaToolStripMenuItem,
            this.velocidadeToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(416, 24);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // comprimentoToolStripMenuItem
            // 
            this.comprimentoToolStripMenuItem.Name = "comprimentoToolStripMenuItem";
            this.comprimentoToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.comprimentoToolStripMenuItem.Text = "Comprimento";
            this.comprimentoToolStripMenuItem.Click += new System.EventHandler(this.comprimentoToolStripMenuItem_Click);
            // 
            // áreaToolStripMenuItem
            // 
            this.áreaToolStripMenuItem.Name = "áreaToolStripMenuItem";
            this.áreaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.áreaToolStripMenuItem.Text = "Área";
            this.áreaToolStripMenuItem.Click += new System.EventHandler(this.áreaToolStripMenuItem_Click);
            // 
            // volumeToolStripMenuItem
            // 
            this.volumeToolStripMenuItem.Name = "volumeToolStripMenuItem";
            this.volumeToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.volumeToolStripMenuItem.Text = "Volume";
            this.volumeToolStripMenuItem.Click += new System.EventHandler(this.volumeToolStripMenuItem_Click);
            // 
            // massaToolStripMenuItem
            // 
            this.massaToolStripMenuItem.Name = "massaToolStripMenuItem";
            this.massaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.massaToolStripMenuItem.Text = "Massa";
            this.massaToolStripMenuItem.Click += new System.EventHandler(this.massaToolStripMenuItem_Click);
            // 
            // velocidadeToolStripMenuItem
            // 
            this.velocidadeToolStripMenuItem.Name = "velocidadeToolStripMenuItem";
            this.velocidadeToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.velocidadeToolStripMenuItem.Text = "Velocidade";
            this.velocidadeToolStripMenuItem.Click += new System.EventHandler(this.velocidadeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 429);
            this.Controls.Add(this.menuStripPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "MainForm";
            this.Text = "Sistema de conversão de Imperial/Métrico";
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem comprimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem áreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem massaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem velocidadeToolStripMenuItem;
    }
}

