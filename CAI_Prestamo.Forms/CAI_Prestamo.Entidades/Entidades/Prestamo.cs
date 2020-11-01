using CAI_Prestamo.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Prestamo.Entidades
{
    public class Prestamo
    {
        private TipoPrestamo tipoPrestamo;
        private int plazo;
        private double monto;
        private string usuario;

        public TipoPrestamo TipoPrest
        {
            get
            {
                return this.tipoPrestamo;
            }
            set
            {
                this.tipoPrestamo = value;
            }
        }
        public int Plazo
        {
            get
            {
                return this.plazo;
            }
            set
            {
                this.plazo = value;
            }
        }
        public double Monto
        {
            get
            {
                return this.monto;
            }
            set
            {
                this.monto = value;
            }
        }
        public string Usuario
        {
            get
            {
                return this.usuario;
            }
            set
            {
                this.usuario = value;
            }
        }
        public double CuotaCapital ()
        {
            return monto/plazo;
        }
        public double CuotaInteres()
        {
            return CuotaCapital() * (tipoPrestamo.TNA * 100 / 12);
    }
        public double Cuota()
        {
            return CuotaCapital()+ CuotaInteres();
        }
    }
}
