using System;

namespace NumeralRomano.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumeralRomanoConversor.InteiroParaRomano(1999));
            Console.WriteLine(NumeralRomanoConversor.InteiroParaRomano(2));
            Console.WriteLine(NumeralRomanoConversor.InteiroParaRomano(3));
            Console.WriteLine(NumeralRomanoConversor.InteiroParaRomano(4));
            Console.WriteLine(NumeralRomanoConversor.InteiroParaRomano(5));
            Console.WriteLine(NumeralRomanoConversor.InteiroParaRomano(6));
            Console.WriteLine(NumeralRomanoConversor.InteiroParaRomano(7));
            Console.WriteLine(NumeralRomanoConversor.InteiroParaRomano(8));
            Console.WriteLine(NumeralRomanoConversor.InteiroParaRomano(9));
            Console.WriteLine(NumeralRomanoConversor.InteiroParaRomano(10));
            Console.WriteLine(NumeralRomanoConversor.InteiroParaRomano(20));
            Console.WriteLine(NumeralRomanoConversor.InteiroParaRomano(30));
            Console.WriteLine(NumeralRomanoConversor.InteiroParaRomano(40));
            Console.WriteLine(NumeralRomanoConversor.InteiroParaRomano(50));
            Console.ReadKey();
        }
    }
}
