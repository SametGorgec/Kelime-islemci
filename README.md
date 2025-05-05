# Kelime işlemci
📄 Arayüz Raporu: "Samet_grgc" Kelime İşlemci Uygulaması
🔹 Genel Tanım:
Bu uygulama, Windows Forms (WinForms) ortamında geliştirilen sade ve işlevsel bir kelime işlemci uygulamasıdır. Kullanıcıların metin yazmasına, biçimlendirme yapmasına ve renk seçimiyle özelleştirme yapmasına olanak tanır.
🧩 Arayüz Bileşenleri:
1. Başlık Çubuğu
Uygulamanın adı: Samet_grgc

Standart pencere kontrol düğmeleri (küçült, büyüt, kapat) mevcut.
2. Yazı Fontu Seçimi
Sol üstte bir ComboBox (açılır liste) yer alıyor.

Kullanıcı burada yüklü yazı tiplerinden birini seçebilir.

Yanındaki "A" butonu büyük ihtimalle yazı tipi stiliyle ilişkilidir (örneğin varsayılan fonta dön).

3. Biçimlendirme Düğmeleri
Kalın (K), İtalik (I) ve Altı Çizili (A) butonları yer alıyor.

Bu butonlar tıklanarak RichTextBox içindeki metnin stili değiştirilebilir.

4. Yazı Boyutu Seçimi
Sağ tarafta bir diğer ComboBox yer almakta.

Kullanıcı, yazı büyüklüğünü buradan seçebilir.

5. Yazı Biçim Düğmeleri
A^: Üst simge veya yazıyı büyütme işlevi görebilir.

Av: Alt simge veya yazıyı küçültme işlevi olabilir.

6. Metin Alanı (RichTextBox)
Uygulamanın ana alanı olarak ortada geniş bir metin kutusu yer almakta.

Yazı fontu, stil ve renk değişiklikleri bu alandaki metne uygulanır.

7. Renk Paleti (GroupBox)
Sağda yer alan GroupBox başlığı: Renk Paleti

Dört adet RadioButton mevcut:

Mavi

Yeşil

Sarı

Mor

Bu seçeneklerle metin veya arka plan rengi değiştirilebilir.

✅ Artılar
Kullanıcı dostu sade arayüz.

Temel kelime işlemci işlevleri sunulmuş.

Biçimlendirme ve renk seçimi kolay erişilebilir.

Geliştirmeye açık ve temiz bir tasarım.

⚠️ Geliştirme Önerileri
Font listesi otomatik olarak sistemdeki fontlarla doldurulmalı.

Renk seçimi yalnızca yazı rengini mi yoksa arka planı mı etkiliyor, bu netleştirilmeli.

Seçilen yazı tipi ve boyutu anlık olarak uygulanmalı.

Kullanıcıya uygulanan stilin aktif olduğu görsel olarak gösterilebilir (örneğin, düğmelerin arka planı değişebilir).

Uygulamanın başlığı açıklayıcı hale getirilebilir (örneğin: “Mini Kelime İşlemci”).
