using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograAvanzada.Tarea.Logica.Accion
{
    public class ECuadratica
    {
        internal ECuadratica ECuadratica(float a, float b, float c)
        {
            var Resultado = new ECuadratica();
            Resultado.PrimeraRaiz = Resultado.SegundaRaiz = null;
            // validar las entradas
            var laValidacion = new Validacion.EcuacionesCuadraticas();
            if (laValidacion.AEsDiferenteDeCero(a))
            {
                Resultado.Discriminante = CalcularDiscriminante(a, b, c);
                if (laValidacion.ElDiscriminanteEsMayorOIgualQueCero(Resultado.Discriminante))
                {
                    Resultado.PrimeraRaiz = CalcularRaiz(a, b, c, Resultado.Discriminante, true);
                    Resultado.SegundaRaiz = CalcularRaiz(a, b, c, Resultado.Discriminante, false);
                }
            }
            return Resultado;
        }

        internal double CalcularDiscriminante(double a, double b, double c)
        {
            double Resultado = (b * b - 4 * a * c);
            return Resultado;
        }

        [Obsolete]
        internal double CalcularRaizConMas(double a, double b, double c, double Discriminante)
        {
            var Resultado = (-b + Math.Sqrt(Discriminante)) / (2 * a);
            return Resultado;
        }

        [Obsolete]
        internal double CalcularRaizConMenos(double a, double b, double c, double Discriminante)
        {
            var Resultado = (-b - Math.Sqrt(Discriminante)) / (2 * a);
            return Resultado;
        }

        internal double CalcularRaiz(double a, double b, double c, double Discriminante, bool hagoUnaSuma)
        {
            double elSigno = (hagoUnaSuma) ? 1.0 : -1.0;
            var Resultado = (-b + (elSigno) * Math.Sqrt(Discriminante)) / (2 * a);
            return Resultado;
        }

    }
}
