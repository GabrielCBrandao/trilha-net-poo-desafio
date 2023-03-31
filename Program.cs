using DesafioPOO.Models;

System.Console.WriteLine("Smartphone: Nokia");
Nokia n1 = new Nokia("(21)99887563", "gt4566","111111",32);
n1.Ligar();
n1.InstalarAplicativo("Whatsapp");

Thread.Sleep(2000);
System.Console.WriteLine("................................Mudando de celular..............................");
Thread.Sleep(2000);

System.Console.WriteLine("\n");
System.Console.WriteLine("Smartphone: Iphone");
Iphone i1= new Iphone("(21)99887563","10","111111",128);
i1.Ligar();
i1.InstalarAplicativo("Play Store");


// TODO: Realizar os testes com as classes Nokia e Iphone