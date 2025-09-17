using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Personagem : Entidade
    {
        public string Classe { get; set; }
        public Personagem(string nome, int pontosDeVida, int ataque , string classe) : base(nome, pontosDeVida, ataque)
        {
            Classe = classe;
        }
        public void Curar()
        {
            int cura = 20; 
            PontosDeVida += cura;
            Console.WriteLine($"{Nome} usou Cura e recuperou {cura} pontos de vida! (HP: {PontosDeVida})");
        }

    }
}
