using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Controllers;
using Arquivos.Data;
using Arquivos.Models;


namespace Arquivos.Views //namespace é um lugar que eu posso guardar blocos de códigos
{
    public class ClinicaView // class especifica o que vai constituir o objeto - o objeto é a variável que fica armazenada na memória ram do computador
    {
        private ClinicaController clinicaController;

        public ClinicaView()
        {
            clinicaController = new ClinicaController();
            this.Init();
        }
        public void Init()
        {
            Console.WriteLine("******************");
            Console.WriteLine("VOCÊ ESTÁ EM CLÍNICAS");
            Console.WriteLine("******************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Clínica");
            Console.WriteLine("2 - Listar Clínica");
            Console.WriteLine("3 - Exportar Clínica");
            Console.WriteLine("4 - Importar Clínica");
            Console.WriteLine("5 - Pesquisar Clínica");
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
            List<Clinica> listgem = clinicaController.List();

            for (int i = 0; i < listgem.Count; i++)
            {
                Console.WriteLine(Print(listgem[i]));
            }
        }

        private string Print(Clinica clinica) //tipo em letra maiuscul - locl em minuscula
        {
            string retorno = "";
            retorno += $"Id: {clinica.IdC} \n"; //\n quebra a linha
            retorno += $"Nome: {clinica.NameC} \n";
            retorno += "-------------------------------------------- \n";

            return retorno;
        }

        private void Insert()
        {
            Clinica clinica = new Clinica(); //classe Client especifica o tipo client = objeto/variável
            clinica.IdC = clinicaController.GetNextId();
            Console.WriteLine("Informe o Nome:");
            clinica.NameC = Console.ReadLine();
            Console.WriteLine("Informe Telefone:");
            clinica.PhoneC = Console.ReadLine();
            Console.WriteLine("Informe o País:");
            clinica.CountryC = Console.ReadLine();
            Console.WriteLine("Informe o Estado:");
            clinica.StateC = Console.ReadLine();
            Console.WriteLine("Informe a Cidade");
            clinica.CityC = Console.ReadLine();
            Console.WriteLine("Informe a Rua:");
            clinica.RoadC = Console.ReadLine();
            Console.WriteLine("Informe o Número");
            clinica.NumberC = Console.ReadLine();

            bool retorno = clinicaController.Insert(clinica);

            if (retorno)
                Console.WriteLine("Clínica inserida com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados!");

        }

        private void Export()
        {
            if (clinicaController.ExportToTextFile())
                Console.WriteLine("Arquivo gerado com sucesso!");
            else
                Console.WriteLine("Opsssss.");
        }

        private void Import()
        {
            if (clinicaController.ImportFromTxtFile())
                Console.WriteLine("Dados importados com sucesso!");
            else
                Console.WriteLine("Opsssss.");
        }

        private void SearchByName()
        {
            Console.WriteLine("Pesquisar Clínica Pelo Nome");
            Console.WriteLine("Digite o Nome:");
            string nameC = Console.ReadLine();

            foreach (Clinica c in clinicaController.SearchByName(nameC))
            {
                Console.WriteLine(c.ToString());
            }
        }

    }
}