using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoReparacoes
{
    internal class ReparoConcluido
    {
        // Campos
        public int id;
        public string descricao;
        public string numSerie;
        public string avaria;
        public Cliente cliente;
        public string contacto;
        public DateTime dtEntrega;
        public DateTime dtReparo;
        public DateTime dtEntregaCliente;
        public Boolean terceirizado;
        public string reparador;

        // Metodos
        // Recebe uma lista com todos os reparos concluidos
        public List<ReparoConcluido> getReparos(SqlConnection conn)
        {
            List<ReparoConcluido> Reparos = new List<ReparoConcluido>();

            string qry = "SELECT * FROM ReparosConcluidos;";
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataReader leitor = cmd.ExecuteReader();

            while (leitor.Read())
            {
                Cliente c = new Cliente();
                ReparoConcluido reparo = new ReparoConcluido();
                reparo.id = (int)leitor["id"];
                reparo.descricao = (string)leitor["descricao"];
                reparo.numSerie = (string)leitor["numSerie"];
                reparo.avaria = (string)leitor["avaria"];
                reparo.cliente = c.getClientWhere(conn, (int)leitor["idCliente"]);
                reparo.contacto = (string)leitor["contacto"];
                reparo.dtEntrega = (DateTime)leitor["dtEntrada"];
                reparo.dtReparo = (DateTime)leitor["dtReparacao"];
                reparo.dtEntregaCliente = (DateTime)leitor["dtEntrega"];
                reparo.terceirizado = (Boolean)leitor["terceirizado"];
                reparo.reparador = (string)leitor["reparador"];
                Reparos.Add(reparo);
            }

            return Reparos;
        }

        // Insere o reparo concluido na tabela reparos ativos
        public void reabrirReparo(SqlConnection conn, ReparoConcluido r)
        {
            string qry = "SET IDENTITY_INSERT ReparosAtivos ON; INSERT into ReparosAtivos(id,descricao,numSerie,avaria,idCLiente," +
                         "contacto,dtEntrada) VALUES(" +
                         r.id + ",'" +
                         r.descricao + "','" +
                         r.numSerie + "','" +
                         r.avaria + "'," +
                         r.cliente.id + ",'" +
                         r.cliente.contacto + "','" +
                         r.dtEntrega + "');" + "SET IDENTITY_INSERT ReparosAtivos OFF;";
            SqlCommand cmd = new SqlCommand(qry, conn);
            cmd.ExecuteNonQuery();

            qry = "DELETE from ReparosConcluidos WHERE id=" + r.id + ";";
            cmd = new SqlCommand(qry, conn);
            cmd.ExecuteNonQuery();
        }

        // Recebe um reparo de id especifico
        public ReparoConcluido getReparosWhere(SqlConnection conn, int id)
        {
            ReparoConcluido r = new ReparoConcluido();
            Cliente c = new Cliente();

            string qry = "SELECT * FROM ReparosConcluidos WHERE id=" + id + ";";
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
                r.dtReparo = (DateTime)leitor["dtReparacao"];
                r.dtEntregaCliente = (DateTime)leitor["dtEntrega"];
                r.terceirizado = (Boolean)leitor["terceirizado"];
                r.reparador = (string)leitor["reparador"];
            }

            return r;
        }

        public void deletarReparo(SqlConnection conn, ReparoConcluido r)
        {
            if (r.cliente == null)
            {
                MessageBox.Show("Selecione um reparo valido");
            }
            else
            {
                string qry = "DELETE FROM ReparosConcluidos WHERE id=" + r.id;
                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
