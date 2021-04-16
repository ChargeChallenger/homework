using System;
using System.Collections.Generic;
using System.Text;

namespace console_project
{
    class Manufacturer
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Manufacturer (string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
