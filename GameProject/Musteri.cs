using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class Musteri : IManager
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string TcNo { get; set; }
        public string BirthDay { get; set; }



        public void Add()
        {
            Console.WriteLine("Sisteme " + Name + " " + FirstName + " kişisi eklendi.");
        }

        public void Del()
        {
            Console.WriteLine("Sistemden " + Name + " " + FirstName + " kişisi silindi.");
        }

        public void update()
        {
            Console.WriteLine("Sistemde " + Name + " " + FirstName + " kişisi güncellendi.");
        }
    }
}
