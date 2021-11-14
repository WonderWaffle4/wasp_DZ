using System;

namespace MusicStore
{
    interface IStoreItem
    {
        static double Price { get; set; }

        void DiscountPrice(int percent);
    }
    public class Disk : IStoreItem
    {
        protected string name;
        protected string genre;
        protected int burnCount;
        public Disk(string name, string genre)
        {
            this.name = name;
            this.genre = genre;
        }
        public virtual int DiskSize { get; set; }
        public virtual void Burn(params string[] values)
        {

        }
        public string getName() { return name; }
        double Price { get; set; }
        void IStoreItem.DiscountPrice(int percent)
        {
            Price -= Price * (percent / 100);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store("DiskStore", "Chertanovskay Str.");
            DVD dvd1 = new DVD("Spider-Man", "Super heroes", "Sam Raimi", "Marvle Studios", 120);
            DVD dvd2 = new DVD("Terminator", "Fantasy", "James Cameron", "Orion Pictures", 90);
            store += dvd1;
            store += dvd2;
            Audio disk1 = new Audio("Famous Monsters", "Horror-Punk", "Misfits", "Studio1", 10);
            Audio disk2 = new Audio("JnG OST", "SID Metal", "Machinae Supremacy", "Studio2", 50);
            store += disk1;
            store += disk2;
            store.ToString();
            disk1.Burn("Burning Memory", "Ambience", "Caretaker", "Studio3");
            Console.WriteLine();
            Console.WriteLine($"{dvd1.getName()} ----> {dvd1.DiskSize}");
            Console.WriteLine($"{dvd2.getName()} ----> {dvd2.DiskSize}");
            Console.WriteLine($"{disk1.getName()} ----> {disk1.DiskSize}");
            Console.WriteLine($"{disk2.getName()} ----> {disk2.DiskSize}");
        }
    }
}
