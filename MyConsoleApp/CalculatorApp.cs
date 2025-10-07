namespace MyConsoleApp
{
    public static class CalculatorApp
    {
        public static void Run()
        {
            Console.WriteLine("\n=== Program Kalkulator ===");
            Console.Write("Masukkan angka pertama: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan angka kedua: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Pilih operasi (+, -, *, /): ");
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
    }
}
