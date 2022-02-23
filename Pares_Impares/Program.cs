using System;

namespace Pares_Impares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, somaPar = 0, somaImpar = 0, i;
            int par = 0;
            int impar = 0;

            Console.WriteLine("Digite um varios numeros inteiros e positivos!");
            numero = int.Parse(Console.ReadLine());


            for (i = 0; numero <= 1000; i++)
            {
               
                if (numero % 2 == 0)
                {
                    par = numero;
                    somaPar = somaPar + par;
                    
                }   
                else
                {
                    impar = numero;
                    somaImpar = somaImpar + impar;
                    
                }
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("A soma dos numeros pares e: {0} ", somaPar);
            Console.WriteLine("A soma dos numeros impares e: {0} ", somaImpar);
        }   
    }
}
