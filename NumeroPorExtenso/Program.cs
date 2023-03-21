using NumeroPorExtenso;

Console.WriteLine("**********************************");
Console.WriteLine("Escrever Número Por Extenso");
Console.WriteLine("**********************************");

Console.WriteLine("Informe um Número Inteiro:");//quer dizer um objeto e write line um metodo escrever linha - escreva um objeto entre parenteses - entre""string
string numero = Console.ReadLine();

int nro;
try //bloco try = tratamento de erros
{
    nro = Convert.ToInt32(numero);
} 
catch 
{
        Console.WriteLine("O número não é válido");
        return;
}

string retorno = "";
switch(numero.Length) //if e switch=if toda vez checa e no switch ele é pre-processado - numero de caracteres que o usuario digitou
{
    case 1 :  // o lenght contou que tem 1 então é unidade
        Unidade unidade = new Unidade();//cria uma variavel unidade dentro do arquivo 
        retorno = unidade.UnidadePorEstenso(nro);
    break;

    case 2:
        Dezena dezena = new Dezena();
        retorno = dezena.DezenaPorExtenso(nro);
    break;
}
Console.WriteLine(retorno);
