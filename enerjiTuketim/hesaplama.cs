namespace enerjiTuketim 
{
    public class hesaplama 
    {
        public static void islem()
        {
            bool devam = true;
             while (devam)
            {
            Console.WriteLine("Hangi ürün için elektirk bedelini hesaplamak istersiniz?\n1.Bulaşık Makinesi\n2.Çamaşır Makinesi\n3.Buzdolabı\n4.Su Isıtıcı(Kettle)\n5.Mikrodalga Fırın\n6.Fırın\n7.Klima\n8.Saç Kurutma Makinesi\n9.Ütü\n10.Televizyon\n11.Özel\n12.Çıkış\nSeçiminiz: ");
            int secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                    BulasikMakinesi.Calistir();
                    break;
                    /*
                    case 2:
                    camasirMakinesi.CamasirMakinesi();
                    break;
                    case 3:
                    buzdolabi.Buzdolabi();
                    break;
                    case 4:
                    suIsitici.SuIsitici();
                    break;
                    case 5:
                    mikrodalgaFirin.MikrodalgaFirin();
                    break;
                    case 6:
                    firin.Firin();
                    break;
                    case 7:
                    klima.Klima();
                    break;
                    case 8:
                    sacKurutmaMakinesi.SacKurutmaMakinesi();
                    break;
                    case 9:
                    utu.Utu();
                    break;
                    case 10:
                    televizyon.Televizyon();
                    break;
                    */
                    case 11:
                    Console.WriteLine("Aylık Tüketim değeri 240kWh'den az ise 'E' değil ise 'H' tuşuna bsaınız!");
                    char aylikTuketim = char.Parse(Console.ReadLine().ToLower());
                        if (aylikTuketim == 'e')
                            {
                                ozelTuketim.ozel240kWhalti();
                            }
                        else if (aylikTuketim == 'h')
                            {
                                ozelTuketim.ozel240kWhuzeri();
                            }
                        else 
                            {
                                Console.WriteLine("Geçersiz giriş yaptınız!");
                            }
                    break;

                    case 12:
                        Console.WriteLine("Çıkış yapılıyor");
                        sayac();
                        devam = false;
                    break;

                    default:
                        Console.WriteLine("Geçersiz giriş yaptınız!");
                        break;
                }
             }
        }
        public static void sayac()
        {
            for (int i = 3; i >= 1; i--)
                {
                    Console.WriteLine(i +"...");
                    Thread.Sleep(1000);
                }
        }        
    }
}