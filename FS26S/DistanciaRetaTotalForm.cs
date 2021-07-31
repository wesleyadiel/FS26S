using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FS26S
{
    public partial class DistanciaRetaTotalForm : Form
    {
        public decimal DistanciaInformada = 0.00M;
        public string Origem;
        public string Destino;
        public DistanciaRetaTotalForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DistanciaInformada = Convert.ToDecimal(nudDistancia.Value);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void DistanciaRetaTotalForm_Shown(object sender, EventArgs e)
        {
            txtOrigem.Text = Origem;
            txtDestino.Text = Destino;
        }
    }
}
