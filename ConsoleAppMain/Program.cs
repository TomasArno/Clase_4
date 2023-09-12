using MyLibrary;

namespace ConsoleAppMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int conver1 = 0;
            int conver2 = 0;

            Sumador mySumador1 = new();
            Sumador mySumador2 = new Sumador(5);

            long resultadoLong = mySumador1.Sumar(1, 1);
            Console.WriteLine(resultadoLong);

            string resultadoStr = mySumador1.Sumar("12", " hola");
            Console.WriteLine(resultadoStr);

            conver1 = (int)mySumador1;
            conver2 = (int)mySumador2;

            Console.WriteLine(conver1);
            Console.WriteLine(conver2);

        }
    }
}