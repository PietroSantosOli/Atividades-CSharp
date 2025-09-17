using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Monstro : Entidade 
    {
        public string Tipo { get; set; }
        public Monstro(string nome, int pontosDeVida, int ataque, string tipo) : base(nome, pontosDeVida, ataque)
        {
            Tipo = tipo;
        }
        public override void ReceberDano(int dano)
        {
            base.ReceberDano(dano);
            if (EstaVivo())
                Console.WriteLine($"{Nome} rosna com raiva!");
            else
                Console.WriteLine($"{Nome} foi derrotado!");
        }
    }
}
