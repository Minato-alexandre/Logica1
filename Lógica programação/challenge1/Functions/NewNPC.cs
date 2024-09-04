using System.Security.Cryptography.X509Certificates;

namespace Challenge{

    public static class NewNpc{
            public static int vidaBonusClasse,dano,danoBonusDeClasse,vida;
            public static float precisao, evasao;
            public static string nick,npcClasse="",confirma2="nao",armaNPC="";
            public static bool confirma = false,valclasse=true;
            public static string npcbarbaro = "barbaro", npcassassino = "assassino", npcguerreiro = "guerreiro";
        public static void Dados(){            
            Console.WriteLine("Vamos começar escolhendo o seu >>adversário!!<<\n Vamos primeiro escolher sua classe! \nGuerreiro velocidade moderada e tem precisão baixa, mas causam dano considerável\n Assassino, são ageis e precisos porém não causam muito dano.\n Bárbaro são lentos e com baixa precisão, porém causam muito dano!\nEscolha: ");
            npcClasse = Console.ReadLine();
            npcClasse.ToLower();
            while(npcClasse != npcbarbaro && npcClasse != npcguerreiro && npcClasse != npcassassino){
                Console.WriteLine("Classe inválida! Digite novamente: ");
                npcClasse = Console.ReadLine();
                npcClasse.ToLower();
                }
            if(npcClasse == npcbarbaro){
                vidaBonusClasse = 30;
                precisao = .4f;
                dano = 1;
            }    
            if (npcClasse == npcassassino){
                vidaBonusClasse = 10;
                precisao = .8f;
                dano = 1;                
            }
            if (npcClasse == npcguerreiro){
                vidaBonusClasse = 20;
                precisao = .6f;
                dano = 1;                
            }
        vida = vidaBonusClasse+vida;
        Console.WriteLine($"status adversário escolhido:\nClasse\t\t|Dano\tPrecisão  Vida\n{npcClasse}\t|{dano}\t|{precisao}\t  |{vida} \n\n");
        Console.WriteLine($"A arma do adversário é escolhida de forma aleatória!\n\n");



        }
     }
}
