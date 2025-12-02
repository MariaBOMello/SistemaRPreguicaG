namespace SistemaRPreguicaG
{
    partial class FrmVizualizarNPCs
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
            this.DgvNPCs = new System.Windows.Forms.DataGridView();
            this.idNPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCampanhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoAtualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPCsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPGdbDataSet22 = new SistemaRPreguicaG.RPGdbDataSet22();
            this.BtnInativarNPC = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.nPCsTableAdapter = new SistemaRPreguicaG.RPGdbDataSet22TableAdapters.NPCsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNPCs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPCsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet22)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvNPCs
            // 
            this.DgvNPCs.AutoGenerateColumns = false;
            this.DgvNPCs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvNPCs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DgvNPCs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvNPCs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNPCDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.funcaoDataGridViewTextBoxColumn,
            this.idCampanhaDataGridViewTextBoxColumn,
            this.observacoesDataGridViewTextBoxColumn,
            this.estadoAtualDataGridViewTextBoxColumn});
            this.DgvNPCs.DataSource = this.nPCsBindingSource;
            this.DgvNPCs.Location = new System.Drawing.Point(20, 20);
            this.DgvNPCs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvNPCs.Name = "DgvNPCs";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DgvNPCs.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvNPCs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvNPCs.Size = new System.Drawing.Size(800, 400);
            this.DgvNPCs.TabIndex = 0;
            // 
            // idNPCDataGridViewTextBoxColumn
            // 
            this.idNPCDataGridViewTextBoxColumn.DataPropertyName = "Id_NPC";
            this.idNPCDataGridViewTextBoxColumn.HeaderText = "Id_NPC";
            this.idNPCDataGridViewTextBoxColumn.Name = "idNPCDataGridViewTextBoxColumn";
            this.idNPCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // funcaoDataGridViewTextBoxColumn
            // 
            this.funcaoDataGridViewTextBoxColumn.DataPropertyName = "Funcao";
            this.funcaoDataGridViewTextBoxColumn.HeaderText = "Funcao";
            this.funcaoDataGridViewTextBoxColumn.Name = "funcaoDataGridViewTextBoxColumn";
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
            // nPCsBindingSource
            // 
            this.nPCsBindingSource.DataMember = "NPCs";
            this.nPCsBindingSource.DataSource = this.rPGdbDataSet22;
            // 
            // rPGdbDataSet22
            // 
            this.rPGdbDataSet22.DataSetName = "RPGdbDataSet22";
            this.rPGdbDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnInativarNPC
            // 
            this.BtnInativarNPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(130)))));
            this.BtnInativarNPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInativarNPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInativarNPC.ForeColor = System.Drawing.Color.White;
            this.BtnInativarNPC.Location = new System.Drawing.Point(20, 440);
            this.BtnInativarNPC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnInativarNPC.Name = "BtnInativarNPC";
            this.BtnInativarNPC.Size = new System.Drawing.Size(200, 45);
            this.BtnInativarNPC.TabIndex = 1;
            this.BtnInativarNPC.Text = "👤 INATIVAR";
            this.BtnInativarNPC.UseVisualStyleBackColor = false;
            this.BtnInativarNPC.Click += new System.EventHandler(this.BtnInativarNPC_Click);
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
            // nPCsTableAdapter
            // 
            this.nPCsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVizualizarNPCs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(840, 505);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnInativarNPC);
            this.Controls.Add(this.DgvNPCs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmVizualizarNPCs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🧔 NPCS - ENIGMAS OCULTOS";
            this.Load += new System.EventHandler(this.FrmVizualizarNPCs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvNPCs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPCsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet22)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvNPCs;
        private System.Windows.Forms.Button BtnInativarNPC;
        private System.Windows.Forms.Button BtnVoltar;
        private RPGdbDataSet22 rPGdbDataSet22;
        private System.Windows.Forms.BindingSource nPCsBindingSource;
        private RPGdbDataSet22TableAdapters.NPCsTableAdapter nPCsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNPCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCampanhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoAtualDataGridViewTextBoxColumn;
    }
}