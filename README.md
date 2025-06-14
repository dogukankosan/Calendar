# 📅 Calendar

## 📝 Tanıtım

**Calendar**, C# ve .NET Framework ile geliştirilmiş, kullanımı kolay bir masaüstü takvim uygulamasıdır. Takvim yönetimi, etkinlik ekleme ve görüntüleme gibi temel özellikleriyle kullanıcı dostu bir arayüz sunar. Modern Windows Forms arayüzü ve özelleştirilebilir ikon desteğiyle, kişisel ve profesyonel kullanım için uygundur.

---

## 🚀 Özellikler

- 📅 Takvim görünümü ve gün seçimi
- 📝 Etkinlik ekleme, düzenleme, silme
- 🖥️ Modern Windows Forms arayüzü (DevExpress tema desteği)
- 🗃️ Hafif ve hızlı çalışma

---

## 🏗️ Teknik Altyapı

- **Platform:** .NET Framework 4.8
- **Arayüz:** Windows Forms (DevExpress skin/theme desteği)
- **Veri:** XML veya yerel veri dosyaları (App.config ve packages.config dosyasına göre); ek veritabanı desteği için Entity Framework ve SQLite desteği eklenebilir
- **Yapı & Katmanlar:**
  - `Classes/` : Takvim yönetimi ve yardımcı sınıflar
  - `Forms/` : Uygulama ana arayüzü ve formlar
  - `Properties/` : Assembly ve uygulama ayarları
  - `App.config` : Uygulama ve tema ayarları
  - `icons8_Apple_Calendar.ico` : Uygulama ikonu
  - `packages.config` : NuGet bağımlılık yönetimi
- **Tema:** DevExpress arayüz ve skin desteği

---

## 📂 Proje Dizini (Özet)

İlk 10 dosya ve klasör aşağıda özetlenmiştir. Daha fazla detay için [buraya tıklayın](https://github.com/dogukankosan/Calendar/tree/main).

```
Calendar/
│
├── .gitattributes
├── App.config
├── Calendar.csproj
├── Program.cs
├── README.md
├── icons8_Apple_Calendar.ico
├── packages.config
│
├── bin/              # Derlenmiş çıktı dosyaları
├── obj/              # Geçici derleme dosyaları
├── Classes/          # Takvim ve veri yönetimi sınıfları
├── Forms/            # Windows Forms arayüzleri
├── Properties/       # Assembly ve ayar dosyaları
```
> Not: Sadece ilk 10+ dosya/klasör listelenmiştir. [Tümünü görüntüle](https://github.com/dogukankosan/Calendar/tree/main)

---

## ⚙️ Kurulum & Kullanım

1. Projeyi klonlayın veya indirin.
2. `App.config` veya ilgili ayar dosyalarını düzenleyin (gerekirse).
3. NuGet paketlerini yükleyin (gerekli bağımlılıklar için).
4. Visual Studio ile projeyi açıp çalıştırın.
5. Takvim arayüzü üzerinden etkinliklerinizi yönetin.

---

## 🤝 Katkı

Katkı sağlamak için projeyi forklayıp pull request gönderebilirsiniz.

---

## 📄 Lisans

Bu proje MIT lisansı ile sunulmuştur.
