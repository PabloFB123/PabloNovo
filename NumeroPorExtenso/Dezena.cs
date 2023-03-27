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
            if (numero >= 30 && numero <=39)
             {
                if(numero == 30)
                retorno = "Trinta";
                else
                {
                    string und = numero.ToString().Substring(1,1); //quebrar o numero - do indice 1 quero 1 caracter
                    retorno = "Trinta e "; // atribuindo valo a retorno
                    retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                return retorno;
            }
            if (numero >= 40 && numero <=49)
             {
                if(numero == 40)
                retorno = "Quarenta";
                else
                {
                    string und = numero.ToString().Substring(1,1); //quebrar o numero - do indice 1 quero 1 caracter
                    retorno = "Quarenta e "; // atribuindo valo a retorno
                    retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                return retorno;
            }
            if (numero >= 50 && numero <=59)
             {
                if(numero == 50)
                retorno = "Cinquenta";
                else
                {
                    string und = numero.ToString().Substring(1,1); //quebrar o numero - do indice 1 quero 1 caracter
                    retorno = "Cinquenta e "; // atribuindo valo a retorno
                    retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                return retorno;
            }
            if (numero >= 60 && numero <=69)
             {
                if(numero == 60)
                retorno = "Sessenta";
                else
                {
                    string und = numero.ToString().Substring(1,1); //quebrar o numero - do indice 1 quero 1 caracter
                    retorno = "Sessenta e "; // atribuindo valo a retorno
                    retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                return retorno;
            }
            if (numero >= 70 && numero <=79)
             {
                if(numero == 70)
                retorno = "Setenta";
                else
                {
                    string und = numero.ToString().Substring(1,1); //quebrar o numero - do indice 1 quero 1 caracter
                    retorno = "Setenta e "; // atribuindo valo a retorno
                    retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                return retorno;
            }
            if (numero >= 80 && numero <=89)
             {
                if(numero == 80)
                retorno = "Oitenta";
                else
                {
                    string und = numero.ToString().Substring(1,1); //quebrar o numero - do indice 1 quero 1 caracter
                    retorno = "Oitenta e "; // atribuindo valo a retorno
                    retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                return retorno;
            }
            if (numero >= 90 && numero <=99)
             {
                if(numero == 90)
                retorno = "Noventa";
                else
                {
                    string und = numero.ToString().Substring(1,1); //quebrar o numero - do indice 1 quero 1 caracter
                    retorno = "Noventa e "; // atribuindo valo a retorno
                    retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                return retorno;
            }
            else
            return "Numero Inválido";
        }
    }
}