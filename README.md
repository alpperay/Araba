# Araba Projesi

Bu proje, araba nesneleri ile ilgili temel bir C# sınıfı (`arac`) ve bu sınıfı kullanan bir programı içermektedir. Proje, araç özelliklerini tanımlamak, güncellemek ve görüntülemek için oluşturulmuş basit bir yapıyı kapsamaktadır.

## Proje Açıklaması

Bu proje, araçların temel özelliklerini (marka, model, yakıt tipi, renk, şanzıman tipi, şase no, yıl ve fiyat) yönetmeyi amaçlayan bir sınıf (`arac`) içerir. Kullanıcı, araç bilgilerini girebilir, fiyatı güncelleyebilir ve aracın tüm özelliklerini görüntüleyebilir.

## Proje İçeriği

1. **arac Sınıfı**:
   - Araçların özelliklerini tanımlar.
   - Fiyat güncelleme ve araç özelliklerini yazdırma metodları içerir.

2. **Program**:
   - `arac` sınıfından bir nesne oluşturur.
   - Nesnenin özelliklerini görüntüler ve fiyatını günceller.

## Kullanıcı Bilgisi

Bu proje, temel özellikler ve metodlar içerdiği için C# dilini öğrenmek isteyenler için faydalı olabilir. Araç sınıfındaki özellikler:

- **Marka**: Aracın markası.
- **Model**: Aracın modeli.
- **YakitTipi**: Aracın kullandığı yakıt türü.
- **Renk**: Aracın rengi.
- **Sanziman**: Aracın şanzıman tipi (örneğin, manuel veya otomatik).
- **SaseNo**: Aracın şase numarası.
- **Yil**: Aracın üretim yılı.
- **Fiyat**: Aracın satış fiyatı.

### Kullanım Örneği:

```csharp
arac a1 = new arac("Renault", "Megane", "Benzin", "Bordo", "Manuel", "615WE328FEMA1928AM1642", 2016, 25000);
a1.Ozellikler(); // Araç bilgilerini yazdırır.
a1.FiyatGuncelle(32000); // Fiyatı günceller.
a1.Ozellikler(); // Güncellenmiş araç bilgilerini yazdırır.
