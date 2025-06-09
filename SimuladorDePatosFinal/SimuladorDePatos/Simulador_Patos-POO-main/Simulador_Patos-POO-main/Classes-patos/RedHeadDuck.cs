using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Patos_POO
{
    public class RedHeadDuck: Pato, IFlayable,IQuackable
    {
        public string display()
        {
            return "Pato Cabeça Vermelha!";
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
