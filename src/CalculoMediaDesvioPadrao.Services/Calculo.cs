namespace CalculoMediaDesvioPadrao.Services;

internal class Calculo
{
    public double DesvioPadrao { get; private set; }
    
    public double Media => Valores.Sum(v => v.NumeroReal) / Valores.Count;

    private double SomaValorIntermediario => Valores.Sum(v => v.ValorIntermediario);
    
    public List<Valor> Valores { get; private set; } = new List<Valor>();

    public Calculo(List<Valor> valores)
    {
        Valores.AddRange(valores);
    }

    private void CalcularDesvioPadrao()
    {
        Valores.ForEach(v => v.DefinirValorIntermediario(Media));
        DesvioPadrao = Math.Sqrt( SomaValorIntermediario / (Valores.Count - 1) );
    }

    public void ExibirResultado()
    {
        CalcularDesvioPadrao();
        Console.WriteLine($"A Média calculada foi: {Media} e o Desvio Padrão Calculado foi:{Math.Round(DesvioPadrao, 6)}");
    }
}