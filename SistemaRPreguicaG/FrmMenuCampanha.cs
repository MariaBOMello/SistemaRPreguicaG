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
    public partial class FrmMenuCampanha : Form
    {
        private int idCampanha;
        private string nomeCampanha;

        public FrmMenuCampanha(int idCampanha, string nomeCampanha)
        {
            InitializeComponent();
            this.idCampanha = idCampanha;
            this.nomeCampanha = nomeCampanha;

            // Configurar título da janela
            this.Text = $"Gerenciar Campanha: {nomeCampanha}";

            // ✅ CONFIGURAR OS BOTÕES CORRETAMENTE
            // Se você tiver um Label para o título, descomente a linha abaixo:
            // LblTitulo.Text = $"Gerenciar: {nomeCampanha}";
        }


        private void BtnPersonagens_Click_1(object sender, EventArgs e)
        {
            FrmVizualizarPersonagens frmPersonagens = new FrmVizualizarPersonagens(1);
            frmPersonagens.ShowDialog();
        }

        private void BtnMonstros_Click_1(object sender, EventArgs e)
        {
            FrmVizualizarMonstros frmMonstros = new FrmVizualizarMonstros(idCampanha);
            frmMonstros.ShowDialog();
        }

        private void BtnNPCs_Click_1(object sender, EventArgs e)
        {
            FrmVizualizarNPCs frmNPCs = new FrmVizualizarNPCs(idCampanha);
            frmNPCs.ShowDialog();
        }

        private void BtnSessoes_Click_1(object sender, EventArgs e)
        {
            FrmVizualizarSessoes frmSessoes = new FrmVizualizarSessoes(idCampanha);
            frmSessoes.ShowDialog();
        }

        private void BtnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}