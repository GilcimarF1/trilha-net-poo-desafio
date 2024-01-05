using System;
using DesafioPOO.Models;

class Program
{
  static void Main(string[] args)
  {
    // Nokia
    Nokia nokia = new Nokia("923568982", "Nokia ModeloTIJOLO", "IMEI555", 64);
    nokia.Ligar();
    nokia.ReceberLigacao();
    nokia.InstalarAplicativo("WhatsApp");

    Console.WriteLine();

    // Iphone
    Iphone iphone = new Iphone("965983265", "iPhone ModeloSEDA", "IMEI666", 128);
    iphone.Ligar();
    iphone.ReceberLigacao();
    iphone.InstalarAplicativo("Telegram");

    Console.ReadLine();
  }
}
