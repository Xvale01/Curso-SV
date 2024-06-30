using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Compra
    {
        private CD_Compra cdCompra = new CD_Compra();

        public int ObtenerCorrelativo()
        {
            return cdCompra.ObtenerCorrelativo();
        }

        public bool Registrar(Compra entidad, DataTable DetalleCompra, out string Mensaje)
        {
            return cdCompra.Registrar(entidad, DetalleCompra, out Mensaje);
        }
    }
}
