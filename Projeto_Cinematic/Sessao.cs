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
    public partial class Sessao : Form
    {
        public Sessao()
        {
            InitializeComponent();
        }

        string escolha;

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                Random random = new Random();
                int valorAleatorio = random.Next(1, 1);
                label1.Text = "Salas: " + valorAleatorio;
            }


            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();

                MessageBox.Show("Sessão cadastrada com êxito!\n Essa sessão estará vinculada ao filme: " + boxFilmes.FindString(escolha));
                this.Close();

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //if (boxFilmes)
            //{
            //    buscar();
            //}
            
        }


        private void buscar()
        {
            //criando o objeto de conexão com banco de dados
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";

            //criando o objeto de comando de SQL para enviar instruções para o banco de dados
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection; //ligando o comando a conexão que configurada acima
            cmd.CommandText = "psBuscarSessao_Di";
            cmd.CommandType = CommandType.StoredProcedure; //definindo que o comando é um procedimento
            cmd.Parameters.AddWithValue("nome", boxFilmes.Text);


            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader(); //executando o comando de busca no SQL e armazenando o resultado da busca em um leitor (matriz)

            if (reader.HasRows) //se o leitor tem linhas de dados
            {
                reader.Read(); //ler a próxima linha de dados

                //tipos de GET em C#

                //GetString = textos (VARCHAR)
                //GetDecimal = valores decimais (DECIMAL)
                //GetInt32 = números inteiros (INT)
                //GetInt64 = números inteiros (BIGINT)
                //GetDateTime = data (DATE, TIME ou DATETIME)

                txtSalas.Text = reader.GetInt32(1).ToString();
                boxFilmes.Text = reader.GetString(3);
                
            }
            else
            {
                MessageBox.Show("Sessão não encontrado!");
            }

            connection.Close();
        }

        private void btnFecharX_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Deseja realmente fechar?", "Aviso", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCadastrarSecao_Click(object sender, EventArgs e)
        {
            if (txtSalas.TextLength != 0 && boxFilmes.Text.Length != 0)
            {
                timer1.Start();
                {
                    //criando o objeto de conexão com banco de dados
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";

                    //criando o objeto de comando de SQL para enviar instruções para o banco de dados
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection; //ligando o comando a conexão que configurada acima
                    cmd.CommandText = "piSessao_Di";
                    cmd.CommandType = CommandType.StoredProcedure; //definindo que o comando é um procedimento

                    //vincular os campos do formulários aos parâmetros do procedimento
                    cmd.Parameters.AddWithValue("sala", txtSalas.Text);
                    cmd.Parameters.AddWithValue("nomeFilme", boxFilmes.Text);

                    connection.Open();
                    if (boxFilmes.SelectedIndex != -1)
                    {
                        escolha = boxFilmes.SelectedItem.ToString();
                    }
                    SqlDataReader reader = cmd.ExecuteReader();

                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Verifique se preencheu os campos corretamente.");
            }
        }

        private void Sessao_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";

            SqlCommand commandFilmes = new SqlCommand();
            commandFilmes.CommandText = "SELECT * FROM filme_Di";
            commandFilmes.CommandType = CommandType.Text;
            commandFilmes.Connection = connection;

            connection.Open();

            SqlDataReader readerFilme = commandFilmes.ExecuteReader();

            if (readerFilme.HasRows)
            {
                while (readerFilme.Read())
                {
                    boxFilmes.Items.Add(readerFilme.GetString(1));
                }
            }
        }
    }
}
