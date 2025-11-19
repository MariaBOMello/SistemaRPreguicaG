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
    public partial class FrmVizualizarCampanha : Form
    {
        private int IdCampanha;
        private string connectionString = @"Server=sqlexpress;Database=RPGdb;USER ID=aluno;PASSWORD=aluno;";

        public FrmVizualizarCampanha(int idCampanha)
        {
            InitializeComponent();
            IdCampanha = idCampanha;
        }

        private void FrmVizualizarCampanha_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // PERSONAGENS
                    string sqlPersonagens = @"SELECT Id_Personagem, Nome, Classe, Origem, Observacoes 
                                     FROM Personagens 
                                     WHERE Id_Campanha = @IdCampanha 
                                     AND Estado_Atual = 'Ativa'";
                    DgvPersonagens.DataSource = BuscarDados(con, sqlPersonagens);

                    // MONSTROS
                    string sqlMonstros = @"SELECT Id_Monstro, Nome, VD, PV, Defesa, Observacoes 
                                  FROM Monstros 
                                  WHERE Id_Campanha = @IdCampanha 
                                  AND Estado_Atual = 'Ativa'";
                    DgvMonstros.DataSource = BuscarDados(con, sqlMonstros);

                    // NPCs
                    string sqlNPCs = @"SELECT Id_NPC, Nome, Funcao, Observacoes 
                              FROM NPCs 
                              WHERE Id_Campanha = @IdCampanha 
                              AND Estado_Atual = 'Ativa'";
                    DgvNPCs.DataSource = BuscarDados(con, sqlNPCs);

                    // SESSÕES
                    string sqlSessoes = @"SELECT Id, DataInicio, DataFim, Observacoes 
                                 FROM SessoesRPG 
                                 WHERE Id_Campanha = @IdCampanha 
                                 AND Estado_Atual = 'Ativa'";
                    DgvSessoes.DataSource = BuscarDados(con, sqlSessoes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable BuscarDados(SqlConnection con, string sql)
        {
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@IdCampanha", IdCampanha);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        private void InativarRegistroComConfirmacao(string tabela, DataGridView dgv, string nomeColunaId)
        {
            if (dgv.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma linha primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pega o valor da primeira coluna (que é sempre o ID)
            var valorId = dgv.CurrentRow.Cells[0].Value;
            if (valorId == null || valorId == DBNull.Value)
            {
                MessageBox.Show("ID do registro não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Convert.ToInt32(valorId);

            // Confirmação
            var resultado = MessageBox.Show($"Tem certeza que deseja inativar este registro?",
                                          "Confirmação",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string sql = $"UPDATE {tabela} SET Estado_Atual = 'Inativa' WHERE {nomeColunaId} = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int linhas = cmd.ExecuteNonQuery();

                        if (linhas > 0)
                        {
                            MessageBox.Show("Registro inativado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarDados();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro foi alterado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inativar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------- BOTÕES DE INATIVAR COM OS NOMES CORRETOS --------
        private void BtnInativarPersonagem_Click(object sender, EventArgs e)
        {
            InativarRegistroComConfirmacao("Personagens", DgvPersonagens, "Id_Personagem");
        }

        private void BtnInativarMonstro_Click(object sender, EventArgs e)
        {
            InativarRegistroComConfirmacao("Monstros", DgvMonstros, "Id_Monstro");
        }

        private void BtnInativarNPC_Click(object sender, EventArgs e)
        {
            InativarRegistroComConfirmacao("NPCs", DgvNPCs, "Id_NPC");
        }

        private void BtnInativarSessao_Click(object sender, EventArgs e)
        {
            InativarRegistroComConfirmacao("SessoesRPG", DgvSessoes, "Id");
        }

        private void DgvMonstros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mantido vazio
        }

        private void DgvNPCs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mantido vazio
        }
    }
}