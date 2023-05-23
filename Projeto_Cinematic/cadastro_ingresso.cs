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
    public partial class cadastro_ingresso : Form
    {
        public cadastro_ingresso()
        {
            InitializeComponent();
        }

        private void cadastro_ingresso_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM filme_Di";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            connection.Open();
            SqlDataReader readerTipo = command.ExecuteReader();

            if (readerTipo.HasRows)
            {
                while (readerTipo.Read())
                {
                    comboBoxfilme.Items.Add(readerTipo.GetString(1));
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //criando o objeto de conexão com banco de dados
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";

            //criando o objeto de comando de SQL para enviar instruções para o banco de dados
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection; //ligando o comando a conexão que configurada acima
            cmd.CommandText = "piingresso_Di";
            cmd.CommandType = CommandType.StoredProcedure; //definindo que o comando é um procedimento

            //vincular os campos do formulários aos parâmetros do procedimento
            cmd.Parameters.AddWithValue("filme", comboBoxfilme.Text);
            cmd.Parameters.AddWithValue("Tipo de ingresso", numInteira.Text);
            cmd.Parameters.AddWithValue("Tipo de ingresso", numMeia.Text);
            cmd.Parameters.AddWithValue("Valor", txtValor.Text);
            cmd.Parameters.AddWithValue("Sala", comboBoxSala.Text);

            connection.Open();
            cmd.ExecuteNonQuery(); //executar para comandos que não possuem retorno de dados (INSERT, UPDATE e DELETE)
            connection.Close();

            MessageBox.Show("Ingresso cadastrado com sucesso!");
        } 

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxtipodeigresso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (numInteira.Text == "inteira")
            {
                txtValor.Text = "25"; 
            } 
            else
            {
                txtValor.Text = "15";
            }
        }

        //private void listarTodosIngressos()
        //{
        //    string sql = "SELECT * FROM ingresso_Di ORDER BY idIngresso DESC ";
        //    //listarTodosIngressos(sql);
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Deseja realmente excluir?", "Aviso", MessageBoxButtons.YesNo);

            //if (result == DialogResult.Yes)
            //{
            //    //criando o objeto de conexão com banco de dados
            //    SqlConnection connection = new SqlConnection();
            //    connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";

            //    //criando o objeto de comando de SQL para enviar instruções para o banco de dados
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = connection; //ligando o comando a conexão que configurada acima
            //    cmd.CommandText = "puIngresso_Di-";
            //    cmd.CommandType = CommandType.StoredProcedure; //definindo que o comando é um procedimento

            //    //vincular os campos do formulários aos parâmetros do procedimento
            //    cmd.Parameters.AddWithValue("idIngresso", idIngresso);

            //    connection.Open();
            //    cmd.ExecuteNonQuery(); //executar para comandos que não possuem retorno de dados (INSERT, UPDATE e DELETE)
            //    connection.Close();

            //    MessageBox.Show("Cliente excluído com sucesso.");

            //    listarTodosIngressos();
            }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void numericUpDownInteira_ValueChanged(object sender, EventArgs e)
        {
            soma();  
        }
        private void soma ()
        {
            int valor = 25 * (int)numInteira.Value + 15 * (int)numMeia.Value;

            txtValor.Text = valor.ToString();
        }

        private void numericUpDownmeia_ValueChanged(object sender, EventArgs e)
        {
            soma();
        }
    }
}
