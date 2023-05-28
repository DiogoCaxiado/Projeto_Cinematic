using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Cinematic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionario cf = new Funcionario();
            cf.MdiParent = this; //a tela filha pertence a tela pai, que é a tela atual
            cf.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.Black;
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuAcesso_Click(object sender, EventArgs e)
        {
            Login cl = new Login();
            cl.MdiParent = this; //a tela filha pertence a tela pai, que é a tela atual
            cl.Show();
        }

        private void menuSecao_Click(object sender, EventArgs e)
        {
            Sessao cs = new Sessao();
            cs.MdiParent = this; //a tela filha pertence a tela pai, que é a tela atual
            cs.Show();
        }

        private void menuIngresso_Click(object sender, EventArgs e)
        {
            Ingresso ci = new Ingresso();
            ci.MdiParent = this; //a tela filha pertence a tela pai, que é a tela atual
            ci.Show();
        }

        private void menuCadastrarFilmes_Click(object sender, EventArgs e)
        {
            Filmes cf = new Filmes();
            cf.MdiParent = this; //a tela filha pertence a tela pai, que é a tela atual
            cf.Show();
        }
    }
}
