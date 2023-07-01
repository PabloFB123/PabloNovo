using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO; //Input and Output
using Arquivos.Data;
using Arquivos.Models;


namespace Arquivos.Controllers
{
    public class ClinicaController
    {
        private string directoryNameC = "ReportFiles";
        private string fileNameC = "Clinicas.txt";

        public List<Clinica> List()
        {
            return DataSet.Clinicas;
        }

        public bool Insert(Clinica clinica)
        {
            if (clinica == null)
                return false;
            if (clinica.IdC <= 0)
                return false;
            if (string.IsNullOrWhiteSpace(clinica.NameC))
                return false;

            DataSet.Clinicas.Add(clinica);
            return true;
        }

        public bool ExportToTextFile()
        {
            if (!Directory.Exists(directoryNameC))
                Directory.CreateDirectory(directoryNameC);

            string fileContent = string.Empty;
            foreach (Clinica c in DataSet.Clinicas)
            {
                fileContent += $"{c.IdC};{c.NameC};{c.PhoneC}; {c.CountryC}; {c.StateC}; {c.CityC}; {c.RoadC}; {c.NumberC}";
                fileContent += "\n";
            }

            try

            {
                StreamWriter sw = File.CreateText($"{directoryNameC}\\{fileNameC}");

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
                StreamReader sr = new StreamReader($"{directoryNameC}\\{fileNameC}");

                string line = string.Empty;
                line = sr.ReadLine();
                while (line != null)
                {
                    Clinica clinica = new Clinica();
                    string[] clinicaData = line.Split(';'); //caracter se referencia com aspas simples
                    clinica.IdC = Convert.ToInt32(clinicaData[0]);
                    clinica.NameC = clinicaData[1];
                    clinica.PhoneC = clinicaData[2];
                    clinica.CountryC = clinicaData[3];
                    clinica.StateC = clinicaData[4];
                    clinica.CityC = clinicaData[5];
                    clinica.RoadC = clinicaData[6];
                    clinica.NumberC = clinicaData[7];


                    DataSet.Clinicas.Add(clinica);

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

        public List<Clinica> SearchByName(string nameC)
        {
            if (string.IsNullOrEmpty(nameC) || string.IsNullOrWhiteSpace(nameC))
                return null;

            List<Clinica> clinicas = new List<Clinica>();
            for (int i = 0; i < DataSet.Clinicas.Count; i++)
            {
                var c = DataSet.Clinicas[i];
                if (c.Address.ToLower().Contains(nameC.ToLower()))
                {
                    clinicas.Add(c);
                }
            }
            return clinicas;
        }

        public int GetNextId()
        {
            int tam = DataSet.Clinicas.Count;

            if (tam > 0)
                return DataSet.Clinicas[tam - 1].IdC + 1;
            else
                return 1;
        }
    }
}