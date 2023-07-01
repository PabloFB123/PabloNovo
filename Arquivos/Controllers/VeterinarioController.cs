using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO; //Input and Output
using Arquivos.Data;
using Arquivos.Models;


namespace Arquivos.Controllers
{
    public class VeterinarioController
    {
        private string directoryNameVet = "ReportFiles";
        private string fileNameVet = "Veterinarios.txt";

        public List<Veterinario> List()
        {
            return DataSet.Veterinarios;
        }

        public bool Insert(Veterinario veterinario)
        {
            if(veterinario == null)
                return false;
            if(veterinario.IdVet <= 0)
                return false;
            if(string.IsNullOrWhiteSpace(veterinario.FirstNameVet))
                return false;

            DataSet.Veterinarios.Add( veterinario);
                return true;
        }

        public bool ExportToTextFile()
        {
            if(!Directory.Exists(directoryNameVet))
                Directory.CreateDirectory(directoryNameVet);

            string fileContent = string.Empty;
            foreach(Veterinario c in DataSet.Veterinarios)
            {
                fileContent += $"{c.IdVet};{c.CPFVet};{c.FirstNameVet};{c.LastNameVet};{c.CrmVet}";
                fileContent += "\n";
            }

            try

            {
            StreamWriter sw = File.CreateText($"{directoryNameVet}\\{fileNameVet}");

            sw.Write(fileContent);
            sw.Close();
            }

            catch(IOException ioEx)

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
                StreamReader sr = new StreamReader($"{directoryNameVet}\\{fileNameVet}");
        
                string line = string.Empty;
                line = sr.ReadLine();
                while(line != null)
                {
                Veterinario veterinario = new Veterinario();
                string[] veterinarioData = line.Split(';'); //caracter se referencia com aspas simples
                veterinario.IdVet = Convert.ToInt32(veterinarioData[0]);
                veterinario.CPFVet = veterinarioData[1];
                veterinario.FirstNameVet = veterinarioData[2];
                veterinario.LastNameVet = veterinarioData[3];
                veterinario.CrmVet = veterinarioData[4];

                DataSet.Veterinarios.Add(veterinario);

                line = sr.ReadLine();

                }

                return true;

            }

            catch(Exception ex)

            {
                Console.WriteLine("Ooooops. Ocorreu um erro ao tentar importar os dados");
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<Veterinario> SearchByName(string nameV)
        {
            if (string.IsNullOrEmpty(nameV) || string.IsNullOrWhiteSpace(nameV))
            return null;

            List<Veterinario> veterinarios = new List<Veterinario>();
            for(int i = 0; i < DataSet.Veterinarios.Count; i++)
            {
                var c = DataSet.Veterinarios[i];
                if(c.FullNameV.ToLower().Contains(nameV.ToLower()))
                {
                    veterinarios.Add(c);
                }
            } 

            return veterinarios;

        }

        public int GetNextId()
        {
            int tam = DataSet.Veterinarios.Count;

            if ( tam > 0)
                return DataSet.Veterinarios[ tam - 1 ].IdVet + 1;
            else
            return 1;
        }
    }
}