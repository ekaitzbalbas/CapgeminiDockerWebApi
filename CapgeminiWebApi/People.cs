using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapgeminiWebApi
{
    public class People
    {
        public int id { get; set; }
        public string name { get; set; }

        public People(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
