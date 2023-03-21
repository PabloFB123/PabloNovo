var myfloat = 10f;
float meuFloat = 11;

//Conversão de tipo numérico

int myInteger = 100;
meuFloat = (float)myInteger;//conversão implicita

decimal myDecimal = Convert.ToDecimal(myInteger);

var myDouble = 10d;
myDecimal = 10m;

string meuNumeroTexto = Convert.ToString(myInteger);//converte em uma string

int qtdChars = meuNumeroTexto.Length;//conta quantos caracter que tem
for(int i= 0; i < qtdChars; i++)//contador int-flag<-i++acumulador - inicia acontagem em 0 que é primeiro caracter e conte até i for igual a quantidade de caractere i++ conte de um em um
{
Console.WriteLine(meuNumeroTexto[i]);
}