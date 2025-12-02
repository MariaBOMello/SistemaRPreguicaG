namespace SistemaRPreguicaG
{
    partial class FrmMenuCampanha
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
            this.BtnPersonagens = new System.Windows.Forms.Button();
            this.BtnMonstros = new System.Windows.Forms.Button();
            this.BtnNPCs = new System.Windows.Forms.Button();
            this.BtnSessoes = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPersonagens
            // 
            this.BtnPersonagens.BackgroundImage = global::SistemaRPreguicaG.Properties.Resources.Design_sem_nome__17_;
            this.BtnPersonagens.Location = new System.Drawing.Point(32, 133);
            this.BtnPersonagens.Name = "BtnPersonagens";
            this.BtnPersonagens.Size = new System.Drawing.Size(140, 134);
            this.BtnPersonagens.TabIndex = 0;
            this.BtnPersonagens.UseVisualStyleBackColor = true;
            this.BtnPersonagens.Click += new System.EventHandler(this.BtnPersonagens_Click_1);
            // 
            // BtnMonstros
            // 
            this.BtnMonstros.BackgroundImage = global::SistemaRPreguicaG.Properties.Resources.Design_sem_nome__18_;
            this.BtnMonstros.Location = new System.Drawing.Point(197, 133);
            this.BtnMonstros.Name = "BtnMonstros";
            this.BtnMonstros.Size = new System.Drawing.Size(141, 134);
            this.BtnMonstros.TabIndex = 1;
            this.BtnMonstros.UseVisualStyleBackColor = true;
            this.BtnMonstros.Click += new System.EventHandler(this.BtnMonstros_Click_1);
            // 
            // BtnNPCs
            // 
            this.BtnNPCs.BackgroundImage = global::SistemaRPreguicaG.Properties.Resources.Design_sem_nome__19_;
            this.BtnNPCs.Location = new System.Drawing.Point(364, 133);
            this.BtnNPCs.Name = "BtnNPCs";
            this.BtnNPCs.Size = new System.Drawing.Size(138, 134);
            this.BtnNPCs.TabIndex = 2;
            this.BtnNPCs.UseVisualStyleBackColor = true;
            this.BtnNPCs.Click += new System.EventHandler(this.BtnNPCs_Click_1);
            // 
            // BtnSessoes
            // 
            this.BtnSessoes.BackgroundImage = global::SistemaRPreguicaG.Properties.Resources.Design_sem_nome__20_;
            this.BtnSessoes.Location = new System.Drawing.Point(527, 133);
            this.BtnSessoes.Name = "BtnSessoes";
            this.BtnSessoes.Size = new System.Drawing.Size(142, 134);
            this.BtnSessoes.TabIndex = 3;
            this.BtnSessoes.UseVisualStyleBackColor = true;
            this.BtnSessoes.Click += new System.EventHandler(this.BtnSessoes_Click_1);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.Moccasin;
            this.BtnVoltar.Font = new System.Drawing.Font("NSimSun", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(12, 377);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtnVoltar.TabIndex = 4;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click_1);
            // 
            // FrmMenuCampanha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaRPreguicaG.Properties.Resources.Cadastrar_Jogadores__3_;
            this.ClientSize = new System.Drawing.Size(736, 412);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnSessoes);
            this.Controls.Add(this.BtnNPCs);
            this.Controls.Add(this.BtnMonstros);
            this.Controls.Add(this.BtnPersonagens);
            this.Name = "FrmMenuCampanha";
            this.Text = "FrmMenuCampanha";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPersonagens;
        private System.Windows.Forms.Button BtnMonstros;
        private System.Windows.Forms.Button BtnNPCs;
        private System.Windows.Forms.Button BtnSessoes;
        private System.Windows.Forms.Button BtnVoltar;
    }
}