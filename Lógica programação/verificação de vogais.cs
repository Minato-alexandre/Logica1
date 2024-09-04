string txt_usuario,minusculo;

int vogais = 0;
int tamanho;

Console.Write("Insira uma palavra: ");
txt_usuario = Console.ReadLine();

minusculo = txt_usuario.ToLower();
tamanho = minusculo.Length;

//Console.WriteLine(minusculo);

for (int i=0; i<tamanho; i++){
    switch(txt_usuario[i]){
        case 'a':
            vogais++;
            break;
        case 'e':
            vogais++;
            break;
        case 'i':
            vogais++;
            break;
        case 'o':
            vogais++;
            break;
        case 'u':
            vogais++;
            break;
    }
}
Console.WriteLine("Quantidade de vogais na palavra ' "+txt_usuario+" ' é: "+vogais);
