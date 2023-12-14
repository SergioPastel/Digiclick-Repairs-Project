using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoReparacoes
{
    internal class ReparoAtivo
    {
        // Campos
        public int id;
        public string descricao;
        public string numSerie;
        public string avaria;
        public Cliente cliente;
        public string contacto;
        public DateTime dtEntrega;

        // Metodos
        // Recebe uma lista com todos os reparos ativos
        public List<ReparoAtivo> getReparos(SqlConnection conn)
        {
            List<ReparoAtivo> Reparos = new List<ReparoAtivo>();

            string qry = "SELECT * FROM ReparosAtivos;";
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataReader leitor = cmd.ExecuteReader();

            while (leitor.Read())
            {
                Cliente c = new Cliente();
                ReparoAtivo reparo = new ReparoAtivo();
                reparo.id = (int)leitor["id"];
                reparo.descricao = (string)leitor["descricao"];
                reparo.numSerie = (string)leitor["numSerie"];
                reparo.avaria = (string)leitor["avaria"];
                reparo.cliente = c.getClientWhere(conn, (int)leitor["idCliente"]);
                reparo.contacto = (string)leitor["contacto"];
                reparo.dtEntrega = (DateTime)leitor["dtEntrada"];
                Reparos.Add(reparo);
            }

            return Reparos;
        }

        // Recebe um reparo de id especifico
        public ReparoAtivo getReparosWhere(SqlConnection conn, int id)
        {
            ReparoAtivo r = new ReparoAtivo();
            Cliente c = new Cliente();

            string qry = "SELECT * FROM ReparosAtivos WHERE id=" + id + ";";
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataReader leitor = cmd.ExecuteReader();

            while (leitor.Read())
            {
                r.id = (int)leitor["id"];
                r.descricao = (string)leitor["descricao"];
                r.numSerie = (string)leitor["numSerie"];
                r.avaria = (string)leitor["avaria"];
                r.cliente = c.getClientWhere(conn, (int)leitor["idCliente"]);
                r.contacto = (string)leitor["contacto"];
                r.dtEntrega = (DateTime)leitor["dtEntrada"];
            }

            return r;
        }

        // Atualiza o reparo de id especifico
        public void updateReparos(SqlConnection conn, int id, string desc, string num, string ava)
        {
            string qry = "UPDATE ReparosAtivos SET descricao ='" + desc + "', numSerie = '" + num + "', avaria = '" + ava + 
                         "' WHERE id =" + id + ";";
            SqlCommand cmd = new SqlCommand(qry, conn);
            cmd.ExecuteNonQuery();
        }

        // Remove o reparo da tabela ReparosAtivos, e o adiciona a tabela ReparosConcluidos
        public void concluirReparo(SqlConnection conn, ReparoAtivo r, DateTime dt, DateTime dtReparo, DateTime dtEntregaCliente, int terceirizado, string reparador)
        {
            string qry = "INSERT into ReparosConcluidos VALUES(" +
                      r.id + ",'" +
                      r.descricao + "','" +
                      r.numSerie + "','" +
                      r.avaria + "'," +
                      r.cliente.id + ",'" +
                      r.cliente.contacto + "','" +
                      dt.ToString(CultureInfo.InvariantCulture).Substring(0, 10) + "','" +
                      dtReparo.ToString(CultureInfo.InvariantCulture).Substring(0, 10) + "','" +
                      dtEntregaCliente.ToString(CultureInfo.InvariantCulture).Substring(0, 10) + "'," +
                      terceirizado + ",'" +
                      reparador + "');";
            SqlCommand cmd = new SqlCommand(qry, conn);
            cmd.ExecuteNonQuery();

            qry = "DELETE from ReparosAtivos WHERE id=" + r.id + ";";
            cmd = new SqlCommand(qry, conn);
            cmd.ExecuteNonQuery();
        }

        // Elimina o reparo da tabela reparos ativos
        public void deletarReparo(SqlConnection conn, ReparoAtivo r)
        {
            if (r.cliente == null)
            {
                MessageBox.Show("Selecione um reparo valido");
            }
            else
            {
                string qry = "DELETE FROM ReparosAtivos WHERE id=" + r.id;
                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
