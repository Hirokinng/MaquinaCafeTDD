using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafe
{
    public class Cafetera
    {
        public int CantidadCafe { get; private set; }

        public Cafetera(int cantidadCafe)
        {
            CantidadCafe = cantidadCafe;
        }

        public bool HasCafe(int cantidadCafe)
        {
            return CantidadCafe >= cantidadCafe;
        }

        public void GiveCafe(int cantidadCafe)
        {
            if (HasCafe(cantidadCafe))
            {
                CantidadCafe -= cantidadCafe;
            }
        }
    }
}