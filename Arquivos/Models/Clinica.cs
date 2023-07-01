using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Arquivos.Models
{//Inicio do escopo do namespace

    public class Clinica
    {//Inicio escopo da classe
        public int IdC { get; set; }
        public string? NameC { get; set; }
        public string? PhoneC { get; set; }
        public string? CountryC { get; set; }
        public string? StateC { get; set; }

        public string? CityC { get; set; }

        public string? RoadC { get; set; }

        public string? NumberC { get; set; }

        //Os métodos construtores são responsáveis por instanciar uma variável do tipo espicificado pela classe.
        //A regra é de que o construtor tenha o mesmo nome da classe

        public Clinica()//vazio necessita devido implementar o código construtor
        {

        }

        //Método sempre utiliza () - () delimita parâmetros
        // O métoo construtor deve ter o mesmo nome da classe classe=Client 
        
        public Clinica(int idC, string? nameC, string? phoneC, string? countryC, string? stateC, string? cityC, string? roadC, string? numberC)//Ctrl+. gerar constructor aparece isso
        {// {}inicio do escopo desse método - {} delimitam as intruções do método
            IdC = idC;
            NameC = nameC;
            PhoneC = phoneC;
            CountryC = countryC;
            StateC = stateC;
            CityC = cityC;
            RoadC = roadC;
            NumberC = numberC;

        } // Fim do escopo deste método

        public string Address => $"{this.CountryC} {this.StateC} {this.CityC} {this.RoadC} {this.NumberC}";

        public override string ToString()
        {
            return $"Id: {this.IdC}; Name: {this.Address} ";
        }
    }//Fim do escopo da classe
}//Fim do escopo do namespace