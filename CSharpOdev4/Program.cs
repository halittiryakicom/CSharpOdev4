//burada hoş geldiniz yazısı ve manavda bulunan meyveleri kullanıcıya aktarıyoruz
Console.WriteLine("Rüya Manavına Hoş Geldiniz!");
Console.WriteLine("Elma = 2TL\nArmut = 3TL\nÇilek = 2TL\nMuz = 3TL\nDiğer bütün meyvelerin fiyatı: 4TL\n");

//burada kullanıcıya seçim yapması için uyarı bırakıyoruz. Write seçmemizin sebebi hemen yan tarafına seçimini belirtebilmesi için
Console.Write("Hangi meyveyi satın almak istersiniz? (Elma, Armut, Çilek, Muz, Diğer):");

//burada kullanıcının yaptığı seçini secim değişkenine aktarıyoruz. Tolower ile seçimi küçük harflere çeviriyoruz. Bu sayede büyük küçük harf duyarlılığını ortadan kaldırıyoruz.
string secim = Console.ReadLine();
secim = secim.ToLower();


//burada girilen seçimin boş olup olmadığını kontrol ediyoruz.
if (secim != null)
{
    //burada switch case kullanmak daha yararlı çünkü birden fazla if kullanmak yerine case ile daha rahat yeni seçenek ekleniyor ve kodun daha temiz okunmasını sağlar.
    //switch (secim)
    //{
    //    case "elma":
    //        Console.WriteLine("Seçtiğiniz meyvenin fiyatı 2TL");
    //        break;

    //    case "armut":
    //        Console.WriteLine("Seçtiğiniz meyvenin fiyatı 3TL");
    //        break;

    //    case "çilek":
    //        Console.WriteLine("Seçtiğiniz meyvenin fiyatı 2TL");
    //        break;

    //    case "muz":
    //        Console.WriteLine("Seçtiğiniz meyvenin fiyatı 3TL");
    //        break;

    //    case "diğer":
    //        Console.WriteLine("Seçtiğiniz meyvenin fiyatı 4TL");
    //        break;

    //    default:
    //        Console.WriteLine("Doğru meyve seçimi yapamadınız");
    //        break;
    //}


    //burada if yapılı seçim ekranı
    if(secim == "elma")
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı 2TL");
    else if (secim == "armut")
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı 3TL");
    else if (secim == "çilek")
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı 2TL");
    else if (secim == "muz")
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı 3TL");
    else if(secim == "diğer")
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı 4TL");
    else
        Console.WriteLine("Doğru meyve seçimi yapamadınız");
}