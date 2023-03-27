using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumeroPorExtenso
{
    public class Milhar
    {
        public string MilharPorExtenso (int numero)
        {
            string retorno = "";
            Unidade unidade = new Unidade();
            Dezena dezena = new Dezena();
            Centena centena = new Centena();
            if(numero >= 1000 && numero <= 1999)
            {
                if(numero == 1000)
                retorno = "Um mil";              
                else if (numero >= 1000 && numero <= 1009)
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Um mil e "; // atribuindo valo a retorno
                retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                else if (numero >= 1010 && numero <= 1099)
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Um mil e "; // atribuindo valo a retorno
                retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                else
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Um mil e "; // atribuindo valo a retorno
                retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
            }

            if(numero >= 2000 && numero <= 2999)
            {
                if(numero == 2000)
                retorno = "Dois mil";              
                else if (numero >= 2000 && numero <= 2009)
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Dois mil e "; // atribuindo valo a retorno
                retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                else if (numero >= 2010 && numero <= 2099)
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Dois mil e "; // atribuindo valo a retorno
                retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                else
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Dois mil e "; // atribuindo valo a retorno
                retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
            }

            if(numero >= 3000 && numero <= 3999)
            {
                if(numero == 3000)
                retorno = "Três mil";              
                else if (numero >= 3000 && numero <= 3009)
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Três mil e "; // atribuindo valo a retorno
                retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                else if (numero >= 3010 && numero <= 3099)
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Três mil e "; // atribuindo valo a retorno
                retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                else
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Três mil e "; // atribuindo valo a retorno
                retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
            }

            if(numero >= 4000 && numero <= 4999)
            {
                if(numero == 4000)
                retorno = "Quatro mil";              
                else if (numero >= 4000 && numero <= 4009)
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Quatro mil e "; // atribuindo valo a retorno
                retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                else if (numero >= 4010 && numero <= 4099)
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Quatro mil e "; // atribuindo valo a retorno
                retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                else
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Quatro mil e "; // atribuindo valo a retorno
                retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
            }

            if(numero >= 5000 && numero <= 5999)
            {
                if(numero == 5000)
                retorno = "Cinco mil";              
                else if (numero >= 5000 && numero <= 5009)
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Cinco mil e "; // atribuindo valo a retorno
                retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                else if (numero >= 5010 && numero <= 5099)
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Cinco mil e "; // atribuindo valo a retorno
                retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                else
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Cinco mil e "; // atribuindo valo a retorno
                retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
            }

            if(numero >= 6000 && numero <= 6999)
            {
                if(numero == 6000)
                retorno = "Seis mil";              
                else if (numero >= 6000 && numero <= 6009)
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Seis mil e "; // atribuindo valo a retorno
                retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                else if (numero >= 1010 && numero <= 1099)
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Seis mil e "; // atribuindo valo a retorno
                retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                else
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Seis mil e "; // atribuindo valo a retorno
                retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
            }
            if(numero >= 7000 && numero <= 7999)
            {
                if(numero == 7000)
                retorno = "Sete mil";              
                else if (numero >= 7000 && numero <= 7009)
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Sete mil e "; // atribuindo valo a retorno
                retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                else if (numero >= 7010 && numero <= 7099)
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Sete mil e "; // atribuindo valo a retorno
                retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                else
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Sete mil e "; // atribuindo valo a retorno
                retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
            }

            if(numero >= 8000 && numero <= 8999)
            {
                if(numero == 8000)
                retorno = "Oito mil";              
                else if (numero >= 8000 && numero <= 8009)
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Oito mil e "; // atribuindo valo a retorno
                retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                else if (numero >= 1010 && numero <= 1099)
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Oito mil e "; // atribuindo valo a retorno
                retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                else
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Oito mil e "; // atribuindo valo a retorno
                retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
            }

            if(numero >= 9000 && numero <= 9999)
            {
                if(numero == 9000)
                retorno = "Nove mil";              
                else if (numero >= 9000 && numero <= 9009)
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Nove mil e "; // atribuindo valo a retorno
                retorno += unidade.UnidadePorEstenso(Convert.ToInt32(und)); //+= ele vai acumular a string de cima e atriuir o valor
                }
                else if (numero >= 9010 && numero <= 9099)
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Nove mil e "; // atribuindo valo a retorno
                retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
                else
                {
                string und = numero.ToString().Substring(1,3); //quebrar o numero - do indice 1 quero 1 caracter
                retorno = "Nove mil e "; // atribuindo valo a retorno
                retorno += centena.CentenaPorExtenso(Convert.ToInt32(und));
                }
            }
                return retorno;

        }

    }
}