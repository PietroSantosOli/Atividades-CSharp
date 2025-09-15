using RPG;

class Programa
{
    static void Main(string[] args)
    {
        Personagem heroi = new Personagem("Arthorias", 100, 20, "Guerreiro");
        Monstro monstro = new Monstro("Manus", 200, 20, "Pai do Abismo");

        Batalha batalha = new Batalha();
        batalha.Iniciar(heroi, monstro);


        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();

    }
}