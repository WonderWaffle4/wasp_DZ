using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroZH1
{
    public class Metro
    {
        private List<Line> lines;
        private string city;

        public Metro(string city)
        {
            this.city = city;
        }
        public string GetCity()
        {
            return city;
        }
        public void AddLine(string name, string color)
        {
            lines.Add(new Line(name, color));
        }
        public void RemoveLine(string name)
        {
            foreach(Line i in lines)
            {
                if(i.GetName() == name) lines.Remove(i);
                break;
            }
        }
        public List<Station> FindStation(string name)
        {
            List<Station> stations = new List<Station>;
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
                if(i.GetName() == lineName)
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
                foreach(Station j in i.GetStationList())
                {
                    stations.Add(j);
                }
            }
            return stations;s
        }
        public void LoadStationsFromFile(string filename)
        {

        }
    }
}
