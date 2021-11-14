using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore
{
    class DVD : Disk
    {
        string producer;
        string filmCompany;
        int minutesCount;
        public DVD(string name, string genre, string producer, string filmCompany, int minutesCount) : base(name, genre)
        {
            this.producer = producer;
            this.filmCompany = filmCompany;
            this.minutesCount = minutesCount;
        }
        public override int DiskSize
        {
            get { return (minutesCount / 64) * 2; }
        }
        public override void Burn(params string[] values)
        {
            producer = values[0];
            filmCompany = values[1];
            burnCount++;
        }
        public override string ToString()
        {
            Console.Write($"Название: {name}\nЖанр: {genre}\nРежиссер: {producer}\nКинокомпания: {filmCompany}\nКоличество минут: {minutesCount}\nКоличество прожигов: {burnCount}\n");
            return "";
        }
    }
}
