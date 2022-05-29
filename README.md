# Telefon Satış Otomasyonu 
# Giriş 
Bu projenin amacı, daha düşük bütçeli şirketler için basit bir ürün (telefon) ekleme , çıkarma ve güncelleme işlemi yapmasını sağlıyor.
Otomasyon içerisinde ürünün teknik özellikleri, fiyat bilgisi, stok durumunu görmemizi sağlıyor.

# Proje İlerleme Süreci
1. Giriş panelinin oluşturulması. ![image](https://user-images.githubusercontent.com/101322048/170857497-470a70cc-0ce6-45a4-8d78-8a633d089b45.png)

2. Veritabanı bağlama süreci.![image](https://user-images.githubusercontent.com/101322048/170857499-61559732-bea0-4a8c-ad09-2d8c9b72e5cd.png)
3. Ürünler katagoresi oluşturulacak.![image](https://user-images.githubusercontent.com/101322048/170857500-61b59cde-1953-49db-82f3-aca08140a032.png)
4. Telefon stok bölümü ve güncelleme bölümü oluşturulacak.![image](https://user-images.githubusercontent.com/101322048/170857503-7a8a7671-cef3-46c1-831b-3f715da8cb82.png)
5. Telefon satış bölümü oluşturuldu ve taksit imkanı sağlandı faiz oranına göre.(Tek çekim - 6 taksit ve 12 taksit.) ![image](https://user-images.githubusercontent.com/101322048/170857504-11326a4f-fbd4-447b-b6b8-7928693ec7f8.png)
6. Satın alan kişinin kişisel bilgiler bölümü eklenecek. ![image](https://user-images.githubusercontent.com/101322048/170857507-7b666745-0d13-4bf8-a2e9-18d31d924fd4.png)
7. Tüm panellerin birbiri ile bağlantısı sağlanacak . ![image](https://user-images.githubusercontent.com/101322048/170857511-37b72814-3440-4de7-819b-160845882f02.png)


# Kullanılan Dil
C#


# Use Case Diagram
![Untitled Workspace](https://user-images.githubusercontent.com/101322048/165139739-c6cc5d8a-807d-49be-91e3-d56e12fbe4a4.png)


# Uygulama İçeriği

![Girisekran](https://user-images.githubusercontent.com/101322048/170858502-c6a4561b-5fe6-42e9-a7bc-f44f6106c280.png)
Bu Ekranda login olmadan tıklama ile direk giriş yapabiliyoruz.

![Telefonekran](https://user-images.githubusercontent.com/101322048/170858616-07793f8c-0001-435c-afb3-b2bfdba892d1.png)
Burada ise sağ ekrandan istediğiniz telefona tıklayarak özelliklerini önünüze getirebiliyor ve seçim yaptıktan sonra onay butonu ile satın alım sayfasına gidebiliyorsunuz.

![alımekran](https://user-images.githubusercontent.com/101322048/170858643-05f9b3c2-e473-450d-865f-1b1acec045a1.png)
Burada seçtiğiniz telefonun alım işlemini tamamlıyor bilgiler doğru ise uygulamanın ilk ekranına yönlendiriliyorsunuz.

![YapılanSatislar](https://user-images.githubusercontent.com/101322048/170858668-22d9bc7b-40cb-4261-9138-2c4b7519de64.png)
Buradan yapılan satışlar fiyatları vs veritabanında gözüküyor.

![Stok](https://user-images.githubusercontent.com/101322048/170858685-349053e3-c82e-4bbc-8d40-07a1d2840d3e.png)
Burada ise kullanıcı telefon stoklarını güncelleyebiliyor silebiliyor özelliklerini düzenleyebiliyor.
