using DesafioPOO.Models;

// TODO: Realizar os testescom as classes Nokia e Iphone 
Iphone ProMax = new Iphone ("81610850", "666", "777", 256);
Nokia VSRjr = new Nokia ("82237368", "222", "111", 1024);

ProMax.Ligar();
VSRjr.ReceberLigacao();
ProMax.InstalarAplicativo("Whatsapp");
VSRjr.InstalarAplicativo("Telegram");
