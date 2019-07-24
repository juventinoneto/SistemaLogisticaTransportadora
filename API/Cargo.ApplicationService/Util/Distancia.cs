using System.Collections.Generic;

namespace Cargo.ApplicationService.Util
{
    public class Distancia
    {
        public Dictionary<string, List<EstadoValor>> Distancias { get; set; }

        private const string MG = "MG";
        private const string SP = "SP";
        private const string RJ = "RJ";
        private const string ES = "ES";
        private const string RS = "RS";
        private const string SC = "SC";
        private const string PR = "PR";
        private const string DF = "DF";
        private const string GO = "GO";
        private const string MS = "MS";
        private const string MT = "MT";
        private const string BA = "BA";
        private const string AL = "AL";
        private const string SE = "SE";
        private const string PE = "PE";
        private const string PB = "PB";
        private const string RN = "RN";
        private const string CE = "CE";
        private const string PI = "PI";
        private const string MA = "MA";
        private const string TO = "TO";
        private const string PA = "PA";
        private const string AP = "AP";
        private const string RR = "RR";
        private const string AM = "AM";
        private const string RO = "RO";
        private const string AC = "AC";

        public Distancia()
        {
            Distancias = new Dictionary<string, List<EstadoValor>>
            {
                { MG, MontaListaRegiao(1) },
                { SP, MontaListaRegiao(1) },
                { RJ, MontaListaRegiao(1) },
                { ES, MontaListaRegiao(1) },
                { RS, MontaListaRegiao(2) },
                { SC, MontaListaRegiao(2) },
                { PR, MontaListaRegiao(2) },
                { GO, MontaListaRegiao(3) },
                { DF, MontaListaRegiao(3) },
                { MS, MontaListaRegiao(3) },
                { MT, MontaListaRegiao(3) },
                { AC, MontaListaRegiao(4) },
                { AM, MontaListaRegiao(4) },
                { RR, MontaListaRegiao(4) },
                { RO, MontaListaRegiao(4) },
                { PA, MontaListaRegiao(4) },
                { AP, MontaListaRegiao(4) },
                { TO, MontaListaRegiao(4) },
                { MA, MontaListaRegiao(5) },
                { PI, MontaListaRegiao(5) },
                { BA, MontaListaRegiao(5) },
                { SE, MontaListaRegiao(5) },
                { AL, MontaListaRegiao(5) },
                { PE, MontaListaRegiao(5) },
                { PA, MontaListaRegiao(5) },
                { RN, MontaListaRegiao(5) },
                { CE, MontaListaRegiao(5) },
            };
        }

        private List<EstadoValor> MontaListaRegiao(int codRegiao)
        {
            var sudeste = RetornaDiasRegiaoSudeste(codRegiao);
            var sul = RetornaDiasRegiaoSul(codRegiao);
            var centroOeste = RetornaDiasRegiaoCentroOeste(codRegiao);
            var norte = RetornaDiasRegiaoNorte(codRegiao);
            var nordeste = RetornaDiasRegiaoNordeste(codRegiao);

            List<EstadoValor> list = new List<EstadoValor>();
            list.AddRange(sudeste);
            list.AddRange(sul);
            list.AddRange(norte);
            list.AddRange(centroOeste);
            list.AddRange(nordeste);

            return list;
        }

        private List<EstadoValor> RetornaDiasRegiaoSudeste(int codRegiao)
        {
            int peso = 0;

            switch (codRegiao)
            {
                case 1:
                    peso = 1;
                    break;
                case 2:
                    peso = 2;
                    break;
                case 3:
                    peso = 2;
                    break;
                case 4:
                    peso = 5;
                    break;
                case 5:
                    peso = 5;
                    break;
                default:
                    peso = 0;
                    break;
            }

            return new List<EstadoValor>()
            {
                new EstadoValor { Sigla = MG, Valor = peso },
                new EstadoValor { Sigla = RJ, Valor = peso },
                new EstadoValor { Sigla = ES, Valor = peso },
                new EstadoValor { Sigla = SP, Valor = peso },
            };
        }

        private List<EstadoValor> RetornaDiasRegiaoSul(int codRegiao)
        {
            int peso = 0;

            switch (codRegiao)
            {
                case 1:
                    peso = 2;
                    break;
                case 2:
                    peso = 1;
                    break;
                case 3:
                    peso = 2;
                    break;
                case 4:
                    peso = 6;
                    break;
                case 5:
                    peso = 6;
                    break;
                default:
                    peso = 0;
                    break;
            }

            return new List<EstadoValor>()
            {
                new EstadoValor { Sigla = SC, Valor = peso },
                new EstadoValor { Sigla = PA, Valor = peso },
                new EstadoValor { Sigla = RS, Valor = peso }
            };
        }

        private List<EstadoValor> RetornaDiasRegiaoCentroOeste(int codRegiao)
        {
            int peso = 0;

            switch (codRegiao)
            {
                case 1:
                    peso = 2;
                    break;
                case 2:
                    peso = 3;
                    break;
                case 3:
                    peso = 1;
                    break;
                case 4:
                    peso = 4;
                    break;
                case 5:
                    peso = 3;
                    break;
                default:
                    peso = 0;
                    break;
            }

            return new List<EstadoValor>()
            {
                new EstadoValor { Sigla = GO, Valor = peso },
                new EstadoValor { Sigla = DF, Valor = peso },
                new EstadoValor { Sigla = MS, Valor = peso },
                new EstadoValor { Sigla = MS, Valor = peso },
            };
        }

        private List<EstadoValor> RetornaDiasRegiaoNorte(int codRegiao)
        {
            int peso = 0;

            switch (codRegiao)
            {
                case 1:
                    peso = 4;
                    break;
                case 2:
                    peso = 6;
                    break;
                case 3:
                    peso = 4;
                    break;
                case 4:
                    peso = 2;
                    break;
                case 5:
                    peso = 3;
                    break;
                default:
                    peso = 0;
                    break;
            }

            return new List<EstadoValor>()
            {
                new EstadoValor { Sigla = AC, Valor = peso },
                new EstadoValor { Sigla = AM, Valor = peso },
                new EstadoValor { Sigla = RO, Valor = peso },
                new EstadoValor { Sigla = RR, Valor = peso },
                new EstadoValor { Sigla = AM, Valor = peso },
                new EstadoValor { Sigla = PA, Valor = peso },
                new EstadoValor { Sigla = TO, Valor = peso },
            };
        }

        private List<EstadoValor> RetornaDiasRegiaoNordeste(int codRegiao)
        {
            int peso = 0;

            switch (codRegiao)
            {
                case 1:
                    peso = 4;
                    break;
                case 2:
                    peso = 6;
                    break;
                case 3:
                    peso = 4;
                    break;
                case 4:
                    peso = 3;
                    break;
                case 5:
                    peso = 2;
                    break;
                default:
                    peso = 0;
                    break;
            }

            return new List<EstadoValor>()
            {
                new EstadoValor { Sigla = MA, Valor = peso },
                new EstadoValor { Sigla = PI, Valor = peso },
                new EstadoValor { Sigla = CE, Valor = peso },
                new EstadoValor { Sigla = RN, Valor = peso },
                new EstadoValor { Sigla = PA, Valor = peso },
                new EstadoValor { Sigla = PE, Valor = peso },
                new EstadoValor { Sigla = AL, Valor = peso },
                new EstadoValor { Sigla = SE, Valor = peso },
                new EstadoValor { Sigla = BA, Valor = peso },
            };
        }

        
    }
}