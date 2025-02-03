using IMDB_List;

List <Film > filmler = new List <Film> ();

string add = "";

do
{

    Film film = new Film ();

    Console.WriteLine("\nEklemek istediğiniz film ismini giriniz.\n");
    film.Name = Console.ReadLine();

    Console.WriteLine("\nFilmin IBDM puanını giriniz.\n ");
    film.Score = double.Parse(Console.ReadLine());

    while (film.Score < 0 || film.Score > 10)
    {
        Console.WriteLine("\nLütfen 0 ila 10 arasında biri sayı giriniz\n");
        film.Score = double.Parse (Console.ReadLine());
    }
    
    
    
    filmler.Add (film);
    
    Console.WriteLine("\nYeni film eklemek ister misiniz ? (e/h)\n");
    add = Console.ReadLine().ToLower().Trim();

    while (add != "e" && add != "h")
    {
        Console.WriteLine("\nGeçersiz giriş yaptınız. Lütfen e yada h tuşlayınız. \n");

        add = Console.ReadLine().ToLower().Trim();
    }

} while (add == "e");

Console.WriteLine("\nFilmler : \n");

//Filmleri listeleme.
foreach (var item in filmler)

{
    Console.WriteLine($"\n{item.Name}");
}


Console.WriteLine("----------------------------");

Console.WriteLine("\nİMDB puanı 4 ila 9 arasındaki filmler : \n");

//Puanı 4 ila 9 arasında olan filmlerin listelemesi. 
foreach (var imdbScore in filmler)
{
    if (imdbScore.Score >= 4 && imdbScore.Score <= 9)
    {
        Console.WriteLine($"\n{imdbScore.Name} -> İMDB Puanı :  {imdbScore.Score}");
    }
}

Console.WriteLine("--------------------------------");
Console.WriteLine("\nA ile başlayan filmler : \n");
bool startA = false;
//A ile başlayan filmlerin listesi. 
foreach (var film in filmler)
{
    if (film.Name.StartsWith("A") || film.Name.StartsWith("a"))
    {
        Console.WriteLine($"Film Adı : {film.Name}, İBDM Puanı : {film.Score}");
        startA = true;
    }

}
if (!startA) 
{
    Console.WriteLine("A ismi ile başlayan film bulunmamaktadır. ");
}