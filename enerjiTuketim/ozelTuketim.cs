using System;

namespace enerjiTuketim
{
    public class ozelTuketim
    {
        public static void ozel240kWhalti() // 11. Seçim
        {
            Console.Clear();
            Console.WriteLine("Cihazın güç(W) değerini giriniz : ");
            double watt = double.Parse(Console.ReadLine());
            Console.WriteLine("Çalışma süresini(Saat) giriniz  : ");
            double sure = double.Parse(Console.ReadLine());
            if (sure < 0 || sure > 24)
            {
               Console.WriteLine("Verdiğiniz bilgiler dahilinde doğru sonuçlar alamayabilirsiniz.");
            }

            double kiloWatt = watt / 1000D; // kW hesaplama
            double normalTuketimBedeli = 2.07d; // TL birim başına
            double gunlukTuketim = kiloWatt * sure; // Günlük tüketim kW cinsinden

            double[] zamanCarpanlari = { 1, 7, 30, 365 };
            string[] zamanDilimi = { "1 gün", "1 hafta", "1 ay", "1 yıl" };

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < zamanCarpanlari.Length; i++)
            {
                double toplamTuketim = gunlukTuketim * zamanCarpanlari[i];
                double toplamBedel = toplamTuketim * normalTuketimBedeli;

                Console.WriteLine($"{sure} saatlik kullanım için yaklaşık {zamanDilimi[i]}de {toplamTuketim:F2} kW elektrik, {toplamBedel:F2} TL fatura.");
            }

            double toplamNormalTuketimBedeli = gunlukTuketim * normalTuketimBedeli;
            Console.WriteLine($"Elektrik tüketim değeri = {kiloWatt}kWh\nGünlük toplam normal tüketim bedeli: {toplamNormalTuketimBedeli:F2} TL");
            Console.WriteLine("\nNot:Sonuçlar değişkenlik gösterebilir.\nFiyatlar 2024 yılı için geçerlidir.\nDevam etmek için 'Enter' tuşuna basınız.");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
        }

        public static void ozel240kWhuzeri() // 11. Seçim
        {
            Console.Clear();
            Console.WriteLine("Cihazın güç(W) değerini giriniz : ");
            double watt = double.Parse(Console.ReadLine());
            Console.WriteLine("Çalışma süresini(Saat) giriniz  : ");
            double sure = double.Parse(Console.ReadLine());
            if (sure < 0 || sure > 24)
            {
               Console.WriteLine("Verdiğiniz bilgiler dahilinde doğru sonuçlar alamayabilirsiniz.");
            }

            double kiloWatt = watt / 1000D;
            double yuksekTuketimBedeli = 3.11d;
            double gunlukTuketim = kiloWatt * sure;

            double[] zamanCarpanlari = { 1, 7, 30, 365 };
            string[] zamanDilimi = { "1 gün", "1 hafta", "1 ay", "1 yıl" };

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < zamanCarpanlari.Length; i++)
            {
                double toplamTuketim = gunlukTuketim * zamanCarpanlari[i];
                double toplamBedel = toplamTuketim * yuksekTuketimBedeli;

                Console.WriteLine($"{sure} saatlik kullanım için yaklaşık {zamanDilimi[i]}de {toplamTuketim:F2} kW elektrik, {toplamBedel:F2} TL fatura.");
            }

            double toplamYuksekTuketimBedeli = gunlukTuketim * yuksekTuketimBedeli;
            Console.WriteLine($"Elektrik tüketim değeri = {kiloWatt}kWh\nToplam yüksek tüketim bedeli: {toplamYuksekTuketimBedeli:F2} TL");
            Console.WriteLine("\nNot:Sonuçlar değişkenlik gösterebilir.\nFiyatlar 2024 yılı için geçerlidir.\nDevam etmek için 'Enter' tuşuna basınız.");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
        }
    }
}
