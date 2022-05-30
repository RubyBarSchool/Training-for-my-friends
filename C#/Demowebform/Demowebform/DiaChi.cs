using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demowebform
{
    public class DiaChi
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}