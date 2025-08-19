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
            this.listBoxCampanhas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxCampanhas
            // 
            this.listBoxCampanhas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxCampanhas.FormattingEnabled = true;
            this.listBoxCampanhas.Location = new System.Drawing.Point(162, 70);
            this.listBoxCampanhas.Name = "listBoxCampanhas";
            this.listBoxCampanhas.Size = new System.Drawing.Size(456, 290);
            this.listBoxCampanhas.TabIndex = 0;
            // 
            // FrmListaCampanhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaRPreguicaG.Properties.Resources.baixados;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxCampanhas);
            this.Name = "FrmListaCampanhas";
            this.Text = "FrmListaCampanhas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCampanhas;
    }
}