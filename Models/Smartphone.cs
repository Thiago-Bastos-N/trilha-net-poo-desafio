namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Propriedade pública
        public string Numero { get; set; }

        // Propriedades privadas
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        // Construtor
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Métodos existentes
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato
        public abstract void InstalarAplicativo(string nomeApp);
    }
}