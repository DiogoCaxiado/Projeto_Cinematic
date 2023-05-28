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
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        int idFuncionario;

        private void button1_Click(object sender, EventArgs e)

        {
            timer1.Start();

            {
                //criando o objeto de conexão com banco de dados
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";

                //criando o objeto de comando de SQL para enviar instruções para o banco de dados
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection; //ligando o comando a conexão que configurada acima
                cmd.CommandText = "piFuncionario_Di";
                cmd.CommandType = CommandType.StoredProcedure; //definindo que o comando é um procedimento

                //vincular os campos do formulários aos parâmetros do procedimento
                cmd.Parameters.AddWithValue("nome", txtNome.Text);
                cmd.Parameters.AddWithValue("dtNascimento", Convert.ToDateTime(txtdtNascimento.Text));
                cmd.Parameters.AddWithValue("cpf", txtCPF.Text);
                cmd.Parameters.AddWithValue("telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
                cmd.Parameters.AddWithValue("cargo", txtCargo.Text);
                cmd.Parameters.AddWithValue("senha", txtSenha.Text);

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                idFuncionario = reader.GetInt32(0);
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
                cmd.CommandText = "puFuncionario_Di";
                cmd.CommandType = CommandType.StoredProcedure; //definindo que o comando é um procedimento
                cmd.Parameters.AddWithValue("idFuncionario", idFuncionario);

                //vincular os campos do formulários aos parâmetros do procedimento
                cmd.Parameters.AddWithValue("nome", txtNome.Text);
                cmd.Parameters.AddWithValue("dtNascimento", Convert.ToDateTime(txtdtNascimento.Text));
                cmd.Parameters.AddWithValue("cpf", txtCPF.Text);
                cmd.Parameters.AddWithValue("cargo", txtCargo.Text);
                cmd.Parameters.AddWithValue("telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
                cmd.Parameters.AddWithValue("senha", txtSenha.Text);

                connection.Open();
                cmd.ExecuteNonQuery(); //executar para comandos que não possuem retorno de dados (INSERT, UPDATE e DELETE)
                connection.Close();

                MessageBox.Show("Funcionário atualizado com sucesso!");
            }
        }

        private void btnBuscarF_Click(object sender, EventArgs e)

        {
            if (txtCPF.TextLength > 0)
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
            cmd.CommandText = "psBuscarFuncionario_Di";
            cmd.CommandType = CommandType.StoredProcedure; //definindo que o comando é um procedimento
            cmd.Parameters.AddWithValue("cpf", txtCPF.Text);


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
                txtdtNascimento.Text = reader.GetDateTime(2).ToString("dd/MM/yyyy");
                txtCPF.Text = reader.GetInt64(3).ToString();
                txtCargo.Text = reader.GetString(4);
                txtTelefone.Text = reader.GetInt64(5).ToString();
                txtEmail.Text = reader.GetString(6);
                txtSenha.Text = reader.GetString(7);
                idFuncionario = reader.GetInt32(0);
            }
            else
            {
                MessageBox.Show("Funcionario não encontrado!");
            }

            connection.Close();

        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            {
                Random random = new Random();
                int valorAleatorio = random.Next(1, 1);
                label1.Text = "Valor Aleatório: " + valorAleatorio.ToString();
            }


            if (progressBar1.Value < progressBar1.Maximum)
                {
                    progressBar1.Value++;
                }
                else
                {
                    timer1.Stop();
                    
                    MessageBox.Show("Funcionário cadastrado com sucesso!\n O código de usuário do funcionário é: "+ idFuncionario.ToString());
                    this.Close();
            }
            

        }

        private void btnFecharX2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Deseja realmente fechar?", "Aviso!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
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
                cmd.CommandText = "pdFuncionario_Di";
                cmd.CommandType = CommandType.StoredProcedure; //definindo que o comando é um procedimento

                //vincular os campos do formulários aos parâmetros do procedimento
                cmd.Parameters.AddWithValue("cpf", txtCPF.Text);

                connection.Open();
                cmd.ExecuteNonQuery(); //executar para comandos que não possuem retorno de dados (INSERT, UPDATE e DELETE)
                connection.Close();

                MessageBox.Show("Funcionário excluído com sucesso.");
            }
        }
    }
}
