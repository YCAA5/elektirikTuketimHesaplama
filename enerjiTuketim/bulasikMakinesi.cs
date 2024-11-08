namespace enerjiTuketim
{
    public class BulasikMakinesi 
    {
        public static void Calistir()
        {
            Console.Clear();
            const double tuketimBedeli = 2.07;
            Console.Write("Bulaşık Makinesi çalışma süresini giriniz (saat): ");
            int calismaSuresi = Convert.ToInt32(Console.ReadLine());

            double gunlukTuketim = HesaplaTuketim(calismaSuresi);
            double[] zamanCarpanlari = { 1, 7, 30, 365 };
            string[] zamanDilimi = { "1 gün", "1 hafta", "1 ay", "1 yıl" };

            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < zamanCarpanlari.Length; i++)
            {
                double toplamTuketim = gunlukTuketim * zamanCarpanlari[i];
                double toplamBedel = toplamTuketim * tuketimBedeli;
                
                Console.WriteLine($"{calismaSuresi} saatlik kullanım için {zamanDilimi[i]}de {toplamTuketim:F2} kW elektrik, {toplamBedel:F2} TL fatura.");
            }

            Console.ResetColor();
        }

        private static double HesaplaTuketim(double saat)
        {
            const int minGuc = 1200;
            return minGuc * saat / 1000; // Minimum güç üzerinden tüketimi döndür
        }
    }
}
