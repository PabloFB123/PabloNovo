//Menu de iniciaização

string entrada = ""; //vazio pode ser representado strtring.Empty;
do // do irá executar ao menos uma vez enquanto o while tem que ter a expressão booleana para validar
{
    Console.WriteLine("");
    Console.WriteLine("Seja Bem-Vindo(a)! Em que podemos ajudá-lo(a)");
    Console.WriteLine("1 - Cadastros");
    Console.WriteLine("2 - Relatórios");
    Console.WriteLine("0 - SAIR");

    entrada = Console.ReadLine();

    switch(entrada)
    {
        case "1":
            //int count = int.Parse("abc"); //Parse verifica se o conteúdo é do tipo inteiro
            
            bool cadastro = true;
            while(cadastro)
            {
                string entradaCadastro = "";
                Console.WriteLine("-----------------");
                Console.WriteLine("Você está no Menu de Cadastramento");
                Console.WriteLine("-----------------");
                Console.WriteLine("1 - Cadastramento Médico");
                Console.WriteLine("2 - Cadastramento Animais");
                Console.WriteLine("3 - Atendimentos");
                Console.WriteLine("4 - SAIR");
                    entradaCadastro = Console.ReadLine();
                    switch(entradaCadastro)
                    {
                        case "1":
                        bool cadastroMedico = true;
                        while(cadastroMedico)
                        {
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Você está no Menu de Cadastramento Médico");
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Nome Completo");
                            string nomeMedico = Console.ReadLine();
                            Console.WriteLine("Data de Nascimento");
                            string nasMedico = Console.ReadLine();
                            Console.WriteLine("Número do CPF");
                            string cpfMedico = Console.ReadLine();
                            Console.WriteLine("Número do CRM");
                            string crmMedico = Console.ReadLine();

                            Console.WriteLine($"Médico {nomeMedico}, Data de Nascimento {nasMedico}, CPF {cpfMedico}, CRM {crmMedico}");
                            Console.WriteLine("Cadastramento Realizado com Sucesso!");
                            break;
                        }
                        break;

                        case "2":
                        bool cadastroAnimal = true;
                        while(cadastroAnimal)
                        {
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Você está no Menu de Cadastramento Animal");
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Nome");
                            string nomeAnimal = Console.ReadLine();
                            Console.WriteLine("Data de Nascimento");
                            string nasAnimal = Console.ReadLine();
                            Console.WriteLine("Tipo de Animal");
                            string tipoAnimal = Console.ReadLine();
                            Console.WriteLine($"{tipoAnimal},  {nomeAnimal}, Nascido em {nasAnimal}");
                            Console.WriteLine("Cadastramento Realizado com Sucesso!");
                            break;
                        } 
                        break;

                        case "3":
                        bool atendimento = true;
                        while(atendimento)
                        {
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Você está no Menu de Atendimentos");
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Dia do Atendimento");
                            string diaAtend = Console.ReadLine();
                            Console.WriteLine("hora do Atendimento");
                            string horaAtend = Console.ReadLine();
                            Console.WriteLine("Nome do Responsável pelo Animal");
                            string nomeAtend = Console.ReadLine();
                            Console.WriteLine("Nome do Animal");
                            string animalAtend = Console.ReadLine();
                            Console.WriteLine("tipo de Animal");
                            string tipoAtend = Console.ReadLine();
                            Console.WriteLine($" Atendimento marcado para o dia {diaAtend}, ás  {horaAtend}, Nome Responsável{nomeAtend} pelo {tipoAtend} {animalAtend}");
                            Console.WriteLine("Atendimento Realizado com Sucesso!");
                            break;
                        }
                        break;

                        case "4":
                        cadastro = false;
                        break;

                        default:
                        Console.WriteLine("ATENÇÂO: Opção Inválida!");
                        break;
                    }
            }
        break;


        case "2":
        bool relatorio = true;
        while(relatorio)
            {
                string entradaRelatorio = "";
                Console.WriteLine("-----------------");
                Console.WriteLine("Você está no Menu de Relatórios");
                Console.WriteLine("-----------------");
                Console.WriteLine("1 - Relatório de Animais");
                Console.WriteLine("2 - Relatório de Atendimentos");
                Console.WriteLine("3 - SAIR");
                    entradaRelatorio = Console.ReadLine();

                    switch(entradaRelatorio)
                    {

                        case "1":
                        bool relatorioAnimal = true;
                        while(relatorioAnimal)
                        {
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Você está no Menu de Relatório de Animais");
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Informe o Nome do Responsável pelo Animal");
                            string rrAnimal = Console.ReadLine();
                            Console.WriteLine("Qual animal é?");
                            string rtAnimal = Console.ReadLine();
                            Console.WriteLine("Nome do Animal");
                            string rnAnimal = Console.ReadLine();
                           

                            Console.WriteLine($"Senhor(a) {rrAnimal} o(a) seu {rtAnimal} {rnAnimal} já está liberado");
                            Console.WriteLine("Obrigado Pela Preferência!");
                            break;
                        }
                        break;

                        case "2":
                        bool relatorioAtendimento = true;
                        while(relatorioAtendimento)
                        {
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Você está no Menu de Relatório de Atendimento");
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Informe o Nome do Solicitante pelo Atendimento");
                            string rrSolicitante = Console.ReadLine();
                            Console.WriteLine("Qual animal é?");
                            string rtSolicitante = Console.ReadLine();
                            Console.WriteLine("Nome do Animal");
                            string rnSolicitante = Console.ReadLine();
                           

                            Console.WriteLine($"Senhor(a) {rrSolicitante} o(a) seu {rtSolicitante} {rnSolicitante} ele foi internado e medicado");
                            Console.WriteLine("Obrigado Pela Preferência!");
                            break;
                        }
                        break;

                        case "3":
                        relatorio = false;
                        break;

                        default:
                        Console.WriteLine("ATENÇÂO: Opção Inválida!");
                        break;
                    }
            }
        break;

        case "0":
        break;

        default:
        Console.WriteLine("ATENÇÂO: Opção Inválida!");
        break;
    }

}

while( !entrada.Equals("0") && 
        !string.IsNullOrWhiteSpace(entrada) ); // ! negação
