using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        private CD_Cliente cdCliente = new CD_Cliente();

        public List<Cliente> Listar()
        {
            return cdCliente.Listar();
        }

        public int Registrar(Cliente entidad, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (entidad.Documento == "")
            {
                Mensaje += "Es necesario el documento del Cliente\n";
            }

            if (entidad.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del Cliente\n";
            }

            if (entidad.Correo == "")
            {
                Mensaje += "Es necesario el correo del Cliente\n";
            }

            if (entidad.Telefono == "")
            {
                Mensaje += "Es necesario el teléfono del Cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return cdCliente.Registrar(entidad, out Mensaje);
            }
        }

        public bool Editar(Cliente entidad, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (entidad.Documento == "")
            {
                Mensaje += "Es necesario el documento del Cliente\n";
            }

            if (entidad.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del Cliente\n";
            }
            if (entidad.Correo == "")
            {
                Mensaje += "Es necesario el correo del Cliente\n";
            }
            if (entidad.Telefono == "")
            {
                Mensaje += "Es necesario el teléfono del Cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return cdCliente.Editar(entidad, out Mensaje);
            }
        }

        public bool Eliminar (Cliente entidad,  out string Mensaje)
        {
            return cdCliente.Eliminar(entidad, out Mensaje);
        }
    }
}
