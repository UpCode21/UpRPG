using Islandia.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islandia.Personagens
{
    class Humano : Personagem
    {
        public Humano()
        {
            Vivo = true;
            Mana = 0;
            Vida = 50;
            Forca = 25;

            Console.WriteLine($"com {Vida} de vida.");
        }
    }
}
