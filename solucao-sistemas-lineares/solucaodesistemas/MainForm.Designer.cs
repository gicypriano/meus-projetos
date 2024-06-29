namespace solucaodesistemas
{
    partial class MainForm
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
            this.ResolverButton = new System.Windows.Forms.Button();
            this.ResultadoLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResolverButton
            // 
            this.ResolverButton.BackColor = System.Drawing.Color.DarkViolet;
            this.ResolverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResolverButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolverButton.ForeColor = System.Drawing.Color.White;
            this.ResolverButton.Location = new System.Drawing.Point(95, 153);
            this.ResolverButton.Name = "ResolverButton";
            this.ResolverButton.Size = new System.Drawing.Size(75, 23);
            this.ResolverButton.TabIndex = 0;
            this.ResolverButton.Text = "RESOLVER";
            this.ResolverButton.UseVisualStyleBackColor = false;
            this.ResolverButton.Click += new System.EventHandler(this.ResolverButton_Click);
            // 
            // ResultadoLabel
            // 
            this.ResultadoLabel.AutoSize = true;
            this.ResultadoLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoLabel.Location = new System.Drawing.Point(29, 192);
            this.ResultadoLabel.Name = "ResultadoLabel";
            this.ResultadoLabel.Size = new System.Drawing.Size(183, 13);
            this.ResultadoLabel.TabIndex = 1;
            this.ResultadoLabel.Text = "ATENÇÃO: digite apenas números";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(31, 21);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(35, 13);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(270, 259);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ResultadoLabel);
            this.Controls.Add(this.ResolverButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResolverButton;
        private System.Windows.Forms.Label ResultadoLabel;
        private System.Windows.Forms.Label TitleLabel;
    }
}

