using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Data;
using Arquivos.Models;


namespace Arquivos.Utils
{
    public static class BootstrapperAnimal
    {
        public static void ChargeAnimals()
        {
            var c1 = new Animal
            {
                IdA = 1,
                NomeA = "Luky",
                TipoA = "Cao",
                RacaA = "Beagle",
                PesoA = "26 kg"
            };

            DataSet.Animals.Add(c1);

            DataSet.Animals.Add // esta forma economiza espaço de memória
            (
                new Animal
                {
                IdA = 1,
                NomeA = "Lara",
                TipoA = "Cao",
                RacaA = "beagle",
                PesoA = "12 kg"
                }
            );
        }
    }
}