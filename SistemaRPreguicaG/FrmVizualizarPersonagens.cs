using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRPreguicaG
{
    public partial class FrmVizualizarPersonagens : Form
    {
        private int idCampanha;
        private string connectionString = @"Server=sqlexpress;Database=RPGdb;USER ID=aluno;PASSWORD=aluno;";

        public FrmVizualizarPersonagens(int idCampanha)
        {
            InitializeComponent();
            this.idCampanha = idCampanha;
            this.Text = $"Personagens da Campanha"; // ✅ Só título da janela
            CarregarPersonagens();
        }

        private void CarregarPersonagens()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"SELECT 
                                    p.Id_Personagem,
                                    p.Nome,
                                    p.Classe, 
                                    p.NEX,
                                    p.Forca,
                                    p.Agilidade,
                                    p.Intelecto,
                                    p.Vigor,
                                    p.Presenca,
                                    j.Nome as Jogador
                                    FROM Personagens p
                                    INNER JOIN Jogadores j ON p.Id_Jogador = j.Id_Jogador
                                    WHERE p.Id_Campanha = @IdCampanha 
                                    AND p.Estado_Atual = 'Ativo'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@IdCampanha", idCampanha);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DgvPersonagens.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar personagens: " + ex.Message, "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnInativarPersonagem_Click(object sender, EventArgs e)
        {
            if (DgvPersonagens.CurrentRow == null)
            {
                MessageBox.Show("Selecione um personagem para inativar.", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPersonagem = Convert.ToInt32(DgvPersonagens.CurrentRow.Cells["Id_Personagem"].Value);
            string nomePersonagem = DgvPersonagens.CurrentRow.Cells["Nome"].Value.ToString();

            var resultado = MessageBox.Show($"Tem certeza que deseja inativar o personagem '{nomePersonagem}'?",
                                          "Confirmação",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "UPDATE Personagens SET Estado_Atual = 'Inativo' WHERE Id_Personagem = @Id";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Id", idPersonagem);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Personagem inativado com sucesso!", "Sucesso",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarPersonagens();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inativar personagem: " + ex.Message, "Erro",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVizualizarPersonagens_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rPGdbDataSet19.Personagens'. Você pode movê-la ou removê-la conforme necessário.
            this.personagensTableAdapter.Fill(this.rPGdbDataSet19.Personagens);

        }
    }
}
