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
        private CD_Compra capaDatos = new CD_Compra();

        public int ObtenerCorrelativo()
        {
            return capaDatos.ObtenerCorrelativo();
        }

        public bool Registrar(Compra entidad, DataTable DetalleCompra, out string Mensaje)
        {
            return capaDatos.Registrar(entidad, DetalleCompra, out Mensaje);
        }

        public Compra ObtenerCompra(string numero)
        {
            Compra oCompra = capaDatos.ObtenerCompra(numero);
            if (oCompra.IdCompra != 0)
            {
                List<Detalle_Compra> oDetalleCompra = capaDatos.ListadoDetalleCompra(oCompra.IdCompra);
                oCompra.oDetalleCompra= oDetalleCompra;
            }

            return oCompra;
        }
    }
}
