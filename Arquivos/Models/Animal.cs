using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Arquivos.Models
{//Inicio do escopo do namespace

    public class Animal
    {//Inicio escopo da classe
        public int IdA { get; set; }
        public string? NomeA { get; set; }
        public string? TipoA { get; set; }
        public string? RacaA { get; set; }
        public string? PesoA { get; set; }

        //Os métodos construtores são responsáveis por instanciar uma variável do tipo espicificado pela classe.
        //A regra é de que o construtor tenha o mesmo nome da classe

        public Animal()//vazio necessita devido implementar o código construtor
        {

        }

        //Método sempre utiliza () - () delimita parâmetros
        // O métoo construtor deve ter o mesmo nome da classe classe=Client 

        public Animal(int idA, string? nomeA, string? tipoA, string? racaA, string? pesoA)//Ctrl+. gerar constructor aparece isso
        {// {}inicio do escopo desse método - {} delimitam as intruções do método
            IdA = idA;
            NomeA = nomeA;
            TipoA = tipoA;
            RacaA = racaA;
            PesoA = pesoA;
        } // Fim do escopo deste método

        public string FullNameA => $"{this.NomeA} {this.TipoA}";

        public override string ToString()
        {
            return $"Id: {this.IdA}; Name: {this.FullNameA} ";
        }
    }//Fim do escopo da classe
}//