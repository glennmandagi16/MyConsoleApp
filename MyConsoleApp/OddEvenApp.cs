namespace MyConsoleApp
{
    public static class OddEvenApp
    {
        public static void Run()
        {
            Console.WriteLine("\n=== Program Cek Ganjil/Genap ===");
            Console.Write("Masukkan angka: ");
            int angka = Convert.ToInt32(Console.ReadLine());

            if (angka % 2 == 0)
                Console.WriteLine($"{angka} adalah bilangan Genap.");
            else
                Console.WriteLine($"{angka} adalah bilangan Ganjil.");
        }
    }
}
