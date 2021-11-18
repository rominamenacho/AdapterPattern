using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class ElectricoAdapter : Motor
    {
        MotorElectrico motorElectrico = new MotorElectrico();
        public override void Acelerar()
        {
            motorElectrico.Mover();
        }

        public override void Apagar()
        {
            motorElectrico.Parar();
        }

        public override void Arrancar()
        {
            motorElectrico.Conectar();
            motorElectrico.Activar();
        }

        public override void CargarCombustible()
        {
            motorElectrico.Enchufar();
        }

        public override void Detener()
        {
            motorElectrico.Desconectar();
            motorElectrico.Parar();
        }
    }
}
