using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Patos_POO
{
    public class RobotDuck : Pato, IFlayable, IQuackable, IEnferrujar
    {
        public string quack()
        {
            return "Eu falo";
        }

        public string display()
        {
            return "Pato Robô!";
        }
        
        public string fly()
        {
            return "Voar";
        }

        public string Enferrujar()
        {
            return "Condição";
        }
    }
}
