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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rPGdbDataSet = new SistemaRPreguicaG.RPGdbDataSet();
            this.campanhasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.campanhasTableAdapter = new SistemaRPreguicaG.RPGdbDataSetTableAdapters.CampanhasTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nexBaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroJogadoresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campanhasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.nexBaseDataGridViewTextBoxColumn,
            this.numeroJogadoresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.campanhasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(172, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 312);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rPGdbDataSet
            // 
            this.rPGdbDataSet.DataSetName = "RPGdbDataSet";
            this.rPGdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // campanhasBindingSource
            // 
            this.campanhasBindingSource.DataMember = "Campanhas";
            this.campanhasBindingSource.DataSource = this.rPGdbDataSet;
            // 
            // campanhasTableAdapter
            // 
            this.campanhasTableAdapter.ClearBeforeFill = true;
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
            // FrmListaCampanhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaRPreguicaG.Properties.Resources.baixados;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmListaCampanhas";
            this.Text = "FrmListaCampanhas";
            this.Load += new System.EventHandler(this.FrmListaCampanhas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campanhasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private RPGdbDataSet rPGdbDataSet;
        private System.Windows.Forms.BindingSource campanhasBindingSource;
        private RPGdbDataSetTableAdapters.CampanhasTableAdapter campanhasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nexBaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroJogadoresDataGridViewTextBoxColumn;
    }
}