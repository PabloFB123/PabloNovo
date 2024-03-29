﻿using Arquivos.Views;
using Arquivos.Utils;

/*
Programa para leitura de dados de pessoas
e exportação de arquivos .txt
*/

Bootstrapper.ChargeClients();
BootstrapperAnimal.ChargeAnimals();
BootstrapperClinica.ChargeClinicas();
BootstrapperVeterinario.ChargeVeterinarios();


int option = 0;

do
{

    Console.WriteLine ("*******************************************");
    Console.WriteLine ("Programa Para Leitura e Exportação de Dados");
    Console.WriteLine ("*******************************************");
    Console.WriteLine("");
    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Animais");
    Console.WriteLine("3 - Veterinários");
    Console.WriteLine("4 - Clínicas");
    Console.WriteLine("0 - SAIR");

    option = Convert.ToInt32 ( Console.ReadLine () );

    switch ( option)
    {
        case 1 :
            Console.WriteLine ("OPÇÃO CLIENTES");
            ClientView clientView = new ClientView();
        break;

        case 2:
            Console.WriteLine ("OPÇÃO ANIMAIS");
            AnimalView animalView = new AnimalView();
        break;

        case 3:
            Console.WriteLine ("OPÇÃO VETERINÁRIO(A)");
            VeterinarioView veterinarioView = new VeterinarioView();
        break;

        case 4:
            Console.WriteLine ("OPÇÃO CLÍNICAS");
            ClinicaView clinicaView = new ClinicaView();
        break;
    }

}
while ( option > 0);