string password = "samurai";
string retorno = string.Empty;

if ( password.Length < 10 )
{
    retorno = @"Sua senha é muito curta.    
                Use ao menos 10 caracteres";// o @ permite continuar a sequencia da linha
}
else if ( password.Length > 15)
{
    retorno = @"Sua senha é muito grande.    
                Use ao menos 10 e 15 caracteres";// o @ permite continuar a sequencia da linha
}
else 
{
    retorno = @"Sua senha está de acordo.";
}

Console.WriteLine(retorno);


// Chcagem de valor e tipo
/*
    Em java scrit podemos azer assim:
    var a = "1"; string
    let b = 1; numerico
    (a == b) retornará true / faz uma checagem de valor
    (a === b) retornara false /faz uma checagem de tipo
*/
object o = 3; //object é um tipo raiz, tudo é filho de object int,string
int j = 4;
if (o is int i)
{
    Console.WriteLine($"{i} x {j} = {i * j}");//concaquetei o valor de i dentro da string - i * j expressão aritmetica
}
else
{
    Console.WriteLine(@"o não é um inteiro, portanto
                        não é possível multiplicar");
}

//Comando switch
//Metodo é a especificação de uma função next é uma função

int number = Random.Shared.Next(1,7); //numero aleatorio de 1 a 7
Console.WriteLine($"Meu número aleatório é {number}");
switch(number)//
{
    case 1:
        Console.WriteLine("Um");
        break;
    case 2:
        Console.WriteLine("Dois");
        break;
    case 3:
    case 4:
        Console.WriteLine("Três ou Quatro");
        goto case 1;
    case 5:
        goto A_label; //vá para a linha A_label
    default: //default no case é que nem o else
        Console.WriteLine("Default");
        break;
}

Console.WriteLine("Depois do fim do switch");

A_label:
Console.WriteLine("Depois de A_label");


