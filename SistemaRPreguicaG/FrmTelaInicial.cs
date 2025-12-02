using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRPreguicaG
{
    public partial class FrmTelaInicial : Form
    {
        private int usuarioLogadoId;
        private string usuarioLogadoEmail;

        public FrmTelaInicial(int idUsuario, string emailUsuario)
        {
            InitializeComponent();
            usuarioLogadoId = idUsuario;
            usuarioLogadoEmail = emailUsuario;
        }

        private void btnExti_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnNovaCampanha_Click(object sender, EventArgs e)
        {
            FrmCriarCampanha criarCamp = new FrmCriarCampanha(usuarioLogadoId);
            criarCamp.ShowDialog();
        }

        // ✅ MANTIDO O NOME ORIGINAL - button1
        private void button1_Click(object sender, EventArgs e)
        {
            FrmListaCampanhas listaCamp = new FrmListaCampanhas(usuarioLogadoId);
            listaCamp.ShowDialog();
        }

        // ✅ BOTÃO ADICIONADO - Gerenciar Jogadores
        private void BtnGerenciarJogadores_Click(object sender, EventArgs e)
        {
            FrmJogadores frmJogadores = new FrmJogadores(usuarioLogadoId);
            frmJogadores.ShowDialog();
        }

        // Evento para carregar a tela inicial
        private void FrmTelaInicial_Load(object sender, EventArgs e)
        {
            // Exemplo: mostrar o e-mail do usuário logado na tela (opcional)
            this.Text = $"Bem-vindo - {usuarioLogadoEmail}";
        }

        private void BtnGerenciarJogadores_Click_1(object sender, EventArgs e)
        {
            FrmJogadores frmJogadores = new FrmJogadores(usuarioLogadoId);
            frmJogadores.ShowDialog();
        }
    }
}