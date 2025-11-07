using System;
using System.Linq;
using System.Collections.Generic;

namespace ExpresionesLambdaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lista de números de ejemplo
            List<int> numeros = new List<int> { 1, 5, 8, 10, 3, 7, 2, 9, 4, 6 };

            // 1️ Expresión lambda simple: filtrar números mayores que 5
            var mayoresQueCinco = numeros.Where(n => n > 5);

            Console.WriteLine("Números mayores que 5:");
            foreach (var n in mayoresQueCinco)
                Console.Write($"{n} ");

            Console.WriteLine("\n");

            // 2️ Expresión lambda con Func: calcular si un número es par
            Func<int, bool> esPar = x => x % 2 == 0;

            Console.WriteLine("Números pares:");
            foreach (var n in numeros.Where(esPar))
                Console.Write($"{n} ");

            Console.WriteLine("\n");

            // 3️ Expresión lambda para ordenar y transformar
            var cuadradosOrdenados = numeros
                .OrderBy(n => n)
                .Select(n => n * n);

            Console.WriteLine("Cuadrados de los números ordenados:");
            foreach (var c in cuadradosOrdenados)
                Console.Write($"{c} ");

            Console.WriteLine("\n");

            // 4️ Expresión lambda compleja: contar los números mayores a su índice * 2
            int contador = numeros
                .Where((valor, indice) => valor > indice * 2)
                .Count();

            Console.WriteLine($"Cantidad de números mayores a su índice * 2: {contador}");
        }
    }
}
