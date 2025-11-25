namespace SistemaRPreguicaG
{
    partial class FrmListaCampanhas
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
            this.DgvListaCampanhas = new System.Windows.Forms.DataGridView();
            this.BtnSelecionarCampanha = new System.Windows.Forms.Button();
            this.BtnVizualizarCampanha = new System.Windows.Forms.Button();
            this.BtnInativarCampanha = new System.Windows.Forms.Button();
            this.BtnGerenciarPersonagens = new System.Windows.Forms.Button();
            this.rPGdbDataSet23 = new SistemaRPreguicaG.RPGdbDataSet23();
            this.campanhasNovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.campanhas_NovaTableAdapter = new SistemaRPreguicaG.RPGdbDataSet23TableAdapters.Campanhas_NovaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nexBaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroJogadoresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoAtualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCampanhas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campanhasNovaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListaCampanhas
            // 
            this.DgvListaCampanhas.AutoGenerateColumns = false;
            this.DgvListaCampanhas.BackgroundColor = System.Drawing.Color.Black;
            this.DgvListaCampanhas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvListaCampanhas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaCampanhas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.nexBaseDataGridViewTextBoxColumn,
            this.numeroJogadoresDataGridViewTextBoxColumn,
            this.estadoAtualDataGridViewTextBoxColumn,
            this.idUsuarioDataGridViewTextBoxColumn});
            this.DgvListaCampanhas.DataSource = this.campanhasNovaBindingSource;
            this.DgvListaCampanhas.GridColor = System.Drawing.Color.Gray;
            this.DgvListaCampanhas.Location = new System.Drawing.Point(20, 20);
            this.DgvListaCampanhas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvListaCampanhas.Name = "DgvListaCampanhas";
            this.DgvListaCampanhas.Size = new System.Drawing.Size(800, 400);
            this.DgvListaCampanhas.TabIndex = 0;
            // 
            // BtnSelecionarCampanha
            // 
            this.BtnSelecionarCampanha.BackColor = System.Drawing.Color.Black;
            this.BtnSelecionarCampanha.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSelecionarCampanha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSelecionarCampanha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnSelecionarCampanha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelecionarCampanha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelecionarCampanha.ForeColor = System.Drawing.Color.White;
            this.BtnSelecionarCampanha.Location = new System.Drawing.Point(20, 440);
            this.BtnSelecionarCampanha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSelecionarCampanha.Name = "BtnSelecionarCampanha";
            this.BtnSelecionarCampanha.Size = new System.Drawing.Size(180, 45);
            this.BtnSelecionarCampanha.TabIndex = 1;
            this.BtnSelecionarCampanha.Text = "🎯 SELECIONAR";
            this.BtnSelecionarCampanha.UseVisualStyleBackColor = false;
            this.BtnSelecionarCampanha.Click += new System.EventHandler(this.BtnSelecionarCampanha_Click);
            // 
            // BtnVizualizarCampanha
            // 
            this.BtnVizualizarCampanha.BackColor = System.Drawing.Color.Black;
            this.BtnVizualizarCampanha.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnVizualizarCampanha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnVizualizarCampanha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnVizualizarCampanha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVizualizarCampanha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVizualizarCampanha.ForeColor = System.Drawing.Color.White;
            this.BtnVizualizarCampanha.Location = new System.Drawing.Point(220, 440);
            this.BtnVizualizarCampanha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnVizualizarCampanha.Name = "BtnVizualizarCampanha";
            this.BtnVizualizarCampanha.Size = new System.Drawing.Size(180, 45);
            this.BtnVizualizarCampanha.TabIndex = 2;
            this.BtnVizualizarCampanha.Text = "👁️ VISUALIZAR";
            this.BtnVizualizarCampanha.UseVisualStyleBackColor = false;
            this.BtnVizualizarCampanha.Click += new System.EventHandler(this.BtnVizualizarCampanha_Click);
            // 
            // BtnInativarCampanha
            // 
            this.BtnInativarCampanha.BackColor = System.Drawing.Color.Black;
            this.BtnInativarCampanha.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnInativarCampanha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnInativarCampanha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnInativarCampanha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInativarCampanha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInativarCampanha.ForeColor = System.Drawing.Color.White;
            this.BtnInativarCampanha.Location = new System.Drawing.Point(420, 440);
            this.BtnInativarCampanha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnInativarCampanha.Name = "BtnInativarCampanha";
            this.BtnInativarCampanha.Size = new System.Drawing.Size(180, 45);
            this.BtnInativarCampanha.TabIndex = 3;
            this.BtnInativarCampanha.Text = "💀 INATIVAR";
            this.BtnInativarCampanha.UseVisualStyleBackColor = false;
            this.BtnInativarCampanha.Click += new System.EventHandler(this.BtnInativarCampanha_Click);
            // 
            // BtnGerenciarPersonagens
            // 
            this.BtnGerenciarPersonagens.BackColor = System.Drawing.Color.Black;
            this.BtnGerenciarPersonagens.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnGerenciarPersonagens.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnGerenciarPersonagens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnGerenciarPersonagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGerenciarPersonagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGerenciarPersonagens.ForeColor = System.Drawing.Color.White;
            this.BtnGerenciarPersonagens.Location = new System.Drawing.Point(620, 440);
            this.BtnGerenciarPersonagens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGerenciarPersonagens.Name = "BtnGerenciarPersonagens";
            this.BtnGerenciarPersonagens.Size = new System.Drawing.Size(200, 45);
            this.BtnGerenciarPersonagens.TabIndex = 4;
            this.BtnGerenciarPersonagens.Text = "👥 GERENCIAR";
            this.BtnGerenciarPersonagens.UseVisualStyleBackColor = false;
            this.BtnGerenciarPersonagens.Click += new System.EventHandler(this.BtnGerenciarPersonagens_Click);
            // 
            // rPGdbDataSet23
            // 
            this.rPGdbDataSet23.DataSetName = "RPGdbDataSet23";
            this.rPGdbDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // campanhasNovaBindingSource
            // 
            this.campanhasNovaBindingSource.DataMember = "Campanhas_Nova";
            this.campanhasNovaBindingSource.DataSource = this.rPGdbDataSet23;
            // 
            // campanhas_NovaTableAdapter
            // 
            this.campanhas_NovaTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // nexBaseDataGridViewTextBoxColumn
            // 
            this.nexBaseDataGridViewTextBoxColumn.DataPropertyName = "NexBase";
            this.nexBaseDataGridViewTextBoxColumn.HeaderText = "NexBase";
            this.nexBaseDataGridViewTextBoxColumn.Name = "nexBaseDataGridViewTextBoxColumn";
            // 
            // numeroJogadoresDataGridViewTextBoxColumn
            // 
            this.numeroJogadoresDataGridViewTextBoxColumn.DataPropertyName = "NumeroJogadores";
            this.numeroJogadoresDataGridViewTextBoxColumn.HeaderText = "NumeroJogadores";
            this.numeroJogadoresDataGridViewTextBoxColumn.Name = "numeroJogadoresDataGridViewTextBoxColumn";
            // 
            // estadoAtualDataGridViewTextBoxColumn
            // 
            this.estadoAtualDataGridViewTextBoxColumn.DataPropertyName = "Estado_Atual";
            this.estadoAtualDataGridViewTextBoxColumn.HeaderText = "Estado_Atual";
            this.estadoAtualDataGridViewTextBoxColumn.Name = "estadoAtualDataGridViewTextBoxColumn";
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            // 
            // FrmListaCampanhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(840, 505);
            this.Controls.Add(this.BtnGerenciarPersonagens);
            this.Controls.Add(this.BtnInativarCampanha);
            this.Controls.Add(this.BtnVizualizarCampanha);
            this.Controls.Add(this.BtnSelecionarCampanha);
            this.Controls.Add(this.DgvListaCampanhas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmListaCampanhas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "📜 LISTA DE CAMPANHAS";
            this.Load += new System.EventHandler(this.FrmListaCampanhas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCampanhas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campanhasNovaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListaCampanhas;
        private System.Windows.Forms.Button BtnSelecionarCampanha;
        private System.Windows.Forms.Button BtnVizualizarCampanha;
        private System.Windows.Forms.Button BtnInativarCampanha;
        private System.Windows.Forms.Button BtnGerenciarPersonagens;
        private RPGdbDataSet23 rPGdbDataSet23;
        private System.Windows.Forms.BindingSource campanhasNovaBindingSource;
        private RPGdbDataSet23TableAdapters.Campanhas_NovaTableAdapter campanhas_NovaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nexBaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroJogadoresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoAtualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
    }
}