using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        private CD_Proveedor cdProveedor = new CD_Proveedor();

        public List<Proveedor> Listar()
        {
            return cdProveedor.Listar();
        }

        public int Registrar(Proveedor entidad, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (entidad.Documento == "")
            {
                Mensaje += "Es necesario el documento del Proveedor\n";
            }

            if (entidad.RazonSocial == "")
            {
                Mensaje += "Es necesario la razon social para el Proveedor\n";
            }

            if (entidad.Correo == "")
            {
                Mensaje += "Es necesario el correo del Proveedor\n";
            }

            if (entidad.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del Proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return cdProveedor.Registrar(entidad, out Mensaje);
            }
        }

        public bool Editar(Proveedor entidad, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (entidad.Documento == "")
            {
                Mensaje += "Es necesario el documento del Proveedor\n";
            }

            if (entidad.RazonSocial == "")
            {
                Mensaje += "Es necesario la razon social para el Proveedor\n";
            }

            if (entidad.Correo == "")
            {
                Mensaje += "Es necesario el correo del Proveedor\n";
            }

            if (entidad.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del Proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return cdProveedor.Editar(entidad, out Mensaje);
            }
        }

        public bool Eliminar(Proveedor entidad, out string Mensaje)
        {
            return cdProveedor.Eliminar(entidad, out Mensaje);
        }
    }
}
