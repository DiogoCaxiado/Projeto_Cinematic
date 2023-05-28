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
    public partial class Ingresso : Form
    {
        public Ingresso()
        {
            InitializeComponent();
        }

        int idIngresso;

        private void cadastro_ingresso_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";

            SqlCommand commandFilme = new SqlCommand();
            commandFilme.CommandText = "SELECT * FROM filme_Di";
            commandFilme.CommandType = CommandType.Text;
            commandFilme.Connection = connection;

            connection.Open();
            SqlDataReader readerFilme = commandFilme.ExecuteReader();

            if (readerFilme.HasRows)
            {
                while (readerFilme.Read())
                {
                    boxSala.Visible = true;
                    boxFilme.Items.Add(readerFilme.GetString(1));
                }
                connection.Close();


                SqlCommand commandSecao = new SqlCommand();
                commandSecao.CommandText = "SELECT * FROM sessao_Di";
                commandSecao.CommandType = CommandType.Text;
                commandSecao.Connection = connection;

                connection.Open();

                SqlDataReader readerSala = commandSecao.ExecuteReader();

                if (readerSala.HasRows)
                {
                    while (readerSala.Read())
                    {
                        boxSala.Items.Add(readerSala.GetString(1));
                    }
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Deseja realmente fechar?", "Aviso!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void soma()
        {
            int valor = 25 * (int)numInteira.Value + 15 * (int)numMeia.Value;

            txtValor.Text = valor.ToString();
        }

        private void numericUpDownInteira_ValueChanged(object sender, EventArgs e)
        {
            soma();  
        }

        private void numericUpDownmeia_ValueChanged(object sender, EventArgs e)
        {
            soma();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //criando o objeto de conexão com banco de dados
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";

            //criando o objeto de comando de SQL para enviar instruções para o banco de dados
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection; //ligando o comando a conexão que configurada acima
            cmd.CommandText = "piIngresso_Di";
            cmd.CommandType = CommandType.StoredProcedure; //definindo que o comando é um procedimento

            //vincular os campos do formulários aos parâmetros do procedimento   
            cmd.Parameters.AddWithValue("inteiraEntrada", numInteira.Text);
            cmd.Parameters.AddWithValue("meiaEntrada", numMeia.Text);
            cmd.Parameters.AddWithValue("valor", txtValor.Text);
            cmd.Parameters.AddWithValue("sala", boxSala.Text);
            cmd.Parameters.AddWithValue("idFilme", boxFilme.Text);

            connection.Open();

            DialogResult result = MessageBox.Show("Deseja confirmar?", "Aviso", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (boxFilme.SelectedIndex == -1)
                {
                    MessageBox.Show("Favor selecionar um filme");
                }
                else if (numInteira.Value > 0 || numMeia.Value > 0)
                {
                    MessageBox.Show("Venda gerada. \n Total da compra R$ " + txtValor.Text);
                }
                else 
                {
                    MessageBox.Show("Favor inserir ao menos um ingresso");
                }

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                idIngresso = reader.GetInt32(0);
            }

            connection.Close();
        }
    }
}
