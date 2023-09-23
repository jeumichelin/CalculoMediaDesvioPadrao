namespace CalculoMediaDesvioPadrao.Services;

internal class Valor
{
    public double NumeroReal { get; private set; }
    public double ValorIntermediario { get; private set; }

    public Valor(double numeroReal)
    {
        NumeroReal = numeroReal;
    }

    public void DefinirValorIntermediario(double media)
    {
        ValorIntermediario = Math.Pow(NumeroReal - media, 2); 
    }
}