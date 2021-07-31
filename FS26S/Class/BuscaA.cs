using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS26S.Class
{
    public class BuscaA
    {
        public City PortoAlegre { get; set; }
        public City Florianopolis { get; set; }
        public City Curitiba { get; set; }
        public City SaoPaulo { get; set; }
        public City RioJaneiro { get; set; }
        public City CampoGrande { get; set; }
        public City BeloHorizonte { get; set; }
        public City Vitoria { get; set; }
        public City Cuiaba { get; set; }
        public City Brasilia { get; set; }
        public City Goiania { get; set; }
        public City Palmas { get; set; }
        public City RioBranco { get; set; }
        public City PortoVelho { get; set; }
        public City Salvador { get; set; }
        public City Aracaju { get; set; }
        public City Maceio { get; set; }
        public City Recife { get; set; }
        public City JoaoPessoa { get; set; }
        public City Natal { get; set; }
        public City Fortaleza { get; set; }
        public City Teresina { get; set; }
        public City SaoLuis { get; set; }
        public City Manaus { get; set; }
        public City Belem { get; set; }
        public City Macapa { get; set; }
        public City BoaVista { get; set; }

        public List<City> Cities { get; set; } = new List<City>();
        public List<String> CitiesVisited { get; set; } = new List<String>();

        public BuscaA()
        {
            //Preenchendo dados das cidades
            PortoAlegre = new City("PA", "Porto Alegre");
            Florianopolis = new City("FP", "Florianópolis");
            Curitiba = new City("CB", "Curitiba");
            SaoPaulo = new City("SP", "São Paulo");
            RioJaneiro = new City("RJ", "Rio de Janeiro");
            CampoGrande = new City("CG", "Campo Grande");
            BeloHorizonte = new City("BH", "Belo Horizonte");
            Vitoria = new City("VT", "Vitória");
            Cuiaba = new City("CU", "Cuiabá");
            Brasilia = new City("BR", "Brasília");
            Goiania = new City("GO", "Goiánia");
            Palmas = new City("PM", "Palmas");
            RioBranco = new City("RB", "Rio Branco");
            PortoVelho = new City("PV", "Porto Velho");
            Salvador = new City("SV", "Salvador");
            Aracaju = new City("AR", "Aracaju");
            Maceio = new City("MC", "Maceió");
            Recife = new City("RC", "Recife");
            JoaoPessoa = new City("JP", "João Pessoa");
            Natal = new City("NT", "Natal");
            Fortaleza = new City("FT", "Fortaleza");
            Teresina = new City("TR", "Teresina");
            SaoLuis = new City("SL", "São Luís");
            Manaus = new City("MN", "Manaus");
            Belem = new City("BL", "Belém");
            Macapa = new City("MP", "Macapá");
            BoaVista = new City("BV", "Boa Vista");

            //Preenchendo dados das conexões 
            List<City> connections = null;

            #region CONEXOES DE PORTO ALEGRE
            connections = new List<City>();

            Florianopolis.distance = 376.00M;
            connections.Add(Florianopolis);

            PortoAlegre.conections = connections;
            #endregion

            #region CONEXOES DE FLORIANOPOLIS
            connections = new List<City>();

            Curitiba.distance = 251.00M;
            connections.Add(Curitiba);

            PortoAlegre.distance = 376.00M;
            connections.Add(PortoAlegre);

            Florianopolis.conections = connections;
            #endregion

            #region CONEXOES DE CURITIBA
            connections = new List<City>();

            Florianopolis.distance = 251.00M;
            connections.Add(Florianopolis);

            SaoPaulo.distance = 338.00M;
            connections.Add(SaoPaulo);

            CampoGrande.distance = 780.00M;
            connections.Add(CampoGrande);

            Curitiba.conections = connections;
            #endregion

            #region CONEXOES DE CAMPO GRANDE
            connections = new List<City>();

            Curitiba.distance = 780.00M;
            connections.Add(Curitiba);

            Cuiaba.distance = 559.00M;
            connections.Add(Cuiaba);

            CampoGrande.conections = connections;
            #endregion

            #region CONEXOES DE SAO PAULO
            connections = new List<City>();

            Curitiba.distance = 338.00M;
            connections.Add(Curitiba);

            RioJaneiro.distance = 357.00M;
            connections.Add(RioJaneiro);

            BeloHorizonte.distance = 489.00M;
            connections.Add(BeloHorizonte);

            Brasilia.distance = 873.00M;
            connections.Add(Brasilia);

            Cuiaba.distance = 1326.00M;
            connections.Add(Cuiaba);

            SaoPaulo.conections = connections;
            #endregion

            #region CONEXOES DE RIO DE JANEIRO
            connections = new List<City>();

            SaoPaulo.distance = 357.00M;
            connections.Add(SaoPaulo);

            BeloHorizonte.distance = 339.00M;
            connections.Add(BeloHorizonte);

            Salvador.distance = 1209.00M;
            connections.Add(Salvador);

            Vitoria.distance = 412.00M;
            connections.Add(Vitoria);

            RioJaneiro.conections = connections;
            #endregion

            #region CONEXOES DE VITORIA
            connections = new List<City>();

            RioJaneiro.distance = 412.00M;
            connections.Add(RioJaneiro);

            Vitoria.conections = connections;
            #endregion

            #region CONEXOES DE BELO HORIZONTE
            connections = new List<City>();

            RioJaneiro.distance = 339.00M;
            connections.Add(RioJaneiro);

            SaoPaulo.distance = 489.00M;
            connections.Add(SaoPaulo);

            Brasilia.distance = 624.00M;
            connections.Add(Brasilia);

            BeloHorizonte.conections = connections;
            #endregion

            #region CONEXOES DE CUIABA
            connections = new List<City>();

            CampoGrande.distance = 559.00M;
            connections.Add(CampoGrande);

            SaoPaulo.distance = 1326.00M;
            connections.Add(SaoPaulo);

            Brasilia.distance = 873.00M;
            connections.Add(Brasilia);

            PortoVelho.distance = 1137.00M;
            connections.Add(PortoVelho);

            Cuiaba.conections = connections;
            #endregion

            #region CONEXOES DE BRASILIA
            connections = new List<City>();

            Cuiaba.distance = 873.00M;
            connections.Add(Cuiaba);

            SaoPaulo.distance = 873.00M;
            connections.Add(SaoPaulo);

            BeloHorizonte.distance = 624.00M;
            connections.Add(BeloHorizonte);

            Goiania.distance = 173.00M;
            connections.Add(Goiania);

            Palmas.distance = 620.00M;
            connections.Add(Palmas);

            Manaus.distance = 1932.00M;
            connections.Add(Manaus);

            Fortaleza.distance = 1687.00M;
            connections.Add(Fortaleza);

            Brasilia.conections = connections;
            #endregion

            #region CONEXOES DE GOIANIA
            connections = new List<City>();

            Brasilia.distance = 173.00M;
            connections.Add(Brasilia);

            Goiania.conections = connections;
            #endregion

            #region CONEXOES DE PALMAS
            connections = new List<City>();

            Brasilia.distance = 620.00M;
            connections.Add(Brasilia);

            Palmas.conections = connections;
            #endregion

            #region CONEXOES DE PORTO VELHO
            connections = new List<City>();

            Cuiaba.distance = 1137.00M;
            connections.Add(Cuiaba);

            RioBranco.distance = 449.00M;
            connections.Add(RioBranco);

            Manaus.distance = 761.00M;
            connections.Add(Manaus);

            PortoVelho.conections = connections;
            #endregion

            #region CONEXOES DE RIO BRANCO
            connections = new List<City>();

            PortoVelho.distance = 449.00M;
            connections.Add(PortoVelho);

            Manaus.distance = 1149.00M;
            connections.Add(Manaus);

            RioBranco.conections = connections;
            #endregion

            #region CONEXOES DE MANAUS
            connections = new List<City>();

            PortoVelho.distance = 761.00M;
            connections.Add(PortoVelho);

            RioBranco.distance = 1149.00M;
            connections.Add(RioBranco);

            BoaVista.distance = 661.00M;
            connections.Add(BoaVista);

            Belem.distance = 1292.00M;
            connections.Add(Belem);

            Manaus.conections = connections;
            #endregion

            #region CONEXOES DE BOA VISTA
            connections = new List<City>();

            Manaus.distance = 661.00M;
            connections.Add(Manaus);

            BoaVista.conections = connections;
            #endregion

            #region CONEXOES DE BELEM
            connections = new List<City>();

            Manaus.distance = 1292.00M;
            connections.Add(Manaus);

            Macapa.distance = 329.00M;
            connections.Add(Macapa);

            Belem.conections = connections;
            #endregion

            #region CONEXOES DE MACAPA
            connections = new List<City>();

            Belem.distance = 329.00M;
            connections.Add(Belem);

            Macapa.conections = connections;
            #endregion

            #region CONEXOES DE SALVADOR
            connections = new List<City>();

            RioJaneiro.distance = 1209.00M;
            connections.Add(RioJaneiro);

            Fortaleza.distance = 1028.00M;
            connections.Add(Fortaleza);

            Aracaju.distance = 277.00M;
            connections.Add(Aracaju);

            Natal.distance = 875.00M;
            connections.Add(Natal);

            Salvador.conections = connections;
            #endregion

            #region CONEXOES DE ARACAJU
            connections = new List<City>();

            Salvador.distance = 277.00M;
            connections.Add(Salvador);

            Maceio.distance = 201.00M;
            connections.Add(Maceio);

            Aracaju.conections = connections;
            #endregion

            #region CONEXOES DE MACEIO
            connections = new List<City>();

            Aracaju.distance = 201.00M;
            connections.Add(Aracaju);

            Recife.distance = 202.00M;
            connections.Add(Recife);

            Maceio.conections = connections;
            #endregion

            #region CONEXOES DE RECIFE
            connections = new List<City>();

            Maceio.distance = 202.00M;
            connections.Add(Maceio);

            Fortaleza.distance = 629.00M;
            connections.Add(Fortaleza);

            JoaoPessoa.distance = 104.00M;
            connections.Add(JoaoPessoa);

            Recife.conections = connections;
            #endregion

            #region CONEXOES DE JOAO PESSOA
            connections = new List<City>();

            Natal.distance = 151.00M;
            connections.Add(Natal);

            Recife.distance = 104.00M;
            connections.Add(Recife);

            JoaoPessoa.conections = connections;
            #endregion

            #region CONEXOES DE NATAL
            connections = new List<City>();

            JoaoPessoa.distance = 151.00M;
            connections.Add(JoaoPessoa);

            Salvador.distance = 875.00M;
            connections.Add(Salvador);

            Fortaleza.distance = 435.00M;
            connections.Add(Fortaleza);

            Natal.conections = connections;
            #endregion

            #region CONEXOES DE FORTALEZA
            connections = new List<City>();

            Natal.distance = 435.00M;
            connections.Add(Natal);

            Salvador.distance = 1028.00M;
            connections.Add(Salvador);

            Recife.distance = 629.00M;
            connections.Add(Recife);

            Brasilia.distance = 1687.00M;
            connections.Add(Brasilia);

            Teresina.distance = 495.00M;
            connections.Add(Teresina);

            SaoLuis.distance = 652.00M;
            connections.Add(SaoLuis);

            Fortaleza.conections = connections;
            #endregion

            #region CONEXOES DE TERESINA
            connections = new List<City>();

            Fortaleza.distance = 495.00M;
            connections.Add(Fortaleza);

            Teresina.conections = connections;
            #endregion

            #region CONEXOES DE SAO LUIS
            connections = new List<City>();

            Fortaleza.distance = 652.00M;
            connections.Add(Fortaleza);

            SaoLuis.conections = connections;
            #endregion


            Cities.Add(PortoAlegre);
            Cities.Add(Florianopolis);
            Cities.Add(Curitiba);
            Cities.Add(SaoPaulo);
            Cities.Add(RioJaneiro);
            Cities.Add(CampoGrande);
            Cities.Add(BeloHorizonte);
            Cities.Add(Vitoria);
            Cities.Add(Cuiaba);
            Cities.Add(Brasilia);
            Cities.Add(Goiania);
            Cities.Add(Palmas);
            Cities.Add(RioBranco);
            Cities.Add(PortoVelho);
            Cities.Add(Salvador);
            Cities.Add(Aracaju);
            Cities.Add(Maceio);
            Cities.Add(Recife);
            Cities.Add(JoaoPessoa);
            Cities.Add(Natal);
            Cities.Add(Fortaleza);
            Cities.Add(Teresina);
            Cities.Add(SaoLuis);
            Cities.Add(Manaus);
            Cities.Add(Belem);
            Cities.Add(Macapa);
            Cities.Add(BoaVista);
        }

        public bool Buscar(City origem, City destino, decimal distanciaRetaDestinoOrigem,  ref decimal distanciaTotal, ref decimal distaciaMenorConexao, ref string caminho)
        {
            CitiesVisited.Add(origem.code);

            if (origem.code == destino.code)
            {
                return true;
            }

            if (origem.conections.Where(c => c.code == destino.code).Count() > 0)
            {
                City cityDestino = origem.conections.Where(c => c.code == destino.code).FirstOrDefault();

                caminho = $" -> {cityDestino.name}" + caminho;
                distanciaTotal += cityDestino.distance;
                if (distaciaMenorConexao == 0.00M || cityDestino.distance < distaciaMenorConexao)
                {
                    distaciaMenorConexao = cityDestino.distance;
                }

                return true;
            }

            foreach (City cityFor in origem.conections)
            {
                cityFor.conections = Cities.Where(c => c.code == cityFor.code).FirstOrDefault()?.conections;
            }

            City next = origem.conections.Where(c => !CitiesVisited.Contains(c.code)).OrderBy(c => c.distance + distanciaRetaDestinoOrigem).FirstOrDefault();
            if (next == null)
            {
                return false;
            }

            string caminhoAux = $" -> {next.name}";
            decimal distanciaAux = next.distance;

            if (Buscar(next, destino, distanciaRetaDestinoOrigem, ref distanciaTotal, ref distaciaMenorConexao, ref caminho))
            {
                caminho = caminhoAux + caminho;
                distanciaTotal += distanciaAux;
                if (distaciaMenorConexao == 0.00M || distanciaAux < distaciaMenorConexao)
                {
                    distaciaMenorConexao = distanciaAux;
                }

                return true;
            }

            return false;
        }
    }
}
