using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoReparacoes
{
    public partial class FormDb : Form
    {
        public FormDb()
        {
            InitializeComponent();
            MessageBox.Show("Insira as informações do servidor.");
        }

        private void FormDb_Load(object sender, EventArgs e)
        {
            txtIp.Text = "localhost";            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string endereco = txtIp.Text;
            string user = txtUser.Text;
            string pass = txtSenha.Text;

            Form1 frm = new Form1(endereco, user, pass);
            frm.Show();
            txtIp.Text = "";       
        }
    }
}
