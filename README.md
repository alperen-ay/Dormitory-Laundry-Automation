# Dormitory Laundry Automation System 🧺

A C# application simulating a real-world dormitory laundry management system. It dynamically calculates finish times and manages shared resources.

**Kullanılan Temel C# / OOP Kavramları:**
* **Static Memory Management:** Tüm makinelerin ortak kullandığı deterjan stokunun `static` mimari ile global olarak yönetilmesi.
* **Dynamic Time Calculation:** Makinenin başlatıldığı saatin üzerine yıkama süresinin eklenmesi ve 60 dakika / 24 saat döngülerinin algoritmik olarak kontrol edilmesi.
* **True/False & Logical Operator Overloading (!):** Makinenin müsaitlik durumunun (`MakineDurumu.Bos`) ve arıza durumunun doğrudan nesne üzerinden `if(makine1)` ve `if(!makine1)` şeklinde kontrol edilebilmesi.
* **String Interpolation:** Kullanıcıya özel dinamik konsol çıktıları üretilmesi.
