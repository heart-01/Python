using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMine.Register
{
    public class Row
    {
        public string account { get; set; }
        public string avatar { get; set; }
        public string tag { get; set; }
    }

    public class PlayerModel
    {
        public List<Row> rows { get; set; }
        public bool more { get; set; }
        public string next_key { get; set; }
    }
}
