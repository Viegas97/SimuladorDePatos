using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Simulador_Patos_POO.Interfaces_skills;

namespace Simulador_Patos_POO
{
    public class MallardDuck : Pato, IFlayable, IQuackable, ISwimmable
    {
        public string display()
        {
            return "Pato Real!";
        }
        
        public string fly()
        {
            return "Voar";
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
