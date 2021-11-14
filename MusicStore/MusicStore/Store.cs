using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore
{
    class Store
    {
        string storeName;
        string address;
        List<Audio> diskCollection;
        List<DVD> dvdCollection;

        public Store(string storeName, string address)
        {
            this.storeName = storeName;
            this.address = address;
            diskCollection = new List<Audio>();
            dvdCollection = new List<DVD>();
        }
        public static Store operator +(Store store, Audio disk)
        {
            store.diskCollection.Add(disk);
            return store;
        }
        public static Store operator -(Store store, Audio disk)
        {
            store.diskCollection.Remove(disk);
            return store;
        }
        public static Store operator +(Store store, DVD disk)
        {
            store.dvdCollection.Add(disk);
            return store;
        }
        public static Store operator -(Store store, DVD disk)
        {
            store.dvdCollection.Remove(disk);
            return store;
        }
        public override string ToString()
        {
            Console.WriteLine("---------------------\nСписок аудиодисков:\n---------------------");
            foreach (Audio i in diskCollection) Console.WriteLine($"---------------------{i}");
            Console.WriteLine("\n---------------------\nСписок фильмов:\n---------------------");
            foreach (DVD i in dvdCollection) Console.WriteLine($"---------------------{i}");
            return "";
        }
    }
}
