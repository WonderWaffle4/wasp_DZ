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
        private string color; // Цвет станции
        public Line line; //  Название линии
        private bool isWheelChairAccessible; // Есть ли инвалидные места?
        private bool hasParkAndRide; // Есть ли парковка
        private bool hasNearbyCableCar; // Есть ли рядом фуникулёр
        private List<Station> transfers;


        public Station(string name, string color, params bool[] options)// создаём конструктор, принимающий имя станции и её цвет
        {
            this.name = name; // присваиваем значению переменной name объекта значение переменной name метода
            this.color = color;// присваиваем значению переменной color объекта значение переменной color метода
            isWheelChairAccessible = options[0];
            hasParkAndRide = options[1];
            hasNearbyCableCar = options[2];
        }
        public Station(string name, string color, List<Station> transfers, params bool[] options)// создаём конструктор, принимающий имя станции, её цвет и список маршрутов
        {
            this.name = name; // присваиваем значению переменной name объекта значение переменной name метода
            this.color = color;// присваиваем значению переменной color объекта значение переменной color метода
            foreach(Station i in transfers)
            {
                this.transfers.Add(i);
            }
            isWheelChairAccessible = options[0];
            hasParkAndRide = options[1];
            hasNearbyCableCar = options[2];
        }
        public string GetName()// создаём метод, возвращающий имя станции
        {
            return name; // возвращаем переменную name объекта
        }
        public void SetName(string name)// создаём метод, задающий имя станции
        {
            this.name = name; // присваиваем значению переменной name объекта значение переменной name метода
        }
        public bool IsWheelChairAccessible()// создаём метод, возвращающий true, если на станции есть инвалидные коляски
        {
            return isWheelChairAccessible;
        }
        public bool HasParkAndRide()// создаём метод, возвращающий true, если у станции есть парковка
        {
            return hasParkAndRide;
        }
        public bool HasNearbyCableCar()// создаём метод, возвращающий true, если у станции есть фуникулёр(??)
        {
            return hasNearbyCableCar;
        }
        public string GetLineName()// создаём метод, имя линии, на которой находится станция
        {
            return line.GetName();
        }
        public List<Station> GetTransferList()// создаём метод, возвращающий список маршрутов
        {
            return transfers;
        }
    }
}
