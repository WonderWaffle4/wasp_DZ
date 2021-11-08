using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroZH1
{
    public class Station
    {
        string name;
        string color;
        Line line;
        bool isWheelChairAccessible;
        bool hasParkAndRide;
        bool hasNearbyCableCar;
        List<Station> transfers;
        
        public Station(string name, string color)
        {

        }
        public Station(string name, string color, List<Station> transfers)
        {

        }
        public string GetName()
        {

        }
        public void SetName(string name)
        {

        }
        public bool isWheelChairAccessible()
        {

        }
        public bool HasParkAndRide()
        {

        }
        public bool HasNearbyCableCar()
        {

        }
        public string GetLineName()
        {

        }
        public List<Station> GetTransferList()
        {

        }
    }
}
