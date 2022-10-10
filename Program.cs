using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456789", "Modelo 1", "123123123", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\nSmartphone Iphone:");
Smartphone iphone = new Iphone("123456789", "Modelo 1", "123123123", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");