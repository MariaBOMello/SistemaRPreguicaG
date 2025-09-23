namespace SistemaRPreguicaG
{
    partial class FrmVizualizarCampanha
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
            this.rPGdbDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPGdbDataSet5 = new SistemaRPreguicaG.RPGdbDataSet5();
            this.campanhasNovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.campanhas_NovaTableAdapter = new SistemaRPreguicaG.RPGdbDataSet5TableAdapters.Campanhas_NovaTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campanhasNovaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // rPGdbDataSet5BindingSource
            // 
            this.rPGdbDataSet5BindingSource.DataSource = this.rPGdbDataSet5;
            this.rPGdbDataSet5BindingSource.Position = 0;
            // 
            // rPGdbDataSet5
            // 
            this.rPGdbDataSet5.DataSetName = "RPGdbDataSet5";
            this.rPGdbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // campanhasNovaBindingSource
            // 
            this.campanhasNovaBindingSource.DataMember = "Campanhas_Nova";
            this.campanhasNovaBindingSource.DataSource = this.rPGdbDataSet5BindingSource;
            // 
            // campanhas_NovaTableAdapter
            // 
            this.campanhas_NovaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(38, 209);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(388, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(454, 22);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(334, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // FrmVizualizarCampanha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaRPreguicaG.Properties.Resources.anfitriao1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmVizualizarCampanha";
            this.Text = "FrmVizualizarCampanha";
            this.Load += new System.EventHandler(this.FrmVizualizarCampanha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPGdbDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campanhasNovaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource rPGdbDataSet5BindingSource;
        private RPGdbDataSet5 rPGdbDataSet5;
        private System.Windows.Forms.BindingSource campanhasNovaBindingSource;
        private RPGdbDataSet5TableAdapters.Campanhas_NovaTableAdapter campanhas_NovaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}