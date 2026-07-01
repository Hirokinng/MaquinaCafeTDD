using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafe
{
    public class MaquinaDeCafe
    {
        public Cafetera Cafetera { get; set; }
        public Vaso VasosPequeno { get; set; }
        public Vaso VasosMediano { get; set; }
        public Vaso VasosGrande { get; set; }
        public Azucarero Azucarero { get; set; }

        public MaquinaDeCafe()
        {
        }

        public Vaso GetTipoDeVaso(string tipoDeVaso)
        {
            switch (tipoDeVaso.ToLower())
            {
                case "pequeno":
                case "pequeño":
                    return VasosPequeno;

                case "mediano":
                    return VasosMediano;

                case "grande":
                    return VasosGrande;

                default:
                    return null;
            }
        }

        public string GetVasoDeCafe(Vaso vaso, int cantidadDeVasos, int cantidadDeAzucar)
        {
            if (vaso == null || !vaso.HasVasos(cantidadDeVasos))
            {
                return "No hay Vasos";
            }

            int cantidadCafeNecesaria = vaso.Contenido * cantidadDeVasos;

            if (!Cafetera.HasCafe(cantidadCafeNecesaria))
            {
                return "No hay Cafe";
            }

            if (!Azucarero.HasAzucar(cantidadDeAzucar))
            {
                return "No hay Azucar";
            }

            vaso.GiveVasos(cantidadDeVasos);
            Cafetera.GiveCafe(cantidadCafeNecesaria);
            Azucarero.GiveAzucar(cantidadDeAzucar);

            return "Felicitaciones";
        }
    }
}