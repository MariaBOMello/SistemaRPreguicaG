namespace SistemaRPreguicaG
{
    partial class FrmListaCampanhas
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
            this.components = new System.ComponentModel.Container();
            this.DgvListaCampanhas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nexBaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroJogadoresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campanhasNovaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rPGdbDataSet7 = new SistemaRPreguicaG.RPGdbDataSet7();
            this.campanhasNovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPGdbDataSet1 = new SistemaRPreguicaG.RPGdbDataSet1();
            this.campanhasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPGdbDataSet = new SistemaRPreguicaG.RPGdbDataSet();
            this.campanhasTableAdapter = new SistemaRPreguicaG.RPGdbDataSetTableAdapters.CampanhasTableAdapter();
            this.BtnSelecionarCampanha = new System.Windows.Forms.Button();
            this.rPGdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.campanhas_NovaTableAdapter = new SistemaRPreguicaG.RPGdbDataSet1TableAdapters.Campanhas_NovaTableAdapter();
            this.BtnVizualizarCampanha = new System.Windows.Forms.Button();
            this.BtnInativarCampanha = new System.Windows.Forms.Button();
            this.campanhas_NovaTableAdapter1 = new SistemaRPreguicaG.RPGdbDataSet7TableAdapters.Campanhas_NovaTableAdapter();
            this.BtnGerenciarPersonagens = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCampanhas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campanhasNovaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campanhasNovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campanhasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListaCampanhas
            // 
            this.DgvListaCampanhas.AutoGenerateColumns = false;
            this.DgvListaCampanhas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaCampanhas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.nexBaseDataGridViewTextBoxColumn,
            this.numeroJogadoresDataGridViewTextBoxColumn});
            this.DgvListaCampanhas.DataSource = this.campanhasNovaBindingSource1;
            this.DgvListaCampanhas.Location = new System.Drawing.Point(121, 47);
            this.DgvListaCampanhas.Name = "DgvListaCampanhas";
            this.DgvListaCampanhas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaCampanhas.Size = new System.Drawing.Size(444, 312);
            this.DgvListaCampanhas.TabIndex = 1;
            this.DgvListaCampanhas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaCampanhas_CellContentClick);
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
            // campanhasNovaBindingSource1
            // 
            this.campanhasNovaBindingSource1.DataMember = "Campanhas_Nova";
            this.campanhasNovaBindingSource1.DataSource = this.rPGdbDataSet7;
            // 
            // rPGdbDataSet7
            // 
            this.rPGdbDataSet7.DataSetName = "RPGdbDataSet7";
            this.rPGdbDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // campanhasNovaBindingSource
            // 
            this.campanhasNovaBindingSource.DataMember = "Campanhas_Nova";
            this.campanhasNovaBindingSource.DataSource = this.rPGdbDataSet1;
            // 
            // rPGdbDataSet1
            // 
            this.rPGdbDataSet1.DataSetName = "RPGdbDataSet1";
            this.rPGdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // campanhasBindingSource
            // 
            this.campanhasBindingSource.DataMember = "Campanhas";
            this.campanhasBindingSource.DataSource = this.rPGdbDataSet;
            // 
            // rPGdbDataSet
            // 
            this.rPGdbDataSet.DataSetName = "RPGdbDataSet";
            this.rPGdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // campanhasTableAdapter
            // 
            this.campanhasTableAdapter.ClearBeforeFill = true;
            // 
            // BtnSelecionarCampanha
            // 
            this.BtnSelecionarCampanha.BackgroundImage = global::SistemaRPreguicaG.Properties.Resources.Design_sem_nome__13_;
            this.BtnSelecionarCampanha.Font = new System.Drawing.Font("RomanT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelecionarCampanha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSelecionarCampanha.Image = global::SistemaRPreguicaG.Properties.Resources.Design_sem_nome__12_;
            this.BtnSelecionarCampanha.Location = new System.Drawing.Point(604, 108);
            this.BtnSelecionarCampanha.Name = "BtnSelecionarCampanha";
            this.BtnSelecionarCampanha.Size = new System.Drawing.Size(155, 81);
            this.BtnSelecionarCampanha.TabIndex = 2;
            this.BtnSelecionarCampanha.Text = "Editar";
            this.BtnSelecionarCampanha.UseVisualStyleBackColor = true;
            this.BtnSelecionarCampanha.Click += new System.EventHandler(this.BtnSelecionarCampanha_Click);
            // 
            // rPGdbDataSetBindingSource
            // 
            this.rPGdbDataSetBindingSource.DataSource = this.rPGdbDataSet;
            this.rPGdbDataSetBindingSource.Position = 0;
            // 
            // campanhas_NovaTableAdapter
            // 
            this.campanhas_NovaTableAdapter.ClearBeforeFill = true;
            // 
            // BtnVizualizarCampanha
            // 
            this.BtnVizualizarCampanha.BackgroundImage = global::SistemaRPreguicaG.Properties.Resources.Design_sem_nome__13_;
            this.BtnVizualizarCampanha.Font = new System.Drawing.Font("RomanT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVizualizarCampanha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnVizualizarCampanha.Image = global::SistemaRPreguicaG.Properties.Resources.Design_sem_nome__12_;
            this.BtnVizualizarCampanha.Location = new System.Drawing.Point(604, 12);
            this.BtnVizualizarCampanha.Name = "BtnVizualizarCampanha";
            this.BtnVizualizarCampanha.Size = new System.Drawing.Size(155, 90);
            this.BtnVizualizarCampanha.TabIndex = 3;
            this.BtnVizualizarCampanha.Text = "Vizualizar";
            this.BtnVizualizarCampanha.UseVisualStyleBackColor = true;
            this.BtnVizualizarCampanha.Click += new System.EventHandler(this.BtnVizualizarCampanha_Click);
            // 
            // BtnInativarCampanha
            // 
            this.BtnInativarCampanha.BackgroundImage = global::SistemaRPreguicaG.Properties.Resources.Design_sem_nome__13_;
            this.BtnInativarCampanha.Font = new System.Drawing.Font("RomanT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInativarCampanha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnInativarCampanha.Image = global::SistemaRPreguicaG.Properties.Resources.Design_sem_nome__12_;
            this.BtnInativarCampanha.Location = new System.Drawing.Point(604, 311);
            this.BtnInativarCampanha.Name = "BtnInativarCampanha";
            this.BtnInativarCampanha.Size = new System.Drawing.Size(155, 88);
            this.BtnInativarCampanha.TabIndex = 4;
            this.BtnInativarCampanha.Text = "Inativar";
            this.BtnInativarCampanha.UseVisualStyleBackColor = true;
            this.BtnInativarCampanha.Click += new System.EventHandler(this.BtnInativarCampanha_Click);
            // 
            // campanhas_NovaTableAdapter1
            // 
            this.campanhas_NovaTableAdapter1.ClearBeforeFill = true;
            // 
            // BtnGerenciarPersonagens
            // 
            this.BtnGerenciarPersonagens.BackgroundImage = global::SistemaRPreguicaG.Properties.Resources.Design_sem_nome__13_;
            this.BtnGerenciarPersonagens.Font = new System.Drawing.Font("RomanT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGerenciarPersonagens.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnGerenciarPersonagens.Image = global::SistemaRPreguicaG.Properties.Resources.Design_sem_nome__12_;
            this.BtnGerenciarPersonagens.Location = new System.Drawing.Point(604, 214);
            this.BtnGerenciarPersonagens.Name = "BtnGerenciarPersonagens";
            this.BtnGerenciarPersonagens.Size = new System.Drawing.Size(155, 91);
            this.BtnGerenciarPersonagens.TabIndex = 5;
            this.BtnGerenciarPersonagens.Text = "Gerenciar Personagens";
            this.BtnGerenciarPersonagens.UseVisualStyleBackColor = true;
            // 
            // FrmListaCampanhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaRPreguicaG.Properties.Resources.baixados;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.BtnGerenciarPersonagens);
            this.Controls.Add(this.BtnInativarCampanha);
            this.Controls.Add(this.BtnVizualizarCampanha);
            this.Controls.Add(this.BtnSelecionarCampanha);
            this.Controls.Add(this.DgvListaCampanhas);
            this.Name = "FrmListaCampanhas";
            this.Text = "FrmListaCampanhas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCampanhas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campanhasNovaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campanhasNovaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campanhasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvListaCampanhas;
        private RPGdbDataSet rPGdbDataSet;
        private System.Windows.Forms.BindingSource campanhasBindingSource;
        private RPGdbDataSetTableAdapters.CampanhasTableAdapter campanhasTableAdapter;
        private System.Windows.Forms.Button BtnSelecionarCampanha;
        private System.Windows.Forms.BindingSource rPGdbDataSetBindingSource;
        private RPGdbDataSet1 rPGdbDataSet1;
        private System.Windows.Forms.BindingSource campanhasNovaBindingSource;
        private RPGdbDataSet1TableAdapters.Campanhas_NovaTableAdapter campanhas_NovaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nexBaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroJogadoresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnVizualizarCampanha;
        private System.Windows.Forms.Button BtnInativarCampanha;
        private RPGdbDataSet7 rPGdbDataSet7;
        private System.Windows.Forms.BindingSource campanhasNovaBindingSource1;
        private RPGdbDataSet7TableAdapters.Campanhas_NovaTableAdapter campanhas_NovaTableAdapter1;
        private System.Windows.Forms.Button BtnGerenciarPersonagens;
    }
}