using System;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productHelper = new ProductHelper();
            string etiqueta = productHelper.ObtenerEtiquetaProducto(1001, "Monitor 24 pulgadas", 185000.50m);
            Console.WriteLine(etiqueta);

            var problema2 = new Problema2();
            string resumenVenta = problema2.CrearResumenVenta(1001, "Monitor 24 pulgadas", 2, 185000.50m);
            Console.WriteLine(resumenVenta);

            var problema3 = new Problema3();
            var producto = new Product();
            producto.SetDescription("Teclado Mecanico");
            string resultadoCopias = problema3.CompararCopias(5, producto);
            Console.WriteLine(resultadoCopias);

            var problema4 = new Problema4();
            double promedio = problema4.CalcularPromedio(8, null, 10);
            Console.WriteLine($"Promedio: {promedio}");

            var problema5 = new Problema5();
            Sale venta = new WholesaleSale { Amount = 50000m };
            decimal totalFinal = problema5.ObtenerImporteFinal(venta);
            Console.WriteLine($"Importe final: {totalFinal}");

            var problema6 = new Problema6();
            string codigoNormalizado = problema6.NormalizarCodigoProducto("  prod 99 x  ");
            Console.WriteLine(codigoNormalizado);
        }
    }
}

