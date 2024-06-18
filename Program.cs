using DesafioPOO.Models;

System.Console.WriteLine("Criando celular Nokia:");

Smartphone n1 = new Nokia(numero: "61982101717", modelo: "Galaxy", imei: "ASD568D", memoria: 128);

n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo($"Google Maps");
System.Console.WriteLine("");

System.Console.WriteLine("Criando celular Iphone:");

Smartphone i1 = new Iphone(numero: "61982101717", modelo: "Galaxy", imei: "ASD568D", memoria: 128);

i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Google Maps");