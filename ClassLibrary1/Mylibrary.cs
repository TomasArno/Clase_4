using System.Runtime.CompilerServices;

namespace MyLibrary
{
    public class Sumador
    {
        int _cantidadSumas;
        public Sumador():this(0)
        {
        }
        public Sumador(int cantidadSumas)
        {
            this._cantidadSumas=cantidadSumas;
        }

        public long Sumar(long num1, long num2)
        {
            this._cantidadSumas++;
            return num1 + num2;
        }

        public string Sumar(string text1, string text2)
        {
            this._cantidadSumas++;
            return text1 + text2;
        }

        public static explicit operator int(Sumador sumador)
        {
            return sumador._cantidadSumas;
        }

        public static long operator +(Sumador miSumador1, Sumador miSumador2)
        {
            return (int)miSumador1 + (int)miSumador2;
        }

        public static bool operator |(Sumador miSumador1, Sumador miSumador2)
        {
            return (int)miSumador1 == (int)miSumador2;
        }
    }
}