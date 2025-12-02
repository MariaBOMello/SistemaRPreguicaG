namespace SistemaRPreguicaG
{
    partial class FrmPersonagens
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
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.CbxJogador = new System.Windows.Forms.ComboBox();
            this.CbxClasse = new System.Windows.Forms.ComboBox();
            this.CbxOrigem = new System.Windows.Forms.ComboBox();
            this.CbxNEX = new System.Windows.Forms.ComboBox();
            this.TxtOutros = new System.Windows.Forms.TextBox();
            this.TxtProtecao = new System.Windows.Forms.TextBox();
            this.TxtResistencia = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.NumPVMaximo = new System.Windows.Forms.NumericUpDown();
            this.NumPEMaximo = new System.Windows.Forms.NumericUpDown();
            this.NumSanidadeMaxima = new System.Windows.Forms.NumericUpDown();
            this.NumDefesa = new System.Windows.Forms.NumericUpDown();
            this.NumPEPorRodada = new System.Windows.Forms.NumericUpDown();
            this.NumDeslocamento = new System.Windows.Forms.NumericUpDown();
            this.NumBonusEquipamento = new System.Windows.Forms.NumericUpDown();
            this.NumAgilidade = new System.Windows.Forms.NumericUpDown();
            this.NumVigor = new System.Windows.Forms.NumericUpDown();
            this.NumIntelecto = new System.Windows.Forms.NumericUpDown();
            this.NumForca = new System.Windows.Forms.NumericUpDown();
            this.NumPresenca = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumPVMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPEMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSanidadeMaxima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDefesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPEPorRodada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDeslocamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBonusEquipamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAgilidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumVigor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumIntelecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumForca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPresenca)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.BackColor = System.Drawing.Color.White;
            this.TxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.ForeColor = System.Drawing.Color.Black;
            this.TxtNome.Location = new System.Drawing.Point(107, 12);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(249, 38);
            this.TxtNome.TabIndex = 5;
            // 
            // CbxJogador
            // 
            this.CbxJogador.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxJogador.FormattingEnabled = true;
            this.CbxJogador.Location = new System.Drawing.Point(404, 18);
            this.CbxJogador.Name = "CbxJogador";
            this.CbxJogador.Size = new System.Drawing.Size(121, 32);
            this.CbxJogador.TabIndex = 6;
            // 
            // CbxClasse
            // 
            this.CbxClasse.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxClasse.FormattingEnabled = true;
            this.CbxClasse.Items.AddRange(new object[] {
            "Combatente",
            "Especialista",
            "Ocultista"});
            this.CbxClasse.Location = new System.Drawing.Point(648, 228);
            this.CbxClasse.Name = "CbxClasse";
            this.CbxClasse.Size = new System.Drawing.Size(283, 32);
            this.CbxClasse.TabIndex = 31;
            // 
            // CbxOrigem
            // 
            this.CbxOrigem.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxOrigem.FormattingEnabled = true;
            this.CbxOrigem.Items.AddRange(new object[] {
            "Acadêmico",
            "Agente de Saúde",
            "Amnésico",
            "Artista",
            "Astronauta",
            "Atleta",
            "Chef",
            "Chef do outro lado",
            "Colegial",
            "Cosplayer",
            "Criminoso",
            "Cultista Arrependido",
            "Desgarrado",
            "Diplomata",
            "Engenheiro",
            "Executivo",
            "Experimento",
            "Explorador",
            "Fanático por Criaturas",
            "Fotógrafo",
            "Inventor Paranormal",
            "Investigador",
            "Jovem Místico",
            "Legista do turno da noite",
            "Lutador",
            "Magnata",
            "Mateiro",
            "Mercenário",
            "Mergulhador",
            "Militar",
            "Motorista",
            "Nerd Entusiasta",
            "Operário",
            "Policial",
            "Profetizado",
            "Psicólogo",
            "Religioso",
            "Reporter Investigativo",
            "Servidor Público",
            "Teórico da Conspiração",
            "T.I.",
            "Trabalhador Rural",
            "Trambiqueiro",
            "Universitário",
            "Vítima"});
            this.CbxOrigem.Location = new System.Drawing.Point(659, 175);
            this.CbxOrigem.Name = "CbxOrigem";
            this.CbxOrigem.Size = new System.Drawing.Size(272, 32);
            this.CbxOrigem.TabIndex = 32;
            // 
            // CbxNEX
            // 
            this.CbxNEX.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxNEX.FormattingEnabled = true;
            this.CbxNEX.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "90",
            "95",
            "99"});
            this.CbxNEX.Location = new System.Drawing.Point(619, 280);
            this.CbxNEX.Name = "CbxNEX";
            this.CbxNEX.Size = new System.Drawing.Size(36, 32);
            this.CbxNEX.TabIndex = 33;
            // 
            // TxtOutros
            // 
            this.TxtOutros.BackColor = System.Drawing.Color.White;
            this.TxtOutros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOutros.ForeColor = System.Drawing.Color.Black;
            this.TxtOutros.Location = new System.Drawing.Point(757, 466);
            this.TxtOutros.Name = "TxtOutros";
            this.TxtOutros.Size = new System.Drawing.Size(23, 26);
            this.TxtOutros.TabIndex = 41;
            // 
            // TxtProtecao
            // 
            this.TxtProtecao.BackColor = System.Drawing.Color.White;
            this.TxtProtecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProtecao.ForeColor = System.Drawing.Color.Black;
            this.TxtProtecao.Location = new System.Drawing.Point(648, 510);
            this.TxtProtecao.Name = "TxtProtecao";
            this.TxtProtecao.Size = new System.Drawing.Size(270, 26);
            this.TxtProtecao.TabIndex = 42;
            // 
            // TxtResistencia
            // 
            this.TxtResistencia.BackColor = System.Drawing.Color.White;
            this.TxtResistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResistencia.ForeColor = System.Drawing.Color.Black;
            this.TxtResistencia.Location = new System.Drawing.Point(659, 540);
            this.TxtResistencia.Name = "TxtResistencia";
            this.TxtResistencia.Size = new System.Drawing.Size(259, 26);
            this.TxtResistencia.TabIndex = 43;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("NSimSun", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(915, 6);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(97, 60);
            this.BtnSalvar.TabIndex = 44;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click_1);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("NSimSun", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(12, 510);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(97, 60);
            this.BtnCancelar.TabIndex = 45;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // NumPVMaximo
            // 
            this.NumPVMaximo.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPVMaximo.Location = new System.Drawing.Point(600, 342);
            this.NumPVMaximo.Name = "NumPVMaximo";
            this.NumPVMaximo.Size = new System.Drawing.Size(34, 38);
            this.NumPVMaximo.TabIndex = 46;
            // 
            // NumPEMaximo
            // 
            this.NumPEMaximo.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPEMaximo.Location = new System.Drawing.Point(778, 342);
            this.NumPEMaximo.Name = "NumPEMaximo";
            this.NumPEMaximo.Size = new System.Drawing.Size(34, 38);
            this.NumPEMaximo.TabIndex = 47;
            // 
            // NumSanidadeMaxima
            // 
            this.NumSanidadeMaxima.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumSanidadeMaxima.Location = new System.Drawing.Point(822, 440);
            this.NumSanidadeMaxima.Name = "NumSanidadeMaxima";
            this.NumSanidadeMaxima.Size = new System.Drawing.Size(34, 38);
            this.NumSanidadeMaxima.TabIndex = 48;
            // 
            // NumDefesa
            // 
            this.NumDefesa.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumDefesa.Location = new System.Drawing.Point(600, 440);
            this.NumDefesa.Name = "NumDefesa";
            this.NumDefesa.Size = new System.Drawing.Size(34, 38);
            this.NumDefesa.TabIndex = 49;
            // 
            // NumPEPorRodada
            // 
            this.NumPEPorRodada.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPEPorRodada.Location = new System.Drawing.Point(695, 280);
            this.NumPEPorRodada.Name = "NumPEPorRodada";
            this.NumPEPorRodada.Size = new System.Drawing.Size(34, 38);
            this.NumPEPorRodada.TabIndex = 50;
            // 
            // NumDeslocamento
            // 
            this.NumDeslocamento.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumDeslocamento.Location = new System.Drawing.Point(822, 279);
            this.NumDeslocamento.Name = "NumDeslocamento";
            this.NumDeslocamento.Size = new System.Drawing.Size(96, 38);
            this.NumDeslocamento.TabIndex = 51;
            // 
            // NumBonusEquipamento
            // 
            this.NumBonusEquipamento.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumBonusEquipamento.Location = new System.Drawing.Point(712, 466);
            this.NumBonusEquipamento.Name = "NumBonusEquipamento";
            this.NumBonusEquipamento.Size = new System.Drawing.Size(30, 26);
            this.NumBonusEquipamento.TabIndex = 52;
            // 
            // NumAgilidade
            // 
            this.NumAgilidade.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumAgilidade.Location = new System.Drawing.Point(304, 149);
            this.NumAgilidade.Name = "NumAgilidade";
            this.NumAgilidade.Size = new System.Drawing.Size(34, 38);
            this.NumAgilidade.TabIndex = 53;
            // 
            // NumVigor
            // 
            this.NumVigor.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumVigor.Location = new System.Drawing.Point(394, 426);
            this.NumVigor.Name = "NumVigor";
            this.NumVigor.Size = new System.Drawing.Size(34, 38);
            this.NumVigor.TabIndex = 54;
            // 
            // NumIntelecto
            // 
            this.NumIntelecto.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumIntelecto.Location = new System.Drawing.Point(448, 252);
            this.NumIntelecto.Name = "NumIntelecto";
            this.NumIntelecto.Size = new System.Drawing.Size(34, 38);
            this.NumIntelecto.TabIndex = 55;
            // 
            // NumForca
            // 
            this.NumForca.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumForca.Location = new System.Drawing.Point(158, 252);
            this.NumForca.Name = "NumForca";
            this.NumForca.Size = new System.Drawing.Size(34, 38);
            this.NumForca.TabIndex = 56;
            // 
            // NumPresenca
            // 
            this.NumPresenca.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPresenca.Location = new System.Drawing.Point(204, 426);
            this.NumPresenca.Name = "NumPresenca";
            this.NumPresenca.Size = new System.Drawing.Size(34, 38);
            this.NumPresenca.TabIndex = 57;
            // 
            // FrmPersonagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaRPreguicaG.Properties.Resources.ficha2;
            this.ClientSize = new System.Drawing.Size(1010, 578);
            this.Controls.Add(this.NumPresenca);
            this.Controls.Add(this.NumForca);
            this.Controls.Add(this.NumIntelecto);
            this.Controls.Add(this.NumVigor);
            this.Controls.Add(this.NumAgilidade);
            this.Controls.Add(this.NumBonusEquipamento);
            this.Controls.Add(this.NumDeslocamento);
            this.Controls.Add(this.NumPEPorRodada);
            this.Controls.Add(this.NumDefesa);
            this.Controls.Add(this.NumSanidadeMaxima);
            this.Controls.Add(this.NumPEMaximo);
            this.Controls.Add(this.NumPVMaximo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.TxtResistencia);
            this.Controls.Add(this.TxtProtecao);
            this.Controls.Add(this.TxtOutros);
            this.Controls.Add(this.CbxNEX);
            this.Controls.Add(this.CbxOrigem);
            this.Controls.Add(this.CbxClasse);
            this.Controls.Add(this.CbxJogador);
            this.Controls.Add(this.TxtNome);
            this.Name = "FrmPersonagens";
            this.Text = "FrmPersonagens";
            ((System.ComponentModel.ISupportInitialize)(this.NumPVMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPEMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSanidadeMaxima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDefesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPEPorRodada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDeslocamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBonusEquipamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAgilidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumVigor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumIntelecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumForca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPresenca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.ComboBox CbxJogador;
        private System.Windows.Forms.ComboBox CbxClasse;
        private System.Windows.Forms.ComboBox CbxOrigem;
        private System.Windows.Forms.ComboBox CbxNEX;
        private System.Windows.Forms.TextBox TxtOutros;
        private System.Windows.Forms.TextBox TxtProtecao;
        private System.Windows.Forms.TextBox TxtResistencia;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.NumericUpDown NumPVMaximo;
        private System.Windows.Forms.NumericUpDown NumPEMaximo;
        private System.Windows.Forms.NumericUpDown NumSanidadeMaxima;
        private System.Windows.Forms.NumericUpDown NumDefesa;
        private System.Windows.Forms.NumericUpDown NumPEPorRodada;
        private System.Windows.Forms.NumericUpDown NumDeslocamento;
        private System.Windows.Forms.NumericUpDown NumBonusEquipamento;
        private System.Windows.Forms.NumericUpDown NumAgilidade;
        private System.Windows.Forms.NumericUpDown NumVigor;
        private System.Windows.Forms.NumericUpDown NumIntelecto;
        private System.Windows.Forms.NumericUpDown NumForca;
        private System.Windows.Forms.NumericUpDown NumPresenca;
    }
}