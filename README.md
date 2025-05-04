# 🚗 Arac Kiralama ve Satis Otomasyonu - Windows Forms Uygulaması

Bu proje, C# Windows Forms kullanılarak geliştirilmiş bir **Araç Kiralama ve Satış Otomasyonu** uygulamasıdır. İkinci el araçların kiralanması ve satılması işlemlerinin kolayca yönetilmesi amacıyla tasarlanmıştır.

---

## ✨ Özellikler

- **Kategori Yönetimi:** Araç kategorilerini (Sedan, SUV, vb.) ekleme, güncelleme ve silme işlemleri.
- **Araç Yönetimi:** Araçların tüm teknik özellikleriyle birlikte kayıt altına alınması, güncellenmesi, silinmesi.
- **Müşteri Yönetimi:** Müşteri kayıtlarının oluşturulması, güncellenmesi ve listelenmesi.
- **Kiralama İşlemleri:** Araçların uygunluk durumuna göre müşterilere kiralanması ve kira süresine göre ücretlendirilmesi.
- **Satış İşlemleri:** Araçların müşterilere satışı, ödeme türüne göre fiyatlandırma (taksitli ödemelerde zamlı fiyat).
- **Raporlama:** 
  - Kiralama raporu: Hangi araç ne zaman, kime ve kaça kiralandı?
  - Satış raporu: Hangi araç ne zaman, kime ve hangi ödeme şekliyle satıldı?

---

## 🛠 Kullanılan Teknolojiler

- **C# - .NET Framework**
- **Windows Forms - Masaüstü Uygulama Arayüzü**
- **Entity Framework Core - Veri Erişim Katmanı**
- **SQL Server - Veritabanı**
- **Görsel Bileşenler:**  
  - `TextBox`, `ComboBox`, `DataGridView`, `NumericUpDown`, `DateTimePicker`, `MessageBox`, `Button`, vb.

---

## 🧠 Ekstra Bilgiler

- Tüm araçlar **Durum** (Kiralık / Satılık) ve **MevcutDurum** (Boşta / Kirada / Satıldı) bilgileriyle filtrelenebilir.
- `ToplamTutar` (kiralama süresi * günlük ücret) otomatik hesaplanır.
- Satışta **ödeme tipi** "Taksitli" seçilirse otomatik %20 zam uygulanır.
- Data annotation'larla tüm alan kontrolleri yapılmıştır (örneğin `[Required]`, `[MaxLength]`, `[Range]`).
- `DbContext` adı her zamanki gibi **MyDbContext** olarak tanımlanmıştır.
