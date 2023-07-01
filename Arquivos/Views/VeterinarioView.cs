using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Controllers;
using Arquivos.Data;
using Arquivos.Models;


namespace Arquivos.Views //namespace é um lugar que eu posso guardar blocos de códigos
{
    public class VeterinarioView // class especifica o que vai constituir o objeto - o objeto é a variável que fica armazenada na memória ram do computador
    {
        private VeterinarioController veterinarioController;

        public VeterinarioView()
        {
            veterinarioController = new VeterinarioController();
            this.Init();
        }
        public void Init()
        {
            Console.WriteLine("******************");
            Console.WriteLine("VOCÊ ESTÁ EM MÉDICO VETERINÁRIO");
            Console.WriteLine("******************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Médico Veterinário");
            Console.WriteLine("2 - Listar Médico Veterinário");
            Console.WriteLine("3 - Exportar Médico Veterinário");
            Console.WriteLine("4 - Importar Médico Veterinário");
            Console.WriteLine("");

            int option = 0;

            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Insert();
                    break;

                case 2:
                    List();
                    break;

                case 3:
                    Export();
                    break;

                case 4:
                    Import();
                    break;

                default:
                    break;
            }
        }

        private void List()
        {
            List<Veterinario> listgem = veterinarioController.List();

            for (int i = 0; i < listgem.Count; i++)
            {
                Console.WriteLine(Print(listgem[i]));
            }
        }

        private string Print(Veterinario veterinario) //tipo em letra maiuscul - locl em minuscula
        {
            string retorno = "";
            retorno += $"Id: {veterinario.IdVet} \n"; //\n quebra a linha
            retorno += $"Nome: {veterinario.FirstNameVet} {veterinario.LastNameVet} \n";
            retorno += "-------------------------------------------- \n";

            return retorno;
        }

        private void Insert()
        {
            Veterinario veterinario = new Veterinario(); //classe Client especifica o tipo client = objeto/variável
            veterinario.IdVet = veterinarioController.GetNextId();

            Console.WriteLine("Informe o primeiro nome:");
            veterinario.FirstNameVet = Console.ReadLine();
            Console.WriteLine("Informe o sobrenome:");
            veterinario.LastNameVet = Console.ReadLine();
            Console.WriteLine("Informe o CPF:");
            veterinario.CPFVet = Console.ReadLine();
            Console.WriteLine("Informe o CRM:");
            veterinario.CrmVet = Console.ReadLine();

            bool retorno = veterinarioController.Insert(veterinario);

            if (retorno)
                Console.WriteLine("Médico Veterinário inserido com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados!");

        }

        private void Export()
        {
            if (veterinarioController.ExportToTextFile())
                Console.WriteLine("Arquivo gerado com sucesso!");
            else
                Console.WriteLine("Opsssss.");
        }

        private void Import()
        {
            if (veterinarioController.ImportFromTxtFile())
                Console.WriteLine("Dados importados com sucesso!");
            else
                Console.WriteLine("Opsssss.");
        }

        private void SearchByName()
        {
            Console.WriteLine("Pesquisar Veterinário Pelo Nome");
            Console.WriteLine("Digite o Nome:");
            string nameV = Console.ReadLine();

            foreach (Veterinario c in veterinarioController.SearchByName(nameV))
            {
                Console.WriteLine(c.ToString());
            }
        }


    }
}