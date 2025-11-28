using System;

namespace KalpAtisHiziHesaplayici
{
    public class HeartRates
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public int MevcutYil { get; set; }

        public HeartRates(string ad, string soyad, int dogumYili, int mevcutYil)
        {
            Ad = ad;
            Soyad = soyad;
            DogumYili = dogumYili;
            MevcutYil = mevcutYil;
        }

        public int Yas
        {
            get { return MevcutYil - DogumYili; }
        }

        public int MaksimumKalpAtisHizi
        {
            get { return 220 - Yas; }
        }

        public double HedefMinimum
        {
            get { return MaksimumKalpAtisHizi * 0.50; }
        }

        public double HedefMaksimum
        {
            get { return MaksimumKalpAtisHizi * 0.85; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- HEDEF KALP ATIŞ HIZI HESAPLAYICI ---");
            Console.WriteLine("Lütfen bilgilerinizi giriniz.\n");

            string girilenAd = "";
            while (true)
            {
                Console.Write("Adınız: ");
                girilenAd = Console.ReadLine();

                bool sayiVar = false;
                foreach (char karakter in girilenAd)
                {
                    if (char.IsDigit(karakter)) 
                    {
                        sayiVar = true;
                        break;
                    }
                }

                if (!string.IsNullOrWhiteSpace(girilenAd) && !sayiVar)
                {
                    break; 
                }
                Console.WriteLine("Hata: İsim boş olamaz ve sayı içeremez. Lütfen tekrar deneyin.");
            }

            string girilenSoyad = "";
            while (true)
            {
                Console.Write("Soyadınız: ");
                girilenSoyad = Console.ReadLine();

                bool sayiVar = false;
                foreach (char karakter in girilenSoyad)
                {
                    if (char.IsDigit(karakter))
                    {
                        sayiVar = true;
                        break;
                    }
                }

                if (!string.IsNullOrWhiteSpace(girilenSoyad) && !sayiVar)
                {
                    break; 
                }
                Console.WriteLine("Hata: Soyad boş olamaz ve sayı içeremez. Lütfen tekrar deneyin.");
            }

            int girilenDogumYili = 0;
            while (true)
            {
                Console.Write("Doğum Yılınız: ");
                string giris = Console.ReadLine();

                if (int.TryParse(giris, out girilenDogumYili) && girilenDogumYili > 1900 && girilenDogumYili < DateTime.Now.Year)
                {
                    break; 
                }
                Console.WriteLine("Hata: Lütfen geçerli bir yıl giriniz (Örn: 1990).");
            }

            int girilenMevcutYil = 0;
            while (true)
            {
                Console.Write("Mevcut Yıl: ");
                string giris = Console.ReadLine();

                if (int.TryParse(giris, out girilenMevcutYil) && girilenMevcutYil >= girilenDogumYili)
                {
                    break; 
                }
                Console.WriteLine("Hata: Lütfen geçerli bir yıl giriniz (Doğum yılından küçük olamaz).");
            }

            HeartRates kisi = new HeartRates(girilenAd, girilenSoyad, girilenDogumYili, girilenMevcutYil);

            Console.Clear(); 
            Console.WriteLine("=============================================");
            Console.WriteLine($"RAPOR: {kisi.Ad} {kisi.Soyad}");
            Console.WriteLine("=============================================");

            Console.WriteLine($"Yaşınız: {kisi.Yas}");
            Console.WriteLine($"Maksimum Kalp Atış Hızınız: {kisi.MaksimumKalpAtisHizi} bpm");

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("HEDEF KALP ATIŞ HIZI ARALIĞINIZ (%50 - %85)");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine($"Minimum Hedef: {(int)kisi.HedefMinimum} bpm");
            Console.WriteLine($"Maksimum Hedef: {(int)kisi.HedefMaksimum} bpm");

            Console.WriteLine("\nNot: Egzersiz programına başlamadan önce doktora danışınız.");
            Console.WriteLine("=============================================");

            Console.ReadLine();
        }
    }
}