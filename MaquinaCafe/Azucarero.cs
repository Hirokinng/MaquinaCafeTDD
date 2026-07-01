using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafe
{
    public class Azucarero
    {
        public int CantidadAzucar { get; private set; }

        public Azucarero(int cantidadAzucar)
        {
            CantidadAzucar = cantidadAzucar;
        }

        public bool HasAzucar(int cantidadAzucar)
        {
            return CantidadAzucar >= cantidadAzucar;
        }

        public void GiveAzucar(int cantidadAzucar)
        {
            if (HasAzucar(cantidadAzucar))
            {
                CantidadAzucar -= cantidadAzucar;
            }
        }
    }
}