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
            cmd.Parameters.AddWithValue("usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("senha", txtSenha.Text);
   
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader(); //executando o comando de busca no SQL e armazenando o resultado da busca em um leitor (matriz)

            if (reader.HasRows)
            {
                reader.Read();
                
                txtUsuario.Text = reader.GetString(7);
                txtSenha.Text = reader.GetString(8);

                Form1 login = new Form1();
                login.Show();
            }
            else
            {
                MessageBox.Show("Funcionário não encontrado!");
            }

            connection.Close();
        }
    }
}
