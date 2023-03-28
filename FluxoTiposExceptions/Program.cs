
//Operadores Unários

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



