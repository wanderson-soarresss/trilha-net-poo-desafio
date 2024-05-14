using DesafioPOO.Models;




Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero:"9999-000", modelo:"Nokia", iMEI:"1",memoria:20);
nokia.Ligar();
nokia.InstalarAplicativo("\"facebook\"");
Console.WriteLine("\n");


Console.WriteLine("Smatphone Iphone:");
Iphone iphone= new Iphone(numero:"8888-000", modelo:"Iphone 15", iMEI:"2",memoria:64);
iphone.Ligar();
iphone.ReceberLigacao();    
iphone.InstalarAplicativo("\"Instagram\"");
