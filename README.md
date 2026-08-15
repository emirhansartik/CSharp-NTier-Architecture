# 🏗️ C# N-Tier Enterprise Architecture

> 📌 **Proje Durumu:** Tamamlandı (Completed) | **Ana Odak:** Entity Framework & N-Tier Architecture

Bu depo, kurumsal yazılım geliştirme standartlarına uygun olarak inşa edilmiş **N-Katmanlı Mimari (N-Tier Architecture)** altyapısını içermektedir. Monolitik (tek parça) kod yığınları yerine; sürdürülebilir, güvenli ve takım çalışmasına uygun bir backend ekosistemi kurmak amacıyla "Separation of Concerns" (Sorumlulukların Ayrılığı) prensibi merkeze alınmıştır.

## ⚙️ Mimari Katmanlar (Layers)

Proje, birbirine olan bağımlılığı (coupling) minimize edilmiş 4 temel katmandan oluşmaktadır:

*   📦 **`EntityLayer` (Varlık Katmanı):** Veritabanı tablolarının C# tarafındaki nesnel (Object) karşılıklarıdır. İş mantığı barındırmaz, veri güvenliğini sağlamak amacıyla kapsüllenmiş (Encapsulation) *Property* (`get; set;`) yapılarını içerir.
*   🗄️ **`DataAccessLayer` (Veri Erişim Katmanı):** Veritabanı (SQL Server) ile doğrudan iletişim kuran tek katmandır. CRUD (Create, Read, Update, Delete) operasyonlarını üstlenir ve diğer katmanları SQL sorgularından izole eder.
*   🧠 **`BusinessLayer` (İş Katmanı):** Projenin karar mekanizmasıdır. `PresentationLayer`'dan gelen verilerin; veritabanına gönderilmeden önce sistem kurallarına (Business Rules), doğrulama (Validation) ve güvenlik şartlarına uyup uymadığını denetler.
*   🖥️ **`PresentationLayer` (Sunum Katmanı):** Kullanıcının sistemle etkileşime girdiği vitrindir (Windows Forms). Veritabanı ile asla doğrudan iletişim kurmaz; tüm veri taleplerini sıkı kurallarla örülmüş `BusinessLayer` üzerinden gerçekleştirir.

## 🧠 Business Katmanı (İş Kuralları) Entegrasyonu

Projenin veri akışını yönetmek ve esnekliğini sağlamak amacıyla `BusinessLayer` içerisinde modern yazılım prensipleri uygulanmıştır:

*   **Generic Service Tasarımı:** Kod tekrarını (WET) önlemek için tüm temel CRUD operasyonları soyutlanarak Interface (`IGenericService`) yapıları üzerinden kurgulanmıştır.
*   **Özel İş Kuralları (Custom Entity Methods):** Standart operasyonların yetersiz kaldığı senaryolarda, sadece ilgili varlığa (Entity) özgü spesifik LINQ sorguları ve veri filtreleme işlemleri tanımlanarak mimarinin yetenekleri genişletilmiştir.
*   **Manager Sınıfları:** Sunum katmanından gelen talepler doğrudan veritabanına iletilmez; ilgili varlığın *Manager* sınıflarında iş kuralları süzgecinden geçirilir.
*   **Dependency Injection (Bağımlılık Enjeksiyonu):** Sınıflar arası sıkı bağlılığı (Tightly Coupled) ortadan kaldırmak için, veri erişim nesneleri `new` anahtar kelimesiyle koda gömülmek yerine Constructor (Yapıcı Metot) üzerinden sisteme enjekte edilmiştir. Bu sayede modüller arası "Tak-Çıkar (Plug & Play)" esnekliği sağlanmıştır.

## 📊 Veri Analizi ve İstatistik Paneli (Case Study)

Sistemin arka planında çalışan mimarinin gücünü test etmek ve veri işleme yeteneklerini sergilemek amacıyla projeye bir **İstatistik Dashboard** modülü entegre edilmiştir.

![Statistics Dashboard](Ekran%20görüntüsü%202026-08-11%20163624.png)

Bu panelin altyapısında kullanılan temel teknik yaklaşımlar:
*   **LINQ (Language Integrated Query):** SQL Server'a karmaşık metin sorguları yazmak yerine, veri çekme operasyonları doğrudan C# nesneleri üzerinden yüksek performansla gerçekleştirilmiştir.
*   **Lambda Expressions (`=>`):** Veritabanı üzerinde anlık filtrelemeler oluşturularak `Where`, `Select`, `OrderBy` gibi metotlarla nokta atışı veriler (örn: Kapadokya Tur Kapasitesi, Eklenen Son Ülke) dinamik olarak çekilmiştir.
*   **Aggregate Functions (Kümeleme Fonksiyonları):** `Count()`, `Sum()`, `Average()`, ve `Max()` gibi toplama fonksiyonları kullanılarak büyük veri setleri üzerinden istatistikler (Toplam Kapasite, Ortalama Fiyat vb.) anlık olarak hesaplanmaktadır.
*   **Relational Mapping (İlişkisel Veri Yönetimi):** Lokasyon ve Rehber (Guide) tabloları arasındaki *Navigation Property*'ler kullanılarak, çapraz tablo verileri (örn: Roma Gezi Rehberi veya Ayşegül Çınar Tur Sayısı) tek bir ekranda başarıyla birleştirilmiştir.

## 🚀 Teknoloji Yığını (Tech Stack)

*   **Programlama Dili:** C# (.NET)
*   **Mimari Yaklaşım:** N-Tier Architecture, Nesne Yönelimli Programlama (OOP)
*   **ORM (Object-Relational Mapping):** Entity Framework (Code First & Database First Yaklaşımları)
*   **Veritabanı:** MS SQL Server
*   **Arayüz:** Windows Forms (WinForms)

---
*Bu proje, modern backend sistemleri geliştirme sürecimin ve N-Katmanlı mimari prensiplerine hakimiyetimin aktif bir göstergesidir.*
