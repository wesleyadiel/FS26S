using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS26S.Class
{
    public class City
    {
        public string code { get; set; }
        public string name { get; set; }
        public bool visit { get; set; }
        public decimal distance { get; set; }
        public List<City> conections { get; set; }

        public City(string code, string name)
        {
            this.code = code;
            this.name = name;
            this.visit = false;
            this.conections = new List<City>();
        }
    }
}
