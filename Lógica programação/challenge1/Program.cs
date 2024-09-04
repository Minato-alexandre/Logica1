using System;
using Challenge1;
namespace Challenge{
            class Program{
            public static void Main(){
                Console.WriteLine("Vamos criar o seu oponente!");
                NewNpc.Dados();
                Console.WriteLine("Vamos criar agora o seu personagem!");
                NewPlayer.Dados();
                Armas.Info();
                Combat.IniciarCombate();
        }            
        

    }
}
