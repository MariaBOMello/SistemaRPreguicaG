namespace SistemaRPreguicaG
{
    partial class FrmJogadores
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
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.DtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.CbxExperiencia = new System.Windows.Forms.ComboBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.BackColor = System.Drawing.Color.Red;
            this.TxtNome.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(82, 81);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(121, 22);
            this.TxtNome.TabIndex = 0;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.Red;
            this.TxtEmail.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(422, 22);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(121, 22);
            this.TxtEmail.TabIndex = 1;
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.BackColor = System.Drawing.Color.Red;
            this.TxtTelefone.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefone.Location = new System.Drawing.Point(520, 131);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(121, 22);
            this.TxtTelefone.TabIndex = 2;
            // 
            // DtpDataNascimento
            // 
            this.DtpDataNascimento.CalendarForeColor = System.Drawing.Color.Red;
            this.DtpDataNascimento.CalendarMonthBackground = System.Drawing.Color.Red;
            this.DtpDataNascimento.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.DtpDataNascimento.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.DtpDataNascimento.CalendarTrailingForeColor = System.Drawing.Color.Red;
            this.DtpDataNascimento.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDataNascimento.Location = new System.Drawing.Point(324, 260);
            this.DtpDataNascimento.Name = "DtpDataNascimento";
            this.DtpDataNascimento.Size = new System.Drawing.Size(200, 22);
            this.DtpDataNascimento.TabIndex = 5;
            // 
            // CbxExperiencia
            // 
            this.CbxExperiencia.BackColor = System.Drawing.Color.Red;
            this.CbxExperiencia.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxExperiencia.FormattingEnabled = true;
            this.CbxExperiencia.Items.AddRange(new object[] {
            "Iniciante",
            "Intermediário",
            "Experiente",
            "Mestre"});
            this.CbxExperiencia.Location = new System.Drawing.Point(436, 345);
            this.CbxExperiencia.Name = "CbxExperiencia";
            this.CbxExperiencia.Size = new System.Drawing.Size(121, 21);
            this.CbxExperiencia.TabIndex = 6;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.Font = new System.Drawing.Font("NSimSun", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(635, 12);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(84, 23);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.Red;
            this.BtnSalvar.Font = new System.Drawing.Font("NSimSun", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(635, 357);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(84, 37);
            this.BtnSalvar.TabIndex = 9;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            // 
            // FrmJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaRPreguicaG.Properties.Resources.Cadastrar_Jogadores__2_;
            this.ClientSize = new System.Drawing.Size(731, 406);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.CbxExperiencia);
            this.Controls.Add(this.DtpDataNascimento);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtNome);
            this.Name = "FrmJogadores";
            this.Text = "FrmJogadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtTelefone;
        private System.Windows.Forms.DateTimePicker DtpDataNascimento;
        private System.Windows.Forms.ComboBox CbxExperiencia;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSalvar;
    }
}