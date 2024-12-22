using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Construtor
{
    internal class Pessoa
    {
        // Construtor
        public Pessoa()
        {
            Console.WriteLine("Construtor Executado");
        }
        public Pessoa(string nome)
        {
            Console.WriteLine($"Ola {nome}");
        }
    }
}
