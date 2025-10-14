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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmListaCampanhas listaCamp = new FrmListaCampanhas(usuarioLogadoId);
            listaCamp.ShowDialog();
        }
    }
}