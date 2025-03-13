using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models;

internal class Reserva
{
    public List<Pessoa> pessoa = new List<Pessoa>();
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva(int diasReservados)
    {
        DiasReservados = diasReservados;
        
    }

    public void CadastrarHospodes (List<Pessoa> hospedes)
    {
        if(Suite.Capacidade <= 4)
        {
            pessoa.AddRange(hospedes);
        }
        else
        {
            throw new Exception("maxima capacidade");
        }
        
        

    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int OberQuantHospedes()
    {
        return pessoa.Count;
    }
    public decimal ValorDiaria()
    {
  
        decimal valorDiaria = Suite.ValorDiarias;

        if (DiasReservados >= 10)
        {
            
            valorDiaria -= valorDiaria * 0.10m;
        }

      
        return DiasReservados * valorDiaria;
    }
}

