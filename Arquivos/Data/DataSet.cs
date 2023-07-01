using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Arquivos.Models;

namespace Arquivos.Data
{

    public static class DataSet
    {
        public static List<Client> Clients
            = new List<Client> ();

        public static List<Animal> Animals
            = new List<Animal> ();
        public static List<Veterinario> Veterinarios
            = new List<Veterinario> ();

        public static List<Clinica> Clinicas
            = new List<Clinica> ();

    }

}