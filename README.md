# C# ile Kapsülleme (Encapsulation) Örneği - Araba Sınıfı

Bu proje, C# dilinde **kapsülleme (encapsulation)** konusunu basit bir `Car` (Araba) sınıfı üzerinden örneklemektedir.

## Kullanılan Kavramlar

- **Class (Sınıf)**: `Car` adında bir sınıf oluşturuldu.
- **Property (Özellikler)**: `Brand`, `Model`, `Color`, `DoorCount`
- **Encapsulation (Kapsülleme)**: `DoorCount` özelliği özel (private) alan ile kapsüllendi ve kontrol mekanizması eklendi.
- **Access Modifier (Erişim Belirleyici)**: `doorCount` alanı `private`, `DoorCount` özelliği ise `public` olarak tanımlandı.

## Kapsülleme Mantığı

`doorCount` alanı dışarıdan doğrudan erişilemez.  
Sadece `DoorCount` özelliği üzerinden veri girilebilir. Bu özellikte:

- Eğer değer **2** veya **4** ise kabul edilir.
- Farklı bir değer girilirse:
  - Konsola uyarı mesajı yazılır
  - `DoorCount` değeri otomatik olarak `-1` yapılır.


