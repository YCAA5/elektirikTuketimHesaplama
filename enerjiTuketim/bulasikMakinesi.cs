namespace enerjiTuketim
{
    public class BulasikMakinesi 
    {
        public static void Calistir() // 1. Seçim
        {
            const double tuketimBedeli = 2.07D;
            Console.Write("Bulaşık Makinesi çalışma süresini giriniz (saat): ");
            int calismaSuresi = Convert.ToInt32(Console.ReadLine());

            double gunlukTuketim = HesaplaTuketim(calismaSuresi);
            double[] zamanCarpanlari = { 1, 7, 30, 365 };
            string[] zamanDilimi = { "1 gün", "1 hafta", "1 ay", "1 yıl" };

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < zamanCarpanlari.Length; i++)
            {
                double toplamTuketim = gunlukTuketim * zamanCarpanlari[i];
                double toplamBedel = toplamTuketim * tuketimBedeli;
                
                Console.WriteLine($"{calismaSuresi} saatlik kullanım için yaklaşık {zamanDilimi[i]}de {toplamTuketim:F2} kW elektrik, {toplamBedel:F2} TL fatura.");
            }
            Console.WriteLine("\nNot:Sonuçlar değişkenlik gösterebilir.\nFiyatlar 2024 yılı için geçerlidir.\nDevam etmek için 'Enter' tuşuna basınız.");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            
        }

        private static double HesaplaTuketim(double saat)
        {
            Random minMaxGucTuketim = new Random();
            int gucTuketim = minMaxGucTuketim.Next(1199,1500);
            // const int minGuc = 1200;
            return gucTuketim * saat / 1000; // 1200-1500 arasında değer döndürür.
        }
    }
}
