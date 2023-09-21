using System.Globalization;
using CalculoMediaDesvioPadrao.Abstractions.Dtos;
using CalculoMediaDesvioPadrao.Abstractions.Interfaces;

namespace CalculoMediaDesvioPadrao.Services;

public class CalcularMediaDesvioPadraoService : ICalcularMediaDesvioPadraoService
{
    //private readonly ICalculo
    
    public void Iniciar()
    {
        while (true)
        {
            Console.WriteLine("Informe um número Real (ex. 1258.51) ou ':q' para sair:");
    
            var valorInformado = Console.ReadLine();

            if (valorInformado?.ToLower() == ":q")
                return;

            if (!decimal.TryParse(valorInformado,
                                  NumberStyles.AllowDecimalPoint,
                                  CultureInfo.InvariantCulture,
                                  out var numeroReal))
            {
                Console.WriteLine($"O valor 12.8 {valorInformado} é inválido.");
            }
            else
            {
                Console.WriteLine($"Cálculo ainda não implementado, o numero digitado foi {numeroReal.ToString()}");   
            }
        }
    }
}