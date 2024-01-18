using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CursoCSharp.Fundamentos
{


    public class Variaveis
    {
        public static void Executar()
        {

            double raio = 3.1;
            const double PI = 1.5;


            double area = PI * raio * raio;

            Console.WriteLine("area");
            Console.WriteLine("a area é " + area);

            // Tipos internos

            bool estachovendo = true;
            Console.WriteLine("Está Chovendo? " + estachovendo);

            byte idade = 45;
            Console.WriteLine("Quantos anos você tem? " + idade);

            sbyte saldodegols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols" + saldodegols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);

            int menor = int.MinValue; //Mais usado dos inteiros
            Console.WriteLine("menor int " + menor);

            uint brasileiros = 207_600_000;
            Console.WriteLine("População de Brasileiros " + brasileiros);

            long menorvalorlong = long.MinValue;
            Console.WriteLine("Menor Valor Long " + menorvalorlong);

            ulong populacaomundial = 7_600_00_000;
            Console.WriteLine("População Mundial " + populacaomundial);

            float precoComputador = 1299.99F;
            Console.WriteLine("O Preço do Computador é " + precoComputador);

            decimal Distancia = decimal.MaxValue;
            Console.WriteLine("Distancia " + Distancia);

            char Letra = 'B';
            Console.WriteLine("Letra " + Letra);

            string texto = "Seja bem vindo ao curso de CSharp";
            Console.WriteLine(texto);
            Console.ReadLine();
        }
    }
}
