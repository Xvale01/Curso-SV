using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Negocio
    {
        private CD_Negocio cdNegocio = new CD_Negocio();

        public Negocio ObtenerDatos()
        {
            return cdNegocio.ObtenerDatos();
        }

        public bool GuardarDatos(Negocio entidad, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (entidad.Nombre == "")
            {
                Mensaje += "Es necesario el nombre\n";
            }

            if (entidad.RUC == "")
            {
                Mensaje += "Es necesario el nombre del RUC\n";
            }

            if (entidad.Direccion == "")
            {
                Mensaje += "Es necesaria la dirección\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return cdNegocio.GuardarDatos(entidad, out Mensaje);
            }
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            return cdNegocio.ObtenerLogo(out obtenido);
        }

        public bool ActualizarLogo(byte[] image,out string mensaje)
        {
            return cdNegocio.ActualizarLogo(image, out mensaje);
        }

    }
}
