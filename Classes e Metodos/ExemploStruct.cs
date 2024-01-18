using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_e_Metodos
{
    interface Ponto
    {
        void MoverNaDiagonal(int delta);
    }
    struct Coordenada: Ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }
    }
    internal class ExemploStruct{
        public static void Executar(){
            Coordenada cordenadaInicial;
            cordenadaInicial.X = 2;
            cordenadaInicial.Y = 2;

            Console.WriteLine("Coordenada Inicial:");
            Console.WriteLine("X ={0}", cordenadaInicial.X);
            Console.WriteLine("Y ={0}", cordenadaInicial.Y);

            var cordenadaFinal = new Coordenada(x: 9, y: 1);
            cordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Inicial:");
            Console.WriteLine("X ={0}", cordenadaFinal.X);
            Console.WriteLine("Y ={0}", cordenadaFinal.Y);


        }
    }
}
