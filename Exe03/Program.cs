static void FormatString(string stringToFormat)//retorna vazio não sofre alteração porque é uma variavel local e var é global
{
    stringToFormat.Replace("Mundo", "Marte");
}

static string FormatRetuningString(string stringToFormat)
{
    return stringToFormat.Replace("Mundo", "Marte");
}

var mensagem = "Olá Mundo!";
// Invocando o método sem retorno
FormatString(mensagem);
Console.WriteLine(mensagem);

var outraMensagem = "Bom-dia Mundo";
Console.WriteLine(FormatRetuningString(outraMensagem));//processa o format line e após passa para o write line
//Crtl+' abre o simunlador e para rodar digita dotnet run