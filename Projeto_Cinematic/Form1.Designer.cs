namespace Projeto_Cinematic
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAcesso = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIngresso = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFilmes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSecao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastrarFilmes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Yellow;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAcesso,
            this.menuIngresso,
            this.menuFilmes,
            this.menuFuncionario,
            this.menuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAcesso
            // 
            this.menuAcesso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuAcesso.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAcesso.Margin = new System.Windows.Forms.Padding(5);
            this.menuAcesso.Name = "menuAcesso";
            this.menuAcesso.Size = new System.Drawing.Size(82, 29);
            this.menuAcesso.Text = "Acesso";
            this.menuAcesso.Click += new System.EventHandler(this.menuAcesso_Click);
            // 
            // menuIngresso
            // 
            this.menuIngresso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuIngresso.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuIngresso.Margin = new System.Windows.Forms.Padding(5);
            this.menuIngresso.Name = "menuIngresso";
            this.menuIngresso.Size = new System.Drawing.Size(95, 29);
            this.menuIngresso.Text = "Ingresso";
            this.menuIngresso.Visible = false;
            this.menuIngresso.Click += new System.EventHandler(this.menuIngresso_Click);
            // 
            // menuFuncionario
            // 
            this.menuFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuFuncionario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFuncionario.Margin = new System.Windows.Forms.Padding(5);
            this.menuFuncionario.Name = "menuFuncionario";
            this.menuFuncionario.Size = new System.Drawing.Size(124, 29);
            this.menuFuncionario.Text = "Funcionário";
            this.menuFuncionario.Visible = false;
            this.menuFuncionario.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // menuFilmes
            // 
            this.menuFilmes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuFilmes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSecao,
            this.menuCadastrarFilmes});
            this.menuFilmes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFilmes.Margin = new System.Windows.Forms.Padding(5);
            this.menuFilmes.Name = "menuFilmes";
            this.menuFilmes.Size = new System.Drawing.Size(77, 29);
            this.menuFilmes.Text = "Filmes";
            this.menuFilmes.Visible = false;
            // 
            // menuSecao
            // 
            this.menuSecao.Name = "menuSecao";
            this.menuSecao.Size = new System.Drawing.Size(234, 30);
            this.menuSecao.Text = "Sessão dos Filmes";
            this.menuSecao.Click += new System.EventHandler(this.menuSecao_Click);
            // 
            // menuCadastrarFilmes
            // 
            this.menuCadastrarFilmes.Name = "menuCadastrarFilmes";
            this.menuCadastrarFilmes.Size = new System.Drawing.Size(234, 30);
            this.menuCadastrarFilmes.Text = "Filmes";
            this.menuCadastrarFilmes.Click += new System.EventHandler(this.menuCadastrarFilmes_Click);
            // 
            // menuSair
            // 
            this.menuSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuSair.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSair.Margin = new System.Windows.Forms.Padding(5);
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(56, 29);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuSecao;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrarFilmes;
        public System.Windows.Forms.ToolStripMenuItem menuAcesso;
        public System.Windows.Forms.ToolStripMenuItem menuFilmes;
        public System.Windows.Forms.ToolStripMenuItem menuIngresso;
        public System.Windows.Forms.ToolStripMenuItem menuFuncionario;
    }
}

