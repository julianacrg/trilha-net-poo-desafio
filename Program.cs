using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokiaX = new Nokia("123456", "Modelo x", "1111111", 64);
nokiaX.Ligar();
nokiaX.InstalarAplicativo("Whatsapp");

Console.WriteLine("\nSmartphone Iphone:");
Smartphone iphoneY = new Nokia("654987", "Modelo Y", "22222", 128);
nokiaX.ReceberLigacao();
nokiaX.InstalarAplicativo("Telegram");