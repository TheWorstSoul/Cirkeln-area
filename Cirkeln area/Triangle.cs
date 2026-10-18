using System;
using System.Collections.Generic;
using System.Text;

namespace Cirkeln_area
{
    internal class Triangle
    {

        public float Basen { get; set; }
        public float Höjden { get; set; }


        public Triangle() 
        { 
        
        }


        public Triangle(float basen, float höjden) 
        { 
        
        Basen = basen;
            
            Höjden = höjden;
        
        }

        public void gettrianglearea() 
        {

            float trianglearea = (Basen * Höjden) / 2;

            Console.WriteLine("Triangel area: " + trianglearea);


        }



    }
}
