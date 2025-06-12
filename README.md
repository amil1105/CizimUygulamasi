# Çizim Uygulaması

Bu proje, C# ve Windows Forms kullanılarak geliştirilmiş basit bir çizim uygulamasıdır. Kullanıcılar farklı şekiller çizebilir, bu şekillerin renklerini değiştirebilir, taşıyabilir ve çalışmalarını kaydedebilirler.

## Özellikler

- Dikdörtgen, daire, üçgen ve altıgen çizme
- Merkez noktasından başlayarak şekil çizme
- Şekilleri seçme, taşıma ve silme
- Şekil renklerini değiştirme
- Çalışmayı dosyaya kaydetme ve yükleme
- Anlık fare konum göstergesi

## Kullanım

### Şekil Çizme
1. Şekil butonlarından birini seçin (dikdörtgen, daire, üçgen veya altıgen)
2. Çizim alanında tıklayın - bu merkez noktanız olacak
3. Fareyi sürükleyerek şeklin boyutunu ayarlayın
4. Fare butonunu bırakarak şekli oluşturun

### Şekil Seçme ve Taşıma
1. "Seç" butonuna tıklayın
2. Bir şekle tıklayarak seçin (seçili şekil yeşil çerçeve ile gösterilir)
3. Seçili şekli fare ile sürükleyerek taşıyın

### Renk Değiştirme
1. Bir şekli seçin
2. Renk butonlarından birini tıklayarak şeklin rengini değiştirin

### Dosya İşlemleri
- "Kaydet" butonuyla çalışmanızı metin dosyası olarak kaydedebilirsiniz
- "Aç" butonuyla önceden kaydedilmiş çalışmaları yükleyebilirsiniz
- "Yeni" butonuyla yeni bir çizime başlayabilirsiniz

## Gereksinimler

- .NET Framework 4.7.2 veya üzeri
- Windows işletim sistemi

## Ekran Görüntüleri

![image](https://github.com/user-attachments/assets/f231d23a-96ce-4f48-9f9a-10448800643e)


## Teknik Detaylar

Uygulama, nesne yönelimli programlama prensiplerini kullanarak tasarlanmıştır:

- Tüm şekiller `Sekil` soyut sınıfından türetilmiştir
- Her şekil kendi çizim mantığını `Ciz()` metoduyla uygular
- Şekil yönetimi `SekilManager` sınıfı tarafından yapılır
- Kullanıcı arayüzü Windows Forms kullanılarak oluşturulmuştur
- Dosya işlemleri için metin formatında (.txt) kayıt/yükleme kullanılır

