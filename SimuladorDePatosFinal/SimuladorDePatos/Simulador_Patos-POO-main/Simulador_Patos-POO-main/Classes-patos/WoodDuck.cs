using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Patos_POO
{
    internal class WoodDuck : Pato, IReciclar
    {
        public string Reciclavel()
        {
            return "Meio ambiente";
        }
        public override string display()
        {
            return "Pato de Madeira!";
        }
        
    }

    
}
