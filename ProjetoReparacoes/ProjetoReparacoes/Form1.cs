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
    // This is the public version.
    public partial class Form1 : Form
    {        
        SqlConnection conn = new SqlConnection();
        string sv;
        string us;
        string pa;
        bool loginSuccesful;
        public Form1()
        {
            InitializeComponent();
            loginSuccesful = false;
        }

        public Form1(string server, string user, string pass)
        {
            InitializeComponent();
            sv = server;
            us = user; 
            pa = pass;

            string str = "Server=" + server + "; User= " + user + ";Password =" + pass + ";";
            conn.ConnectionString = str;
            loginSuccesful = true;
        }
        
        // Codigo dos botões dos formularios
        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmInserir(sv, us, pa, loginSuccesful);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            if (loginSuccesful == false)
            {
                this.Close();
            }
            else { 
                string CriarDb = "CREATE DATABASE IF NOT EXISTS ReparacoesDB;";
                SqlCommand cmd = new SqlCommand(CriarDb, conn);
                string usarDb = "USE ReparacoesDB; CREATE TABLE Clientes( id int NOT NULL IDENTITY (1,1), nome VARCHAR(30) NOT NULL, contacto VARCHAR(30) NOT NULL, PRIMARY KEY(id));CREATE TABLE ReparosAtivos( id INT NOT NULL IDENTITY (1,1), descricao VARCHAR(30), numSerie VARCHAR(30), avaria VARCHAR(500), idCliente INT NOT NULL FOREIGN KEY REFERENCES Clientes(id),\tcontacto VARCHAR(30), dtEntrada DATE, reparador varchar(50), PRIMARY KEY(id));create table ReparosConcluidos (\tid INT NOT NULL,\tdescricao VARCHAR(30),\tnumSerie VARCHAR(30),\t\tavaria VARCHAR(500),\tidCliente INT NOT NULL,\tcontacto VARCHAR(30),\tdtEntrada DATE,\tdtReparacao DATE,\tdtEntrega DATE,\tterceirizado BIT NOT NULL,\treparador VARCHAR(30),\tPRIMARY KEY(id));";                        
                try
                {
                    conn.Open();
                }
                catch (SqlException ex)
                {
                    DialogResult result = MessageBox.Show("Informações de login incorretas. Deseja utilizar o programa sem servidor?\n(Mensagem de Erro: " + ex.Message + ")", "Contacte o administrador de redes.", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Form1 frm = new Form1();
                        frm.Show();
                    }
                    else
                        this.Close();
                }
                if ((bool)Properties.Settings.Default["FirstRun"] == true)
                {
                    //First application run
                    //Update setting
                    Properties.Settings.Default["FirstRun"] = false;
                    //Save setting
                    Properties.Settings.Default.Save();
                    //Create new instance of Dialog you want to show                
                    cmd = new SqlCommand(usarDb, conn);
                    cmd.ExecuteNonQuery();
                }
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
