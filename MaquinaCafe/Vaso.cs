using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafe
{
    public class Vaso
    {
        public int CantidadVasos { get; private set; }
        public int Contenido { get; private set; }

        public Vaso(int cantidadVasos, int contenido)
        {
            CantidadVasos = cantidadVasos;
            Contenido = contenido;
        }

        public bool HasVasos(int cantidad)
        {
            return CantidadVasos >= cantidad;
        }

        public void GiveVasos(int cantidad)
        {
            if (HasVasos(cantidad))
            {
                CantidadVasos -= cantidad;
            }
        }
    }
}