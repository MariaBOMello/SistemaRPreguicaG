namespace SistemaRPreguicaG
{
    partial class FrmVizualizarMonstros
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
            this.DgvMonstros = new System.Windows.Forms.DataGridView();
            this.BtnInativarMonstro = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.rPGdbDataSet24 = new SistemaRPreguicaG.RPGdbDataSet24();
            this.monstrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monstrosTableAdapter = new SistemaRPreguicaG.RPGdbDataSet24TableAdapters.MonstrosTableAdapter();
            this.idMonstroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCampanhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoAtualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMonstros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monstrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvMonstros
            // 
            this.DgvMonstros.AutoGenerateColumns = false;
            this.DgvMonstros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DgvMonstros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMonstros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMonstroDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.vDDataGridViewTextBoxColumn,
            this.pVDataGridViewTextBoxColumn,
            this.defesaDataGridViewTextBoxColumn,
            this.idCampanhaDataGridViewTextBoxColumn,
            this.observacoesDataGridViewTextBoxColumn,
            this.estadoAtualDataGridViewTextBoxColumn});
            this.DgvMonstros.DataSource = this.monstrosBindingSource;
            this.DgvMonstros.Location = new System.Drawing.Point(20, 20);
            this.DgvMonstros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvMonstros.Name = "DgvMonstros";
            this.DgvMonstros.Size = new System.Drawing.Size(800, 400);
            this.DgvMonstros.TabIndex = 0;
            // 
            // BtnInativarMonstro
            // 
            this.BtnInativarMonstro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(130)))));
            this.BtnInativarMonstro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInativarMonstro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInativarMonstro.ForeColor = System.Drawing.Color.White;
            this.BtnInativarMonstro.Location = new System.Drawing.Point(20, 440);
            this.BtnInativarMonstro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnInativarMonstro.Name = "BtnInativarMonstro";
            this.BtnInativarMonstro.Size = new System.Drawing.Size(200, 45);
            this.BtnInativarMonstro.TabIndex = 1;
            this.BtnInativarMonstro.Text = "👹 INATIVAR";
            this.BtnInativarMonstro.UseVisualStyleBackColor = false;
            this.BtnInativarMonstro.Click += new System.EventHandler(this.BtnInativarMonstro_Click);
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
            // rPGdbDataSet24
            // 
            this.rPGdbDataSet24.DataSetName = "RPGdbDataSet24";
            this.rPGdbDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monstrosBindingSource
            // 
            this.monstrosBindingSource.DataMember = "Monstros";
            this.monstrosBindingSource.DataSource = this.rPGdbDataSet24;
            // 
            // monstrosTableAdapter
            // 
            this.monstrosTableAdapter.ClearBeforeFill = true;
            // 
            // idMonstroDataGridViewTextBoxColumn
            // 
            this.idMonstroDataGridViewTextBoxColumn.DataPropertyName = "Id_Monstro";
            this.idMonstroDataGridViewTextBoxColumn.HeaderText = "Id_Monstro";
            this.idMonstroDataGridViewTextBoxColumn.Name = "idMonstroDataGridViewTextBoxColumn";
            this.idMonstroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // vDDataGridViewTextBoxColumn
            // 
            this.vDDataGridViewTextBoxColumn.DataPropertyName = "VD";
            this.vDDataGridViewTextBoxColumn.HeaderText = "VD";
            this.vDDataGridViewTextBoxColumn.Name = "vDDataGridViewTextBoxColumn";
            // 
            // pVDataGridViewTextBoxColumn
            // 
            this.pVDataGridViewTextBoxColumn.DataPropertyName = "PV";
            this.pVDataGridViewTextBoxColumn.HeaderText = "PV";
            this.pVDataGridViewTextBoxColumn.Name = "pVDataGridViewTextBoxColumn";
            // 
            // defesaDataGridViewTextBoxColumn
            // 
            this.defesaDataGridViewTextBoxColumn.DataPropertyName = "Defesa";
            this.defesaDataGridViewTextBoxColumn.HeaderText = "Defesa";
            this.defesaDataGridViewTextBoxColumn.Name = "defesaDataGridViewTextBoxColumn";
            // 
            // idCampanhaDataGridViewTextBoxColumn
            // 
            this.idCampanhaDataGridViewTextBoxColumn.DataPropertyName = "Id_Campanha";
            this.idCampanhaDataGridViewTextBoxColumn.HeaderText = "Id_Campanha";
            this.idCampanhaDataGridViewTextBoxColumn.Name = "idCampanhaDataGridViewTextBoxColumn";
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
            // FrmVizualizarMonstros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(840, 505);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnInativarMonstro);
            this.Controls.Add(this.DgvMonstros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmVizualizarMonstros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🐉 MONSTROS - TERRITÓRIO OBSCURO";
            this.Load += new System.EventHandler(this.FrmVizualizarMonstros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMonstros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monstrosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvMonstros;
        private System.Windows.Forms.Button BtnInativarMonstro;
        private System.Windows.Forms.Button BtnVoltar;
        private RPGdbDataSet24 rPGdbDataSet24;
        private System.Windows.Forms.BindingSource monstrosBindingSource;
        private RPGdbDataSet24TableAdapters.MonstrosTableAdapter monstrosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMonstroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defesaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCampanhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoAtualDataGridViewTextBoxColumn;
    }
}