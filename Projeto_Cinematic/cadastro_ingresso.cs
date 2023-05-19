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

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            cmd.Parameters.AddWithValue("poltrona", txtpoltrona.Text);
            cmd.Parameters.AddWithValue("filme", txtfilme.Text);
            cmd.Parameters.AddWithValue("Tipo de ingresso", textipodeigresso.Text);
            cmd.Parameters.AddWithValue("Valor", textvalor.Text);
            cmd.Parameters.AddWithValue("Sala", txtsala.Text);
            cmd.Parameters.AddWithValue("Horario", texthorario.Text);
           

            connection.Open();
            cmd.ExecuteNonQuery(); //executar para comandos que não possuem retorno de dados (INSERT, UPDATE e DELETE)
            connection.Close();

            MessageBox.Show("Funcionário cadastrado com sucesso!");
        }

        private void cadastro_funcionario_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
