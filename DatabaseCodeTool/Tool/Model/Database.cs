using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool.Model
{
    [Serializable]
    class Database
    {
        public string name { set; get; }
        public string type { set; get; }
        public string value { set; get; }
    }
}
