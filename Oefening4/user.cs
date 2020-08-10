using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening4
{
    public class user
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }

        public user(string voornaam, string achternaam)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
        }

    }
}
