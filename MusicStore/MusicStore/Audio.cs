using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore
{
    class Audio : Disk
    {
        string artist;
        string recordingStudio;
        int songsNumber;

        public Audio(string name, string genre, string artist,string recordingStudio, int songsNumber) : base(name, genre)
        {
            this.artist = artist;
            this.recordingStudio = recordingStudio;
            this.songsNumber = songsNumber;
        }
        public override int DiskSize
        {
            get { return songsNumber * 8; }
        }
        public override void Burn(params string[] values)
        {
            name = values[0];
            genre = values[1];
            artist = values[2];
            recordingStudio = values[3];
            burnCount++;
        }
        public override string ToString()//жанр, исполнитель, студия звукозаписи, количество песен, количество прожигов.
        {
            Console.Write($"Жанр: {genre}\nИсполнитель: {artist}\nСтудия звукозаписи: {recordingStudio}\nКол-во песен: {songsNumber}\nКол-во прожигов: {burnCount}\n");
            return "";
        }
    }
}
