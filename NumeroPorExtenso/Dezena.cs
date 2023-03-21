using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumeroPorExtenso
{
    public class Dezena
    {
        public string DezenaPorExtenso(int numero)
        {
         string retorno = "";
         Unidade unidade = new Unidade(); // instanciando a classe unidade em objeto unidade
            if (numero == 10)
            return "Dez";
            if (numero == 11)
            return "Onze";
            if (numero == 12)
            return "Doze";
            if (numero == 13)
            return "Treze";
            if (numero == 14)
            return "Quatorze";
            if (numero == 15)
            return "Quinze";
            if (numero == 16)
            return "Dezesseis";
            if (numero == 17)
            return "Dezessete";
            if (numero == 18)
            return "Dezoito";
            if (numero == 19)
            return "Dezenove";

            if (numero >= 20 && numero <=29)
            {
                if(numero == 20)
                retorno = "Vinte";
                else
                {
                    string und = numero.ToString().Substring(1,1); //quebrar o numero - do indice 1 quero 1 caracter
                    retorno = "Vinte e "; // atribuindo valo a retorno
                    retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                return retorno;
            }
            //implementar regra para 30 a 99
            if (numero == 20)
            return "Vinte";
            if (numero == 30)
            return "Trinta";
            if (numero == 40)
            return "Quarenta";
            if (numero == 50)
            return "Cinquenta";
            if (numero == 60)
            return "Sessenta";
            if (numero == 70)
            return "Setenta";
            if (numero == 80)
            return "Oitenta";
            if (numero == 90)
            return "Noventa";
            else
            return "Numero Inválido";
        }
    }
}