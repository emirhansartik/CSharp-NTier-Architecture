# 🏗️ C# N-Tier Enterprise Architecture

Bu depo, kurumsal yazılım geliştirme standartlarına uygun olarak inşa edilmiş **N-Katmanlı Mimari (N-Tier Architecture)** altyapısını içermektedir. Monolitik (tek parça) kod yığınları yerine; sürdürülebilir, güvenli ve takım çalışmasına uygun bir backend ekosistemi kurmak amacıyla "Separation of Concerns" (Sorumlulukların Ayrılığı) prensibi merkeze alınmıştır.

## ⚙️ Mimari Katmanlar (Layers)

Proje, birbirine olan bağımlılığı (coupling) minimize edilmiş 4 temel katmandan oluşmaktadır:

*   📦 **`EntityLayer` (Varlık Katmanı):** Veritabanı tablolarının C# tarafındaki nesnel (Object) karşılıklarıdır. İş mantığı barındırmaz, veri güvenliğini sağlamak amacıyla kapsüllenmiş (Encapsulation) *Property* (`get; set;`) yapılarını içerir.
*   🗄️ **`DataAccessLayer` (Veri Erişim Katmanı):** Veritabanı (SQL Server) ile doğrudan iletişim kuran tek katmandır. CRUD (Create, Read, Update, Delete) operasyonlarını üstlenir ve diğer katmanları SQL sorgularından izole eder.
*   🧠 **`BusinessLayer` (İş Katmanı):** Projenin karar mekanizmasıdır. `PresentationLayer`'dan gelen verilerin; veritabanına gönderilmeden önce sistem kurallarına (Business Rules), doğrulama (Validation) ve güvenlik şartlarına uyup uymadığını denetler.
*   🖥️ **`PresentationLayer` (Sunum Katmanı):** Kullanıcının sistemle etkileşime girdiği vitrindir (Windows Forms). Veritabanı ile asla doğrudan iletişim kurmaz; tüm veri taleplerini sıkı kurallarla örülmüş `BusinessLayer` üzerinden gerçekleştirir.

## 🚀 Teknoloji Yığını (Tech Stack)

*   **Programlama Dili:** C# (.NET)
*   **Mimari Yaklaşım:** N-Tier Architecture, Nesne Yönelimli Programlama (OOP)
*   **ORM (Object-Relational Mapping):** Entity Framework (Code First & Database First Yaklaşımları)
*   **Veritabanı:** MS SQL Server
*   **Arayüz:** Windows Forms (WinForms)

---
*Bu proje, modern ve ölçeklenebilir backend sistemleri geliştirme sürecimin aktif bir parçasıdır.*
