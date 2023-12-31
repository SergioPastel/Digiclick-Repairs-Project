﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoReparacoes
{
    public partial class FrmAtivos : Form
    {
        // Codigo da conexão da base de dados, multipleactiveresults permite que varios sqlcommands sejam usados
        const string str = "Server=localhost;Database=ReparacoesDB;Trusted_Connection=True;MultipleActiveResultSets=true;";
        SqlConnection conn = new SqlConnection(str);
        // Lista e Dictionary que vai ser usado para correr e preencher a listbox
        List<ReparoAtivo> reparos = new List<ReparoAtivo>();
        Dictionary<int, string> ReparosLst = new Dictionary<int, string>();
        public FrmAtivos()
        {         
            InitializeComponent();
            // Limpa as caixas de inicio para esconder as caixas do checkbox
            ClearBoxes();             
            try
            {
                // Abre a conexão e cria um novo reparo para usar o metodo getReparos
                conn.Open();
                ReparoAtivo reparo = new ReparoAtivo();

                // Para cada reparo devolvido pelo metodo getreparos, adiciona o reparo a lista e ao dictionary
                foreach (ReparoAtivo r in reparo.getReparos(conn))
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
                    MessageBox.Show("Não existem reparos ativos.");
                    ClearBoxes();
                }
                conn.Close();
            }
        }

        private void lstReparos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se o dictionary estiver vazio esconde os botões e limpa as caixas, return impede a função de prosseguir
            if (ReparosLst.Count == 0)
            {
                btnConcluirEditar.Hide();
                btnEliminar.Hide();
                btnImprimir.Hide();
                ClearBoxes();
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
                foreach (ReparoAtivo rep in reparos) {
                    if (lstReparos.SelectedValue.Equals(rep.id))
                        reparoId = rep.id;
                }

                // Cria um novo reparo que tem os valores do reparo de mesmo id, preenche as caixas com os dados deste reparo
                ReparoAtivo r = new ReparoAtivo().getReparosWhere(conn, reparoId);
                txtId.Text = r.id.ToString();
                txtDescricao.Text = r.descricao;
                txtNumSerie.Text = r.numSerie;
                txtAvaria.Text = r.avaria;
                txtCliente.Text = r.cliente.nome;
                txtContacto.Text = r.cliente.contacto;
                txtDtEntrada.Text = r.dtEntrega.ToString().Substring(0, 10);
                txtReparador.Text = r.reparador.ToString();

                if (txtReparador.Text.Equals(""))
                    chbTerceirizado.Checked = false;
                else
                    chbTerceirizado.Checked = true;
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

        private void chbFinalizado_CheckStateChanged(object sender, EventArgs e)
        {
            // Se a checkbox estiver checked, mostra as opções, se não as esconde. Muda o texto do botão de editar para concluir e vice versa
            if (chbFinalizado.Checked)
            {
                lblDtReparo.Show();
                dtpReparo.Show();
                lblDtEntrega.Show();
                dtpEntrega.Show();
                btnConcluirEditar.Text = "Concluir Reparação";
            }
            else
            {
                lblDtReparo.Hide();
                dtpReparo.Hide();
                lblDtEntrega.Hide();
                dtpEntrega.Hide();
                btnConcluirEditar.Text = "Editar Reparação";
            }
        }

        private void chbTerceirizado_CheckStateChanged(object sender, EventArgs e)
        {
            // Se a checkbox estiver checked, mostra as opções, se não as esconde.
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
            Console.WriteLine(btnConcluirEditar.Text);
            // Declara o Id do reparo que vai ser usado, a este é atribuido o valor selecionado na listbox
            int reparoId = (int)lstReparos.SelectedValue;
            // Se o texto do botão for de edição, remove o item selecionado do dictionary e adiciona um com as informações atualizadas
            if (btnConcluirEditar.Text.Equals("Editar Reparação"))
            {
                try
                {
                    conn.Open();
                    ReparoAtivo r = new ReparoAtivo();                   

                    r.updateReparos(conn, reparoId, txtDescricao.Text, txtNumSerie.Text, txtAvaria.Text, txtReparador.Text);
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
            // Se o botão tiver outro texto(concluir), cria um novo cliente para usar a função getclientwhere e getclientbyname
            // (clientes não podem ter o mesmo nome, então não a chance de erro)
            else
            {
                Cliente c = new Cliente();
                try
                {
                    conn.Open();
                    ReparoAtivo r = new ReparoAtivo();
                    r.cliente = c.getClientWhere(conn, c.getClientByName(conn, txtCliente.Text));

                    // Sql não tem o tipo Bool, então é usado o tipo BIT ao invés, por isso é usado um int que é false(0) ou true(1)
                    int trueOrFalse = 0;
                    if (chbTerceirizado.Checked == true)
                        trueOrFalse = 1;

                    // Usa a função concluir reparo para remover o reparo da tabela ReparosAtivos e adiciona-lo a ReparosConcluidos
                    // Remove reparo do dictionary e atualiza a lista
                    r.updateReparos(conn, reparoId, txtDescricao.Text, txtNumSerie.Text, txtAvaria.Text, txtReparador.Text);
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
                    // Se depois de concluir um reparo o dictionary estiver vazio, esvazia a lista e limpa as caixas
                    if (ReparosLst.Count == 0)
                    {
                        lstReparos.DataSource = null;
                        btnConcluirEditar.Hide();
                        btnEliminar.Hide();
                        btnImprimir.Hide();
                        ClearBoxes();
                    }
                    chbFinalizado.CheckState = CheckState.Unchecked;
                    chbTerceirizado.CheckState = CheckState.Unchecked;
                    txtReparador.Text = "";
                    conn.Close();
                }
            }
        }
        // Função que limpa as caixas
        public void ClearBoxes()
        {
            txtId.Text = "";
            txtDescricao.Text = "";
            txtNumSerie.Text = "";
            txtCliente.Text = "";
            txtContacto.Text = "";
            txtDtEntrada.Text = "";
            txtAvaria.Text = "";
            chbFinalizado.CheckState = CheckState.Unchecked;
            lblDtEntrega.Hide();
            dtpEntrega.Value = DateTime.Now;
            dtpEntrega.Hide();
            lblDtReparo.Hide();
            dtpReparo.Value = DateTime.Now;
            dtpReparo.Hide();
            lblReparador.Hide();
            txtReparador.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Declara o Id do reparo que vai ser usado, a este é atribuido o valor selecionado na listbox.
                // Cria um novo reparo com os valores do reparo de mesmo id, remove este reparo da tabela e do dictionary
                conn.Open();
                int reparoId = (int)lstReparos.SelectedValue;
                ReparoAtivo r = new ReparoAtivo().getReparosWhere(conn, reparoId);
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
                    btnConcluirEditar.Hide();
                    btnEliminar.Hide();
                    btnImprimir.Hide();
                    ClearBoxes();
                }
                chbFinalizado.CheckState = CheckState.Unchecked;
                chbTerceirizado.CheckState = CheckState.Unchecked;
                txtReparador.Text = "";
                conn.Close();
            }
        }

        // Funções de impressão do Reparo
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printPreviewDialog1.ClientSize = new Size(700, 700);
            try
            {
                if(conn.State == ConnectionState.Closed)
                    conn.Open();
                ReparoAtivo r = new ReparoAtivo().getReparosWhere(conn, (int)lstReparos.SelectedValue);

                Font font1 = new Font("Arial", 36, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
                Font font2 = new Font("Arial", 24, FontStyle.Regular, GraphicsUnit.Point);

                //O string format serve para formatar strings
                //quanto a seu alinhamento e o proprio alinhamento da linha
                StringFormat sf = new StringFormat();

                sf.Alignment = StringAlignment.Center;

                SolidBrush drawBrush = new SolidBrush(System.Drawing.Color.Black);

                //Captura todo o retângulo dos limites da página
                System.Drawing.RectangleF rect = e.PageBounds;

                //Aumenta a coordenada de localização Y
                rect.Y += 50;

                //Desenhar os textos centralizado
                e.Graphics.DrawString(r.id + " - " + r.descricao + "(" + r.cliente.nome + ")", font1, drawBrush, rect, sf);

                rect.Y += 200;

                if (r.numSerie == "")
                    e.Graphics.DrawString("Nº de Serie: Não foi inserido.", font2, drawBrush, new RectangleF(rect.X, rect.Y, rect.Width, rect.Height), sf);
                else
                    e.Graphics.DrawString("Nº de Serie: " + r.numSerie, font2, drawBrush, new RectangleF(rect.X, rect.Y, rect.Width, rect.Height), sf);

                rect.Y += 200;

                if (r.cliente.contacto == "")
                    e.Graphics.DrawString("Contacto do Cliente: Não foi inserido.", font2, drawBrush, new RectangleF(rect.X, rect.Y, rect.Width, rect.Height), sf);
                else
                    e.Graphics.DrawString("Contacto do Cliente: " + r.cliente.contacto, font2, drawBrush, new RectangleF(rect.X, rect.Y, rect.Width, rect.Height), sf);

                rect.Y += 200;

                if (r.avaria == "")
                    e.Graphics.DrawString("Avaria: Não foi inserida.", font2, drawBrush, new RectangleF(rect.X, rect.Y, rect.Width, rect.Height), sf);
                else
                    e.Graphics.DrawString("Avaria:\n".ToString() + r.avaria, font2, drawBrush, new RectangleF(rect.X, rect.Y, rect.Width, rect.Height), sf);

                rect.Y += 448;
                e.Graphics.DrawString("Data de Entrada: " + r.dtEntrega.ToString().Substring(0, 10), font2, drawBrush, new RectangleF(rect.X, rect.Y, rect.Width, rect.Height), sf);

            }      
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
                MessageBox.Show("Reparo impresso com sucesso!");
            }
        }
    }   
}
