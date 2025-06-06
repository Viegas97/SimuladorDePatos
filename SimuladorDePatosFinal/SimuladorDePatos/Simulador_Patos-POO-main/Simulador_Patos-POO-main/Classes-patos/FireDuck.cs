using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Patos_POO
{
    internal class FireDuck : IFlayable, IBoladefogo, IQuackable
    {
        public string SoltarFogo()
        {
            return "Cuspir fogo";
        }
        public string display()
        {
            return "Pato de Fogo!";
        }
        
        public string fly()
        {
            return "Voar";
        }

        public string quack()
        {
            return "Eu falo";
        }

    }
}
