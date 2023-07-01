using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO; //Input and Output
using Arquivos.Data;
using Arquivos.Models;


namespace Arquivos.Controllers
{
    public class AnimalController
    {
        private string directoryNameA = "ReportFiles";
        private string fileNameA = "Animals.txt";

        public List<Animal> List()
        {
            return DataSet.Animals;
        }

        public bool Insert(Animal animal)
        {
            if (animal == null)
                return false;
            if (animal.IdA <= 0)
                return false;
            if (string.IsNullOrWhiteSpace(animal.NomeA))
                return false;

            DataSet.Animals.Add(animal);

            return true;
        }

        public bool ExportToTextFile()
        {
            if (!Directory.Exists(directoryNameA))
                Directory.CreateDirectory(directoryNameA);

            string fileContent = string.Empty;
            foreach (Animal c in DataSet.Animals)
            {
                fileContent += $"{c.IdA};{c.NomeA};{c.TipoA};{c.RacaA};{c.PesoA}";
                fileContent += "\n";
            }

            try

            {
                StreamWriter sw = File.CreateText($"{directoryNameA}\\{fileNameA}");

                sw.Write(fileContent);
                sw.Close();
            }

            catch (IOException ioEx)

            {
                Console.WriteLine("Erro ao manipular o arquivo.");
                Console.WriteLine(ioEx.Message);
                return false;
            }

            return true;
            
        }

        public bool ImportFromTxtFile()
        {

            try

            {
                StreamReader sr = new StreamReader($"{directoryNameA}\\{fileNameA}");

                string line = string.Empty;
                line = sr.ReadLine();
                while (line != null)
                {
                    Animal animal = new Animal();
                    string[] animalData = line.Split(';'); //caracter se referencia com aspas simples
                    animal.IdA = Convert.ToInt32(animalData[0]);
                    animal.NomeA = animalData[1];
                    animal.TipoA = animalData[2];
                    animal.RacaA = animalData[3];
                    animal.PesoA = animalData[4];

                    DataSet.Animals.Add(animal);

                    line = sr.ReadLine();

                }

                return true;

            }

            catch (Exception ex)

            {
                Console.WriteLine("Ooooops. Ocorreu um erro ao tentar importar os dados");
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<Animal> SearchByName(string nameA)
        {
            if (string.IsNullOrEmpty(nameA) || string.IsNullOrWhiteSpace(nameA))
                return null;

            List<Animal> animals = new List<Animal>();
            for (int i = 0; i < DataSet.Animals.Count; i++)
            {
                var c = DataSet.Animals[i];
                if (c.FullNameA.ToLower().Contains(nameA.ToLower()))
                {
                    animals.Add(c);
                }
            }

            return animals;
        }

        public int GetNextId()
        {
            int tam = DataSet.Animals.Count;

            if (tam > 0)
                return DataSet.Animals[tam - 1].IdA + 1;
            else
                return 1;
        }
    }
}