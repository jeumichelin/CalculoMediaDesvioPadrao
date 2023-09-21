using CalculoMediaDesvioPadrao.Abstractions.Interfaces;
using CalculoMediaDesvioPadrao.Services;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddSingleton<ICalcularMediaDesvioPadraoService, CalcularMediaDesvioPadraoService>();

using var host = builder.Build();
using var serviceScope = host.Services.CreateScope();
var provider = serviceScope.ServiceProvider;

Console.WriteLine("Programa para Executar Cálculos de Média e Desvio Padrão");
var calcularMediaDesvioPadraoService = provider.GetService<ICalcularMediaDesvioPadraoService>();
calcularMediaDesvioPadraoService?.Iniciar();