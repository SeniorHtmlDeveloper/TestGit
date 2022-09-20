using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Salam : Human
    {
        public string Orientation { get; set; }

        public Salam(string name, int age, string orientation) : base(name, age)
        {
            Orientation = orientation;
        }

        public override string Info()
        {
            return $"{Name}, {Age}, {Orientation}";
        }
    }
}
