namespace DesafioPOO.Models
{
    // IMPLEMENTADO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {
        }

        // IMPLEMENTADO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Aplicativo "  + nomeApp+" instalado no Iphone");
        }
    }
}