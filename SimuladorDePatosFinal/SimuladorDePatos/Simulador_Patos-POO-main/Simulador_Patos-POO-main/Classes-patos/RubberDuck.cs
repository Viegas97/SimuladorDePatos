using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulador_Patos_POO.Interfaces_skills;

namespace Simulador_Patos_POO
{
    public class RubberDuck : IQuackable, ISwimmable
    {
        public string display()
        {
            return "Pato de Borracha!";
        }
        
        public string quack()
        {
            return "Quack";
        }

        public string Nadar()
        {
            return "Nadar";
        }

    }
}
