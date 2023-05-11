using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("555-1234", "Tijolão", "123jj458", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSmartphone Iphone");
Iphone iphone = new Iphone("555-4321", "I12", "abc1234", 64);
iphone.Numero = "555-6666";
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");