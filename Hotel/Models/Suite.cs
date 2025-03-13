using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models;

internal class Suite
{
    public string TipoSuite { get; set; }
    public int Capacidade { get; set; }
    public decimal ValorDiarias { get; set; }

    public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
    {
        TipoSuite = tipoSuite;
        Capacidade = capacidade;
        ValorDiarias = valorDiaria;
    }
}
