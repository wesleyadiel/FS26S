using FS26S.Class;
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
    public partial class PrincipalForm : Form
    {
        private BuscaProfundidade BuscaProfundidade { get; set; }
        private BuscaA BuscaA { get; set; }

        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void PrincipalForm_Shown(object sender, EventArgs e)
        {
            MessageBox.Show(this, $@"
                                        Bem vindo!!!                    {Environment.NewLine}
                    Projeto referente a Estratégias de busca       {Environment.NewLine}
             FS26S - Fundamentos de Sistemas Inteligentes     ", "", MessageBoxButtons.OK, MessageBoxIcon.None);

            iniciar();
        }

        private void iniciar()
        {
            BuscaProfundidade = new BuscaProfundidade();

            //Preenchendo origens
            dgvOrigem.Rows.Add(BuscaProfundidade.PortoAlegre.code, BuscaProfundidade.PortoAlegre.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.Florianopolis.code, BuscaProfundidade.Florianopolis.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.Curitiba.code, BuscaProfundidade.Curitiba.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.SaoPaulo.code, BuscaProfundidade.SaoPaulo.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.RioJaneiro.code, BuscaProfundidade.RioJaneiro.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.CampoGrande.code, BuscaProfundidade.CampoGrande.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.BeloHorizonte.code, BuscaProfundidade.BeloHorizonte.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.Vitoria.code, BuscaProfundidade.Vitoria.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.Cuiaba.code, BuscaProfundidade.Cuiaba.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.Brasilia.code, BuscaProfundidade.Brasilia.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.Goiania.code, BuscaProfundidade.Goiania.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.Palmas.code, BuscaProfundidade.Palmas.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.RioBranco.code, BuscaProfundidade.RioBranco.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.PortoVelho.code, BuscaProfundidade.PortoVelho.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.Salvador.code, BuscaProfundidade.Salvador.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.Aracaju.code, BuscaProfundidade.Aracaju.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.Maceio.code, BuscaProfundidade.Maceio.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.Recife.code, BuscaProfundidade.Recife.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.JoaoPessoa.code, BuscaProfundidade.JoaoPessoa.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.Natal.code, BuscaProfundidade.Natal.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.Fortaleza.code, BuscaProfundidade.Fortaleza.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.Teresina.code, BuscaProfundidade.Teresina.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.SaoLuis.code, BuscaProfundidade.SaoLuis.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.Manaus.code, BuscaProfundidade.Manaus.name);
            dgvOrigem.Rows.Add(BuscaProfundidade.Belem.code, BuscaProfundidade.Belem.name); 
            dgvOrigem.Rows.Add(BuscaProfundidade.Macapa.code, BuscaProfundidade.Macapa.name); 
            dgvOrigem.Rows.Add(BuscaProfundidade.BoaVista.code, BuscaProfundidade.BoaVista.name);

            //Preenchendo destinos
            dgvDestino.Rows.Add(BuscaProfundidade.PortoAlegre.code, BuscaProfundidade.PortoAlegre.name);
            dgvDestino.Rows.Add(BuscaProfundidade.Florianopolis.code, BuscaProfundidade.Florianopolis.name);
            dgvDestino.Rows.Add(BuscaProfundidade.Curitiba.code, BuscaProfundidade.Curitiba.name);
            dgvDestino.Rows.Add(BuscaProfundidade.SaoPaulo.code, BuscaProfundidade.SaoPaulo.name);
            dgvDestino.Rows.Add(BuscaProfundidade.RioJaneiro.code, BuscaProfundidade.RioJaneiro.name);
            dgvDestino.Rows.Add(BuscaProfundidade.CampoGrande.code, BuscaProfundidade.CampoGrande.name);
            dgvDestino.Rows.Add(BuscaProfundidade.BeloHorizonte.code, BuscaProfundidade.BeloHorizonte.name);
            dgvDestino.Rows.Add(BuscaProfundidade.Vitoria.code, BuscaProfundidade.Vitoria.name);
            dgvDestino.Rows.Add(BuscaProfundidade.Cuiaba.code, BuscaProfundidade.Cuiaba.name);
            dgvDestino.Rows.Add(BuscaProfundidade.Brasilia.code, BuscaProfundidade.Brasilia.name);
            dgvDestino.Rows.Add(BuscaProfundidade.Goiania.code, BuscaProfundidade.Goiania.name);
            dgvDestino.Rows.Add(BuscaProfundidade.Palmas.code, BuscaProfundidade.Palmas.name);
            dgvDestino.Rows.Add(BuscaProfundidade.RioBranco.code, BuscaProfundidade.RioBranco.name);
            dgvDestino.Rows.Add(BuscaProfundidade.PortoVelho.code, BuscaProfundidade.PortoVelho.name);
            dgvDestino.Rows.Add(BuscaProfundidade.Salvador.code, BuscaProfundidade.Salvador.name);
            dgvDestino.Rows.Add(BuscaProfundidade.Aracaju.code, BuscaProfundidade.Aracaju.name);
            dgvDestino.Rows.Add(BuscaProfundidade.Maceio.code, BuscaProfundidade.Maceio.name);
            dgvDestino.Rows.Add(BuscaProfundidade.Recife.code, BuscaProfundidade.Recife.name);
            dgvDestino.Rows.Add(BuscaProfundidade.JoaoPessoa.code, BuscaProfundidade.JoaoPessoa.name);
            dgvDestino.Rows.Add(BuscaProfundidade.Natal.code, BuscaProfundidade.Natal.name);
            dgvDestino.Rows.Add(BuscaProfundidade.Fortaleza.code, BuscaProfundidade.Fortaleza.name);
            dgvDestino.Rows.Add(BuscaProfundidade.Teresina.code, BuscaProfundidade.Teresina.name);
            dgvDestino.Rows.Add(BuscaProfundidade.SaoLuis.code, BuscaProfundidade.SaoLuis.name);
            dgvDestino.Rows.Add(BuscaProfundidade.Manaus.code, BuscaProfundidade.Manaus.name);
            dgvDestino.Rows.Add(BuscaProfundidade.Belem.code, BuscaProfundidade.Belem.name);
            dgvDestino.Rows.Add(BuscaProfundidade.Macapa.code, BuscaProfundidade.Macapa.name);
            dgvDestino.Rows.Add(BuscaProfundidade.BoaVista.code, BuscaProfundidade.BoaVista.name);


            Application.DoEvents();
        }

        private void btnCalcularRota_Click(object sender, EventArgs e)
        {
            BuscaProfundidade = new BuscaProfundidade();

            decimal distanciaTotal = 0.00M;
            decimal conexaoMaisCurta = 0.00M;
            string caminho = string.Empty;

            if (dgvOrigem.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Origem não selecionada!");
                return;
            }
            
            if (dgvDestino.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Destino não selecionado!");
                return;
            }

            City origem = BuscaProfundidade.Cities.Where(c => c.code == Convert.ToString(dgvOrigem.SelectedRows[0].Cells["codeorigem"].Value)).FirstOrDefault();
            City destino = BuscaProfundidade.Cities.Where(c => c.code == Convert.ToString(dgvDestino.SelectedRows[0].Cells["codedestino"].Value)).FirstOrDefault();

            if (origem == null)
            {
                MessageBox.Show(this, "Origem não encontrada!");
                return;
            }

            if (destino == null)
            {
                MessageBox.Show(this, "Destino não encontrado!");
                return;
            }

            BuscaProfundidade.IniciarBuscar(origem, destino, ref distanciaTotal, ref conexaoMaisCurta, ref caminho);

            nudDistanciaTotal.Value = distanciaTotal;
            nudConexaoMaisCurta.Value = conexaoMaisCurta;
            rtxCaminho.Text = caminho;

        }

        private void btnCalcularRotaA_Click(object sender, EventArgs e)
        {
            BuscaA = new BuscaA();

            decimal distanciaTotal = 0.00M;
            decimal conexaoMaisCurta = 0.00M;
            string caminho = string.Empty;

            if (dgvOrigem.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Origem não selecionada!");
                return;
            }

            if (dgvDestino.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Destino não selecionado!");
                return;
            }

            City origem = BuscaA.Cities.Where(c => c.code == Convert.ToString(dgvOrigem.SelectedRows[0].Cells["codeorigem"].Value)).FirstOrDefault();
            City destino = BuscaA.Cities.Where(c => c.code == Convert.ToString(dgvDestino.SelectedRows[0].Cells["codedestino"].Value)).FirstOrDefault();

            if (origem == null)
            {
                MessageBox.Show(this, "Origem não encontrada!");
                return;
            }

            if (destino == null)
            {
                MessageBox.Show(this, "Destino não encontrado!");
                return;
            }

            decimal distanciaTotalOrigemDestino = 0.00M;
            if (origem.code == "PA" && destino.code == "CU")
            {
                distanciaTotalOrigemDestino = 1682.00M;
            }
            else if (origem.code == "MN" && destino.code == "SP")
            {
                distanciaTotalOrigemDestino = 2690.00M;
            }
            else if (origem.code == "PV" && destino.code == "CB")
            {
                distanciaTotalOrigemDestino = 2414.00M;
            }
            else
            {
                DistanciaRetaTotalForm d = new DistanciaRetaTotalForm();
                d.Origem = origem.name;
                d.Destino = destino.name;

                if (d.ShowDialog() == DialogResult.OK)
                {
                    distanciaTotalOrigemDestino = d.DistanciaInformada;
                }

                if (distanciaTotalOrigemDestino < 0.00M)
                {
                    MessageBox.Show(this, "Distância reta entre origem e destino não informada");
                    return;
                }
            }

            if (origem.code == destino.code)
            {
                distanciaTotal = 0.00M;
                conexaoMaisCurta = 0.00M;
                caminho = "Origem é o destino!!";
                return;
            }
            else
            {
                bool encontrou = false;
                while (!encontrou)
                {
                    if (BuscaA.Buscar(origem, destino, distanciaTotalOrigemDestino, ref distanciaTotal, ref conexaoMaisCurta, ref caminho))
                    {
                        encontrou = true;
                    }
                    else
                    {
                        distanciaTotal = 0.00M;
                        conexaoMaisCurta = 0.00M;
                        caminho = string.Empty;
                    }
                }

                caminho = $"{origem.name} " + caminho;
            }

            nudDistanciaTotal.Value = distanciaTotal;
            nudConexaoMaisCurta.Value = conexaoMaisCurta;
            rtxCaminho.Text = caminho;
        }
    }
}
