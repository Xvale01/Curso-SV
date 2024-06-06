using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private CD_Producto cdProducto = new CD_Producto();

        public List<Producto> Listar()
        {
            return cdProducto.Listar();
        }

        public int Registrar(Producto entidad, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (entidad.Codigo == "")
            {
                Mensaje += "Es necesario el codigo del producto\n";
            }

            if (entidad.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del producto\n";
            }

            if (entidad.Descripcion == "")
            {
                Mensaje += "Es necesario la descripción del producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return cdProducto.Registrar(entidad, out Mensaje);
            }
        }

        public bool Editar(Producto entidad, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (entidad.Codigo == "")
            {
                Mensaje += "Es necesario el codigo del producto\n";
            }

            if (entidad.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del producto\n";
            }

            if (entidad.Descripcion == "")
            {
                Mensaje += "Es necesario la descripción del producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return cdProducto.Editar(entidad, out Mensaje);
            }
        }

        public bool Eliminar(Producto entidad, out string Mensaje)
        {
            return cdProducto.Eliminar(entidad, out Mensaje);
        }
    }
}
