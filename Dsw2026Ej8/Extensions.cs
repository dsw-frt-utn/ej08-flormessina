namespace Dsw2026Ej8
{
    public static class Extensions
    {
        
        public static string ToProductCode(this string input)
        {
            
            return input.Trim().ToUpper().Replace(" ", "-");
        }
    }
}
