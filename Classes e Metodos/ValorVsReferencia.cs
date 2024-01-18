﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_e_Metodos
{
    public class Dependente
    {
        public string Nome; // Referência
        public int Idade; // Valor
    }
    internal class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente
            {
                Nome = "Beto",
                Idade = 20

            };
            Dependente copiaDep = dep;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            copiaDep.Nome = "Renato";
            copiaDep.Idade = 21;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

        }
    }
}