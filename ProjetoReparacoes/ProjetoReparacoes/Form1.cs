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
    public partial class Form1 : Form
    {       
        public Form1()
        {
            InitializeComponent();            
        }
        
        // Codigo dos botões dos formularios
        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmInserir();
            frm.ShowDialog();
        }

        private void btnAtivos_Click(object sender, EventArgs e)
        {
            Form frm = new FrmAtivos();
            frm.ShowDialog();
        }

        private void btnConcluidos_Click(object sender, EventArgs e)
        {
            Form frm = new FrmConcluidos();
            frm.ShowDialog();
        }
    }
}
