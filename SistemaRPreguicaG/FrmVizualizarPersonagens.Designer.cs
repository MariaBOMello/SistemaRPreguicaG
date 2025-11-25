namespace SistemaRPreguicaG
{
    partial class FrmVizualizarPersonagens
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DgvPersonagens = new System.Windows.Forms.DataGridView();
            this.BtnInativarPersonagem = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.rPGdbDataSet19 = new SistemaRPreguicaG.RPGdbDataSet19();
            this.personagensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personagensTableAdapter = new SistemaRPreguicaG.RPGdbDataSet19TableAdapters.PersonagensTableAdapter();
            this.idPersonagemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idJogadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agilidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intelectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vigorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presencaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pVMaximoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanidadeMaximaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEMaximoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEPorRodadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resistenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deslocamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusEquipamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protecaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCriacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoAtualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonagens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personagensBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPersonagens
            // 
            this.DgvPersonagens.AutoGenerateColumns = false;
            this.DgvPersonagens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DgvPersonagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPersonagens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersonagemDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.classeDataGridViewTextBoxColumn,
            this.origemDataGridViewTextBoxColumn,
            this.nEXDataGridViewTextBoxColumn,
            this.idJogadorDataGridViewTextBoxColumn,
            this.forcaDataGridViewTextBoxColumn,
            this.agilidadeDataGridViewTextBoxColumn,
            this.intelectoDataGridViewTextBoxColumn,
            this.vigorDataGridViewTextBoxColumn,
            this.presencaDataGridViewTextBoxColumn,
            this.pVMaximoDataGridViewTextBoxColumn,
            this.sanidadeMaximaDataGridViewTextBoxColumn,
            this.pEMaximoDataGridViewTextBoxColumn,
            this.pEPorRodadaDataGridViewTextBoxColumn,
            this.defesaDataGridViewTextBoxColumn,
            this.resistenciaDataGridViewTextBoxColumn,
            this.deslocamentoDataGridViewTextBoxColumn,
            this.bonusEquipamentoDataGridViewTextBoxColumn,
            this.protecaoDataGridViewTextBoxColumn,
            this.outrosDataGridViewTextBoxColumn,
            this.dataCriacaoDataGridViewTextBoxColumn,
            this.estadoAtualDataGridViewTextBoxColumn});
            this.DgvPersonagens.DataSource = this.personagensBindingSource;
            this.DgvPersonagens.Location = new System.Drawing.Point(20, 20);
            this.DgvPersonagens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvPersonagens.Name = "DgvPersonagens";
            this.DgvPersonagens.Size = new System.Drawing.Size(800, 400);
            this.DgvPersonagens.TabIndex = 0;
            // 
            // BtnInativarPersonagem
            // 
            this.BtnInativarPersonagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(130)))));
            this.BtnInativarPersonagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInativarPersonagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInativarPersonagem.ForeColor = System.Drawing.Color.White;
            this.BtnInativarPersonagem.Location = new System.Drawing.Point(20, 440);
            this.BtnInativarPersonagem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnInativarPersonagem.Name = "BtnInativarPersonagem";
            this.BtnInativarPersonagem.Size = new System.Drawing.Size(200, 45);
            this.BtnInativarPersonagem.TabIndex = 1;
            this.BtnInativarPersonagem.Text = "💀 INATIVAR";
            this.BtnInativarPersonagem.UseVisualStyleBackColor = false;
            this.BtnInativarPersonagem.Click += new System.EventHandler(this.BtnInativarPersonagem_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.BtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.ForeColor = System.Drawing.Color.White;
            this.BtnVoltar.Location = new System.Drawing.Point(620, 440);
            this.BtnVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(200, 45);
            this.BtnVoltar.TabIndex = 2;
            this.BtnVoltar.Text = "⬅️ VOLTAR";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // rPGdbDataSet19
            // 
            this.rPGdbDataSet19.DataSetName = "RPGdbDataSet19";
            this.rPGdbDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personagensBindingSource
            // 
            this.personagensBindingSource.DataMember = "Personagens";
            this.personagensBindingSource.DataSource = this.rPGdbDataSet19;
            // 
            // personagensTableAdapter
            // 
            this.personagensTableAdapter.ClearBeforeFill = true;
            // 
            // idPersonagemDataGridViewTextBoxColumn
            // 
            this.idPersonagemDataGridViewTextBoxColumn.DataPropertyName = "Id_Personagem";
            this.idPersonagemDataGridViewTextBoxColumn.HeaderText = "Id_Personagem";
            this.idPersonagemDataGridViewTextBoxColumn.Name = "idPersonagemDataGridViewTextBoxColumn";
            this.idPersonagemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // classeDataGridViewTextBoxColumn
            // 
            this.classeDataGridViewTextBoxColumn.DataPropertyName = "Classe";
            this.classeDataGridViewTextBoxColumn.HeaderText = "Classe";
            this.classeDataGridViewTextBoxColumn.Name = "classeDataGridViewTextBoxColumn";
            // 
            // origemDataGridViewTextBoxColumn
            // 
            this.origemDataGridViewTextBoxColumn.DataPropertyName = "Origem";
            this.origemDataGridViewTextBoxColumn.HeaderText = "Origem";
            this.origemDataGridViewTextBoxColumn.Name = "origemDataGridViewTextBoxColumn";
            // 
            // nEXDataGridViewTextBoxColumn
            // 
            this.nEXDataGridViewTextBoxColumn.DataPropertyName = "NEX";
            this.nEXDataGridViewTextBoxColumn.HeaderText = "NEX";
            this.nEXDataGridViewTextBoxColumn.Name = "nEXDataGridViewTextBoxColumn";
            // 
            // idJogadorDataGridViewTextBoxColumn
            // 
            this.idJogadorDataGridViewTextBoxColumn.DataPropertyName = "Id_Jogador";
            this.idJogadorDataGridViewTextBoxColumn.HeaderText = "Id_Jogador";
            this.idJogadorDataGridViewTextBoxColumn.Name = "idJogadorDataGridViewTextBoxColumn";
            // 
            // forcaDataGridViewTextBoxColumn
            // 
            this.forcaDataGridViewTextBoxColumn.DataPropertyName = "Forca";
            this.forcaDataGridViewTextBoxColumn.HeaderText = "Forca";
            this.forcaDataGridViewTextBoxColumn.Name = "forcaDataGridViewTextBoxColumn";
            // 
            // agilidadeDataGridViewTextBoxColumn
            // 
            this.agilidadeDataGridViewTextBoxColumn.DataPropertyName = "Agilidade";
            this.agilidadeDataGridViewTextBoxColumn.HeaderText = "Agilidade";
            this.agilidadeDataGridViewTextBoxColumn.Name = "agilidadeDataGridViewTextBoxColumn";
            // 
            // intelectoDataGridViewTextBoxColumn
            // 
            this.intelectoDataGridViewTextBoxColumn.DataPropertyName = "Intelecto";
            this.intelectoDataGridViewTextBoxColumn.HeaderText = "Intelecto";
            this.intelectoDataGridViewTextBoxColumn.Name = "intelectoDataGridViewTextBoxColumn";
            // 
            // vigorDataGridViewTextBoxColumn
            // 
            this.vigorDataGridViewTextBoxColumn.DataPropertyName = "Vigor";
            this.vigorDataGridViewTextBoxColumn.HeaderText = "Vigor";
            this.vigorDataGridViewTextBoxColumn.Name = "vigorDataGridViewTextBoxColumn";
            // 
            // presencaDataGridViewTextBoxColumn
            // 
            this.presencaDataGridViewTextBoxColumn.DataPropertyName = "Presenca";
            this.presencaDataGridViewTextBoxColumn.HeaderText = "Presenca";
            this.presencaDataGridViewTextBoxColumn.Name = "presencaDataGridViewTextBoxColumn";
            // 
            // pVMaximoDataGridViewTextBoxColumn
            // 
            this.pVMaximoDataGridViewTextBoxColumn.DataPropertyName = "PV_Maximo";
            this.pVMaximoDataGridViewTextBoxColumn.HeaderText = "PV_Maximo";
            this.pVMaximoDataGridViewTextBoxColumn.Name = "pVMaximoDataGridViewTextBoxColumn";
            // 
            // sanidadeMaximaDataGridViewTextBoxColumn
            // 
            this.sanidadeMaximaDataGridViewTextBoxColumn.DataPropertyName = "Sanidade_Maxima";
            this.sanidadeMaximaDataGridViewTextBoxColumn.HeaderText = "Sanidade_Maxima";
            this.sanidadeMaximaDataGridViewTextBoxColumn.Name = "sanidadeMaximaDataGridViewTextBoxColumn";
            // 
            // pEMaximoDataGridViewTextBoxColumn
            // 
            this.pEMaximoDataGridViewTextBoxColumn.DataPropertyName = "PE_Maximo";
            this.pEMaximoDataGridViewTextBoxColumn.HeaderText = "PE_Maximo";
            this.pEMaximoDataGridViewTextBoxColumn.Name = "pEMaximoDataGridViewTextBoxColumn";
            // 
            // pEPorRodadaDataGridViewTextBoxColumn
            // 
            this.pEPorRodadaDataGridViewTextBoxColumn.DataPropertyName = "PE_Por_Rodada";
            this.pEPorRodadaDataGridViewTextBoxColumn.HeaderText = "PE_Por_Rodada";
            this.pEPorRodadaDataGridViewTextBoxColumn.Name = "pEPorRodadaDataGridViewTextBoxColumn";
            // 
            // defesaDataGridViewTextBoxColumn
            // 
            this.defesaDataGridViewTextBoxColumn.DataPropertyName = "Defesa";
            this.defesaDataGridViewTextBoxColumn.HeaderText = "Defesa";
            this.defesaDataGridViewTextBoxColumn.Name = "defesaDataGridViewTextBoxColumn";
            // 
            // resistenciaDataGridViewTextBoxColumn
            // 
            this.resistenciaDataGridViewTextBoxColumn.DataPropertyName = "Resistencia";
            this.resistenciaDataGridViewTextBoxColumn.HeaderText = "Resistencia";
            this.resistenciaDataGridViewTextBoxColumn.Name = "resistenciaDataGridViewTextBoxColumn";
            // 
            // deslocamentoDataGridViewTextBoxColumn
            // 
            this.deslocamentoDataGridViewTextBoxColumn.DataPropertyName = "Deslocamento";
            this.deslocamentoDataGridViewTextBoxColumn.HeaderText = "Deslocamento";
            this.deslocamentoDataGridViewTextBoxColumn.Name = "deslocamentoDataGridViewTextBoxColumn";
            // 
            // bonusEquipamentoDataGridViewTextBoxColumn
            // 
            this.bonusEquipamentoDataGridViewTextBoxColumn.DataPropertyName = "Bonus_Equipamento";
            this.bonusEquipamentoDataGridViewTextBoxColumn.HeaderText = "Bonus_Equipamento";
            this.bonusEquipamentoDataGridViewTextBoxColumn.Name = "bonusEquipamentoDataGridViewTextBoxColumn";
            // 
            // protecaoDataGridViewTextBoxColumn
            // 
            this.protecaoDataGridViewTextBoxColumn.DataPropertyName = "Protecao";
            this.protecaoDataGridViewTextBoxColumn.HeaderText = "Protecao";
            this.protecaoDataGridViewTextBoxColumn.Name = "protecaoDataGridViewTextBoxColumn";
            // 
            // outrosDataGridViewTextBoxColumn
            // 
            this.outrosDataGridViewTextBoxColumn.DataPropertyName = "Outros";
            this.outrosDataGridViewTextBoxColumn.HeaderText = "Outros";
            this.outrosDataGridViewTextBoxColumn.Name = "outrosDataGridViewTextBoxColumn";
            // 
            // dataCriacaoDataGridViewTextBoxColumn
            // 
            this.dataCriacaoDataGridViewTextBoxColumn.DataPropertyName = "DataCriacao";
            this.dataCriacaoDataGridViewTextBoxColumn.HeaderText = "DataCriacao";
            this.dataCriacaoDataGridViewTextBoxColumn.Name = "dataCriacaoDataGridViewTextBoxColumn";
            // 
            // estadoAtualDataGridViewTextBoxColumn
            // 
            this.estadoAtualDataGridViewTextBoxColumn.DataPropertyName = "Estado_Atual";
            this.estadoAtualDataGridViewTextBoxColumn.HeaderText = "Estado_Atual";
            this.estadoAtualDataGridViewTextBoxColumn.Name = "estadoAtualDataGridViewTextBoxColumn";
            // 
            // FrmVizualizarPersonagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(840, 505);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnInativarPersonagem);
            this.Controls.Add(this.DgvPersonagens);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmVizualizarPersonagens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "👥 PERSONAGENS - CAMPAÑHA SOMBRIA";
            this.Load += new System.EventHandler(this.FrmVizualizarPersonagens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonagens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personagensBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPersonagens;
        private System.Windows.Forms.Button BtnInativarPersonagem;
        private System.Windows.Forms.Button BtnVoltar;
        private RPGdbDataSet19 rPGdbDataSet19;
        private System.Windows.Forms.BindingSource personagensBindingSource;
        private RPGdbDataSet19TableAdapters.PersonagensTableAdapter personagensTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonagemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJogadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agilidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intelectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vigorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presencaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pVMaximoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanidadeMaximaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pEMaximoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pEPorRodadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defesaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resistenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deslocamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusEquipamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn protecaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outrosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCriacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoAtualDataGridViewTextBoxColumn;
    }
}