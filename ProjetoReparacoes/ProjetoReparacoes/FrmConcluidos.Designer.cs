namespace ProjetoReparacoes
{
    partial class FrmConcluidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConcluidos));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblReparador = new System.Windows.Forms.Label();
            this.txtReparador = new System.Windows.Forms.TextBox();
            this.txtDtEntrada = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblAvaria = new System.Windows.Forms.Label();
            this.txtAvaria = new System.Windows.Forms.TextBox();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblNumSerie = new System.Windows.Forms.Label();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnReabrir = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lstReparos = new System.Windows.Forms.ListBox();
            this.txtDtReparo = new System.Windows.Forms.TextBox();
            this.lblDtReparo = new System.Windows.Forms.Label();
            this.txtDtEntrega = new System.Windows.Forms.TextBox();
            this.lblDtEntrega = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 659);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(290, 73);
            this.btnEliminar.TabIndex = 53;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblReparador
            // 
            this.lblReparador.AutoSize = true;
            this.lblReparador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReparador.Location = new System.Drawing.Point(315, 535);
            this.lblReparador.Name = "lblReparador";
            this.lblReparador.Size = new System.Drawing.Size(114, 24);
            this.lblReparador.TabIndex = 52;
            this.lblReparador.Text = "Reparador:";
            // 
            // txtReparador
            // 
            this.txtReparador.Location = new System.Drawing.Point(316, 560);
            this.txtReparador.Name = "txtReparador";
            this.txtReparador.ReadOnly = true;
            this.txtReparador.Size = new System.Drawing.Size(300, 20);
            this.txtReparador.TabIndex = 48;
            // 
            // txtDtEntrada
            // 
            this.txtDtEntrada.Location = new System.Drawing.Point(319, 350);
            this.txtDtEntrada.Name = "txtDtEntrada";
            this.txtDtEntrada.ReadOnly = true;
            this.txtDtEntrada.Size = new System.Drawing.Size(300, 20);
            this.txtDtEntrada.TabIndex = 45;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(315, 10);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 24);
            this.lblId.TabIndex = 43;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(350, 10);
            this.txtId.Margin = new System.Windows.Forms.Padding(0);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(50, 25);
            this.txtId.TabIndex = 42;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAvaria
            // 
            this.lblAvaria.AutoSize = true;
            this.lblAvaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvaria.Location = new System.Drawing.Point(315, 605);
            this.lblAvaria.Name = "lblAvaria";
            this.lblAvaria.Size = new System.Drawing.Size(74, 24);
            this.lblAvaria.TabIndex = 41;
            this.lblAvaria.Text = "Avaria:";
            // 
            // txtAvaria
            // 
            this.txtAvaria.Location = new System.Drawing.Point(316, 632);
            this.txtAvaria.Multiline = true;
            this.txtAvaria.Name = "txtAvaria";
            this.txtAvaria.ReadOnly = true;
            this.txtAvaria.Size = new System.Drawing.Size(300, 100);
            this.txtAvaria.TabIndex = 40;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrada.Location = new System.Drawing.Point(315, 325);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(165, 24);
            this.lblDataEntrada.TabIndex = 39;
            this.lblDataEntrada.Text = "Data de Entrada:";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto.Location = new System.Drawing.Point(315, 255);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(98, 24);
            this.lblContacto.TabIndex = 38;
            this.lblContacto.Text = "Contacto:";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(319, 280);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.ReadOnly = true;
            this.txtContacto.Size = new System.Drawing.Size(300, 20);
            this.txtContacto.TabIndex = 37;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(315, 185);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(81, 24);
            this.lblCliente.TabIndex = 36;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(319, 210);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(300, 20);
            this.txtCliente.TabIndex = 35;
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSerie.Location = new System.Drawing.Point(315, 115);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(124, 24);
            this.lblNumSerie.TabIndex = 34;
            this.lblNumSerie.Text = "Nº de Serie:";
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Location = new System.Drawing.Point(319, 140);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.ReadOnly = true;
            this.txtNumSerie.Size = new System.Drawing.Size(300, 20);
            this.txtNumSerie.TabIndex = 33;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(315, 45);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(109, 24);
            this.lblDescricao.TabIndex = 32;
            this.lblDescricao.Text = "Descrição:";
            // 
            // btnReabrir
            // 
            this.btnReabrir.Location = new System.Drawing.Point(12, 560);
            this.btnReabrir.Name = "btnReabrir";
            this.btnReabrir.Size = new System.Drawing.Size(290, 73);
            this.btnReabrir.TabIndex = 31;
            this.btnReabrir.Text = "Reabrir Reparação";
            this.btnReabrir.UseVisualStyleBackColor = true;
            this.btnReabrir.Click += new System.EventHandler(this.btnReabrir_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(319, 70);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(300, 20);
            this.txtDescricao.TabIndex = 30;
            // 
            // lstReparos
            // 
            this.lstReparos.FormattingEnabled = true;
            this.lstReparos.Location = new System.Drawing.Point(12, 12);
            this.lstReparos.Name = "lstReparos";
            this.lstReparos.Size = new System.Drawing.Size(290, 524);
            this.lstReparos.TabIndex = 29;
            this.lstReparos.SelectedIndexChanged += new System.EventHandler(this.lstReparos_SelectedIndexChanged);
            // 
            // txtDtReparo
            // 
            this.txtDtReparo.Location = new System.Drawing.Point(319, 420);
            this.txtDtReparo.Name = "txtDtReparo";
            this.txtDtReparo.ReadOnly = true;
            this.txtDtReparo.Size = new System.Drawing.Size(300, 20);
            this.txtDtReparo.TabIndex = 55;
            // 
            // lblDtReparo
            // 
            this.lblDtReparo.AutoSize = true;
            this.lblDtReparo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtReparo.Location = new System.Drawing.Point(315, 395);
            this.lblDtReparo.Name = "lblDtReparo";
            this.lblDtReparo.Size = new System.Drawing.Size(161, 24);
            this.lblDtReparo.TabIndex = 54;
            this.lblDtReparo.Text = "Data de Reparo:";
            // 
            // txtDtEntrega
            // 
            this.txtDtEntrega.Location = new System.Drawing.Point(319, 490);
            this.txtDtEntrega.Name = "txtDtEntrega";
            this.txtDtEntrega.ReadOnly = true;
            this.txtDtEntrega.Size = new System.Drawing.Size(300, 20);
            this.txtDtEntrega.TabIndex = 57;
            // 
            // lblDtEntrega
            // 
            this.lblDtEntrega.AutoSize = true;
            this.lblDtEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtEntrega.Location = new System.Drawing.Point(315, 465);
            this.lblDtEntrega.Name = "lblDtEntrega";
            this.lblDtEntrega.Size = new System.Drawing.Size(166, 24);
            this.lblDtEntrega.TabIndex = 56;
            this.lblDtEntrega.Text = "Data de Entrega:";
            // 
            // FrmConcluidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 747);
            this.Controls.Add(this.txtDtEntrega);
            this.Controls.Add(this.lblDtEntrega);
            this.Controls.Add(this.txtDtReparo);
            this.Controls.Add(this.lblDtReparo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblReparador);
            this.Controls.Add(this.txtReparador);
            this.Controls.Add(this.txtDtEntrada);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblAvaria);
            this.Controls.Add(this.txtAvaria);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblNumSerie);
            this.Controls.Add(this.txtNumSerie);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.btnReabrir);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lstReparos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConcluidos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reparações Concluidas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblReparador;
        private System.Windows.Forms.TextBox txtReparador;
        private System.Windows.Forms.TextBox txtDtEntrada;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblAvaria;
        private System.Windows.Forms.TextBox txtAvaria;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblNumSerie;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnReabrir;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ListBox lstReparos;
        private System.Windows.Forms.TextBox txtDtReparo;
        private System.Windows.Forms.Label lblDtReparo;
        private System.Windows.Forms.TextBox txtDtEntrega;
        private System.Windows.Forms.Label lblDtEntrega;
    }
}