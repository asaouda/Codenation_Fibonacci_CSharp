using System;
using System.Collections.Generic;

namespace Codenation.Challenge
{
    public class Math
    {
        public List<int> Fibonacci()
        {
            var numeros=new List<int>();
            int numeroFibonacci=0;
            
            while (numeroFibonacci <= 350)
            {
                if (numeroFibonacci == 0)
                {
                    numeros.Add(0);
                    numeros.Add(1);
                }
                else
                {
                    int soma;
                    soma = numeros[(numeros.Count - 1)] + numeros[(numeros.Count - 2)];
                    if (soma <= 350)
                    {
                        numeros.Add(soma);
                    }
                    else if (soma > 350)
                    {
                        break;
                    }   
                }
                numeroFibonacci = numeros[numeros.Count-1];
            }
            return numeros;
        }

        public bool IsFibonacci(int numberToTest)
        {
            List<int> fibonacci = Fibonacci();
            foreach (int numero in fibonacci)
            {
                if (numero == numberToTest)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
