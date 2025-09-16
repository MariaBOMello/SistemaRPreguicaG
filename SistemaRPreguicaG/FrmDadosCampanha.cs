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
            string personagemClasse = TxtClasse.Text;
            string personagemOrigem = TxtOrigem.Text;

            // ========== Monstro ==========
            string monstroNome = TxtMonstroNome.Text;
            int monstroVD = int.Parse(TxtVD.Text);
            int monstroPV = int.Parse(TxtPV.Text);
            int monstroDefesa = int.Parse(TxtDefesa.Text);

            // ========== NPC ==========
            string npcNome = TxtNpcNome.Text;
            string npcFuncao = TxtFuncao.Text;

            string connectionString = @"Server=sqlexpress;Database=RPGdb;USER ID=aluno;PASSWORD=aluno;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // ========== SALVAR PERSONAGEM ==========
                string queryPersonagem = "INSERT INTO Personagens (Nome, Classe, Origem, Id_Campanha) VALUES (@Nome, @Classe, @Origem, @IdCampanha)";
                using (SqlCommand cmd = new SqlCommand(queryPersonagem, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", personagemNome);
                    cmd.Parameters.AddWithValue("@Classe", personagemClasse);
                    cmd.Parameters.AddWithValue("@Origem", personagemOrigem);
                    cmd.Parameters.AddWithValue("@IdCampanha", IDcampanha);
                    cmd.ExecuteNonQuery();
                }

                // ========== SALVAR MONSTRO ==========
                string queryMonstro = "INSERT INTO Monstros (Nome, VD, PV, Defesa, Id_Campanha) VALUES (@Nome, @VD, @PV, @Defesa, @IdCampanha)";
                using (SqlCommand cmd = new SqlCommand(queryMonstro, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", monstroNome);
                    cmd.Parameters.AddWithValue("@VD", monstroVD);
                    cmd.Parameters.AddWithValue("@PV", monstroPV);
                    cmd.Parameters.AddWithValue("@Defesa", monstroDefesa);
                    cmd.Parameters.AddWithValue("@IdCampanha", IDcampanha);
                    cmd.ExecuteNonQuery();
                }

                // ========== SALVAR NPC ==========
                string queryNPC = "INSERT INTO NPCs (Nome, Funcao, Id_Campanha) VALUES (@Nome, @Funcao, @IdCampanha)";
                using (SqlCommand cmd = new SqlCommand(queryNPC, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", npcNome);
                    cmd.Parameters.AddWithValue("@Funcao", npcFuncao);
                    cmd.Parameters.AddWithValue("@IdCampanha", IDcampanha);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Todos os dados foram salvos com sucesso!");

            // Limpar campos
            TxtPersonagemNome.Clear();
            TxtClasse.Clear();
            TxtOrigem.Clear();
            TxtMonstroNome.Clear();
            TxtVD.Clear();
            TxtPV.Clear();
            TxtDefesa.Clear();
            TxtNpcNome.Clear();
            TxtFuncao.Clear();
        }

        private void TxtClasse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
