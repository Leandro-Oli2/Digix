namespace Aula_22_OO_Enumerate
{
    public enum Estado
    {
        SP,
        RJ,
        MG,
        BA,
        MS,
    }
    public class EstecaoEstado{
        public static string GetDescricao(Estado estado){
            switch (estado)
            {
                case Estado.SP:
                    return "São Paulo";
                case Estado.RJ:
                    return "Rio de Janeiro";
                case Estado.MG:
                    return "Minas Gerais";
                case Estado.BA:
                    return "Bahia";
                case Estado.MS:
                    return "Mato Grosso do Sul";
                default:
                    return "Estado não encontrado";
            }
        }
    }
    public class Regiao{
        public string[] Regioes = new string[] { "Sul", "Sudeste", "Centro-Oeste", "Norte", "Nordeste" };

        public string GetRegio(Estado estado){
            return estado switch{
                Estado.SP => Regioes[1],
                Estado.RJ => Regioes[1],
                Estado.MG => Regioes[1],
                Estado.MS => Regioes[2],
                Estado.BA => Regioes[4],
                _ => "Regiao não encontrada D= ",
            };
        }
    }
}