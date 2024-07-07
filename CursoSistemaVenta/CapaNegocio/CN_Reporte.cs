using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Reporte
    {
        private CD_Reporte cd = new CD_Reporte();

        public List<ReporteCompra> Compra(string fechainicio, string fechafin, int idproveedor, out string mensaje)
        {
            return cd.Compra(fechainicio, fechafin, idproveedor, out mensaje);
        }

        public List<ReporteVenta> Venta(string fechainicio, string fechafin, out string mensaje)
        {
            return cd.Venta(fechainicio, fechafin, out mensaje);
        }
    }
}
