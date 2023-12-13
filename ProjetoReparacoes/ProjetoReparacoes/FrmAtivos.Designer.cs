namespace ProjetoReparacoes
{
    partial class FrmAtivos
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
            this.lstReparos = new System.Windows.Forms.ListBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnConcluirEditar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblNumSerie = new System.Windows.Forms.Label();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblAvaria = new System.Windows.Forms.Label();
            this.txtAvaria = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.chbFinalizado = new System.Windows.Forms.CheckBox();
            this.txtDtEntrada = new System.Windows.Forms.TextBox();
            this.dtpReparo = new System.Windows.Forms.DateTimePicker();
            this.chbTerceirizado = new System.Windows.Forms.CheckBox();
            this.txtReparador = new System.Windows.Forms.TextBox();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblDtReparo = new System.Windows.Forms.Label();
            this.lblDtEntrega = new System.Windows.Forms.Label();
            this.lblReparador = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstReparos
            // 
            this.lstReparos.FormattingEnabled = true;
            this.lstReparos.Location = new System.Drawing.Point(12, 12);
            this.lstReparos.Name = "lstReparos";
            this.lstReparos.Size = new System.Drawing.Size(289, 511);
            this.lstReparos.TabIndex = 0;
            this.lstReparos.SelectedIndexChanged += new System.EventHandler(this.lstReparos_SelectedIndexChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(319, 70);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(301, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // btnConcluirEditar
            // 
            this.btnConcluirEditar.Location = new System.Drawing.Point(12, 529);
            this.btnConcluirEditar.Name = "btnConcluirEditar";
            this.btnConcluirEditar.Size = new System.Drawing.Size(289, 73);
            this.btnConcluirEditar.TabIndex = 3;
            this.btnConcluirEditar.Text = "Editar Reparação";
            this.btnConcluirEditar.UseVisualStyleBackColor = true;
            this.btnConcluirEditar.Click += new System.EventHandler(this.btnConcluirEditar_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(315, 45);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(109, 24);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSerie.Location = new System.Drawing.Point(315, 115);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(124, 24);
            this.lblNumSerie.TabIndex = 6;
            this.lblNumSerie.Text = "Nº de Serie:";
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Location = new System.Drawing.Point(319, 140);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(301, 20);
            this.txtNumSerie.TabIndex = 5;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(315, 185);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(81, 24);
            this.lblCliente.TabIndex = 8;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(319, 210);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(301, 20);
            this.txtCliente.TabIndex = 7;
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto.Location = new System.Drawing.Point(315, 255);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(98, 24);
            this.lblContacto.TabIndex = 10;
            this.lblContacto.Text = "Contacto:";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(319, 280);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.ReadOnly = true;
            this.txtContacto.Size = new System.Drawing.Size(301, 20);
            this.txtContacto.TabIndex = 9;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrada.Location = new System.Drawing.Point(315, 325);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(165, 24);
            this.lblDataEntrada.TabIndex = 12;
            this.lblDataEntrada.Text = "Data de Entrada:";
            // 
            // lblAvaria
            // 
            this.lblAvaria.AutoSize = true;
            this.lblAvaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvaria.Location = new System.Drawing.Point(315, 395);
            this.lblAvaria.Name = "lblAvaria";
            this.lblAvaria.Size = new System.Drawing.Size(74, 24);
            this.lblAvaria.TabIndex = 14;
            this.lblAvaria.Text = "Avaria:";
            // 
            // txtAvaria
            // 
            this.txtAvaria.Location = new System.Drawing.Point(319, 420);
            this.txtAvaria.Multiline = true;
            this.txtAvaria.Name = "txtAvaria";
            this.txtAvaria.Size = new System.Drawing.Size(301, 103);
            this.txtAvaria.TabIndex = 13;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(315, 10);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 24);
            this.lblId.TabIndex = 16;
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
            this.txtId.Size = new System.Drawing.Size(25, 25);
            this.txtId.TabIndex = 15;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chbFinalizado
            // 
            this.chbFinalizado.AutoSize = true;
            this.chbFinalizado.Location = new System.Drawing.Point(319, 529);
            this.chbFinalizado.Name = "chbFinalizado";
            this.chbFinalizado.Size = new System.Drawing.Size(79, 17);
            this.chbFinalizado.TabIndex = 18;
            this.chbFinalizado.Text = "Finalizado?";
            this.chbFinalizado.UseVisualStyleBackColor = true;
            this.chbFinalizado.CheckStateChanged += new System.EventHandler(this.chbFinalizado_CheckStateChanged);
            // 
            // txtDtEntrada
            // 
            this.txtDtEntrada.Location = new System.Drawing.Point(319, 350);
            this.txtDtEntrada.Name = "txtDtEntrada";
            this.txtDtEntrada.ReadOnly = true;
            this.txtDtEntrada.Size = new System.Drawing.Size(301, 20);
            this.txtDtEntrada.TabIndex = 19;
            // 
            // dtpReparo
            // 
            this.dtpReparo.Location = new System.Drawing.Point(320, 582);
            this.dtpReparo.Name = "dtpReparo";
            this.dtpReparo.Size = new System.Drawing.Size(144, 20);
            this.dtpReparo.TabIndex = 20;
            // 
            // chbTerceirizado
            // 
            this.chbTerceirizado.AutoSize = true;
            this.chbTerceirizado.Location = new System.Drawing.Point(319, 624);
            this.chbTerceirizado.Name = "chbTerceirizado";
            this.chbTerceirizado.Size = new System.Drawing.Size(91, 17);
            this.chbTerceirizado.TabIndex = 22;
            this.chbTerceirizado.Text = "Por terceiros?";
            this.chbTerceirizado.UseVisualStyleBackColor = true;
            this.chbTerceirizado.CheckStateChanged += new System.EventHandler(this.chbTerceirizado_CheckStateChanged);
            // 
            // txtReparador
            // 
            this.txtReparador.Location = new System.Drawing.Point(319, 676);
            this.txtReparador.Name = "txtReparador";
            this.txtReparador.Size = new System.Drawing.Size(301, 20);
            this.txtReparador.TabIndex = 23;
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.Location = new System.Drawing.Point(476, 582);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(144, 20);
            this.dtpEntrega.TabIndex = 24;
            // 
            // lblDtReparo
            // 
            this.lblDtReparo.AutoSize = true;
            this.lblDtReparo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtReparo.Location = new System.Drawing.Point(319, 559);
            this.lblDtReparo.Name = "lblDtReparo";
            this.lblDtReparo.Size = new System.Drawing.Size(148, 16);
            this.lblDtReparo.TabIndex = 25;
            this.lblDtReparo.Text = "Data de Reparação:";
            // 
            // lblDtEntrega
            // 
            this.lblDtEntrega.AutoSize = true;
            this.lblDtEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtEntrega.Location = new System.Drawing.Point(473, 559);
            this.lblDtEntrega.Name = "lblDtEntrega";
            this.lblDtEntrega.Size = new System.Drawing.Size(124, 16);
            this.lblDtEntrega.TabIndex = 26;
            this.lblDtEntrega.Text = "Data de Entrega:";
            // 
            // lblReparador
            // 
            this.lblReparador.AutoSize = true;
            this.lblReparador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReparador.Location = new System.Drawing.Point(318, 651);
            this.lblReparador.Name = "lblReparador";
            this.lblReparador.Size = new System.Drawing.Size(114, 24);
            this.lblReparador.TabIndex = 27;
            this.lblReparador.Text = "Reparador:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 624);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(289, 73);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // FrmAtivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 709);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblReparador);
            this.Controls.Add(this.lblDtEntrega);
            this.Controls.Add(this.lblDtReparo);
            this.Controls.Add(this.dtpEntrega);
            this.Controls.Add(this.txtReparador);
            this.Controls.Add(this.chbTerceirizado);
            this.Controls.Add(this.dtpReparo);
            this.Controls.Add(this.txtDtEntrada);
            this.Controls.Add(this.chbFinalizado);
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
            this.Controls.Add(this.btnConcluirEditar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lstReparos);
            this.Name = "FrmAtivos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reparações Abertas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstReparos;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnConcluirEditar;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblNumSerie;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblAvaria;
        private System.Windows.Forms.TextBox txtAvaria;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.CheckBox chbFinalizado;
        private System.Windows.Forms.TextBox txtDtEntrada;
        private System.Windows.Forms.DateTimePicker dtpReparo;
        private System.Windows.Forms.CheckBox chbTerceirizado;
        private System.Windows.Forms.TextBox txtReparador;
        private System.Windows.Forms.DateTimePicker dtpEntrega;
        private System.Windows.Forms.Label lblDtReparo;
        private System.Windows.Forms.Label lblDtEntrega;
        private System.Windows.Forms.Label lblReparador;
        private System.Windows.Forms.Button btnEliminar;
    }
}