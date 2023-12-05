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
    public partial class frmInserir : Form
    {
        const string str = "Server=localhost;Database=ReparacoesDB;Trusted_Connection=True;";
        SqlConnection conn = new SqlConnection(str);
        public frmInserir()
        {
            InitializeComponent();            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string qry = "INSERT INTO ReparosAtivos VALUES(" +
                             "'" + txtDenominacao.Text + "'," +
                             "'" + txtNumSerie.Text + "'," +
                             "'" + txtAvaria.Text + "'," +
                             "'" + txtCliente.Text + "'," +
                             "'" + txtContacto.Text + "'," +
                             "'" + dtpEntrada.Value.ToString("dd-MM-yy") +
                             "')";
                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserção finalizada com sucesso!");
                ClearBoxes();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ClearBoxes()
        {
            txtDenominacao.Text = "";
            txtNumSerie.Text = "";
            txtContacto.Text = "";
            txtAvaria.Text = "";
            txtCliente.Text = "";
            dtpEntrada.Text = "";
        }
    }
}
