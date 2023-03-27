using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumeroPorExtenso
{
    public class Centena
    {
        public string CentenaPorExtenso (int numero)
        {
            string retorno = "";
            Unidade unidade = new Unidade();
            Dezena dezena = new Dezena();
            if(numero >= 100 && numero <= 199)
            {
                if(numero == 100)
                retorno = "Cem";
                else if (numero >= 100 && numero <= 109)
                {
                string und = numero.ToString().Substring(1,2); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Cento e "; // atribuindo valo a retorno
                retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                else
                {
                string und = numero.ToString().Substring(1,2); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Cento e "; // atribuindo valo a retorno
                retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
            }

            if(numero >= 200 && numero <= 299)
            {
                if(numero == 200)
                retorno = "Duzentos";
                else if (numero >= 200 && numero <= 209)
                {
                string und = numero.ToString().Substring(1,2); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Duzentos e "; // atribuindo valo a retorno
                retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                else
                {
                string und = numero.ToString().Substring(1,2); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Duzentos e "; // atribuindo valo a retorno
                retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
            }

            if(numero >= 300 && numero <= 399)
            {
                if(numero == 300)
                retorno = "Trezentos";
                else if (numero >= 300 && numero <= 309)
                {
                string und = numero.ToString().Substring(1,2); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Trezentos e "; // atribuindo valo a retorno
                retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                else
                {
                string und = numero.ToString().Substring(1,2); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Trezentos e "; // atribuindo valo a retorno
                retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
            }

            if(numero >= 400 && numero <= 499)
            {
                if(numero == 400)
                retorno = "Quatrocentos";
                else if (numero >= 400 && numero <= 409)
                {
                string und = numero.ToString().Substring(1,2); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Quatrocentos e "; // atribuindo valo a retorno
                retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                else
                {
                string und = numero.ToString().Substring(1,2); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Quatrocentos e "; // atribuindo valo a retorno
                retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
            }


            if(numero >= 500 && numero <= 599)
            {
                if(numero == 500)
                retorno = "Quinhentos";
                else if (numero >= 500 && numero <= 509)
                {
                string und = numero.ToString().Substring(1,2); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Quinhentos e "; // atribuindo valo a retorno
                retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                else
                {
                string und = numero.ToString().Substring(1,2); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Quinhentos e "; // atribuindo valo a retorno
                retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
            }

            if(numero >= 600 && numero <= 699)
            {
                if(numero == 600)
                retorno = "Seiscentos";
                else if (numero >= 600 && numero <= 609)
                {
                string und = numero.ToString().Substring(1,2); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Seiscentos e "; // atribuindo valo a retorno
                retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                else
                {
                string und = numero.ToString().Substring(1,2); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Seiscentos e "; // atribuindo valo a retorno
                retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
            }

            if(numero >= 700 && numero <= 799)
            {
                if(numero == 700)
                retorno = "Setecentos";
                else if (numero >= 700 && numero <= 709)
                {
                string und = numero.ToString().Substring(1,2); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Setecentos e "; // atribuindo valo a retorno
                retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                else
                {
                string und = numero.ToString().Substring(1,2); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Setecentos e "; // atribuindo valo a retorno
                retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
            }

            if(numero >= 800 && numero <= 899)
            {
                if(numero == 800)
                retorno = "Oitocentos";
                else if (numero >= 800 && numero <= 809)
                {
                string und = numero.ToString().Substring(1,2); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Oitocentos e "; // atribuindo valo a retorno
                retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                else
                {
                string und = numero.ToString().Substring(1,2); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Oitocentos e "; // atribuindo valo a retorno
                retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
            }

            if(numero >= 900 && numero <= 999)
            {
                if(numero == 900)
                retorno = "Novecentos";
                else if (numero >= 900 && numero <= 909)
                {
                string und = numero.ToString().Substring(1,2); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Novecentos e "; // atribuindo valo a retorno
                retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                else
                {
                string und = numero.ToString().Substring(1,2); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Novecentos e "; // atribuindo valo a retorno
                retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
            }
            
                return retorno;


        }
    }
}