using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luc3
{
    internal class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public Persona(string _nome, string _cognome)
        {
            Nome = _nome;
            Cognome = _cognome;
        }

        public string StampaNomeCompleto()
        {
            return $"{Nome} {Cognome}";
        }





    }
}
