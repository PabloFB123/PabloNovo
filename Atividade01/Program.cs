using Atividade01.Classes;

Pessoa [] pessoas = new Pessoa []
{
    new Gerente 
        {
            Nome = "Heron"
            , Nascimento = new (year: 1960, month: 1, day: 23)
            , Gênero = "Masculino"
            , Função = "Gerente"
            , SalarioAlto = "R$ 20000,00"
        },
    new Supervisor 
        {
            Nome = "Ricardo"
            , Nascimento = new (year: 1970, month: 2, day: 24)
            , Gênero = "Masculino"
            , Função = "Supervisor(a)"
            , SalarioMedio = "R$ 10000,00"
        },
    new Supervisor 
        {
            Nome = "Camila"
            , Nascimento = new (year: 1980, month: 3, day: 25) 
            , Gênero = "Feminino"
            , Função = "Supervisor(a)"
            , SalarioMedio = "R$ 10000,00"

        },
    new Operário
        {
            Nome = "João"
            , Nascimento = new (year: 1990, month: 4, day: 26) 
            , Gênero = "Masculino"
            , Função = "Operador(a)"
            , SalarioBaixo = "R$ 5000,00"
        },
    new Operário
        {
            Nome = "Maria"
            , Nascimento = new ( year:2000, month: 5, day: 27)
            , Gênero = "Feminino"
            , Função = "Operador(a)"
            , SalarioBaixo = "R$ 5000,00"
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

            if (pessoas[i] is Gerente)
                {
                    Gerente gerente = (Gerente)pessoas[i];
                    Console.WriteLine($"Salário: {gerente.SalarioAlto}");
                }

            if (pessoas[i] is Supervisor)
                {
                    Supervisor supervisor = (Supervisor)pessoas[i];
                    Console.WriteLine($"Salário: {supervisor.SalarioMedio}");
                }

            if (pessoas[i] is Operário)
                {
                    Operário operador = (Operário)pessoas[i];
                    Console.WriteLine($"Salário: {operador.SalarioBaixo}");
                }
        }
};