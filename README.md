# 🛡️ GoodbyeDPI Manager (Türkiye Edition)

**GoodbyeDPI Manager**, Siyah pencerelerle uğraşmadan tek tıkla kullanmanızı sağlayan modern bir Windows arayüzüdür.

## 🚀 Özellikler

* **Tek Tıkla Kurulum:** Siyah CMD ekranları yok. "Aç" butonuna basarsınız, gerekli servisler otomatik kurulur.
* **Otomatik Başlatma & Sessiz Mod:** İsteğe bağlı olarak Windows açıldığında otomatik devreye girer. Tamamen sessizdir, arka planda direkt sistem tepsisine (System Tray) yerleşir.
* **Ubisoft ve Oyun Dostu:** Klasik yöntemlerin aksine tüm internetinizi yavaşlatmaz veya bozmaz. Yalnızca hedeflenen sitelerin yasağını deler. Bu sayede **Ubisoft Connect, EA App, Riot Client** gibi katı güvenlikli oyun servisleri asla hata vermez!
* **Özelleştirilebilir Liste (Blacklist):** İstediğiniz siteyi listeye ekleyerek erişime açabilirsiniz.
* **Canlı Durum Takibi:** Servisin çalışıp çalışmadığını anlık renkli gösterge ile takip edebilirsiniz.
* **Tek Dosya (Portable):** Kurulum gerektirmez, indirip direkt çalıştırabilirsiniz.

---

## 📥 İndirme ve Kullanım

Kodlarla uğraşmak istemiyorsanız, hazır derlenmiş sürümü indirebilirsiniz:

1.  Bu sayfanın sağ tarafındaki **[Releases (Sürümler)](../../releases)** kısmına tıklayın.
2.  En son sürümün altındaki **EXE** dosyasını indirin.

> **Not:** Uygulama Windows Servislerini (`sc create`) yönettiği için **Yönetici İzni** şarttır.

---

## 🏆 Teşekkürler ve Kaynaklar (Credits)

Bu proje bir "GUI Wrapper" (Arayüz Giydirme) projesidir ve devlerin omuzlarında yükselmektedir. Asıl işi yapan aşağıdaki projelere sonsuz teşekkürler:

* **[GoodbyeDPI-Turkey](https://github.com/cagritaskn/GoodbyeDPI-Turkey):** Türkiye şartlarına özel ayarları yapan ve bu projeye ilham olan fork. (**cagritaskn**'e özel teşekkürler).
* **[GoodbyeDPI](https://github.com/ValdikSS/GoodbyeDPI):** Orijinal DPI atlatma aracının yaratıcısı **ValdikSS**.
* **WinDivert:** Ağ paketlerini yakalamak ve işlemek için kullanılan temel kütüphane.

---

## ⚙️ Teknik Detaylar

Bu yazılım, *GoodbyeDPI* çekirdeğini ve ayar dosyalarını kendi içinde barındırır (Embedded Resource). Uygulama çalıştırıldığında bu dosyaları (ve `discord-blacklist.txt` dosyasını) `C:\ProgramData\MyGoodbyeDPI` klasörüne çıkarır ve Windows Servis Yönetimi üzerinden aşağıdaki parametreleri uygular:

`sc create "GoodbyeDPI" binPath= "... -5 --set-ttl 5 --dns-addr 77.88.8.8 --dns-port 1253 --blacklist discord-blacklist.txt ..."`

**Kendi Sitelerini Ekleme:**
`C:\ProgramData\MyGoodbyeDPI` klasöründe oluşan `discord-blacklist.txt` dosyasına dilediğiniz adresleri ekleyebilirsiniz.

---

## ⚠️ Yasal Uyarı

Bu yazılım; eğitim, araştırma ve bilgiye erişim özgürlüğü amaçlarıyla, açık kaynak kodlu projeler temel alınarak geliştirilmiştir. Yazılımın kullanımından doğabilecek her türlü yasal sorumluluk son kullanıcıya aittir.

License: Apache-2.0 (GoodbyeDPI-Turkey temel alınmıştır).


https://claytstudio.com/dnschangerapp/
