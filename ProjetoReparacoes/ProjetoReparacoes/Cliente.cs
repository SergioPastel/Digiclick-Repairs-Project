using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoReparacoes
{
    internal class Cliente
    {
        // Campos
        public int id;
        public string nome;
        public string contacto;

        // Metodos
        // Recebe uma lista com todos os clientes
        public List<Cliente> getClients(SqlConnection conn)
        {
            List<Cliente> Clientes = new List<Cliente>();

            string qry = "SELECT * FROM Clientes;";
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataReader leitor = cmd.ExecuteReader();

            while (leitor.Read())
            {
                Cliente c = new Cliente();
                c.id = (int)leitor["id"];
                c.nome = (string)leitor["nome"];
                c.contacto = (string)leitor["contacto"];
                Clientes.Add(c);
            }           
            return Clientes;
        }

        // Recebe o cliente com um id especifico
        public Cliente getClientWhere(SqlConnection conn, int id)
        {
            Cliente c = new Cliente();

            string qry = "SELECT * FROM Clientes WHERE id = " + id + ";";
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataReader leitor = cmd.ExecuteReader();

            while (leitor.Read())
            {
                c.id = (int)leitor["id"];
                c.nome = (string)leitor["nome"];
                c.contacto = (string)leitor["contacto"];
            }           
            return c;
        }

        // Recebe o id de um cliente com um nome especifico(Clientes não podem ter o mesmo nome)
        public int getClientByName (SqlConnection conn, string name) 
        {
            string qry = "SELECT id FROM Clientes WHERE nome = '" + name + "';";
            SqlCommand cmd = new SqlCommand(qry, conn);
            int id = (int)cmd.ExecuteScalar();

            return id;
        }
    }
}
