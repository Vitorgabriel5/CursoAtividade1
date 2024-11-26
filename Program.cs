using System.Globalization;
namespace Curso2 {
    internal class Program {
        static void Main(string[] args) {

            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            r.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area: "+ r.Area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: "+ r.Perimetro().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: "+ r.Diagonal().ToString("F2",CultureInfo.InvariantCulture));
          
        }
    }
}