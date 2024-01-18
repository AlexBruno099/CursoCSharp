using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
     class OperadoresRelacionais{
        public static void Executar(){
            //double nota = 6.0;
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota); // você inserindo este comando vai estar solicitando que você insira sua nota e ele vai estar mostrando o resultado do "boletim"
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota invalida? {0}", nota > 10.0); // maior que = resultado
            Console.WriteLine("Nota invalida? {0}", nota < 0.00); // menor que = resultado
            Console.WriteLine("Perfeito? {0}", nota == 10.0); // igual que = resultado
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0); // diferente que = resultado
            Console.WriteLine("Passou por media? {0}", nota >= notaDeCorte); // maior ou igual que = resultado
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte); // menor que = resultado
            Console.WriteLine("Reprovado {0}", nota <= 3.0); // menor ou igual que = resultado
            

        }
    }
}
