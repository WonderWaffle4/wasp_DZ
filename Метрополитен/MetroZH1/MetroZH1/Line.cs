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
        private List<Station> stations;//список станций линии
        private string name;//имя линии
        private string color;//цвет линии
        //Методы
        public Line(string name, string color)//конструктор, принимающий имя линии и цвет
        {
            this.name = name;// присваиваем значению переменной name объекта значение переменной name метода
            this.color = color;// присваиваем значению переменной color объекта значение переменной color метода
            stations = new List<Station>();//объявляем список станций для данной линии
        }
        public Station GetStation(string name)//ну дальше там все понятно
        {
            foreach (Station i in stations)
            {
                if (i.GetName() == name) return i;
            }
            return null;
        }
        public string GetName()
        {
            return name;//возвращаем имя линии
        }
        public void SetName(string name)
        {
            this.name = name; //присваем имя линии
        }
        public string GetColor()
        {
            return color;//возвращаем цвет линии
        }
        public void SetColor(string color)
        {
            this.color = color;//присваем цвет линии
        }
        public void AddStation(string name)//добавление станции в линию
        {
            stations.Add(new Station(name, color));
        }
        public void AddStaion(string name, List<Station> transfers, params bool[] options)
        {
            stations.Add(new Station(name, color, transfers, options[0], options[1], options[2]) { line = this }) ;
        }
        public void RemoveStation(string name)
        {
            foreach (Station i in stations)
            {
                if (i.GetName() == name) stations.Remove(i);
                break;
            }
        }
        public Station FindStationByName(string name)
        {
            return GetStation(name);//то же самое, что getStation
        }
        public List<Station> GetStationList()
        {
            return stations;
        }
    }
}
