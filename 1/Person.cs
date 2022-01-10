using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Person
    {
        string name;
        int age;
        static int br = 0;

        public string Name
        {
            get { return name; }
            private set { name = value; }

        }
        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public Person()
        {
            Name = "";
            Age = 0;
            br++;
        }

    }
}
