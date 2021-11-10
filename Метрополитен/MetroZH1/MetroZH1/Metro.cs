using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MetroZH1
{
    public class Metro
    {
        private List<Line> lines;
        private string city;
        private StreamReader reader;
        private ConsoleColor[] LineColors = new ConsoleColor[18];
        public Metro(string city)
        {
            this.city = city;
            lines = new List<Line>();
        }
        public string City
        {
            get { return city; }
        }
        public void AddLine(string name, ConsoleColor color)
        {
            lines.Add(new Line(name, color));
        }
        public void RemoveLine(string name)
        {
            foreach(Line i in lines)
            {
                if(i.Name == name) lines.Remove(i);
                break;
            }
        }
        public List<Station> FindStation(string name)
        {
            List<Station> stations = new List<Station>();
            foreach(Line i in lines)
            {
                stations.Add(i.FindStationByName(name));
            }
            return stations;
        }
        public Station FindStation(string name, string lineName)
        {
            foreach(Line i in lines)
            {
                if(i.Name == lineName)
                {
                    return i.FindStationByName(name);
                }
            }
            return null;
        }
        public List<Station> GetStationList(string name)
        {
            List<Station> stations = new List<Station>();
            foreach(Line i in lines)
            {
                foreach(Station j in i.GetStationList)
                {
                    stations.Add(j);
                }
            }
            return stations;
        }
        public void LoadStationsFromFile(string filename)
        {
            Console.WriteLine("Введите путь к файлу: ");
            reader = new StreamReader(Console.ReadLine());
            string line = reader.ReadLine();
            string add = "";
            int buffer;
            //добавление ветки
            for(int i = 0; i != line[i] && i < line.Length; i++)
            {
                add += line[i];
                if (i + 1 == line.Length) buffer = i;
            }
            AddLine();
            //добавление станции

            //добавление пересадок
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
