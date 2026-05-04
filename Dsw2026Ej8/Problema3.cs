namespace Dsw2026Ej8
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int valorCopia = originalValue;
            
            valorCopia++;

            Product productoCopia = product;
           
            productoCopia.SetDescription("Modificado");

            return $"{originalValue}-{valorCopia}-{product.Description}";
        }
    }
}
