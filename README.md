# Film Listesi ve IMDB Puanlama Programı

Bu proje, kullanıcıdan film isimlerini ve IMDB puanlarını alarak bir liste oluşturan ve belirli kriterlere göre bu listeyi filtreleyen bir C# konsol uygulamasıdır.

## Proje Yapısı

### Sınıflar
- **IMDB Sınıfı**: Bu sınıf, her bir film için IMDB puanını ve film adını saklar.
- **Program Sınıfı**: Programın çalıştığı ana sınıftır ve kullanıcı etkileşimini sağlar.

### Özellikler
- **Film Adı**: Kullanıcı tarafından girilen film adı.
- **IMDB Puanı**: Kullanıcı tarafından girilen filmin IMDB puanı.

## Kullanım

1. Program çalıştırıldığında, kullanıcıdan bir film adı girmesi istenir.
2. Ardından, kullanıcının girdiği filme ait IMDB puanı girilir.
3. Kullanıcı istediği kadar film ekleyebilir; her film girişinden sonra tekrar film eklemek isteyip istemediği sorulur.
4. Kullanıcı “hayır” dediğinde, film ekleme işlemi sonlanır ve girilen filmler listelenir.

### Çıktılar
Program, son aşamada aşağıdaki üç listeyi kullanıcıya sunar:
1. Girilen tüm filmlerin listesi.
2. IMDB puanı 4 ile 9 arasında olan filmler.
3. İsmi “A” harfi ile başlayan filmler ve IMDB puanları.

## Kod Açıklaması

Kod iki sınıftan oluşur:

1. **IMDB Sınıfı**:
   - `ImdbScore`: Film için IMDB puanını tutar.
   - `FilmName`: Film adını tutar.
   - Yapıcı metot ile (`IMDB(string filmName, double imdbScore)`) film adı ve IMDB puanı başlatılır.

2. **Program Sınıfı**:
   - `Main` metodu, kullanıcıdan film ve IMDB puanlarını alır, listeye ekler ve ardından belirli filtrelere göre sonuçları ekrana yazar.
