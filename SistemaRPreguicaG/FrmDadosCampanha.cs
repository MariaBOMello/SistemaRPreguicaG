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
            // Validações básicas - REMOVIDO PERSONAGEM
            if (string.IsNullOrWhiteSpace(TxtMonstroNome.Text) &&
                string.IsNullOrWhiteSpace(TxtNpcNome.Text))
            {
                MessageBox.Show("Preencha pelo menos um campo para salvar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Server=sqlexpress;Database=RPGdb;USER ID=aluno;PASSWORD=aluno;";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // 🔍 Verifica se a campanha existe na Campanhas_Unificada
                    if (!CampanhaExiste(con, IDcampanha))
                    {
                        MessageBox.Show("Campanha não encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 🐉 SALVAR MONSTRO (se preenchido)
                    if (!string.IsNullOrWhiteSpace(TxtMonstroNome.Text))
                    {
                        SalvarMonstro(con);
                    }

                    // 🧔 SALVAR NPC (se preenchido)
                    if (!string.IsNullOrWhiteSpace(TxtNpcNome.Text))
                    {
                        SalvarNPC(con);
                    }

                    // 🗓️ SALVAR SESSÃO (sempre tenta salvar)
                    SalvarSessao(con);
                }

                MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CampanhaExiste(SqlConnection con, int idCampanha)
        {
            string query = "SELECT COUNT(1) FROM Campanhas_Unificada WHERE Id = @IdCampanha";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@IdCampanha", idCampanha);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        // ❌ REMOVIDO: Método SalvarPersonagem

        private void SalvarMonstro(SqlConnection con)
        {
            string query = @"INSERT INTO Monstros (Nome, VD, PV, Defesa, Observacoes, Id_Campanha, Estado_Atual) 
                           VALUES (@Nome, @VD, @PV, @Defesa, @Observacoes, @IdCampanha, 'Ativa')";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Nome", TxtMonstroNome.Text.Trim());
                cmd.Parameters.AddWithValue("@VD", int.TryParse(TxtVD.Text, out int vd) ? vd : 0);
                cmd.Parameters.AddWithValue("@PV", int.TryParse(TxtPV.Text, out int pv) ? pv : 0);
                cmd.Parameters.AddWithValue("@Defesa", int.TryParse(TxtDefesa.Text, out int def) ? def : 0);
                cmd.Parameters.AddWithValue("@Observacoes", TxtObservacoesMonstros.Text);
                cmd.Parameters.AddWithValue("@IdCampanha", IDcampanha);
                cmd.ExecuteNonQuery();
            }
        }

        private void SalvarNPC(SqlConnection con)
        {
            string query = @"INSERT INTO NPCs (Nome, Funcao, Observacoes, Id_Campanha, Estado_Atual) 
                           VALUES (@Nome, @Funcao, @Observacoes, @IdCampanha, 'Ativa')";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Nome", TxtNpcNome.Text.Trim());
                cmd.Parameters.AddWithValue("@Funcao", TxtFuncao.Text.Trim());
                cmd.Parameters.AddWithValue("@Observacoes", TxtObservacoesNPCs.Text);
                cmd.Parameters.AddWithValue("@IdCampanha", IDcampanha);
                cmd.ExecuteNonQuery();
            }
        }

        private void SalvarSessao(SqlConnection con)
        {
            DateTime dataSelecionada = monthCalendar1.SelectionStart;
            DateTime inicioSessao = dataSelecionada.Date + DtpInicio.Value.TimeOfDay;
            DateTime fimSessao = dataSelecionada.Date + DtpFim.Value.TimeOfDay;

            string query = @"INSERT INTO SessoesRPG (Id_Campanha, DataInicio, DataFim, Observacoes, Estado_Atual) 
                           VALUES (@IdCampanha, @DataInicio, @DataFim, @Observacoes, 'Ativa')";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@IdCampanha", IDcampanha);
                cmd.Parameters.AddWithValue("@DataInicio", inicioSessao);
                cmd.Parameters.AddWithValue("@DataFim", fimSessao);
                cmd.Parameters.AddWithValue("@Observacoes", TxtObservacoesSessao.Text);
                cmd.ExecuteNonQuery();
            }
        }

        private void LimparCampos()
        {
            // ❌ REMOVIDO: Campos de personagem
            // TxtPersonagemNome.Clear();
            // CbxClasse.SelectedIndex = -1;
            // CbxOrigem.SelectedIndex = -1;
            // TxtObservacoesPersonagens.Clear();

            TxtMonstroNome.Clear();
            TxtVD.Clear();
            TxtPV.Clear();
            TxtDefesa.Clear();
            TxtObservacoesMonstros.Clear();

            TxtNpcNome.Clear();
            TxtFuncao.Clear();
            TxtObservacoesNPCs.Clear();

            TxtObservacoesSessao.Clear();
        }

        private void label12_Click(object sender, EventArgs e) { }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDadosCampanha_Load(object sender, EventArgs e)
        {

        }
    }
}