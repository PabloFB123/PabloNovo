using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Controllers;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Views //namespace é um lugar que eu posso guardar blocos de códigos
{
    public class ClientView // class especifica o que vai constituir o objeto - o objeto é a variável que fica armazenada na memória ram do computador
    {
        private ClientController clientController;

        public ClientView()
        {
            clientController = new ClientController();
            this.Init();
        }
        public void Init()
        {
            Console.WriteLine("******************");
            Console.WriteLine("VOCÊ ESTÁ EM CLIENTES");
            Console.WriteLine("******************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Cliente");
            Console.WriteLine("2 - Listar Cliente");
            Console.WriteLine("3 - Exportar Cliente");
            Console.WriteLine("4 - Importar Cliente");
            Console.WriteLine("");
            int option = 0;
            option = Convert.ToInt32( Console.ReadLine() );
            switch (option)
            {
                case 1 :
                    Insert();
                break;
                
                case 2:
                    List();
                break;
            }
        }

        private void List()
        {
            List<Client> listgem = clientController.List();

            for(int i = 0; i < listgem.Count; i++)
            {
                Console.WriteLine (Print(listgem[i]));
            }
        }

        private string Print(Client client) //tipo em letra maiuscul - locl em minuscula
        {
            string retorno = "";
            retorno += $"Id: {client.Id} \n"; //\n quebra a linha
            retorno += $"Nome: {client.FirstName} {client.FirstName} \n";
            retorno += "-------------------------------------------- \n";

            return retorno;
        }

        private void Insert()
        {
            Client client = new Client(); //classe Client especifica o tipo client = objeto/variável
            client.Id = clientController.GetNextId();

            Console.WriteLine("Informe o primeiro nome:");
            client.FirstName = Console.ReadLine();
            Console.WriteLine("Informe o sobrenome:");
            client.LastName = Console.ReadLine();
            Console.WriteLine("Informe o CPF:");
            client.CPF = Console.ReadLine();
            Console.WriteLine("Informe o Email:");
            client.Email = Console.ReadLine();

            bool retorno = clientController.Insert(client);

            if(retorno)
                Console.WriteLine("Cliente inserido com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados!");

        }
    }
}