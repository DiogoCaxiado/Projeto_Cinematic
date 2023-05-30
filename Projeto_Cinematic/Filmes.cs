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
    public partial class Filmes : Form
    {
        public Filmes()
        {
            InitializeComponent();
        }

        int idFilme;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.TextLength != 0 && txtGenero.TextLength != 0 && txtDuracao.TextLength != 0 && txtIdioma.TextLength != 0 && txtAnoLancamento.TextLength != 0 && txtSinopse.TextLength != 0 && txtFaixaEtaria.TextLength != 0 && rad2D.Checked || rad3D.Checked)
            {
                //criando o objeto de conexão com banco de dados
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";

                //criando o objeto de comando de SQL para enviar instruções para o banco de dados
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection; //ligando o comando a conexão que configurada acima
                cmd.CommandText = "piFilme_Di";
                cmd.CommandType = CommandType.StoredProcedure; //definindo que o comando é um procedimento

                string exibicao;

                if (rad2D.Checked == true)
                {
                    exibicao = "2D";
                }
                else
                {
                    exibicao = "3D";
                }
                //vincular os campos do formulários aos parâmetros do procedimento
                cmd.Parameters.AddWithValue("nome", txtNome.Text);
                cmd.Parameters.AddWithValue("genero", txtGenero.Text);
                cmd.Parameters.AddWithValue("duracao", txtDuracao.Text);
                cmd.Parameters.AddWithValue("idioma", txtIdioma.Text);
                cmd.Parameters.AddWithValue("anoLancamento", txtAnoLancamento.Text);
                cmd.Parameters.AddWithValue("sinopse", txtSinopse.Text);
                cmd.Parameters.AddWithValue("faixaEtaria", txtFaixaEtaria.Text);
                cmd.Parameters.AddWithValue("exibicao", exibicao);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                connection.Close();

                MessageBox.Show("Filme cadastrado com sucesso.");
            }
            else
            {
                MessageBox.Show("Verifique os campos preenchidos.");
            }
        }


        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            if (txtNome.TextLength != 0 && txtGenero.TextLength != 0 && txtDuracao.TextLength != 0 && txtIdioma.TextLength != 0 && txtAnoLancamento.TextLength != 0 && txtSinopse.TextLength != 0 && txtFaixaEtaria.TextLength != 0 && rad2D.Checked || rad3D.Checked)
            {
                DialogResult dialog = MessageBox.Show("Deseja realmente atualizar?", "Aviso", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    //criando o objeto de conexão com banco de dados
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";

                    //criando o objeto de comando de SQL para enviar instruções para o banco de dados
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection; //ligando o comando a conexão que configurada acima
                    cmd.CommandText = "puFilme_Di";
                    cmd.CommandType = CommandType.StoredProcedure; //definindo que o comando é um procedimento
                    cmd.Parameters.AddWithValue("idFilme", idFilme);

                    string exibicao;

                    if (rad2D.Checked == true)
                    {
                        exibicao = "2D";
                    }
                    else
                    {
                        exibicao = "3D";
                    }

                    //vincular os campos do formulários aos parâmetros do procedimento
                    cmd.Parameters.AddWithValue("nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("faixaEtaria", txtFaixaEtaria.Text);
                    cmd.Parameters.AddWithValue("genero", txtGenero.Text);
                    cmd.Parameters.AddWithValue("idioma", txtIdioma.Text);
                    cmd.Parameters.AddWithValue("duracao", txtDuracao.Text);
                    cmd.Parameters.AddWithValue("exibicao", exibicao);
                    cmd.Parameters.AddWithValue("anoLancamento", txtAnoLancamento.Text);
                    cmd.Parameters.AddWithValue("sinopse", txtSinopse.Text);

                    connection.Open();
                    cmd.ExecuteNonQuery(); //executar para comandos que não possuem retorno de dados (INSERT, UPDATE e DELETE)
                    connection.Close();

                    MessageBox.Show("Filme atualizado com sucesso.");
                }
            }
            else
            {
                MessageBox.Show("Verifique os campos preenchidos");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (boxNome.SelectedIndex != -1)
            {
                buscar();
            }
        }

        private void buscar()

        {
            //criando o objeto de conexão com banco de dados
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";

            //criando o objeto de comando de SQL para enviar instruções para o banco de dados
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection; //ligando o comando a conexão que configurada acima
            cmd.CommandText = "psBuscarFilmes_Di";
            cmd.CommandType = CommandType.StoredProcedure; //definindo que o comando é um procedimento
            cmd.Parameters.AddWithValue("nome", boxNome.Text);

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

                txtNome.Text = reader.GetString(1);
                txtFaixaEtaria.Text = reader.GetString(2);
                txtGenero.Text = reader.GetString(3);
                txtIdioma.Text = reader.GetString(4);
                txtDuracao.Text = reader.GetInt32(5).ToString();

                if (reader.GetString(6) == "2D")
                {
                    rad2D.Checked = true;
                }
                else
                {
                    rad3D.Checked = true;
                }

                txtAnoLancamento.Text = reader.GetInt32(7).ToString();
                txtSinopse.Text = reader.GetString(8);
                idFilme = reader.GetInt32(0);
            }
            else
            {
                MessageBox.Show("Filme não encontrado!");
            }

            connection.Close();
        }

        private void btnFecharX2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Deseja realmente fechar?", "Aviso!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Filmes_Load(object sender, EventArgs e)
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
                    boxNome.Items.Add(readerFilme.GetString(1));
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente excluir?", "Aviso", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                //criando o objeto de conexão com banco de dados
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";

                //criando o objeto de comando de SQL para enviar instruções para o banco de dados
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection; //ligando o comando a conexão que configurada acima
                cmd.CommandText = "pdFilme_Di";
                cmd.CommandType = CommandType.StoredProcedure; //definindo que o comando é um procedimento

                //vincular os campos do formulários aos parâmetros do procedimento
                cmd.Parameters.AddWithValue("nome", txtNome.Text);

                connection.Open();
                cmd.ExecuteNonQuery(); //executar para comandos que não possuem retorno de dados (INSERT, UPDATE e DELETE)
                connection.Close();

                MessageBox.Show("Filme excluído com sucesso.");
            }
        }

        private void boxNome_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}