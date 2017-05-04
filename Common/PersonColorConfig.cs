using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class PersonColorConfig
    {
        public string DEPT_CODE { get; set; }
        public SerializableDictionary<string, SerializableDictionary<string, string>> COLOR_SET { get; set; }
    }
}
