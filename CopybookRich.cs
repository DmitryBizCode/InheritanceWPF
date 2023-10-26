using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCopybookWPF
{
    internal class CopybookRich : Copybook
    {
        public string Cover { get; set;}

        public double MAPCO(string key)
        {
            var map = new Dictionary<string, double>
            {
                ["leather"] = 150,
                ["paper"] = 0,
                ["cardboard"] = 20,
                ["art"] = 50
            };
            return map[key];
        }

        public CopybookRich(uint page, string name, string cover) : base(page, name) => Cover = cover;
        public CopybookRich() { }
        public CopybookRich(uint page, string name) : base(page, name){ }
        
        public double Calculate() => BasePrice * Pages * MAP(Name) + MAPCO(Cover);
    }
}
