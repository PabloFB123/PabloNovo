//Menu de iniciaização

string entrada = ""; //vazio pode ser representado strtring.Empty;
Console.WriteLine("-----------------");
Console.WriteLine("Tratamento de erros");
Console.WriteLine("-----------------");

do // do irá executar ao menos uma vez enquanto o while tem que ter a expressão booleana para validar
{
    Console.WriteLine("");
    Console.WriteLine("Selecione uma das opções abaixo");
    Console.WriteLine("1 - Tratamento de erro");
    Console.WriteLine("2 - Try { } Catch { }");
    Console.WriteLine("3 - Catch com Filtros");
    Console.WriteLine("4 - ");
    Console.WriteLine("5 - ");
    Console.WriteLine("0 - SAIR");

    entrada = Console.ReadLine();

    switch(entrada)
    {
        case "1":
            //int count = int.Parse("abc"); //Parse verifica se o conteúdo é do tipo inteiro
            bool aux = true;
            while(aux)
            {

                Console.WriteLine("Quantos ovos na cesta?");
                string? input = Console.ReadLine(); // string? permite o valor nulo
                if( int.TryParse( input, out int count ) )
                {
                    Console.WriteLine($"Existem {count} ovos bo cesto.");
                    aux = false;
                }
                else
                {
                    Console.WriteLine("Não é um número válido.");
                    aux = true;
                }

            }

        break; // break identifica o numero e se for algum deles si do switch

        case "2":

            Console.WriteLine("Antes da validação.");
            Console.WriteLine("Informe sua idade:");
            string input2 = Console.ReadLine();
            try // bloco try linha por linha que estiver dentro do escopo verifica se der erro e vai para o bloco cath quetrata o erro e depois mostra para o usuario
            {
                int age = int.Parse(input2);
                //forçando um erro de índice fora dos limites do vetor
                int [] vetInteiros = {10,11,12,13};
                //Console.WriteLine(vetInteiros[vetInteiros.Length]);// orça um ero por pedir lenght= 4 itens e ter 3 devido ir de 0 a 3
                Console.WriteLine(vetInteiros[vetInteiros.Length - 1]);
            }

            catch(IndexOutOfRangeException ixorgex)
            {
                Console.WriteLine("Queridão, esta posição inexistente no vetor.");
            }

            catch(FormatException fex )
            {
                Console.WriteLine("Erro de formato inválido de dados.");
            }

            catch( Exception ex )
            {
                Console.WriteLine("Ocorreu um erro. Dados inválidos");
                Console.WriteLine($"{ex.GetType()} : {ex.Message}");
            }

            Console.WriteLine("Depois da validação.");

        break;


        case "3":

            Console.WriteLine("Informe o Valor:");
            string quantia = Console.ReadLine();
            if( String.IsNullOrEmpty(quantia) )
                Console.WriteLine("Quantia inválida.");
            else
            {
                try
                {
                    decimal amaountValue = decimal.Parse(quantia);
                    Console.WriteLine($"Valor formatado: {amaountValue : C}");
                }

                catch(FormatException) when (quantia.Contains("$"))
                {
                    Console.WriteLine("O valor deve ser informado sem $");
                }
                catch(FormatException fex)
                {
                    Console.WriteLine("Informe apenas os dígitos.");
                }
            }
        break;


        case "4":
        break;


        case "5":
        break;


        case "0":
        break;

        default:
        Console.WriteLine("ATENÇÂO: Opção inválida!");
        break;
    }

}

while( !entrada.Equals("0") && 
        !string.IsNullOrWhiteSpace(entrada) ); // ! negação

