namespace SistemaRPreguicaG
{
    partial class FrmVizualizarSessoes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvSessoes = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCampanhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoAtualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessoesRPGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPGdbDataSet21 = new SistemaRPreguicaG.RPGdbDataSet21();
            this.BtnInativarSessao = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.sessoesRPGTableAdapter = new SistemaRPreguicaG.RPGdbDataSet21TableAdapters.SessoesRPGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSessoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessoesRPGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet21)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSessoes
            // 
            this.DgvSessoes.AutoGenerateColumns = false;
            this.DgvSessoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSessoes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DgvSessoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSessoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idCampanhaDataGridViewTextBoxColumn,
            this.dataInicioDataGridViewTextBoxColumn,
            this.dataFimDataGridViewTextBoxColumn,
            this.observacoesDataGridViewTextBoxColumn,
            this.estadoAtualDataGridViewTextBoxColumn});
            this.DgvSessoes.DataSource = this.sessoesRPGBindingSource;
            this.DgvSessoes.Location = new System.Drawing.Point(20, 20);
            this.DgvSessoes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvSessoes.Name = "DgvSessoes";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DgvSessoes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSessoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSessoes.Size = new System.Drawing.Size(800, 400);
            this.DgvSessoes.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCampanhaDataGridViewTextBoxColumn
            // 
            this.idCampanhaDataGridViewTextBoxColumn.DataPropertyName = "Id_Campanha";
            this.idCampanhaDataGridViewTextBoxColumn.HeaderText = "Id_Campanha";
            this.idCampanhaDataGridViewTextBoxColumn.Name = "idCampanhaDataGridViewTextBoxColumn";
            // 
            // dataInicioDataGridViewTextBoxColumn
            // 
            this.dataInicioDataGridViewTextBoxColumn.DataPropertyName = "DataInicio";
            this.dataInicioDataGridViewTextBoxColumn.HeaderText = "DataInicio";
            this.dataInicioDataGridViewTextBoxColumn.Name = "dataInicioDataGridViewTextBoxColumn";
            // 
            // dataFimDataGridViewTextBoxColumn
            // 
            this.dataFimDataGridViewTextBoxColumn.DataPropertyName = "DataFim";
            this.dataFimDataGridViewTextBoxColumn.HeaderText = "DataFim";
            this.dataFimDataGridViewTextBoxColumn.Name = "dataFimDataGridViewTextBoxColumn";
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            this.observacoesDataGridViewTextBoxColumn.DataPropertyName = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.HeaderText = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            // 
            // estadoAtualDataGridViewTextBoxColumn
            // 
            this.estadoAtualDataGridViewTextBoxColumn.DataPropertyName = "Estado_Atual";
            this.estadoAtualDataGridViewTextBoxColumn.HeaderText = "Estado_Atual";
            this.estadoAtualDataGridViewTextBoxColumn.Name = "estadoAtualDataGridViewTextBoxColumn";
            // 
            // sessoesRPGBindingSource
            // 
            this.sessoesRPGBindingSource.DataMember = "SessoesRPG";
            this.sessoesRPGBindingSource.DataSource = this.rPGdbDataSet21;
            // 
            // rPGdbDataSet21
            // 
            this.rPGdbDataSet21.DataSetName = "RPGdbDataSet21";
            this.rPGdbDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnInativarSessao
            // 
            this.BtnInativarSessao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(130)))));
            this.BtnInativarSessao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInativarSessao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInativarSessao.ForeColor = System.Drawing.Color.White;
            this.BtnInativarSessao.Location = new System.Drawing.Point(20, 440);
            this.BtnInativarSessao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnInativarSessao.Name = "BtnInativarSessao";
            this.BtnInativarSessao.Size = new System.Drawing.Size(200, 45);
            this.BtnInativarSessao.TabIndex = 1;
            this.BtnInativarSessao.Text = "🌙 INATIVAR";
            this.BtnInativarSessao.UseVisualStyleBackColor = false;
            this.BtnInativarSessao.Click += new System.EventHandler(this.BtnInativarSessao_Click);
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
            // sessoesRPGTableAdapter
            // 
            this.sessoesRPGTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVizualizarSessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(840, 505);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnInativarSessao);
            this.Controls.Add(this.DgvSessoes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmVizualizarSessoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🗓️ SESSÕES - CRÔNICAS NOTURNAS";
            this.Load += new System.EventHandler(this.FrmVizualizarSessoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSessoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessoesRPGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvSessoes;
        private System.Windows.Forms.Button BtnInativarSessao;
        private System.Windows.Forms.Button BtnVoltar;
        private RPGdbDataSet21 rPGdbDataSet21;
        private System.Windows.Forms.BindingSource sessoesRPGBindingSource;
        private RPGdbDataSet21TableAdapters.SessoesRPGTableAdapter sessoesRPGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCampanhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoAtualDataGridViewTextBoxColumn;
    }
}