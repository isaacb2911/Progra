using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograAvanzada.Tarea.Logica.Especificacion
{
    public class ResuelvaECuadratica
    {
        public ResultadoEcuacionCuadratica ResolverEcuacionCuadratica(float a, float b, float c)
        {
            var laAccion = new Logica.Accion.ResolverEcuacionCuadratica();
            ResultadoEcuacionCuadratica elResultado = laAccion.ResuelvaEcuacionCuadratica(a, b, c);
            return elResultado;
        }

    }
}