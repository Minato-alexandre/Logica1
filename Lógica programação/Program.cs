string cripto,minusculo;

int cont;


//criptografia
Console.WriteLine("Digite a mensagem criptografada: ");
cripto = Console.ReadLine();

minusculo = cripto.ToLower();
cont = minusculo.Length;

for (int i = 0; i<cont; i++)
    switch(cripto[i]){
        case "u":
        cripto[i] = Console.ReadLine();
        case "e":
        cripto[i] = Console.ReadLine();
        case "z":
        cripto[i] = Console.ReadLine();
        case "n":
        cripto[i] = Console.ReadLine();
        case "c":
        cripto[i] = Console.ReadLine();
        case "s":
        cripto[i] = Console.ReadLine();
        case "m":
        cripto[i] = Console.ReadLine();
        case "r":
        cripto[i] = Console.ReadLine();
        case "t":
        cripto[i] = Console.ReadLine();
        case "v":
        cripto[i] = Console.ReadLine();
        case "i":
        cripto[i] = Console.ReadLine();
               
    }
Console.WriteLine("mensagem: "+cripto);
