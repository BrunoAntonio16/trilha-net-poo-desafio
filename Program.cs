using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "965473887", modelo: "NokiaK7", imei: "84324324252", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "964354632", modelo: "IphoneNG", imei: "1973285282", memoria: 120);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");