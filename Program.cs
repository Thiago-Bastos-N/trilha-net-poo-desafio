using DesafioPOO.Models;

// Instanciando e testando a classe Nokia
var nokia = new Nokia("123456789", "ModeloNokia", "IMEINokia", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

// Instanciando e testando a classe Iphone
var iphone = new Iphone("987654321", "ModeloIphone", "IMEIIphone", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
