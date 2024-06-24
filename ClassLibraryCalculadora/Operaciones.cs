using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCalculadora
{
    public class Operaciones
    {
        public int Sumar(int nro1, int nro2)
        {
            return nro1 + nro2;
        }
        public int Restar(int nro1, int nro2)
        {
            return nro1 - nro2;
        }
        public int Multiplicar(int nro1, int nro2)
        {
            return nro1 * nro2;
        }
        public float Dividir(int nro1, int nro2)
        {
            return (float)nro1 / nro2;
        }

    }
}
