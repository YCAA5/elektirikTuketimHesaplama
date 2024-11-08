namespace enerjiTuketim
{
    public class ozelTuketim()
    {
        public static void ozel240kWhalti() // 11. Seçim
         {
            Console.WriteLine("Cihazın güç(W) değerini giriniz : ");
            double watt = double.Parse(Console.ReadLine());
            Console.WriteLine("Çalışma süresini(Saat) giriniz  : ");
            double sure = double.Parse(Console.ReadLine());           
            double kiloWatt = watt/1000D;
            double normalTuketimBedeli = 2.07d;

            double toplamNormalTuketimBedeli = (kiloWatt*sure)*normalTuketimBedeli;

            Console.WriteLine($"Elektrik tüketim değeri = {kiloWatt}kWh\nToplam normal tüketim bedeli: {toplamNormalTuketimBedeli}");
         }
         public static void ozel240kWhuzeri() //11. Seçim
         {
            Console.WriteLine("Cihazın güç(W) değerini giriniz : ");
            double watt = double.Parse(Console.ReadLine());
            Console.WriteLine("Çalışma süresini(Saat) giriniz  : ");
            double sure = double.Parse(Console.ReadLine());           
            double kiloWatt = watt/1000D;
            double yuksekTuketimBedeli = 3.11d;

            double toplamYuksekTuketimBedeli = (kiloWatt*sure)*yuksekTuketimBedeli;

            Console.WriteLine($"Elektrik tüketim değeri = {kiloWatt}kWh\nToplam yüksek tüketim bedeli: {toplamYuksekTuketimBedeli}");          
         }
    }
}