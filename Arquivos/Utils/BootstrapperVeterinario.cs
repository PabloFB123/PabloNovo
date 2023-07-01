using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Data;
using Arquivos.Models;


namespace Arquivos.Utils
{
    public static class BootstrapperVeterinario
    {
        public static void ChargeVeterinarios()
        {
            var c1 = new Veterinario
            {
                IdVet = 1,
                FirstNameVet = "Chuck",
                LastNameVet = "Norris",
                CPFVet = "000.000.000-00",
                CrmVet = "123456789"
            };

            DataSet.Veterinarios.Add(c1);

            DataSet.Veterinarios.Add // esta forma economiza espaço de memória
            (
                new Veterinario
                {
                IdVet = 1,
                FirstNameVet = "Arnold",
                LastNameVet = "Shcwarzenegger",
                CPFVet = "000.000.000-01",
                CrmVet = "987456321"
                }
            );
        }
    }
}