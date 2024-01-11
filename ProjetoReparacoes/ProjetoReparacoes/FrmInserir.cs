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
using System.Globalization;

namespace ProjetoReparacoes
{
    public partial class frmInserir : Form
    {
        SqlConnection conn = new SqlConnection();
        // List de clientes que vai ser usada para conseguir o contacto
        List<Cliente> Lista = new List<Cliente>();
        Dictionary<int, string> Clientes = new Dictionary<int, string>();

        public frmInserir()
        {
            InitializeComponent();
            
        }
        public frmInserir(string server, string user, string pass, bool log)
        {
            string str = "Server= " + server + "; Database= ReparacoesDB; User=" + user + "; Password= " + pass + ";";
            conn.ConnectionString = str;
            if (log == false)
            {
                this.Close();
                frmInserir frm = new frmInserir();
                frm.Show();
            }
            else
            {
                InitializeComponent();
                // Cria um cliente novo para usar o "GetClients" e para adicionar um cliente vazio no indice 0
                Cliente c = new Cliente();
                try
                {
                    conn.Open();
                    // Adiciona um Cliente vazio no indice 0
                    Clientes.Add(0, "Insira/Escolha um Cliente");
                    // Para cada Cliente na base de dados, é adicionado a lista e ao dictionary
                    foreach (Cliente cliente in c.getClients(conn))
                    {
                        Lista.Add(cliente);
                        Clientes.Add(cliente.id, cliente.nome);
                    }
                    // Fonte de dados da combobox se torna o dictionary de clientes
                    cmbCliente.DataSource = new BindingSource(Clientes, null);
                    cmbCliente.DisplayMember = "Value";
                    cmbCliente.ValueMember = "Key";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    ClearBoxes();
                }
            }
        }
        
        private void btnInserir_Click(object sender, EventArgs e)
        {   
            // Para cada cliente na lista, se este cliente já existir e estiver sendo adicionado novamente, para a função
            foreach (Cliente cliente in Lista)
            {
                if (cliente.nome == cmbCliente.Text && cmbCliente.SelectedIndex == -1)
                {
                    MessageBox.Show("Este cliente já existe");
                    ClearBoxes();                    
                    return;
                }
            }
            try
            {
                // Abre a conexão, força o usuario a inserir ou escolher um cliente
                conn.Open();
                if (cmbCliente.SelectedIndex == 0 || cmbCliente.Text == null)
                    MessageBox.Show("Escolha um Cliente!");
                else
                {
                    // Cria um novo cliente c, esse cliente é preenchido com as informações do cliente
                    Cliente c = new Cliente();
                    c.id = cmbCliente.SelectedIndex;
                    c.nome = cmbCliente.Text;
                    c.contacto = txtContacto.Text;                    
                    // É criado a querry e o comando sql para serem preenchidos depois dependendo da situação
                    string qry = null;
                    SqlCommand cmd = new SqlCommand(qry, conn);                    
                    if (cmbCliente.SelectedIndex == -1)
                    {                                                
                        // Adiciona o ultimo id da combobox para o novo cliente, o adiciona pra lista e dictionary,
                        // Re-adiciona o dictionary como datasource pra atualizar a combobox automaticamente
                        // Executa a querry e adiciona o novo cliente a base de dados
                        c.id = cmbCliente.Items.Count;
                        Clientes.Add(c.id, c.nome);
                        Lista.Add(c);
                        cmbCliente.DataSource = new BindingSource(Clientes, null);
                        qry = "INSERT INTO Clientes VALUES(" +
                                 "'" + c.nome + "'," +
                                 "'" + c.contacto + "');";

                        cmd = new SqlCommand(qry, conn);
                        cmd.ExecuteNonQuery();                        
                    }                    
                    // Atualiza a querry e adiciona a reparação a base de dados, também podendo escolher novos clientes
                    qry = "INSERT INTO ReparosAtivos VALUES(" +
                                 "'" + txtDenominacao.Text + "'," +
                                 "'" + txtNumSerie.Text + "'," +
                                 "'" + txtAvaria.Text + "'," +
                                 c.id + "," +
                                 "'" + c.contacto + "','" +
                                 dtpEntrada.Value.ToString(CultureInfo.InvariantCulture).Substring(0, 10) +
                                 "', '')";
                    cmd = new SqlCommand(qry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inserção finalizada com sucesso!");                    
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ClearBoxes();
                conn.Close();
            }
        }

        // Limpar as caixas
        private void ClearBoxes()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string qry = "SELECT ISNULL(IDENT_CURRENT('ReparosAtivos'), 0);";
                SqlCommand cmd = new SqlCommand(qry, conn);
                int idAtivo = Convert.ToInt32(cmd.ExecuteScalar());
               
                lblIdUltimo.Text = (idAtivo + 1).ToString();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtDenominacao.Text = "";
                txtNumSerie.Text = "";
                txtContacto.Text = "";
                txtAvaria.Text = "";
                cmbCliente.SelectedIndex = 0;
                dtpEntrada.Value = DateTime.Now;
                txtDenominacao.Focus();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }                        
        }

        // Muda o estado das caixas dependendo do cliente selecionado e seu id
        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex == 0)
            {
                cmbCliente.DropDownStyle = ComboBoxStyle.DropDown;
                txtContacto.Text = null;
                txtContacto.ReadOnly = false;
            }
            foreach (Cliente cliente in Lista)
            {               
                if(cmbCliente.SelectedIndex == cliente.id)
                {
                    cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
                    txtContacto.Text = cliente.contacto;
                    txtContacto.ReadOnly = true;
                }
            }
        }
    }
}
