using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class MotorElectrico
    {
        bool _conectado;
        bool _activo;
        bool _moviendo;

        public void Activar() {
            if (!_conectado)
            {
                Console.WriteLine("imposible activar un motor no conectado");
            }
            else
            {
                _activo = true;
                Console.WriteLine("Motor activado");
             }
        }

        public void Conectar() {
            if (_conectado)
            {
                Console.WriteLine("Motor electrico conectado, no es posible conectar");
            }
            else
            {
                _conectado = true;
                Console.WriteLine("Conectando motor electrico");
            }
        }
        public void Desconectar() {
            if (_conectado)
            {
                _conectado = false;
                Console.WriteLine("desconectando motor electrico");
            }
            else
            {
                Console.WriteLine("imposible desconectar. ya se encuentra desconectado");
            }



        }
        public void Enchufar() {
            if (_activo)
            {
                _activo = false;
                Console.WriteLine("Motor cargando las baterias");
            }
            else
            {
                Console.WriteLine("imposible enchufar un motor activo");
            }
        }
        public void Mover() { 
        if(_conectado && _activo)
            {
                _moviendo = true;
                Console.WriteLine("moviendo vehiculo con motor electrico");
            }
            else
            {
                Console.WriteLine("El motor deberia estar conectado");
            }
        }
        public void Parar() {
            if (_moviendo)
            {
                _moviendo = false;
                Console.WriteLine("Parando vehiculo con motor electrico");
            }
            else
            {
                Console.WriteLine("Imposible parar un motor que no se esta en moviento");
            }
        }

    }
}
