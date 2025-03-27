using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia: ");
Smartphone nokiaG32 = new Nokia("42904", "Modelo G32", "236714", 32);
nokiaG32.Ligar();
nokiaG32.InstalarAplicativo("Netflix");

Console.WriteLine("------------------");

Console.WriteLine("Iphone: ");
Smartphone iphone7Pro = new Iphone("87123", "Modelo 7 Pro", "44402932", 64);
iphone7Pro.Ligar();
iphone7Pro.InstalarAplicativo("Linkedin");
