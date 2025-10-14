using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace SistemaRPreguicaG
{
    public partial class FrmDadosCampanha : Form
    {
        private int IDcampanha;

        public FrmDadosCampanha(int idcampanha)
        {
            InitializeComponent();
            IDcampanha = idcampanha;
        }

        private void BtnSalvarDados_Click(object sender, EventArgs e)
        {
            // ========== Personagem ==========
            string personagemNome = TxtPersonagemNome.Text;
            string personagemClasse = CbxClasse.Text;
            string personagemOrigem = CbxOrigem.Text;
            string obsPersonagem = TxtObservacoesPersonagens.Text;

            // ========== Monstro ==========
            string monstroNome = TxtMonstroNome.Text;
            int monstroVD = int.Parse(TxtVD.Text);
            int monstroPV = int.Parse(TxtPV.Text);
            int monstroDefesa = int.Parse(TxtDefesa.Text);
            string obsMonstro = TxtObservacoesMonstros.Text;

            // ========== NPC ==========
            string npcNome = TxtNpcNome.Text;
            string npcFuncao = TxtFuncao.Text;
            string obsNpc = TxtObservacoesNPCs.Text;

            // ========== Sessão ==========
            DateTime dataSelecionada = monthCalendar1.SelectionStart;
            DateTime inicioSessao = dataSelecionada.Date + DtpInicio.Value.TimeOfDay;
            DateTime fimSessao = dataSelecionada.Date + DtpFim.Value.TimeOfDay;
            string obsSessao = TxtObservacoesSessao.Text;

            string connectionString = @"Server=sqlexpress;Database=RPGdb;USER ID=aluno;PASSWORD=aluno;";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // SALVAR PERSONAGEM
                    string queryPersonagem = "INSERT INTO Personagens (Nome, Classe, Origem, Observacoes, Id_Campanha) " +
                                             "VALUES (@Nome, @Classe, @Origem, @Observacoes, @IdCampanha)";
                    using (SqlCommand cmd = new SqlCommand(queryPersonagem, con))
                    {
                        cmd.Parameters.AddWithValue("@Nome", personagemNome);
                        cmd.Parameters.AddWithValue("@Classe", personagemClasse);
                        cmd.Parameters.AddWithValue("@Origem", personagemOrigem);
                        cmd.Parameters.AddWithValue("@Observacoes", obsPersonagem);
                        cmd.Parameters.AddWithValue("@IdCampanha", IDcampanha);
                        cmd.ExecuteNonQuery();
                    }

                    // SALVAR MONSTRO
                    string queryMonstro = "INSERT INTO Monstros (Nome, VD, PV, Defesa, Observacoes, Id_Campanha) " +
                                          "VALUES (@Nome, @VD, @PV, @Defesa, @Observacoes, @IdCampanha)";
                    using (SqlCommand cmd = new SqlCommand(queryMonstro, con))
                    {
                        cmd.Parameters.AddWithValue("@Nome", monstroNome);
                        cmd.Parameters.AddWithValue("@VD", monstroVD);
                        cmd.Parameters.AddWithValue("@PV", monstroPV);
                        cmd.Parameters.AddWithValue("@Defesa", monstroDefesa);
                        cmd.Parameters.AddWithValue("@Observacoes", obsMonstro);
                        cmd.Parameters.AddWithValue("@IdCampanha", IDcampanha);
                        cmd.ExecuteNonQuery();
                    }

                    // SALVAR NPC
                    string queryNPC = "INSERT INTO NPCs (Nome, Funcao, Observacoes, Id_Campanha) " +
                                      "VALUES (@Nome, @Funcao, @Observacoes, @IdCampanha)";
                    using (SqlCommand cmd = new SqlCommand(queryNPC, con))
                    {
                        cmd.Parameters.AddWithValue("@Nome", npcNome);
                        cmd.Parameters.AddWithValue("@Funcao", npcFuncao);
                        cmd.Parameters.AddWithValue("@Observacoes", obsNpc);
                        cmd.Parameters.AddWithValue("@IdCampanha", IDcampanha);
                        cmd.ExecuteNonQuery();
                    }

                    // SALVAR SESSÃO
                    string querySessao = "INSERT INTO SessoesRPG (Id_Campanha, DataInicio, DataFim, Observacoes) " +
                                         "VALUES (@IdCampanha, @DataInicio, @DataFim, @Observacoes)";
                    using (SqlCommand cmd = new SqlCommand(querySessao, con))
                    {
                        cmd.Parameters.AddWithValue("@IdCampanha", IDcampanha);
                        cmd.Parameters.AddWithValue("@DataInicio", inicioSessao);
                        cmd.Parameters.AddWithValue("@DataFim", fimSessao);
                        cmd.Parameters.AddWithValue("@Observacoes", obsSessao);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Todos os dados foram salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpar campos
                TxtPersonagemNome.Clear();
                TxtMonstroNome.Clear();
                TxtVD.Clear();
                TxtPV.Clear();
                TxtDefesa.Clear();
                TxtNpcNome.Clear();
                TxtFuncao.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Mantém o label para não dar erro
        private void label12_Click(object sender, EventArgs e)
        {
            // Sem ação, apenas para manter o evento
        }
    }
}