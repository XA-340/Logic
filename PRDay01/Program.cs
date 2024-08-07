namespace PRDay01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("==============\n");

            Console.WriteLine("=== PROGRAM MENGHITUNG NILAI ===");
            int nilai;
            Console.Write("Masukkan nilai: ");
            int.TryParse(Console.ReadLine(), out nilai);
            Console.WriteLine(Grade(nilai));

            Console.WriteLine("\n=== PROGRAM MENENTUKAN GANJIL / GENAP ===");
            int angka;
            Console.Write("Masukkan angka: ");
            int.TryParse(Console.ReadLine(), out angka);
            Console.WriteLine(EvenOdd(angka));
        }

        static string Grade(int score)
        {
            if (score >= 80)
            {
                return "A";
            } else if (score >= 60)
            {
                return "B";
            } else if (score < 60)
            {
                return "C";
            } else
            {
                return "Score out of range!";
            }
        }

        static string EvenOdd(int angka)
        {
            if (angka % 2 == 0) {
                return $"angka {angka} adalah genap";
            } else
            {
                return $"angka {angka} adalah ganjil";
            }
        }
    }
}
 