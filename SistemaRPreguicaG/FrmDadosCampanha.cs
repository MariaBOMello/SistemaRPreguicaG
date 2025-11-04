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

        private bool CampanhaExiste(int idCampanha, SqlConnection con)
        {
            string query = "SELECT COUNT(1) FROM Campanhas_Unificada WHERE Id = @IdCampanha";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@IdCampanha", idCampanha);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void BtnSalvarDados_Click(object sender, EventArgs e)
        {
            string personagemNome = TxtPersonagemNome.Text;
            string personagemClasse = CbxClasse.Text;
            string personagemOrigem = CbxOrigem.Text;
            string obsPersonagem = TxtObservacoesPersonagens.Text;

            string monstroNome = TxtMonstroNome.Text;
            int monstroVD = int.TryParse(TxtVD.Text, out int vd) ? vd : 0;
            int monstroPV = int.TryParse(TxtPV.Text, out int pv) ? pv : 0;
            int monstroDefesa = int.TryParse(TxtDefesa.Text, out int def) ? def : 0;
            string obsMonstro = TxtObservacoesMonstros.Text;

            string npcNome = TxtNpcNome.Text;
            string npcFuncao = TxtFuncao.Text;
            string obsNpc = TxtObservacoesNPCs.Text;

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

                    // 🔍 Verifica se a campanha existe
                    if (!CampanhaExiste(IDcampanha, con))
                    {
                        MessageBox.Show("A campanha selecionada não existe. Não é possível salvar os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 🧙‍♂️ Inserir Personagem
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

                    // 🐉 Inserir Monstro
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

                    // 🧔 Inserir NPC
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

                    // 🗓️ Inserir Sessão
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
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro SQL ao salvar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro geral ao salvar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label12_Click(object sender, EventArgs e) { }
    }
}