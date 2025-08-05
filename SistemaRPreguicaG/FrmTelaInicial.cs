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
        public FrmTelaInicial()
        {
            InitializeComponent();
        }

        private void btnExti_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnNovaCampanha_Click(object sender, EventArgs e)
        {
            FrmCriarCampanha CriarCamp = new FrmCriarCampanha();
            CriarCamp.ShowDialog();

        }
    }
}
