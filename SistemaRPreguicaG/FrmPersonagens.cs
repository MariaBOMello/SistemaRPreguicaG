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
    public partial class FrmPersonagens : Form
    {
        private int usuarioLogadoId;
        private int? idCampanha; // Pode ser null (personagem sem campanha)
        private string connectionString = @"Server=sqlexpress;Database=RPGdb;USER ID=aluno;PASSWORD=aluno;";

        // Construtor para personagem vinculado a campanha
        public FrmPersonagens(int idUsuario, int idCampanhaSelecionada)
        {
            InitializeComponent();
            usuarioLogadoId = idUsuario;
            idCampanha = idCampanhaSelecionada;
            CarregarComboBoxes();
        }

        // Construtor para personagem sem campanha
        public FrmPersonagens(int idUsuario)
        {
            InitializeComponent();
            usuarioLogadoId = idUsuario;
            idCampanha = null;
            CarregarComboBoxes();
        }

        private void CarregarComboBoxes()
        {
            // Carregar jogadores
            CarregarJogadores();

            // Carregar classes
            CbxClasse.Items.AddRange(new string[] {
                "Combatente", "Especialista", "Ocultista"
            });

            // Carregar origens
            CbxOrigem.Items.AddRange(new string[] {
                "Academia", "Militar", "Religião", "Artista", "Atleta",
                "Criminal", "Serviço", "Trabalho", "Vítima"
            });

            // Carregar NEX (0-99)
            for (int i = 0; i <= 99; i++)
            {
                CbxNEX.Items.Add(i);
            }
            CbxNEX.SelectedIndex = 0; // NEX 0% padrão
        }

        private void CarregarJogadores()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT Id_Jogador, Nome FROM Jogadores WHERE Estado_Atual = 'Ativo' AND Id_Usuario = @IdUsuario";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@IdUsuario", usuarioLogadoId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            CbxJogador.Items.Clear();
                            while (reader.Read())
                            {
                                CbxJogador.Items.Add(new
                                {
                                    Id = reader.GetInt32(0),
                                    Nome = reader.GetString(1)
                                });
                            }
                        }
                    }
                }

                CbxJogador.DisplayMember = "Nome";
                CbxJogador.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar jogadores: " + ex.Message, "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Inserir personagem
                    string queryPersonagem = @"INSERT INTO Personagens 
                        (Nome, Classe, Origem, NEX, Id_Jogador, Forca, Agilidade, Intelecto, 
                         Vigor, Presenca, PV_Maximo, Sanidade_Maxima, PE_Maximo, PE_Por_Rodada, 
                         Defesa, Resistencia, Deslocamento, Bonus_Equipamento, Protecao, Outros, Estado_Atual)
                        VALUES (@Nome, @Classe, @Origem, @NEX, @IdJogador, @Forca, @Agilidade, @Intelecto,
                         @Vigor, @Presenca, @PVMaximo, @SanidadeMaxima, @PEMaximo, @PEPorRodada,
                         @Defesa, @Resistencia, @Deslocamento, @BonusEquipamento, @Protecao, @Outros, 'Ativo');
                        SELECT SCOPE_IDENTITY();";

                    int idPersonagem;

                    using (SqlCommand cmd = new SqlCommand(queryPersonagem, con))
                    {
                        cmd.Parameters.AddWithValue("@Nome", TxtNome.Text.Trim());
                        cmd.Parameters.AddWithValue("@Classe", CbxClasse.Text);
                        cmd.Parameters.AddWithValue("@Origem", CbxOrigem.Text);
                        cmd.Parameters.AddWithValue("@NEX", Convert.ToInt32(CbxNEX.Text));
                        cmd.Parameters.AddWithValue("@IdJogador", ((dynamic)CbxJogador.SelectedItem).Id);
                        cmd.Parameters.AddWithValue("@Forca", (int)NumForca.Value);
                        cmd.Parameters.AddWithValue("@Agilidade", (int)NumAgilidade.Value);
                        cmd.Parameters.AddWithValue("@Intelecto", (int)NumIntelecto.Value);
                        cmd.Parameters.AddWithValue("@Vigor", (int)NumVigor.Value);
                        cmd.Parameters.AddWithValue("@Presenca", (int)NumPresenca.Value);
                        cmd.Parameters.AddWithValue("@PVMaximo", (int)NumPVMaximo.Value);
                        cmd.Parameters.AddWithValue("@SanidadeMaxima", (int)NumSanidadeMaxima.Value);
                        cmd.Parameters.AddWithValue("@PEMaximo", (int)NumPEMaximo.Value);
                        cmd.Parameters.AddWithValue("@PEPorRodada", (int)NumPEPorRodada.Value);
                        cmd.Parameters.AddWithValue("@Defesa", (int)NumDefesa.Value);
                        cmd.Parameters.AddWithValue("@Resistencia", string.IsNullOrEmpty(TxtResistencia.Text) ? (object)DBNull.Value : TxtResistencia.Text);
                        cmd.Parameters.AddWithValue("@Deslocamento", (int)NumDeslocamento.Value);
                        cmd.Parameters.AddWithValue("@BonusEquipamento", (int)NumBonusEquipamento.Value);
                        cmd.Parameters.AddWithValue("@Protecao", string.IsNullOrEmpty(TxtProtecao.Text) ? (object)DBNull.Value : TxtProtecao.Text);
                        cmd.Parameters.AddWithValue("@Outros", string.IsNullOrEmpty(TxtOutros.Text) ? (object)DBNull.Value : TxtOutros.Text);

                        idPersonagem = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Vincular à campanha se foi selecionada
                    if (idCampanha.HasValue)
                    {
                        string queryVinculo = @"INSERT INTO Personagens_Campanhas 
                            (Id_Personagem, Id_Campanha, Estado)
                            VALUES (@IdPersonagem, @IdCampanha, 'Ativo')";

                        using (SqlCommand cmd = new SqlCommand(queryVinculo, con))
                        {
                            cmd.Parameters.AddWithValue("@IdPersonagem", idPersonagem);
                            cmd.Parameters.AddWithValue("@IdCampanha", idCampanha.Value);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Personagem cadastrado com sucesso!", "Sucesso",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar personagem: " + ex.Message, "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(TxtNome.Text))
            {
                MessageBox.Show("O nome do personagem é obrigatório!", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (CbxJogador.SelectedItem == null)
            {
                MessageBox.Show("Selecione um jogador!", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(CbxClasse.Text))
            {
                MessageBox.Show("Selecione uma classe!", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(CbxOrigem.Text))
            {
                MessageBox.Show("Selecione uma origem!", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimparCampos()
        {
            TxtNome.Clear();
            CbxJogador.SelectedIndex = -1;
            CbxClasse.SelectedIndex = -1;
            CbxOrigem.SelectedIndex = -1;
            CbxNEX.SelectedIndex = 0;

            // Resetar atributos para valores padrão
            NumForca.Value = 1;
            NumAgilidade.Value = 1;
            NumIntelecto.Value = 1;
            NumVigor.Value = 1;
            NumPresenca.Value = 1;

            // Resetar combate para valores padrão
            NumPVMaximo.Value = 12;
            NumSanidadeMaxima.Value = 12;
            NumPEMaximo.Value = 10;
            NumPEPorRodada.Value = 2;
            NumDefesa.Value = 10;
            TxtResistencia.Clear();
            NumDeslocamento.Value = 9;
            NumBonusEquipamento.Value = 0;
            TxtProtecao.Clear();

            TxtOutros.Clear();
        }
    }
}