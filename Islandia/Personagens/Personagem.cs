using Islandia.Classes;
using System;

namespace Islandia.Personagens
{
    class Personagem : Atacador
    {
        private bool _vivo;
        private int _vida;
        public bool Vivo 
        {
            get 
            {
                return _vivo;
            }
            set 
            { 
                if (value == false)
                {
                    Console.WriteLine($"{this.GetType().Name} morreu");
                }
                _vivo = value;
            } 
        }
        public int Forca { get; protected set; }
        public int Vida 
        {
            get
            {
                return _vida;
            }
            set 
            {
                if (value <= 0)
                {
                    Vivo = false;
                    _vida = 0;
                }
                else
                {
                    _vida = value;
                }
                
            } 
        }
        public int Mana { get; protected set; }

        public void golpe(Personagem atacado)
        {
            Console.Write($"{this.GetType().Name}");
            Console.Write($" está golpeando {atacado.GetType().Name}.");
            atacado.Vida = atacado.Vida - Forca;
            Console.Write($"{atacado.GetType().Name} está com {atacado.Vida} de vida.");
            
            Console.WriteLine();
        }

        public Personagem()
        {
            Console.Write($"{this.GetType().Name} foi criado ");
        }
    }
}
