Console.WriteLine("Bem vinda (o) ao palíndromo :)");
bool sequenciaJogo = true;


while(sequenciaJogo)
{
    Console.WriteLine("\nDigite uma palavra ou frase que seja palíndromo:");
    string textoaUsuario = Console.ReadLine();

    //Tratamento de string para auxiliar na validação do texto. Remover espaços e deixa o texto em minusculo
    string removerEspaco = textoaUsuario.Replace(" ", "").ToLower();

    //Criacao de uma funcao pra validar o texto
    if(ValidaTextoPalindromo(removerEspaco))
    {
        Console.WriteLine("\nVocê mandou bem, a palavra digitada é um palíndromo! :)");
    }
    else
    {
        Console.WriteLine("\nERRRROOOOU, a palavra digitada não é um palíndromo!");
        Console.WriteLine("Não desista, tente novamente!");
    }

    Console.WriteLine("\nDeseja tentar mais uma vez?");
    Console.WriteLine("1. Continuar Jogando");
    Console.WriteLine("Digite qualquer tecla para sair!");
    
    var resultadoEscolha = Console.ReadLine();

    if(resultadoEscolha != "1")
    {
        sequenciaJogo = false;
    }

}


bool ValidaTextoPalindromo(string texto)
{
    //pega o tamanho do texto
    int tamanhoTexto = texto.Length;

    //utilizacao do for para validar se a primeira letra é igual a ultima, se alguma das 
    //letras não forem iguais retorna false
    for (int i = 0; i < tamanhoTexto / 2; i++)
        {
            if (texto[i] != texto[tamanhoTexto - 1 - i])
            {
                return false;
            }
        }

    return true;
}

