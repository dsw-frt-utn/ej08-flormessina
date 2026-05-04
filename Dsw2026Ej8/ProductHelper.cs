namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
       
public string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            string precioFinal = FormatearPrecio (price);
            return $"[{code}] {description} -  {precioFinal}";

        }
        
        public object ObtenerInformacionProducto(long code, string description, decimal price)
{
    
    return new 
    {
        Codigo = code,
        Descripcion = description,
        Precio = price,
        FechaDeCarga = DateTime.Now // DateTime.Now te da la fecha y hora de tu PC
    };
}


    }
}
