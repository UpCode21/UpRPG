using Islandia.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islandia.Personagens.Inimigos
{
    class Goblin : Personagem
    {
        public Goblin() {
            this.Vivo = true;
            this.Mana = 0;
            this.Vida = 30;
            this.Forca = 15;

            Console.WriteLine($"com {Vida} de vida.");
        }

    }
}
