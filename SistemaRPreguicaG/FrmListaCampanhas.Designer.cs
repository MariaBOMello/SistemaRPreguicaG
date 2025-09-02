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
            this.campanhasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPGdbDataSet = new SistemaRPreguicaG.RPGdbDataSet();
            this.campanhasTableAdapter = new SistemaRPreguicaG.RPGdbDataSetTableAdapters.CampanhasTableAdapter();
            this.BtnSelecionarCampanha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCampanhas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campanhasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet)).BeginInit();
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
            this.DgvListaCampanhas.DataSource = this.campanhasBindingSource;
            this.DgvListaCampanhas.Location = new System.Drawing.Point(121, 47);
            this.DgvListaCampanhas.Name = "DgvListaCampanhas";
            this.DgvListaCampanhas.Size = new System.Drawing.Size(444, 312);
            this.DgvListaCampanhas.TabIndex = 1;
            this.DgvListaCampanhas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.BtnSelecionarCampanha.Location = new System.Drawing.Point(609, 272);
            this.BtnSelecionarCampanha.Name = "BtnSelecionarCampanha";
            this.BtnSelecionarCampanha.Size = new System.Drawing.Size(144, 115);
            this.BtnSelecionarCampanha.TabIndex = 2;
            this.BtnSelecionarCampanha.Text = "Selecionar";
            this.BtnSelecionarCampanha.UseVisualStyleBackColor = true;
            this.BtnSelecionarCampanha.Click += new System.EventHandler(this.BtnSelecionarCampanha_Click);
            // 
            // FrmListaCampanhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaRPreguicaG.Properties.Resources.baixados;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSelecionarCampanha);
            this.Controls.Add(this.DgvListaCampanhas);
            this.Name = "FrmListaCampanhas";
            this.Text = "FrmListaCampanhas";
            this.Load += new System.EventHandler(this.FrmListaCampanhas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCampanhas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campanhasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvListaCampanhas;
        private RPGdbDataSet rPGdbDataSet;
        private System.Windows.Forms.BindingSource campanhasBindingSource;
        private RPGdbDataSetTableAdapters.CampanhasTableAdapter campanhasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nexBaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroJogadoresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnSelecionarCampanha;
    }
}