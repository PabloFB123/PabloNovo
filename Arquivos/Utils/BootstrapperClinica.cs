using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Data;
using Arquivos.Models;


namespace Arquivos.Utils
{
    public static class BootstrapperClinica
    {
        public static void ChargeClinicas()
        {
            var c1 = new Clinica
            {
                IdC = 1,
                NameC = "Cao e gato",
                PhoneC = "4900001111",
                CountryC = "Brazil",
                StateC = "SC",
                CityC = "Caçador",
                RoadC = "Salgado Filho",
                NumberC = "000"
            };

            DataSet.Clinicas.Add(c1);

            DataSet.Clinicas.Add // esta forma economiza espaço de memória
            (
                new Clinica
                {
                IdC = 1,
                NameC = "Gato e Cao",
                PhoneC = "4911110000",
                CountryC = "Brazil",
                StateC = "SC",
                CityC = "Caçador",
                RoadC = "Barão do Rio Branco",
                NumberC = "111"
                }
            );
        }
    }
}