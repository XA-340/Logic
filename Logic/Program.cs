namespace Logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tHello, World!");
            Console.WriteLine("==================\n");

            //Day01.ArithmaticOperators();
            //string teks1 = "abcdefgh\b \"akhir\"";
            //string teks1 = "10";
            //Day01.StringOperation(teks1, "100");

            Console.WriteLine("=== PROGRAM MENGHITUNG LUAS DAN KELILING LINGKARAN ===");
            Console.Write("Input Jari-Jari Lingkaran: ");
            double radius; 
            double.TryParse(Console.ReadLine(), out radius);
            double keliling = Day01.HitungKelilingLingkaran(radius);
            Console.WriteLine($"Keliling Lingkaran: {keliling}");
            double luas = Day01.HitungLuasLingkaran(radius);
            Console.WriteLine($"Luas Lingkaran: {luas}");

            Console.WriteLine("\n=== PROGRAM MENGHITUNG LUAS DAN KELILING PERSEGI ===");
            Console.Write("Input Sisi Persegi: ");
            double sisi;
            double.TryParse(Console.ReadLine(), out sisi);
            keliling = Day01.HitungKelilingPersegi(sisi);
            Console.WriteLine($"Keliling Persegi: {keliling}");
            luas = Day01.HitungLuasPersegi(sisi);
            Console.WriteLine($"Luas Persegi: {luas}");

            Console.WriteLine("\n=== PROGRAM MENGHITUNG MODULUS ===");
            int angka, pembagi;
            Console.Write("Input angka: ");
            int.TryParse(Console.ReadLine(), out angka);
            Console.Write("Input pembagi: ");
            int.TryParse(Console.ReadLine(), out pembagi);
            Console.WriteLine(Day01.HitungModulus(angka, pembagi));

            Console.WriteLine("\n=== PROGRAM MENGHITUNG PUNTUNG ROKOK ===");
            int puntung;
            Console.Write("Masukkan puntung rokok yang didapat: ");
            int.TryParse(Console.ReadLine(), out puntung);
            Day01.HitungRokok(puntung);
        }
    }

    internal class Day01
    {
        internal static void ArithmaticOperators()
        {
            int a = 0;
            /*
             * jika a++ maka ditampilkan dulu baru dijumlahkan atau dikurangkan
             * jika ++a maka dijumlahkan atau dikurangkan terlebih dahulu baru ditampilkan
             */
            Console.WriteLine("a++: " + a++);
            Console.WriteLine("a: " + a);
            Console.WriteLine("++a: " + ++a);

            int mangga, apel, hasil = 0;

            Console.Write("Mangga = ");
            mangga = int.Parse(Console.ReadLine());
            Console.Write("Apel = ");
            apel = int.Parse(Console.ReadLine());

            hasil = mangga + apel;

            Console.WriteLine($"Hasil mangga + apel = {hasil}");
        }

        internal static void StringOperation(string? teks, string teks2)
        {
            /*
             * kalo null, lokasi atributnya blm ada,jd blm bisa diapa2in
             * kalo empty / string kosong,lokasinya udh ada
             * 
             * INTERPOLATION STRING: $"Teks: {teks}"
             */
            //string? teks = "abcd";
            Console.WriteLine($"Teks: {teks}");
            Console.WriteLine($"Teks UPPER: {teks.ToUpper()}");
            Console.WriteLine($"Teks LOWER: {teks.ToLower()}");
            Console.WriteLine($"Jumlah karakter: {teks.Length}");
            Console.WriteLine($"Karakter Teks #0: {teks[0]}");
            Console.WriteLine($"Karakter Teks #7: {teks[7]}");
            Console.WriteLine($"Karakter Z ada pada indeks ke: {teks.IndexOf("Z")}");
            Console.WriteLine($"Karakter a ada pada indeks ke: {teks.IndexOf("a")}");
            Console.WriteLine($"Karakter Za ada pada indeks ke: {teks.IndexOf("Za")}");
            Console.WriteLine($"Karakter aZ ada pada indeks ke: {teks.IndexOf("aZ")}");
            Console.WriteLine($"Karakter ba ada pada indeks ke: {teks.IndexOf("ba")}");
            Console.WriteLine($"Karakter ab ada pada indeks ke: {teks.IndexOf("ab")}");
        }

        internal static double HitungKelilingLingkaran(double jariJari)
        {
            return 2 * Math.PI * jariJari;
        }

        internal static double HitungLuasLingkaran(double jariJari)
        {
            return Math.PI * jariJari * jariJari;
        }

        internal static double HitungKelilingPersegi(double sisi)
        {
            return 4 * sisi;
        }

        internal static double HitungLuasPersegi(double sisi)
        {
            return sisi * sisi;
        }

        internal static string HitungModulus(int angka, int pembagi)
        {
            int hasil = angka % pembagi;
            if (hasil == 0)
            {
                return $"angka {angka} % {pembagi} adalah 0";
            }
            else
            {
                return $"angka {angka} % {pembagi} bukan 0 melainkan {hasil}";
            }
        }

        internal static void HitungRokok(int puntung)
        {
            Console.WriteLine($"{puntung} Puntung Terkumpul");
            Console.WriteLine($"{puntung/8} Batang Rokok");
            Console.WriteLine($"{puntung%8} Sisa Puntung");
            Console.WriteLine($"{(puntung/8) * 500} Rupiah Dihasilkan");
        }
    }
}
