
//Operadores Unários
/*
using FluxoTiposExceptions.Classes;

int x = 5;
int IncrementoPosFixado = x++; //incremento 5+resultado 5+1 = 6 - x=x+1 
IncrementoPosFixado++; //incremento 1
x++; x = x + 1;
int IncrementoPreFixado = ++x;
Console.WriteLine ($"PosFixado: {IncrementoPosFixado}");
Console.WriteLine($"PreFixado: {IncrementoPreFixado}");

//Como obter o tipo de uma variavel
Type TipoDeInteiro = typeof(int);
Type TipoDeX = x.GetType(); //controla o fluxo conforme for o tipo de variavel X

//Como obter o nome de uma variável
string NomeDaVariavel = nameof (x);
int QuantosBytes = sizeof (int); // quantos bytes consome uma variavel tipo inteiro

Console.WriteLine( "Nome da var: " + NomeDaVariavel);

//Operadores de Atribuição
int p = 6;
p +=3; //equivalente a p=p+3
Console.WriteLine( $"+={p}");

p -=3; // euivalente a p=p-3
Console.WriteLine( $"-={p}");

p *=3; // equivalente a p=p*3
Console.WriteLine( $"*={p}");

p /=3; // equivalente a p=p/3
Console.WriteLine( $"/={p}");

//Operadores Lógicos $ serve para fazer uma interpolação ou concatenar uma string
//{}delimitam escopo
//()função = o que vai executar
bool a = true;
bool b = false;
WriteLine( $"AND    | a     | b    ");
WriteLine( $"a      | {a & a, -5} | {a & b, -5}");
WriteLine( $"b      | {b & a, -5} | {b & b, -5}");
WriteLine();//linha vazia
WriteLine( $"OR     | a     | b    ");
WriteLine( $"a      | {a | a, -5} | {a | b, -5}");
WriteLine( $"a      | {b | a, -5} | {b | b, -5}");
WriteLine();
WriteLine( $"XOR    | a     | b    "); // or negado
WriteLine( $"a      | {a ^ a, -5} | {a ^ b, -5}");
WriteLine( $"a      | {b ^ a, -5} | {b ^ b, -5}");
WriteLine();//linha vazia
static bool FacaAlgo()
{
    WriteLine("Fazendo Alguma Coisa");
    return true;
}
WriteLine();//linha vazia
WriteLine( $"a & FacaAlgo() = {a & FacaAlgo()}");
WriteLine( $"b & FacaAlgo() = {b & FacaAlgo()}");

//--------------
*/
using FluxoTiposExceptions.Classes;

Animal [] animals = new Animal []// ctrl+. atribui a class animal a fluxotiposexceptions
{
    new Cat 
        {
            Name = "Garfield"
            , Born = new (year:2022, month: 8, day: 23)
            , Legs = 4
            , IsDomestic = true
        },
    new Animal
        {
            Name = "Eu mesmo"
            , Born = new(year: 1993, month: 9, day:  14)
            , Legs = 2
        },
    new Cat 
        {
            Name = "Mimi"
            , Born = new (year:1994, month: 6, day: 12)
            , Legs = 4
            , IsDomestic = true
        },
    new Spider
        {
            Name = "Peter Parker"
            , Born = DateTime.Today
            , Legs = 8
            , IsPoisonous = true
        },
    new Spider
        {
            Name = "Eddie Brock"
            , Born = DateTime.Today
            , Legs = 8
            , IsPoisonous = false
        },
};

// Laços de repetição
// 3 tipos de variáveis para ontrole de repetição
// 1: Flag - bandeirinha, booleano que indica de para ou continua
// 2: Counter - contador, conta quantas vezes a repetção ocorreu
// 3: Acumulador - Permite acumular valores a cada repetição

// Laço For

for (int i = 0; i < animals.Length; i++) //lenght é o atributo que diz o tamanho dele-
{
    string message = string.Empty;
    if(animals [i] != null )
        {
            message = $"Nome: {animals[i].Name} "; //o colchetes faz acessar a caixinha do vetor que é a I
            message += $"Data Nasc: {animals[i].Born.ToShortDateString()}"; //+= acumulador pra texto
            Console.WriteLine(message);
        }
}

/*

// Laço de repetição para cada
Console.WriteLine("\n---FOREACH---\n");
foreach(Animal animal in animals)
{
    string message = string.Empty;
    if(animal != null )
        {
            message = $"Nome: {animal.Name} "; //o colchetes faz acessar a caixinha do vetor que é a I
        }
    Console.WriteLine(message);
}

//
*/
