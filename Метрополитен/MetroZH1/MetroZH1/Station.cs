using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroZH1
{
    public class Station
    {
        // Поля класса Station
        private string name; // Название станции
        protected ConsoleColor color; // Цвет станции
        protected Line line; //  Название линии
        protected bool isWheelChairAccessible; // Есть ли инвалидные места?
        protected bool hasParkAndRide; // Есть ли парковка
        protected bool hasNearbyCableCar; // Есть ли рядом фуникулёр
        protected List<Station> transfers;


        public Station(string name, ConsoleColor color, params bool[] info)// создаём конструктор, принимающий имя станции и её цвет
        {
            this.name = name; // присваиваем значению переменной name объекта значение переменной name метода
            this.color = color;// присваиваем значению переменной color объекта значение переменной color метода
            transfers = new List<Station>();
            isWheelChairAccessible = info[0];
            hasParkAndRide = info[1];
            hasNearbyCableCar = info[2];
        }
        public Station(string name, ConsoleColor color, List<Station> transfers, params bool[] info)// создаём конструктор, принимающий имя станции, её цвет и список маршрутов
        {
            this.name = name; // присваиваем значению переменной name объекта значение переменной name метода
            this.color = color;// присваиваем значению переменной color объекта значение переменной color метода
            this.transfers = new List<Station>(transfers);
            isWheelChairAccessible = info[0];
            hasParkAndRide = info[1];
            hasNearbyCableCar = info[2];
        }
        public Line SetLine
        {
            set { line = value; }
        }
        public string Name// создаём свойство
        {
            get { return name; }
            set { name = value; }
        } 
        public bool IsWheelChairAccessible// создаём свойство, возвращающий true, если на станции есть инвалидные коляски
        {
            get { return isWheelChairAccessible; }
        }
        public bool HasParkAndRide// создаём свойство, возвращающий true, если у станции есть парковка
        {
            get { return hasParkAndRide; }
        }
        public bool HasNearbyCableCar// создаём свойство, возвращающий true, если у станции есть фуникулёр(??)
        {
            get { return hasNearbyCableCar; }
        }
        public string GetLineName// создаём свойство, имя линии, на которой находится станция
        {
            get { return line.Name; }
        }
        public List<Station> GetTransferList// создаём свойство, возвращающий список маршрутов
        {
            get { return transfers; }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
