using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class Personagem
    {
        public enum Cores
        {
            Azul,
            Castanho,
            Verde,
            Louro,
            Preto
        }
        public Cores olhos;
        public Cores cabelo;
        public bool homem;
        public int level;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Personagem> listaDeDados = new List<Personagem>();

            int level = 1;
            while (level >= 0)
            {
                Personagem cobaia = new Personagem();
                string sexo =  Console.ReadLine();
                cobaia.homem = (sexo == "m");
                cobaia.olhos = Personagem.Cores.Azul;
                listaDeDados.Add(cobaia);
            }

        }
    }
}
