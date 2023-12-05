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
            this.btnCriarTabelas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCriarTabelas
            // 
            this.btnCriarTabelas.Location = new System.Drawing.Point(36, 68);
            this.btnCriarTabelas.Name = "btnCriarTabelas";
            this.btnCriarTabelas.Size = new System.Drawing.Size(75, 23);
            this.btnCriarTabelas.TabIndex = 0;
            this.btnCriarTabelas.Text = "Criar tabelas";
            this.btnCriarTabelas.UseVisualStyleBackColor = true;
//            this.btnCriarTabelas.Click += new System.EventHandler(this.btnCriarTabelas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCriarTabelas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCriarTabelas;
    }
}

