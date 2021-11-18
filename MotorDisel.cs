using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class MotorDisel : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("acelerando motor disel");
        }

        public override void Apagar()
        {
            Console.WriteLine("apagando motor disel");
        }

        public override void Arrancar()
        {
            Console.WriteLine("arrancando motor disel");
        }

        public override void CargarCombustible()
        {
            Console.WriteLine("cargando combustible motor disel");
        }

        public override void Detener()
        {
            Console.WriteLine("Deteniendo motor disel");
        }
    }
}
