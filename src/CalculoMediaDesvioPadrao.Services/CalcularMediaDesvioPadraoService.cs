using CalculoMediaDesvioPadrao.Abstractions.Interfaces;

namespace CalculoMediaDesvioPadrao.Services;

public class CalcularMediaDesvioPadraoService : ICalcularMediaDesvioPadraoService
{
    private const string Calcular = ":c";
    private const string Sair = ":q";
    
    public void Iniciar()
    {
        var valores = new List<Valor>();
        var coletarValores = true;
        var valorInformado = string.Empty;
        
        while (coletarValores)
        {
            SolicitarValor();

            LerValor(ref valorInformado);

            switch ( valorInformado.ToLower() )
            {
                case Sair:
                    return;
                
                case Calcular:
                    coletarValores = false;
                    break;
                
                default:
                    ArmazenarValor(valorInformado, valores);
                    break;
            }
        }

        ExecutarCalculo(valores);
    }
    
    private void SolicitarValor() =>  Console.WriteLine("Informe um número Real (ex. 1258.51) ou ':q' para sair. Após informar todos os valores, digite ':c' para calcular.");
    
    private string LerValor(ref string valor) => valor = Console.ReadLine();

    private void ArmazenarValor(string valorInformado, List<Valor> valores)
    {
        if (!valorInformado.IsParseableToDouble())
        {
            Console.WriteLine($"O valor {valorInformado} é inválido.");
            return;
        }
        
        valores.Add(new Valor(valorInformado.ParseableToDouble()));
    }

    private void ExecutarCalculo(List<Valor> valores)
    {
        var calculo = new Calculo(valores);
        calculo.ExibirResultado();
    }
}