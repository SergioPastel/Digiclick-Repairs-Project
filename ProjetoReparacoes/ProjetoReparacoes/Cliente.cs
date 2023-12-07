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

        //metodos
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
    }
}
