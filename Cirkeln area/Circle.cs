using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;

namespace Cirkeln_area
{
    internal class Circle
    {

        public float Radius { get; set; }



        public Circle()
        {

        }


        public Circle(float radius)
        {
            Radius = radius;
        }



        public void getArea()
        {
            float area = Radius * Radius * 3.141f;
            Console.WriteLine("Area: {0}", area);
        }

        public void getOmkrets() 
        { 
        
        float omkrets = Radius * 2 * 3.141f;
            Console.WriteLine("Omkrets: " + omkrets);
        }

        public void getVolym() 
        {

            float volym = (4 * 3.141f * Radius * Radius * Radius) / 3;
            Console.WriteLine("Volym: " + volym);
        
        }

    }
}
