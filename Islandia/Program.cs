using Islandia.Personagens;
using Islandia.Personagens.Inimigos;
using System;

namespace Islandia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Jogo jogo = new Jogo();
            Humano heroi = new Humano();
            Goblin goblin1 = new Goblin();

            jogo.listaPersonagens.Add(heroi);
            jogo.listaPersonagens.Add(goblin1);

            goblin1.golpe(heroi);
            heroi.golpe(goblin1);
            goblin1.golpe(heroi);
            heroi.golpe(goblin1);
            goblin1.golpe(heroi);
            heroi.golpe(goblin1);
            goblin1.golpe(heroi);
            heroi.golpe(goblin1);



            /*while (!jogo.fim)
            {

            }*/
        }
    }
}
