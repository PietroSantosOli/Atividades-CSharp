using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public abstract class Entidade
    {
        public string Nome { get; set; }
        public int PontosDeVida { get; set; }
        public int Ataque { get; set; }

        public Entidade(string nome, int pontosDeVida, int ataque)
        {
            Nome = nome;
            PontosDeVida = pontosDeVida;
            Ataque = ataque;
        }
        public virtual void Atacar(Entidade alvo)
        {
            int dano = Ataque;
            alvo.ReceberDano(dano);
            Console.WriteLine($"{Nome} atacou {alvo.Nome} e causou {dano} de dano!");
        }
        public virtual void ReceberDano(int dano)
        {
            PontosDeVida = Math.Max(0, PontosDeVida - dano);
            Console.WriteLine($"{Nome} agora tem {PontosDeVida} HP.");
        }
        public bool EstaVivo() => PontosDeVida > 0;
    }
}
