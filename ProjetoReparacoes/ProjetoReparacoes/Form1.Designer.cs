namespace ProjetoReparacoes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNovoItem = new System.Windows.Forms.Button();
            this.btnAtivos = new System.Windows.Forms.Button();
            this.btnConcluidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.Location = new System.Drawing.Point(100, 27);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(233, 77);
            this.btnNovoItem.TabIndex = 0;
            this.btnNovoItem.Text = "Inserir nova Reparação";
            this.btnNovoItem.UseVisualStyleBackColor = true;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
            // 
            // btnAtivos
            // 
            this.btnAtivos.Location = new System.Drawing.Point(100, 139);
            this.btnAtivos.Name = "btnAtivos";
            this.btnAtivos.Size = new System.Drawing.Size(233, 77);
            this.btnAtivos.TabIndex = 1;
            this.btnAtivos.Text = "Reparações Ativas";
            this.btnAtivos.UseVisualStyleBackColor = true;
            this.btnAtivos.Click += new System.EventHandler(this.btnAtivos_Click);
            // 
            // btnConcluidos
            // 
            this.btnConcluidos.Location = new System.Drawing.Point(100, 250);
            this.btnConcluidos.Name = "btnConcluidos";
            this.btnConcluidos.Size = new System.Drawing.Size(233, 77);
            this.btnConcluidos.TabIndex = 2;
            this.btnConcluidos.Text = "Reparações Concluidas";
            this.btnConcluidos.UseVisualStyleBackColor = true;
            this.btnConcluidos.Click += new System.EventHandler(this.btnConcluidos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 356);
            this.Controls.Add(this.btnConcluidos);
            this.Controls.Add(this.btnAtivos);
            this.Controls.Add(this.btnNovoItem);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoItem;
        private System.Windows.Forms.Button btnAtivos;
        private System.Windows.Forms.Button btnConcluidos;
    }
}

