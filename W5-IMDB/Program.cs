
class IMDB
{
    private double _ımdbScore;
    private string _filmName;
    public double ImdbScore
    {
        get
        {
            return _ımdbScore;

        }
        set
        {
            _ımdbScore = value;
        }
    }
    public string FilmName
    {
        get
        {
            return _filmName;
        }
        set
        {
            _filmName = value;
        }

    }
    public IMDB(string filmName, double imdbScore)
    {
        FilmName = filmName;
        ImdbScore = imdbScore;
    }
}
class Program
{
    static void Main()
    {
        List<IMDB> filmList = new List<IMDB>();

    baslangic:

        while (true)
        {
            Console.WriteLine("Bir Film adı giriniz.");
            string filmAdi = Console.ReadLine();

            Console.WriteLine("Girdiğiniz filmin IMDB puanını giriniz.");
            double imdbPuani;
            while (!double.TryParse(Console.ReadLine(), out imdbPuani))
            {
                Console.WriteLine("Geçerli bir IMDB puanı giriniz.");
            }

            filmList.Add(new IMDB(filmAdi, imdbPuani));

            Console.WriteLine("Yeni bir Film eklemek ister misiniz? evet/hayır");
            string cevap = Console.ReadLine().ToLower();
            if (cevap == "evet")
            {
                goto baslangic;
            }
            else
            {
                Console.WriteLine("Film ekleme işlemi sonlandırıldı.");
                break;
            }
        }

        Console.WriteLine("\nGirilen filmlerin listesi:");
        int i = 1;
        foreach (IMDB film in filmList)
        {
            Console.WriteLine($"{i}- {film.FilmName}");
            i++;
        }

        Console.WriteLine("\nGirilen filmlerin IMDB puanları 4-9 arasında olanlar:");
        int a = 1;
        foreach (IMDB film in filmList.Where(f => f.ImdbScore >= 4 && f.ImdbScore <= 9))
        {
            Console.WriteLine($"{a}- {film.FilmName} (IMDB: {film.ImdbScore})");
            a++;
        }

        Console.WriteLine("\nİsmi 'A' ile başlayan filmler ve IMDB puanları:");
        int k = 1;
        foreach (IMDB film in filmList.Where(f => f.FilmName.StartsWith("A", StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine($"{k}- {film.FilmName} (IMDB: {film.ImdbScore})");
            k++;
        }
    }
}

