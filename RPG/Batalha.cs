namespace RPG
{
    public class Batalha
    {
        public void Iniciar(Personagem heroi, Monstro monstro)
        {
            Console.WriteLine($"Uma batalha começa: {heroi.Nome} vs {monstro.Nome} ({monstro.Tipo})");

            while (heroi.EstaVivo() && monstro.EstaVivo())
            {
                    //turno do heroi
                    Console.WriteLine("Escolha uma opcao 1- Atacar 2-Curar");
                    string opcao = Console.ReadLine();
                    if (opcao == "1")
                    {
                        heroi.Atacar(monstro);
                        Console.WriteLine($"O {monstro.Nome} está com {monstro.PontosDeVida} pontos de vida");
                    }
                    else if(opcao == "2") 
                    {
                        heroi.Curar();
                        Console.WriteLine($"O {heroi.Nome} está com {heroi.PontosDeVida} pontos de vida");
                    }
                    else
                    {
                        Console.WriteLine("Opcao inválida!");
                    }
                    if (!monstro.EstaVivo())
                    {
                        break;
                    }

                    //turno do monstro
                    Console.WriteLine($"{monstro.Nome} contra-ataca!");
                    monstro.Atacar(heroi);
                    Console.WriteLine($"O {heroi.Nome} está com {heroi.PontosDeVida} pontos de vida");
            }
        }
    }
}
