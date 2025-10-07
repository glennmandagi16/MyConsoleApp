namespace MyConsoleApp
{
    public static class NumberPrinterApp
    {
        public static void Run()
        {
            Console.WriteLine("\n=== Program Cetak Bilangan 1-10 ===");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
