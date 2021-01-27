using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class Game : ICampaign,IBuyManager
    {
        public string Name { get; set; }
        public double Price { get; set; }
        double fiyat2 = 0;
        public void YuzdeEllı(Game game)
        {
            fiyat2 = game.Price / 2;
            Console.WriteLine(game.Name + " Oyununun %50 İndirimli Fiyatı : " + fiyat2 + "TL");
            game.Price = fiyat2;
        }
        double fiyat = 0;
        public void YuzdeYırmıBes(Game game)
        {
            fiyat = game.Price / 2 / 2;
            Console.WriteLine(game.Name + " Oyununun %25 İndirimli Fiyatı : " + fiyat + "TL");
            game.Price = fiyat;
        }

        public void Add(Game game)
        {
            Console.WriteLine(game + " Kampanyası Sisteme Eklendi.");
        }

        public void Del(Game game)
        {
            Console.WriteLine(game + " Kampanyası Sistemden Silindi.");
        }

        public void update(Game game)
        {
            Console.WriteLine(game + " Kampanyası Sistemde Güncellendi.");
        }

        public void Buy(Musteri musteri, Game game)
        {
            Console.WriteLine(musteri.Name + " " + game.Name + " Oyununu " + game.Price + "TL Fiyatından satın aldın." );
        }
    }
}
