# Araba Projesi

Bu proje, araçları temsil eden bir C# sınıfı (arac) ve bu sınıfı kullanan bir program içerir. Projede, araçların temel özelliklerini tanımlamak, fiyatlarını güncellemek ve özelliklerini görüntülemek için bir yapı oluşturulmuştur.

## Proje Açıklaması

Bu proje, araçların özelliklerini tutan ve işleyen bir arac sınıfını içerir. Kullanıcı, araç bilgilerini oluşturabilir, fiyatını güncelleyebilir ve aracın tüm özelliklerini görüntüleyebilir.

## Proje İçeriği

1) **arac Sınıfı**:
- Araçların marka, model, yakıt tipi, renk, şanzıman, şase numarası, üretim yılı ve fiyat gibi temel özelliklerini tanımlar.
- Fiyat güncellenebilir ve araç bilgileri ekrana yazdırılabilir.
2) **Program.cs**:
- arac sınıfından bir nesne oluşturur.
- Nesnenin özelliklerini ekrana yazdırır.
- Fiyatı günceller ve güncellenmiş bilgileri tekrar yazdırır.

## Araç Özellikleri

- **Marka**: Aracın markası.
- **Model**: Aracın modeli.
- **YakitTipi**: Aracın kullandığı yakıt türü.
- **Renk**: Aracın rengi.
- **Sanziman**: Aracın şanzıman tipi (manuel veya otomatik).
- **SaseNo**: Aracın şase numarası.
- **Yil**: Aracın üretim yılı.
- **Fiyat**: Aracın satış fiyatı.

## Kullanım Örneği

Aşağıdaki örnekte, `arac` sınıfının nasıl kullanılacağı gösterilmektedir:

```csharp
arac a1 = new arac("Renault", "Megane", "Benzin", "Bordo", "Manuel", "615WE328FEMA1928AM1642", 2016, 25000);
a1.Ozellikler(); // Araç bilgilerini yazdırır.
a1.FiyatGuncelle(32000); // Fiyatı günceller.
a1.Ozellikler(); // Güncellenmiş araç bilgilerini yazdırır.
````

## Katkıda Bulunma 

Bu projeye katkıda bulunmak isterseniz, aşağıdaki adımları izleyebilirsiniz:

1) GitHub reposunu fork edin,
2) Kendi değişikliklerinizi yapın ve pull request gönderin.









