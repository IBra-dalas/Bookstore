﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewResto.Models
{
    public class Clients
    {

        public List<Client> ListeClients()
        {
            return new List<Client>
            {
                new Client{NomClient ="Mamadou", Email = "mamadou@gmail.com"},
                new Client{NomClient ="Razor", Email = "razor@gmail.com"},
            };
        }
    }
}
