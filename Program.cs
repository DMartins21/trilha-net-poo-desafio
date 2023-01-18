using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new("1234567", "modelo 1", "11111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new("7654321", "modelo X", "22222222", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();