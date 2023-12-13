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

namespace ProjetoReparacoes
{
    public partial class FrmAtivos : Form
    {
        // Codigo da conexão da base de dados
        const string str = "Server=localhost;Database=ReparacoesDB;Trusted_Connection=True;MultipleActiveResultSets=true;";
        SqlConnection conn = new SqlConnection(str);
        // Dictionary que vai ser usado para preencher a listbox
        List<ReparoAtivo> reparos = new List<ReparoAtivo>();
        Dictionary<int, string> ReparosLst = new Dictionary<int, string>();
        public FrmAtivos()
        {
            InitializeComponent();
            lblDtReparo.Hide();
            dtpReparo.Hide();
            lblDtEntrega.Hide();
            dtpEntrega.Hide();
            chbTerceirizado.Hide();
            lblReparador.Hide();
            txtReparador.Hide();
            try
            {
                conn.Open();
                // Cria um novo reparo para usar o metodo getReparos
                ReparoAtivo reparo = new ReparoAtivo();

                foreach (ReparoAtivo r in reparo.getReparos(conn))
                {
                    reparos.Add(r);
                    ReparosLst.Add(r.id, r.descricao);                    
                }                
                lstReparos.ValueMember = "Key";
                lstReparos.DisplayMember = "Value";
                lstReparos.DataSource = new BindingSource(ReparosLst, null);
                Console.WriteLine(lstReparos.SelectedValue);
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

        private void lstReparos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                int reparoId = 0;
                foreach (ReparoAtivo rep in reparos) {
                    //ERRO NESTA PARTE, LSTREPAROS SELECTED VALUE DEVOLVE UM OBJECT QUE NÃO CONSEGUE FAZER COMPARAçÕES
                    if (lstReparos.SelectedValue.Equals(rep.id))
                        reparoId = rep.id;
                }

                ReparoAtivo r = new ReparoAtivo().getReparosWhere(conn, reparoId);
                txtId.Text = r.id.ToString();
                txtDescricao.Text = r.descricao;
                txtNumSerie.Text = r.numSerie;
                txtAvaria.Text = r.avaria;
                txtCliente.Text = r.cliente.nome;
                txtContacto.Text = r.cliente.contacto;
                txtDtEntrada.Text = r.dtEntrega.ToString().Substring(0, 10);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void chbFinalizado_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbFinalizado.Checked)
            {
                lblDtReparo.Show();
                dtpReparo.Show();
                lblDtEntrega.Show();
                dtpEntrega.Show();
                chbTerceirizado.Show();
                btnConcluirEditar.Text = "Concluir reparação";
            }
            else
            {
                lblDtReparo.Hide();
                dtpReparo.Hide();
                lblDtEntrega.Hide();
                dtpEntrega.Hide();
                chbTerceirizado.Hide();
                lblReparador.Hide();
                txtReparador.Hide();
                btnConcluirEditar.Text = "Editar reparação";
            }
        }

        private void chbTerceirizado_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbTerceirizado.Checked)
            {
                lblReparador.Show();
                txtReparador.Show();
            }
            else
            {
                lblReparador.Hide();
                txtReparador.Hide();
            }
        }

        private void btnConcluirEditar_Click(object sender, EventArgs e)
        {
            int reparoId = 1;
            if (btnConcluirEditar.Text.Equals("Editar Reparação"))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    ReparoAtivo r = new ReparoAtivo();
                    r.updateReparos(conn, reparoId, txtDescricao.Text, txtNumSerie.Text, txtAvaria.Text);
                    string nomeNovo = txtDescricao.Text + "(" + txtCliente.Text + ")";
                    ReparosLst.Remove(reparoId);
                    ReparosLst.Add(reparoId, nomeNovo);
                    lstReparos.DataSource = new BindingSource(ReparosLst, null);
                    lstReparos.DisplayMember = "Value";
                    lstReparos.ValueMember = "Key";
                    MessageBox.Show("Reparo editado com sucesso!");
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
            else
            {
                Cliente c = new Cliente();
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    ReparoAtivo r = new ReparoAtivo();
                    r.cliente = c.getClientWhere(conn, c.getClientByName(conn, txtCliente.Text));
                    Console.WriteLine(r.cliente);

                    int trueOrFalse = 0;
                    if (chbTerceirizado.Checked == true)
                        trueOrFalse = 1;

                    r.concluirReparo(conn, r.getReparosWhere(conn, int.Parse(txtId.Text)), DateTime.Parse(txtDtEntrada.Text), dtpReparo.Value, dtpEntrega.Value, trueOrFalse, txtReparador.Text);
                    ReparosLst.Remove(reparoId);
                    lstReparos.DataSource = new BindingSource(ReparosLst, null);
                    lstReparos.DisplayMember = "Value";
                    lstReparos.ValueMember = "Key";
                    MessageBox.Show("Reparo concluido com sucesso!");
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
        }
    }
}
