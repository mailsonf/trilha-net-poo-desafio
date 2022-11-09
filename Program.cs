using System.Globalization;
using System.Reflection;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");


Console.WriteLine("Smartphone iphone");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", imei: "222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");


