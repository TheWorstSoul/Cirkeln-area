namespace Cirkeln_area
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vill du ha arean på en triangel eller en circkel?");
            Console.WriteLine("Trycke 1 för triangel och 2 för circkel");
         

            while (true)
            {
                string val = Console.ReadLine();
                if (val == "1") 
                { 
                
                Triangle area = new Triangle();


                    Console.WriteLine("basen: ");
                    area.Basen = float.Parse(Console.ReadLine());

                    Console.WriteLine("höjden; ");
                    area.Höjden = float.Parse(Console.ReadLine());

                    area.gettrianglearea();
                    break;
                }

                else if (val == "2")
                {
                    Console.WriteLine("Hej, vänligen ange radien, så berätar jag arean");
                    Circle Area = new Circle();

                    Area.Radius = float.Parse(Console.ReadLine());

                    Area.getArea();

                    Area.getOmkrets();

                    Area.getVolym();
                    break;
                }

                else 
                {
                    Console.WriteLine("måste vara 1 eller 2");
                }
            }
        
        
        
        
        }
    }
}
