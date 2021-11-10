using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroZH1
{
    public class Line
    {
        //Поля
        protected List<Station> stations;//список станций линии
        protected string name;//имя линии
        protected ConsoleColor color;//цвет линии
        //Методы
        public Line(string name, ConsoleColor color)//конструктор, принимающий имя линии и цвет
        {
            this.name = name;// присваиваем значению переменной name объекта значение переменной name метода
            this.color = color;// присваиваем значению переменной color объекта значение переменной color метода
            stations = new List<Station>();//объявляем список станций для данной линии
        }
        public Station GetStation(string name)//ну дальше там все понятно
        {
                foreach (Station i in stations)
                {
                    if (i.Name == name) return i;
                }
                return null;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public ConsoleColor GetColor
        {
            get { return color; }
            set { color = value; }
        }
        public void AddStation(string name)//добавление станции в линию
        {
            stations.Add(new Station(name, color));
        }
        public void AddStaion(string name, List<Station> transfers, params bool[] options)
        {
            stations.Add(new Station(name, color, transfers, options[0], options[1], options[2]) { SetLine = this }) ;
            
        }
        public void RemoveStation(string name)
        {
            foreach (Station i in stations)
            {
                if (i.Name == name) stations.Remove(i);
                break;
            }
        }
        public Station FindStationByName(string name)
        {
            return GetStation(name);
        }
        public List<Station> GetStationList
        {
            get { return stations; }
        }
        public virtual void PrintLine()
        {

        }
    }
    public class UndergroundLine : Line
    {
        public UndergroundLine(string name, ConsoleColor color) : base(name, color)
        {
            this.name = name;
            this.color = color;
        }
        public override void PrintLine()
        {

        }
    }
    public class DiameterLine : Line
    {
        public DiameterLine(string name, ConsoleColor color) : base(name, color)
        {
            this.name = name;
            this.color = color;
        }
        public override void PrintLine()
        {

        }
    }
    public class MCCLine : Line
    {
        public MCCLine(string name, ConsoleColor color) : base(name, color)
        {
            this.name = name;
            this.color = color;
        }
        public override void PrintLine()
        {

        }
    }
}
