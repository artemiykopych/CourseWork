using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Vertex
    {
        string color;

        public Vertex()
        {
            color = "Default";
        }

        public void changeColor(string color1)
        {
            color = color1;
        }

        public string Color { get { return color; } set { color = value; } }
    }
}
