using System.Globalization;

namespace CalculoMediaDesvioPadrao.Services;

public static class StringExtensions
{
    public static bool IsParseableToDouble(this string valor)
    {
        return double.TryParse(valor, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out var numeroRealInformado);
    }
    
    public static double ParseableToDouble(this string valor)
    {
        double.TryParse(valor, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out var numeroRealInformado);

        return numeroRealInformado;
    }    
}