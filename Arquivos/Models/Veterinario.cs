using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Arquivos.Models
{//Inicio do escopo do namespace

    public class Veterinario
    {//Inicio escopo da classe
        public int IdVet { get; set; }
        public string? FirstNameVet { get; set; }
        public string? LastNameVet { get; set; }
        public string? CPFVet { get; set; }
        public string? CrmVet { get; set; }

        //Os métodos construtores são responsáveis por instanciar uma variável do tipo espicificado pela classe.
        //A regra é de que o construtor tenha o mesmo nome da classe
        public Veterinario()//vazio necessita devido implementar o código construtor
        {

        }

        //Método sempre utiliza () - () delimita parâmetros
        // O métoo construtor deve ter o mesmo nome da classe classe=Client 

        public Veterinario(int idVet, string? firstNameVet, string? lastNameVet, string? cpfVet, string? crmVet)//Ctrl+. gerar constructor aparece isso
        {// {}inicio do escopo desse método - {} delimitam as intruções do método
            IdVet = idVet;
            FirstNameVet = firstNameVet;
            LastNameVet = lastNameVet;
            CPFVet = cpfVet;
            CrmVet = crmVet;
        } // Fim do escopo deste método

        public string FullNameV => $"{this.FirstNameVet} {this.LastNameVet}";

        public override string ToString()
        {
            return $"Id: {this.IdVet}; Name: {this.FullNameV} ";
        }
    }//Fim do escopo da classe
}//Fim do escopo do namespace