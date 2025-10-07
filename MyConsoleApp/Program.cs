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
                        HelloWorld();
                        break;
                    case "2":
                        Kalkulator();
                        break;
                    case "3":
                        CetakBilangan();
                        break;
                    case "4":
                        GanjilGenap();
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

        // Program 1: Hello World
        static void HelloWorld()
        {
            Console.WriteLine("\n=== Program Hello World ===");
            Console.WriteLine("Hello, World!");
        }

        // Program 2: Kalkulator Sederhana
        static void Kalkulator()
        {
            Console.WriteLine("\n=== Program Kalkulator ===");
            Console.Write("Masukkan angka pertama: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan angka kedua: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Pilih operasi (+, -, *, /): ");
            char op = Console.ReadKey().KeyChar;

            double hasil = 0;
            switch (op)
            {
                case '+': hasil = a + b; break;
                case '-': hasil = a - b; break;
                case '*': hasil = a * b; break;
                case '/': hasil = b != 0 ? a / b : double.NaN; break;
                default: Console.WriteLine("\nOperasi tidak valid!"); return;
            }

            Console.WriteLine($"\nHasil: {a} {op} {b} = {hasil}");
        }

        // Program 3: Cetak Bilangan 1-10
        static void CetakBilangan()
        {
            Console.WriteLine("\n=== Program Cetak Bilangan 1-10 ===");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // Program 4: Cek Ganjil/Genap
        static void GanjilGenap()
        {
            Console.WriteLine("\n=== Program Cek Ganjil/Genap ===");
            Console.Write("Masukkan angka: ");
            int angka = Convert.ToInt32(Console.ReadLine());

            if (angka % 2 == 0)
                Console.WriteLine($"{angka} adalah Genap.");
            else
                Console.WriteLine($"{angka} adalah Ganjil.");
        }
    }
}
