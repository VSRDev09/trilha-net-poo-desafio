namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia (string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria){

        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
             Console.WriteLine("Qual app deseja instalar?");
            nomeApp = Console.ReadLine();
            Console.WriteLine($"Instalando {nomeApp} no Nokia...");
        }
    }
}