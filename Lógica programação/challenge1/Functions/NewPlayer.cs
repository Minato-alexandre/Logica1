using System.Security.Cryptography.X509Certificates;

namespace Challenge{

    public static class NewPlayer{
        public static string nick,playerClasse="", playerBarbaro="barbaro",playerGuerreiro="guerreiro", playerAssassino="assassino";
        public static int vidaBonusClasse,dano,vidaPlayer;
        public static float precisaoPlayer; 
        public static void Dados(){ 
            Console.WriteLine("Digite um nome para o seu personagem!");
            nick = Console.ReadLine();
            Console.WriteLine("Agora vamos escolher a sua classe!");
            playerClasse = Console.ReadLine();
            playerClasse.ToLower();

            while(playerClasse != playerBarbaro && playerClasse != playerGuerreiro && playerClasse != playerAssassino){
                Console.WriteLine("Classe inválida! Digite novamente: ");
                playerClasse = Console.ReadLine();
                playerClasse.ToLower();
            }

            if(playerClasse == playerBarbaro){
                vidaBonusClasse = 30;
                precisaoPlayer = .4f;
                dano = 1;
            }    
            if (playerClasse == playerAssassino){
                vidaBonusClasse = 10;
                precisaoPlayer = .8f;
                dano = 1;                
            }
            if (playerClasse == playerGuerreiro){
                vidaBonusClasse = 20;
                precisaoPlayer = .6f;
                dano = 1;                
            }
            vidaPlayer = 100+vidaBonusClasse;
            Console.WriteLine($"Seja bem vindo ao Challenge1\n{nick}\nVIDA: {vidaPlayer}\nPrecisao: {precisaoPlayer}\n\n");



        }
    }

}