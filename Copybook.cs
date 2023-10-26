using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Xml.Linq;

namespace InheritanceCopybookWPF
{
    internal class Copybook
    {
        public uint Pages { get; set;}
        public uint BasePrice { get; set;}
        public string Name { get; set;}
        public double MAP(string key)
        {
            Dictionary<string, double> map = new Dictionary<string, double>
            {
                ["cell"] = 1,
                ["stripe"] = 1,
                ["diagonal stripe"] = 1.1,
                ["empty"] = 1.5
            };
            return map[key];
        }

        public Copybook(uint page, string name)
        {
            Pages = page;
            Name = name;
            BasePrice = 15;
        }

        public Copybook() {
            Pages = 12;
            Name = "cell";
            BasePrice = 15;
        }

        public double Calculate() => BasePrice * Pages * MAP(this.Name);

    }
}
