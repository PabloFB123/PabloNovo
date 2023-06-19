using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Arquivos.Models
{//Inicio do escopo do namespace
    public class Client
    {//Inicio escopo da classe
        public int Id { get; set; }
        public string?  FirstName { get; set; }
        public string?  LastName { get; set; }
        public string?  CPF { get; set; }
        public string?  Email { get; set; }


        //Os métodos construtores são responsáveis por instanciar uma variável do tipo espicificado pela classe.
        //A regra é de que o construtor tenha o mesmo nome da classe
        public Client()//vazio necessita devido implementar o código construtor
        {

        }


        //Método sempre utiliza () - () delimita parâmetros
        // O métoo construtor deve ter o mesmo nome da classe classe=Client 
        public Client(int id, string? firstName, string? lastName, string? cPF, string? email)//Ctrl+. gerar constructor aparece isso
        {// {}inicio do escopo desse método - {} delimitam as intruções do método
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CPF = cPF;
            Email = email;
        } // Fim do escopo deste método


    }//Fim do escopo da classe


}//Fim do escopo do namespace