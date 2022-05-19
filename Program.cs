﻿// Abaixo segue um exemplo de código que você pode ou não utilizar
using System;

namespace Introducao
{
    class Desafios
    {
        static void CoxinhaDeBueno(string[] args)
        {
            String[] line = Console.ReadLine().Split(" ");

            float A = Int32.Parse(line[0]);
            float B = Int32.Parse(line[1]);
            //TODO: Complete os espaços em branco com uma possível solução para o desafio        
            float total = (A / B);

            if (A % B != 0)
                Console.WriteLine(Math.Round(total, 2).ToString("0.00"));
            else
                Console.WriteLine(total.ToString("0.00"));
        }


        static void PROD(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PROD = " + (a * b)); //implemente o código que representa a multiplicação.
            Console.ReadLine();
        }

        static void Average(string[] args)
        {

            double a, b, c, d, avg;

            string[] values = Console.ReadLine().Split(' ');



            a = double.Parse(values[0]) * 2;

            b = double.Parse(values[1]) * 3;

            c = double.Parse(values[2]) * 4;

            d = double.Parse(values[3]) * 1;



            avg = (a + b + c + d) / 10;

            Console.WriteLine("Media: " + avg.ToString("0.0"));



            if (avg >= 7)
            {

                Console.WriteLine("Aluno aprovado.");

            }
            else if (avg < 5)
            {

                Console.WriteLine("Aluno reprovado.");

            }
            else if (avg >= 5 && avg <= 6.9)
            {

                double e = double.Parse(Console.ReadLine());

                Console.WriteLine("Aluno em exame.");

                Console.WriteLine("Nota do exame: " + e.ToString("0.0"));

                avg = (avg + e) / 2;



                if (avg >= 5)
                {

                    Console.WriteLine("Aluno aprovado.");

                }

                else
                {

                    Console.WriteLine("Aluno reprovado");

                }

                Console.WriteLine("Media final: " + avg.ToString("0.0"));

            }

            Console.ReadKey();

        }

        static void Multiplos(string[] args)
        {

            int suavariavel = int.Parse(Console.ReadLine());
            string[] n = Console.ReadLine().Split(' ');

            int multiplo2 = 0;
            int multiplo3 = 0;
            int multiplo4 = 0;
            int multiplo5 = 0;
            for (int iContador = 0; iContador < n.Length; iContador++)
            {
                if ((int.Parse(n[iContador]) % 2) == 0) { multiplo2++; }
                if ((int.Parse(n[iContador]) % 3) == 0) { multiplo3++; }
                if ((int.Parse(n[iContador]) % 4) == 0) { multiplo4++; }
                if ((int.Parse(n[iContador]) % 5) == 0) { multiplo5++; }
            }

            Console.WriteLine("{0} Multiplo(s) de 2", multiplo2);
            Console.WriteLine("{0} Multiplo(s) de 3", multiplo3);
            Console.WriteLine("{0} Multiplo(s) de 4", multiplo4);
            Console.WriteLine("{0} Multiplo(s) de 5", multiplo5);
        }

    }
}