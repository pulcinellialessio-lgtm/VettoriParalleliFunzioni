namespace VettoriParalleliFunzioni
{
    internal class Program
    {
        static void stampa_inventario( string[] prodotti, int[] quantità)
        {
            for(int i = 0; i < prodotti.Length; i++)
            {
                Console.Write(prodotti[i] + "   ");
            }

            Console.WriteLine("    ");

            for (int i = 0; i < quantità.Length; i++)
            {
                Console.Write(quantità[i] + "       ");
            }
        }
        static string cerca_libro()
        static void Main(string[] args)
        {
            string[] prodotti = { "mela", "banana", "arancia", "uva" };

            int[] quantità = { 10, 5, 12, 34 };

            stampa_inventario(prodotti, quantità); 
        }
    }
}
