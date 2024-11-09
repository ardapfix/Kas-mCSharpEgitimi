namespace Konu01Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Değişkenler"); // bu projeyi çalıştırmak için üst menüdeki play tuşunun yanından projeyi seçtik.
            Console.WriteLine();
            Console.WriteLine("Değişken Tanımlama - Tam Sayılar");
            // Değişken Tanımlama - Tam Sayılar
            byte plakakodu = 34;
            short kisa = 123;
            int tamsayi = 1800;
            long uzunsayi = 123456;

            plakakodu = 18;

            Console.WriteLine("Plaka Kodu : " + plakakodu);
            Console.WriteLine();
            // Kesirli Sayılar
            Console.WriteLine("Kesirli Sayılar");
            float kesirliSayi = 4.5f;
            double kesirliDouble = 4.5;
            decimal urunFiyati = 5500;

            urunFiyati = 6600;

            Console.WriteLine("Ürün Fiyatı : " + urunFiyati);

            // Karakter
            char karakter = 'c'; // Klavyedeki tüm akrakterleri taşıyabilir. Char veri tipi sadece 1 karakter alır ve tek tırnak içinde değer alır.

            // String Veri Tipi
            string metin = "klavyedeki tüm karakterleri yan yana yazılmış olarak taşıyabilir";

            Console.WriteLine();
            Console.WriteLine("Metin : " + metin);

            // Boolean Veri Tipi
            bool islemSonucu = false; // İşlerm başarılı mı başarısız mı 2 değer alabilir | true-false

            Console.WriteLine("islemSonucu {0} ikinci parametre : {1}" , islemSonucu , karakter);
            metin = "yeni metin";
            Console.WriteLine($"islemSonucu {islemSonucu} Metin yazısı : {metin}"); // Değişkenleri metin içerisine bir önceki gibi parametreli göndermek yerine direk kullanabilmek için tırnak başına $ ekliyoruz.

            // C#'ta Sabit Tanımlama
            const int kdvMiktari = 18;
            const double dolarKuru = 34.33;
            const double euroKuru = 37.19;
            // kdvMiktarı = 20; sabitlerin değer sonradan değiştirilemez!
            Console.WriteLine(kdvMiktari);
        }
    }
}
