using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Cinematic
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //criando o objeto de conexão com banco de dados
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";

            //criando o objeto de comando de SQL para enviar instruções para o banco de dados
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection; //ligando o comando a conexão que configurada acima
            cmd.CommandText = "psLogin_Di";
            cmd.CommandType = CommandType.StoredProcedure; //definindo que o comando é um procedimento

            //vincular os campos do formulários aos parâmetros do procedimento
            cmd.Parameters.AddWithValue("idFuncionario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("senha", txtSenha.Text);
   
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader(); //executando o comando de busca no SQL e armazenando o resultado da busca em um leitor (matriz)
           
            if (reader.HasRows)
            {
                reader.Read();
                string cargo = reader.GetString(4);

                Form1 f = (Form1)MdiParent; //clonando o objeto da tela principal

                MessageBox.Show("Bem vindo!");

                if (cargo == "Gerente")
                {
                    //abrir os menus de gerente
                    f.menuAcesso.Visible = false;
                    f.menuFuncionario.Visible = true;
                    f.menuIngresso.Visible = true;
                    f.menuFilmes.Visible = true;
                }
                else if (cargo == "Caixa")
                {
                    //abrir os menus de balcão ingressos
                    f.menuAcesso.Visible = false;
                    f.menuFuncionario.Visible = false;
                    f.menuIngresso.Visible = true;
                    f.menuFilmes.Visible = false;
                }

                connection.Close();
                this.Close();
            }

            else
            {
                MessageBox.Show("Verifique seu usuário e senha.");
            }

            connection.Close();
        }

        private void btnFecharX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
