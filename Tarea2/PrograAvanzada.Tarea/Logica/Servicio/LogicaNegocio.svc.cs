﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Topicos.MiLogicaDeNegocio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class LogicaNegocio : ILogica
    {

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public ResultadoEcuacionCuadratica ResolverEcuacionCuadratica(float a, float b, float c)
        {
            //Topicos.MiLogicaDeNegocio.Logica.Especificacion.ResuelvaEcuacionCuadratica laEspecificacion = new Logica.Especificacion.ResuelvaEcuacionCuadratica();
            var laEspecificacion = new Logica.Especificacion.ResuelvaEcuacionCuadratica();
            var elResultado = laEspecificacion.ResolverEcuacionCuadratica(a, b, c);
            return elResultado;
        }
    }
}
