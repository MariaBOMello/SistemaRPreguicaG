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
                                    AND p.Estado_Atual = 'Ativa'";

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

            try
            {
                // ✅ MÉTODO SEGURO 1: Tente pelo nome da coluna
                int idPersonagem = 0;
                string nomePersonagem = "";

                // Verifique quais colunas existem
                bool temIdColuna = DgvPersonagens.CurrentRow.Cells.Contains("Id_Personagem");
                bool temIdColuna2 = DgvPersonagens.CurrentRow.Cells.Contains("id_personagem"); // lowercase
                bool temIdColuna3 = DgvPersonagens.CurrentRow.Cells.Contains("Id Personagem"); // com espaço

                if (temIdColuna)
                {
                    idPersonagem = Convert.ToInt32(DgvPersonagens.CurrentRow.Cells["Id_Personagem"].Value);
                }
                else if (temIdColuna2)
                {
                    idPersonagem = Convert.ToInt32(DgvPersonagens.CurrentRow.Cells["id_personagem"].Value);
                }
                else if (temIdColuna3)
                {
                    idPersonagem = Convert.ToInt32(DgvPersonagens.CurrentRow.Cells["Id Personagem"].Value);
                }
                else
                {
                    // ✅ MÉTODO SEGURO 2: Use o ÍNDICE (coluna 0 geralmente é o ID)
                    idPersonagem = Convert.ToInt32(DgvPersonagens.CurrentRow.Cells[0].Value);
                }

                // Pega o nome (coluna 1 geralmente é o nome)
                nomePersonagem = DgvPersonagens.CurrentRow.Cells[1].Value.ToString();

                var resultado = MessageBox.Show($"Tem certeza que deseja inativar o personagem '{nomePersonagem}'?",
                                              "Confirmação",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        // ✅ CORREÇÃO: 'Inativa' não 'Inativo'
                        string query = "UPDATE Personagens SET Estado_Atual = 'Inativa' WHERE Id_Personagem = @Id";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Id", idPersonagem);
                            int linhasAfetadas = cmd.ExecuteNonQuery();

                            if (linhasAfetadas > 0)
                            {
                                MessageBox.Show("Personagem inativado com sucesso!", "Sucesso",
                                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CarregarPersonagens(); // Recarrega a lista
                            }
                            else
                            {
                                MessageBox.Show("Personagem não encontrado ou já inativado.", "Aviso",
                                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // ✅ DEBUG DETALHADO para ver qual é o problema
                string debugInfo = "ERRO DETALHADO:\n\n";
                debugInfo += $"Mensagem: {ex.Message}\n\n";

                if (DgvPersonagens.CurrentRow != null)
                {
                    debugInfo += "COLUNAS DISPONÍVEIS nesta linha:\n";
                    for (int i = 0; i < DgvPersonagens.CurrentRow.Cells.Count; i++)
                    {
                        var cell = DgvPersonagens.CurrentRow.Cells[i];
                        if (cell.OwningColumn != null)
                        {
                            debugInfo += $"[{i}] {cell.OwningColumn.Name} = {cell.Value}\n";
                        }
                    }
                }

                MessageBox.Show(debugInfo, "Erro ao Inativar",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVizualizarPersonagens_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rPGdbDataSet27.Personagens'. Você pode movê-la ou removê-la conforme necessário.
            this.personagensTableAdapter.Fill(this.rPGdbDataSet27.Personagens);
        }

        private void personagensBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personagensBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rPGdbDataSet27);

        }
    }
}
