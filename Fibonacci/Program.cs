using System;

namespace Fibonacci
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        //Serie Fibonacci
        public static int SerieFibonacci(int numero)
        {
            int valorPrevio = 0;
            int valorRecurrente = 0;

            for(int i = 0; i <= numero; i++)
            {
                int valor = valorPrevio;
                valorPrevio = valorRecurrente;
                valorRecurrente = i == 1 ? 1 : (valor + valorPrevio);
            }

            return valorRecurrente;
        }

    }
}
