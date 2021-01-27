using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Musteri musteri1 = new Musteri();
            musteri1.Name = "Hasan";
            musteri1.FirstName = "Sesturk";
            musteri1.TcNo = "2137234923";
            musteri1.BirthDay = "2001.12.2";

            Game game1 = new Game();
            game1.Name = "GTAV";
            game1.Price = 160.0;

            Musteri musteri = new Musteri();
            Game game = new Game();

            game.YuzdeEllı(game1);
            game.Buy(musteri1,game1);

            
        }
    }
}
