using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Controllers;
using Arquivos.Data;
using Arquivos.Models;


namespace Arquivos.Views //namespace é um lugar que eu posso guardar blocos de códigos
{
    public class AnimalView // class especifica o que vai constituir o objeto - o objeto é a variável que fica armazenada na memória ram do computador
    {
        private AnimalController animalController;

        public AnimalView()
        {
            animalController = new AnimalController();
            this.Init();
        }
        public void Init()
        {
            Console.WriteLine("******************");
            Console.WriteLine("VOCÊ ESTÁ EM ANIMAIS");
            Console.WriteLine("******************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Animal");
            Console.WriteLine("2 - Listar Animal");
            Console.WriteLine("3 - Exportar Animal");
            Console.WriteLine("4 - Importar Animal");
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

                case 5:
                    SearchByName();// todo: Pesquisa pelo nome Search();
                    break;

                default:
                    break;
            }
        }

        private void List()
        {
            List<Animal> listgem = animalController.List();

            for (int i = 0; i < listgem.Count; i++)
            {
                Console.WriteLine(Print(listgem[i]));
            }
        }

        private string Print(Animal animal) //tipo em letra maiuscul - locl em minuscula
        {
            string retorno = "";
            retorno += $"Id: {animal.IdA} \n"; //\n quebra a linha
            retorno += $"Nome: {animal.NomeA} \n";
            retorno += $"Tipo: {animal.TipoA} \n";
            retorno += "-------------------------------------------- \n";

            return retorno;
        }

        private void Insert()
        {
            Animal animal = new Animal(); //classe Client especifica o tipo client = objeto/variável
            animal.IdA = animalController.GetNextId();
            Console.WriteLine("Informe o nome:");
            animal.NomeA = Console.ReadLine();
            Console.WriteLine("Informe o Tipo:");
            animal.TipoA = Console.ReadLine();
            Console.WriteLine("Informe a Raça:");
            animal.RacaA = Console.ReadLine();
            Console.WriteLine("Informe o Peso:");
            animal.PesoA = Console.ReadLine();

            bool retorno = animalController.Insert(animal);

            if (retorno)
                Console.WriteLine("Animal inserido com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados!");

        }

        private void Export()
        {
            if (animalController.ExportToTextFile())
                Console.WriteLine("Arquivo gerado com sucesso!");
            else
                Console.WriteLine("Opsssss.");
        }

        private void Import()
        {
            if (animalController.ImportFromTxtFile())
                Console.WriteLine("Dados importados com sucesso!");
            else
                Console.WriteLine("Opsssss.");
        }

        private void SearchByName()
        {
            Console.WriteLine("Pesquisar Animal Pelo Nome");
            Console.WriteLine("Digite o Nome:");
            string nameA = Console.ReadLine();

            foreach (Animal c in animalController.SearchByName(nameA))
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}