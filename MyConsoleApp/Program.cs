namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("===== MENU PROGRAM =====");
                Console.WriteLine("1. Hello World");
                Console.WriteLine("2. Kalkulator Sederhana");
                Console.WriteLine("3. Menampilkan Bilangan 1-10");
                Console.WriteLine("4. Mengecek Angka Ganjil/Genap");
                Console.WriteLine("5. Keluar");
                Console.Write("Pilih menu (1-5): ");

                string pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "1":
                        HelloWorldApp.Run();
                        break;
                    case "2":
                        CalculatorApp.Run();
                        break;
                    case "3":
                        NumberPrinterApp.Run();
                        break;
                    case "4":
                        OddEvenApp.Run();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
                    Console.ReadLine();
                }
            }
        }
    }
}