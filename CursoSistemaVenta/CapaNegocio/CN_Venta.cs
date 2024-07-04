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
    public class CN_Venta
    {
        private CD_Ventas capaDatos = new CD_Ventas();

        public int ObtenerCorrelativo()
        {
            return capaDatos.ObtenerCorrelativo();
        }

        public bool RestarStock(int idProducto, int cantidad)
        {
            return capaDatos.RestarStock(idProducto, cantidad);
        }

        public bool SumarStock(int idProducto, int cantidad)
        {
            return capaDatos.SumarStock(idProducto, cantidad);
        }

        public bool Registrar(Venta entidad, DataTable DetalleVenta, out string Mensaje)
        {
            return capaDatos.Registrar(entidad, DetalleVenta, out Mensaje);
        }

        public Venta ObtenerVenta(string numero)
        {
            Venta oVenta = capaDatos.ObtenerVenta(numero);
            if (oVenta.IdVenta != 0)
            {
                List<Detalle_Venta> oDetalleVenta = capaDatos.ListadoDetalleVenta(oVenta.IdVenta);
                oVenta.oDetalleVenta = oDetalleVenta;
            }

            return oVenta;
        }
    }
}
