namespace ProjetoReparacoes
{
    partial class frmInserir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserir));
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblDenominacao = new System.Windows.Forms.Label();
            this.txtDenominacao = new System.Windows.Forms.TextBox();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.lblNumSerie = new System.Windows.Forms.Label();
            this.txtAvaria = new System.Windows.Forms.TextBox();
            this.lblAvaria = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdUltimo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(12, 485);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(351, 85);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.Text = "Adicionar reparação";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblDenominacao
            // 
            this.lblDenominacao.AutoSize = true;
            this.lblDenominacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenominacao.Location = new System.Drawing.Point(12, 10);
            this.lblDenominacao.Name = "lblDenominacao";
            this.lblDenominacao.Size = new System.Drawing.Size(145, 24);
            this.lblDenominacao.TabIndex = 1;
            this.lblDenominacao.Text = "Denominação:";
            // 
            // txtDenominacao
            // 
            this.txtDenominacao.Location = new System.Drawing.Point(12, 35);
            this.txtDenominacao.MaxLength = 30;
            this.txtDenominacao.Name = "txtDenominacao";
            this.txtDenominacao.Size = new System.Drawing.Size(351, 20);
            this.txtDenominacao.TabIndex = 1;
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Location = new System.Drawing.Point(12, 95);
            this.txtNumSerie.MaxLength = 30;
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(351, 20);
            this.txtNumSerie.TabIndex = 2;
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSerie.Location = new System.Drawing.Point(12, 70);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(124, 24);
            this.lblNumSerie.TabIndex = 3;
            this.lblNumSerie.Text = "Nº de Serie:";
            // 
            // txtAvaria
            // 
            this.txtAvaria.Location = new System.Drawing.Point(12, 335);
            this.txtAvaria.MaxLength = 500;
            this.txtAvaria.Multiline = true;
            this.txtAvaria.Name = "txtAvaria";
            this.txtAvaria.Size = new System.Drawing.Size(351, 135);
            this.txtAvaria.TabIndex = 6;
            // 
            // lblAvaria
            // 
            this.lblAvaria.AutoSize = true;
            this.lblAvaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvaria.Location = new System.Drawing.Point(12, 310);
            this.lblAvaria.Name = "lblAvaria";
            this.lblAvaria.Size = new System.Drawing.Size(74, 24);
            this.lblAvaria.TabIndex = 5;
            this.lblAvaria.Text = "Avaria:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(12, 190);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(81, 24);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrada.Location = new System.Drawing.Point(12, 130);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(163, 24);
            this.lblDataEntrada.TabIndex = 9;
            this.lblDataEntrada.Text = "Data de entrada:";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Location = new System.Drawing.Point(12, 155);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(351, 20);
            this.dtpEntrada.TabIndex = 3;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(12, 275);
            this.txtContacto.MaxLength = 30;
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.ReadOnly = true;
            this.txtContacto.Size = new System.Drawing.Size(351, 20);
            this.txtContacto.TabIndex = 5;
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto.Location = new System.Drawing.Point(12, 248);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(98, 24);
            this.lblContacto.TabIndex = 18;
            this.lblContacto.Text = "Contacto:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(12, 214);
            this.cmbCliente.MaxLength = 30;
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(351, 21);
            this.cmbCliente.TabIndex = 4;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(238, 8);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 24);
            this.lblId.TabIndex = 22;
            this.lblId.Text = "ID:";
            // 
            // lblIdUltimo
            // 
            this.lblIdUltimo.AutoSize = true;
            this.lblIdUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUltimo.Location = new System.Drawing.Point(275, 8);
            this.lblIdUltimo.Name = "lblIdUltimo";
            this.lblIdUltimo.Size = new System.Drawing.Size(0, 24);
            this.lblIdUltimo.TabIndex = 23;
            this.lblIdUltimo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 577);
            this.Controls.Add(this.lblIdUltimo);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.dtpEntrada);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtAvaria);
            this.Controls.Add(this.lblAvaria);
            this.Controls.Add(this.txtNumSerie);
            this.Controls.Add(this.lblNumSerie);
            this.Controls.Add(this.txtDenominacao);
            this.Controls.Add(this.lblDenominacao);
            this.Controls.Add(this.btnInserir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInserir";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir nova Reparação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblDenominacao;
        private System.Windows.Forms.TextBox txtDenominacao;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.Label lblNumSerie;
        private System.Windows.Forms.TextBox txtAvaria;
        private System.Windows.Forms.Label lblAvaria;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdUltimo;
    }
}