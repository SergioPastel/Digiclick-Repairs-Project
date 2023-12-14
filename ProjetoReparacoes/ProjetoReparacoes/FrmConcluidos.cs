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
    public partial class FrmConcluidos : Form
    {
        // Codigo da conexão da base de dados, multipleactiveresults permite que varios sqlcommands sejam usados
        const string str = "Server=localhost;Database=ReparacoesDB;Trusted_Connection=True;MultipleActiveResultSets=true;";
        SqlConnection conn = new SqlConnection(str);
        // Lista e Dictionary que vai ser usado para correr e preencher a listbox
        List<ReparoConcluido> reparos = new List<ReparoConcluido>();
        Dictionary<int, string> ReparosLst = new Dictionary<int, string>();
        public FrmConcluidos()
        {
            InitializeComponent();
            // Limpa as caixas de inicio para esconder as caixas do checkbox
            try
            {
                // Abre a conexão e cria um novo reparo para usar o metodo getReparos
                conn.Open();
                ReparoConcluido reparo = new ReparoConcluido();

                // Para cada reparo devolvido pelo metodo getreparos, adiciona o reparo a lista e ao dictionary
                foreach (ReparoConcluido r in reparo.getReparos(conn))
                {
                    reparos.Add(r);
                    ReparosLst.Add(r.id, r.descricao + "(" + r.cliente.nome + ")");
                }
                // Adiciona o dictionary como fonte da lista, PS: O valuemember e displaymember TEM de vir antes do datasource,
                // se não as comparações não iram funcionar
                lstReparos.ValueMember = "Key";
                lstReparos.DisplayMember = "Value";
                lstReparos.DataSource = new BindingSource(ReparosLst, null);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Se o dictionary estiver vazio, remove o datasource para que a listbox apareça vazia
                if (ReparosLst.Count == 0)
                {
                    lstReparos.DataSource = null;
                    btnReabrir.Hide();
                    btnEliminar.Hide();
                }
                conn.Close();
            }
        }

        private void lstReparos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se o dictionary estiver vazio esconde os botões e limpa as caixas, return impede a função de prosseguir
            if (ReparosLst.Count == 0)
            {
                btnReabrir.Hide();
                btnEliminar.Hide();
                return;
            }
            try
            {
                // Quando o index é mudado pela primeira vez(na inicialização do formulario) a conexão está aberta.
                // Para impedir erros, a conexão e testada primeiro e só é aberta se estiver fechada
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                // Declara o Id do reparo que vai ser usado, a este é atribuido o id da lista que é igual ao valor selecionado da listbox
                int reparoId = 0;
                foreach (ReparoConcluido rep in reparos)
                {
                    if (lstReparos.SelectedValue.Equals(rep.id))
                        reparoId = rep.id;
                }

                // Cria um novo reparo que tem os valores do reparo de mesmo id, preenche as caixas com os dados deste reparo
                ReparoConcluido r = new ReparoConcluido().getReparosWhere(conn, reparoId);
                txtId.Text = r.id.ToString();
                txtDescricao.Text = r.descricao;
                txtNumSerie.Text = r.numSerie;
                txtAvaria.Text = r.avaria;
                txtCliente.Text = r.cliente.nome;
                txtContacto.Text = r.cliente.contacto;
                txtDtEntrada.Text = r.dtEntrega.ToString().Substring(0, 10);
                txtDtReparo.Text = r.dtReparo.ToString().Substring(0, 10);
                txtDtEntrega.Text = r.dtReparo.ToString().Substring(0, 10);
                if(r.terceirizado == false)                
                    txtReparador.Text = "Digiclick";
                else
                    txtReparador.Text = r.reparador;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Declara o Id do reparo que vai ser usado, a este é atribuido o valor selecionado na listbox.
                // Cria um novo reparo com os valores do reparo de mesmo id, remove este reparo da tabela e do dictionary
                conn.Open();
                int reparoId = (int)lstReparos.SelectedValue;
                ReparoConcluido r = new ReparoConcluido().getReparosWhere(conn, reparoId);
                r.deletarReparo(conn, r);
                MessageBox.Show("Reparo eliminado com sucesso!");
                ReparosLst.Remove(reparoId);
                lstReparos.DataSource = new BindingSource(ReparosLst, null);
                lstReparos.DisplayMember = "Value";
                lstReparos.ValueMember = "Key";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Se ao eliminar o reparo o dictionary ficar vazio, esvazia a listbox
                if (ReparosLst.Count == 0)
                {
                    lstReparos.DataSource = null;
                    txtId.Text = "";
                    txtDescricao.Text = "";
                    txtNumSerie.Text = "";
                    txtCliente.Text = "";
                    txtContacto.Text = "";
                    txtDtEntrada.Text = "";
                    txtDtReparo.Text = "";
                    txtDtEntrega.Text = "";
                    txtReparador.Text = "";
                    txtAvaria.Text = "";
                    btnEliminar.Hide();
                    btnReabrir.Hide();
                    Focus();
                }
                txtReparador.Text = "";
                conn.Close();
            }
        }

        private void btnReabrir_Click(object sender, EventArgs e)
        {
            // Declara o Id do reparo que vai ser usado, a este é atribuido o valor selecionado na listbox
            int reparoId = (int)lstReparos.SelectedValue;

            Cliente c = new Cliente();
            try
            {
                conn.Open();
                ReparoConcluido r = new ReparoConcluido();
                r.cliente = c.getClientWhere(conn, c.getClientByName(conn, txtCliente.Text));                

                // Usa a função concluir reparo para remover o reparo da tabela ReparosAtivos e adiciona-lo a ReparosConcluidos
                // Remove reparo do dictionary e atualiza a lista
                r.reabrirReparo(conn, r);
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
                // Se depois de concluir um reparo o dictionary estiver vazio, esvazia a lista e limpa as caixas
                if (ReparosLst.Count == 0)
                {
                    lstReparos.DataSource = null;
                    txtId.Text = "";
                    txtDescricao.Text = "";
                    txtNumSerie.Text = "";
                    txtCliente.Text = "";
                    txtContacto.Text = "";
                    txtDtEntrada.Text = "";
                    txtDtReparo.Text = "";
                    txtDtEntrega.Text = "";
                    txtReparador.Text = "";
                    txtAvaria.Text = "";
                    btnEliminar.Hide();
                    btnReabrir.Hide();
                    Focus();
                }
                conn.Close();
            }
        }
    }
}
