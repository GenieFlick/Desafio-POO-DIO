using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("37998236635", "4", "2313131", 64);
Iphone iphone = new Iphone("31998236535", "8", "3213131", 128);


Console.WriteLine("------------Testando Nokia------------");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");


Console.WriteLine("------------Testando Iphone------------");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("FaceBook");
