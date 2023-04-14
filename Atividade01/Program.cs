using Atividade01.Classes;

Pessoa [] pessoas = new Pessoa []
{
    new Gerente 
        {
            Nome = "Heron"
            , Nascimento = new (year: 1960, month: 1, day: 23)
            , Gênero = "Masculino"
            , Função = "Gerente"
            , SalarioAlto = true
        },
    new Supervisor 
        {
            Nome = "Ricardo"
            , Nascimento = new (year: 1970, month: 2, day: 24)
            , Gênero = "Masculino"
            , Função = "Supervisor (a)"
            , SalarioMedio = true
        },
    new Supervisor 
        {
            Nome = "Camila"
            , Nascimento = new (year: 1980, month: 3, day: 25) 
            , Gênero = "Feminino"
            , Função = "Supervisor (a)"
            , SalarioMedio = true

        },
    new Operário
        {
            Nome = "João"
            , Nascimento = new (year: 1990, month: 4, day: 26) 
            , Gênero = "Masculino"
            , Função = "Operador (a)"
            , SalarioBaixo = true
        },
    new Operário
        {
            Nome = "Maria"
            , Nascimento = new ( year:2000, month: 5, day: 27)
            , Gênero = "Feminino"
            , Função = "Operador (a)"
            , SalarioBaixo = true
        },
};

for (int i = 0; i < pessoas.Length; i++) 
{
    string message = string.Empty;
    if(pessoas [i] != null )
        {
    
            message = $"Nome: {pessoas[i].Nome} - "; 
            message += $"Data de Nascimento: {pessoas[i].Nascimento.ToShortDateString()} - ";
            message += $"Gênero: {pessoas[i].Gênero} - ";
            message += $"Função: {pessoas[i].Função}";
            
            Console.WriteLine(message);
        }
};