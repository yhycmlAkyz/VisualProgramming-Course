# 🎲 DiceRolling - Zar Atma Simülasyonu

Bu proje, C# programlama dili kullanılarak geliştirilmiş bir olasılık ve istatistik simülasyonudur. Uygulama, iki zarın 36.000 kez atılmasını simüle eder ve sonuçların dağılımını analiz eder.

### ⚙️ Nasıl Çalışır?
1.  **Rastgelelik:** `System.Random` sınıfı kullanılarak her bir zar için 1-6 arasında sayı üretilir.
2.  **Toplama:** İki zarın değeri toplanır (Sonuç 2 ile 12 arasında değişir).
3.  **Veri Saklama:** Sonuçlar `int[]` tipinde tek boyutlu bir dizide tutulur. Dizi indeksleri doğrudan zar toplamını temsil eder.
4.  **Analiz:** 36.000 atış sonunda, her sonucun gelme sıklığı (frekansı) ve yüzdelik oranı hesaplanır.

## 📊 Örnek Çıktı

Uygulama çalıştırıldığında aşağıdakine benzer bir analiz tablosu oluşturur:

```text
Toplam    Frekans        Gerçekleşen(%)      Beklenen(%)*
-----------------------------------------------------------------
2         985            2.74                2.78
3         2010           5.58                5.56
...
7         6005           16.68               16.67
...
12        1015           2.82                2.78

* Beklenen oranlar, 36 olası kombinasyon üzerinden hesaplanmıştır.
