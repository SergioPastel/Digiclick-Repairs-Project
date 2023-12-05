using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoReparacoes
{
    public partial class Form1 : Form
    {
        // Codigo da conexão a base de dados confiavel
        static string str = "Server=localhost;Database=ReparacoesDB;Trusted_Connection=True;";
        SqlConnection conn = new SqlConnection(str);
        public Form1()
        {
            InitializeComponent();
            // Tentar conectar a base de dados
            try 
            {
                conn.Open();
                MessageBox.Show("Conexão a Base de Dados estabelecida com sucesso!");
                conn.Close();
            } 
            catch (SqlException ex) 
            {
                   MessageBox.Show(ex.Message);
            }            
        }

        /*private void btnCriarTabelas_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            string criarTbl = "CREATE TABLE"
        }*/
    }
}
