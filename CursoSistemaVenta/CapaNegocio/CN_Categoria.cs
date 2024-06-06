using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria cdCategoria = new CD_Categoria();

        public List<Categoria> Listar()
        {
            return cdCategoria.Listar();
        }

        public int Registrar(Categoria entidad, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (entidad.Descripcion == "")
            {
                Mensaje += "Es necesaria la descripción de la categoria\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return cdCategoria.Registrar(entidad, out Mensaje);
            }
        }

        public bool Editar(Categoria entidad, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (entidad.Descripcion == "")
            {
                Mensaje += "Es necesaria la descripción de la categoria\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return cdCategoria.Editar(entidad, out Mensaje);
            }
        }

        public bool Eliminar(Categoria entidad, out string Mensaje)
        {
            return cdCategoria.Eliminar(entidad, out Mensaje);
        }
    }
}
