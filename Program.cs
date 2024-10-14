using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo1", imei: "1234", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("jogos");

Console.WriteLine("\n");
Console.WriteLine($"numero: {nokia.Numero} , modelo: {nokia.Modelo}, imei:{nokia.Imei} , memoria:{nokia.Memoria}");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iPhone = new Nokia(numero: "123456", modelo: "Modelo1", imei: "1234", memoria: 64);
iPhone.Ligar();
iPhone.InstalarAplicativo("música");

Console.WriteLine("\n");
Console.WriteLine($"numero: {iPhone.Numero} , modelo: {iPhone.Modelo}, imei:{iPhone.Imei} , memoria:{iPhone.Memoria}");