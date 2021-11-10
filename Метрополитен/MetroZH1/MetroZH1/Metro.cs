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
            /*string line = reader.ReadLine();
            string add = "";//добавляет символы, пока не встретится ;
            string mainLine;//хранит текущую главную ветку метро на строке
            string Line = "";//хранит ветку пересадки
            string mainStation;//хранит главную станцию строки
            string Station;//хранит текущую пересадку метро на строке
            List<Station> transfers = new List<Station>();//хранит пересадки
            int buffer = 0;
            //добавление ветки
            for(int i = 0; line[i] != ';'; i++)//проверяем ветку
            {
                add += line[i];
                buffer = i;
            }
            AddLine(add, ConsoleColor.Red);
            mainLine = add;
            buffer++;
            add = "";
            for(int i = buffer; line[i] != ';'; i++)//проверяем главную станцию
            {
                add += line[i];
                buffer = i;
            }
            mainStation = add;
            add = "";
            buffer++;
            if (buffer < line.Length)//добавляем пересадки
            {
                for (int i = buffer; i < line.Length; i++)
                {
                    if (line[i] != '-' && line[i] != ';') add += line[i];
                    if (i == '-')//создаём несуществующую пока ветку, если пересадка идёт на нёё
                    {
                        AddLine(add, ConsoleColor.Red);
                        Line = add;//сохраняем добавленную ветку
                        add = "";    
                    }
                    if (i == ';')//добавляем станцию в список пересадок
                    {
                        foreach(Line j in lines)
                        {
                            if (j.Name == Line) j.AddStation(i);
                        }
                    }
                }


                foreach (Line i in lines)
                {
                    if (i == Line) i.AddStation(add, );
                }
            }
            buffer++;
            add = "";*/
            Console.WriteLine("Введите путь к файлу: ");
            reader = new StreamReader(Console.ReadLine());
            string line = reader.ReadLine();
            string add = "";//буфер строки
            int buffer = 0;
            string mainLine;//навзвание главной проверяемой ветки
            bool foundLine = false;//нашлась ли ветка в списке
            for (int i = 0; i != ';'; i++)
            {
                add += line[i];
                if (line[i + 1] == ';') buffer = i;
            }
            
            mainLine = add;//запомнили ветку
            add = "";
            buffer++;
            for (int i = buffer; i != ';'; i++) add += line[i];
            foreach (Line i in lines)
            {
                if (i.Name == mainLine)
                {
                    foundLine = true;
                    break;
                }
            }
            if (!foundLine)
            {
                AddLine(mainLine, ConsoleColor.Red);
            }
            foundLine = false;
            foreach(Line i in lines)
            {
                if (i.Name == mainLine) i.AddStation(add);
            }
            line = reader.ReadLine();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
