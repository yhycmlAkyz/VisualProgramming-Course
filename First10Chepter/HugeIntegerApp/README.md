# HugeInteger Class Implementation

Bu proje, C# programlama dili kullanılarak geliştirilmiş, standart veri tiplerinin (int, long vb.) sınırlarını aşan çok büyük tamsayıları (40 basamağa kadar) saklamak ve bu sayılarla aritmetik işlemler yapmak için tasarlanmış özel bir sınıf yapısıdır.

## 🚀 Özellikler

Uygulama aşağıdaki temel fonksiyonları içerir:

* **Veri Girişi (Input):** String formatındaki sayıları karakter dizisine dönüştürür ve sayısal diziye (array) işler.
* **Görüntüleme (ToString):** Sayı dizisini anlamlı bir String'e çevirir (Baştaki gereksiz sıfırları temizleyerek).
* **Toplama (Add):** İki `HugeInteger` nesnesini toplar (Elde/Carry mantığı dahil).
* **Çıkarma (Subtract):** İki `HugeInteger` nesnesini çıkarır (Ödünç alma/Borrow mantığı dahil). Negatif sonuçlar için `0` döner (Basit implementasyon).
* **Karşılaştırma:** İki büyük sayıyı birbiriyle kıyaslar:
    * `IsEqualTo` / `IsNotEqualTo`
    * `IsGreaterThan` / `IsLessThan`
    * `IsGreaterThanOrEqualTo` / `IsLessThanOrEqualTo`
    * `IsZero`

## 💻 Kullanım Örneği

`Program.cs` içerisindeki test senaryosu aşağıdaki gibidir:

```csharp
HugeInteger sayi1 = new HugeInteger();
HugeInteger sayi2 = new HugeInteger();

// 1. Veri Girişi
sayi1.Input("99999999999999999999");
sayi2.Input("1");

// 2. Toplama İşlemi
HugeInteger toplam = sayi1.Add(sayi2);
Console.WriteLine($"{sayi1} + {sayi2} = {toplam}");
// Çıktı: 99999999999999999999 + 1 = 100000000000000000000

// 3. Karşılaştırma
bool isGreater = sayi1.IsGreaterThan(sayi2); // True
