using System.Runtime.InteropServices;

namespace Challenge1.dll{

    
        public static class Player{
            public static string nick,classe;
            public static int vida,dano;
            public static float precisao;
            public static void inicializar(string nome, string classes, int vida, int dano, float preci)
            {
                nick = nome;
                classe = classes;
            }
        }
        public static class NPC{
            public static string classe;
            public static int vida;
            public static float precisao; 
        }
        //public static void Dados(){
            // Player.nick = "";
            // Player.classe = "";
            // Player.classe ="";
            // Player.vida = 100;
            // Player.precisao = 0;
            // NPC.classe = "";
            // NPC.precisao = 0;
            // NPC.vida = 100;
        //
        //}   
    }
