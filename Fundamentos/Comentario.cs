using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class Comentario
    {
        public static void Executar()
        {
            Console.WriteLine("Primeiro comentario seria o // que seria em somente uma linha ");
            // Exemplo seria desta maneira

            Console.WriteLine("Segundo comentario seria o comentario estilo cabeçalho ///*");
            ///* 
            /// O Segundo exemplo seria desta maneira
            ///*
            
            Console.WriteLine("Terceiro seria o comentario em varias linhas /*");
            /*
             * exemplo deste jeito 
             */ 
            Console.ReadLine();
        }
    }
}