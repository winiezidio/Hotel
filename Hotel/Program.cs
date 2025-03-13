
using System.Globalization;
using System.Runtime.CompilerServices;
using Hotel.Models;

List<Pessoa> hospede = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Winicius", sobrenome: "ezidio");
Pessoa p2 = new Pessoa(nome: "keila", sobrenome: "ezidio");


hospede.Add(p1);
hospede.Add(p2);

Suite suite = new Suite(tipoSuite: "Luxo", 1,1000);

Reserva reserva = new Reserva(10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospodes(hospede);

Console.WriteLine($"Hospedes:  {reserva.OberQuantHospedes()}");
Console.WriteLine($"Valor da Diaria: {reserva.ValorDiaria().ToString("f2",CultureInfo.InvariantCulture)}");