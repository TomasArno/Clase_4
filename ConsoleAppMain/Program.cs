using MyLibrary;

namespace ConsoleAppMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int conver1 = 0;

            Sumador mySumador1 = new();

            long resultadoLong = mySumador1.Sumar(1, 1);
            Console.WriteLine(resultadoLong);

            string resultadoStr = mySumador1.Sumar("12", " hola");
            Console.WriteLine(resultadoStr);

            conver1 = (int)mySumador1;
            Console.WriteLine(conver1);

            Sumador mySumador2 = new Sumador(5);

            long resultadoSuma = mySumador1 + mySumador2;
            Console.WriteLine(resultadoSuma);

            bool resultadoOr = mySumador1 | mySumador2;
            Console.WriteLine(resultadoOr);


        }
    }
}