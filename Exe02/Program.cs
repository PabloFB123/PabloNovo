Console.WriteLine("Olá, seja bem-vindo!");
Console.WriteLine("Qual é o seu nome?");
string name = Console.ReadLine();
Console.WriteLine($"Olá {name} prazer conhece-lo.");

//Declarar sem inicializar / primitivo
string message1;
//Declarar inicializado / abstrato
String message2 = "Seu Nome Completo";
//Declarar string vazia
string message3 = String.Empty;
string message4 = "";

//Declaração com tipo implícito
var message5 = "Mensagem Aleatória";

message1 = "Rogerio Ceni;Pele;The Rock;Roberto Carlos";
var palavras = message1.Split(';');//passando um argumento que é o caracter ; denominado aspas simples - se fosse caractere aspas duplas - faz a quebra de segmentos das linhas
foreach(var word in palavras)//insere um laço de repetição a cada item que o split quebrou - para cada variavel que tiver dentro dessa coleção repita 
{
    // Variavel de escopo local do laço de repetição foreach
 int a = 10;
 Console.WriteLine(word);
}
