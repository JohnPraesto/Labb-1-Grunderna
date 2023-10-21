namespace Labb_1_Grunderna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("[1] Triangle (Equilateral)");
                Console.WriteLine("[2] Circle");
                string selection = Console.ReadLine();
                Console.Clear();
                switch (selection)
                {
                    case "1":
                        while (true)
                        {
                            Console.Write("What is the side length of the triangle? ");
                            try
                            {
                                double side = double.Parse(Console.ReadLine());
                                Triangle newTriangle = new Triangle(side);
                                Console.WriteLine("Area:          " + Math.Round(newTriangle.getArea(), 2));
                                Console.WriteLine("Circumference: " + Math.Round(newTriangle.getCircumference(), 2));
                                Console.WriteLine("Volume       : " + Math.Round(newTriangle.getVolume(), 2) + " (Pyramid, given height: " + side + ")\n");
                                Console.WriteLine("Exit press X. Continue press any key.");
                                selection = Console.ReadLine().ToUpper();
                                if (selection == "X")
                                    break;
                            }
                            catch
                            {
                                Console.WriteLine("Only insert numbers.\n");
                            }
                            Console.Clear();
                        }
                        break;
                    case "2":
                        while (true)
                        {
                            Console.Write("What is the radius of the circle? ");
                            try
                            {
                                double radius = double.Parse(Console.ReadLine());
                                Circle newCircle = new Circle(radius);
                                Console.WriteLine("Area:          " + Math.Round(newCircle.getArea(), 2));
                                Console.WriteLine("Circumference: " + Math.Round(newCircle.getCircumference(), 2));
                                Console.WriteLine("Volume       : " + Math.Round(newCircle.getVolume(), 2) + " (Sphere)\n");
                                Console.WriteLine("Exit press X. Continue press any key.");
                                selection = Console.ReadLine().ToUpper();
                                if (selection == "X")
                                    break;
                            }
                            catch
                            {
                                Console.WriteLine("Only insert numbers.\n");
                            }
                            Console.Clear();
                        }
                        break;
                    default:
                        Console.WriteLine("Incorrect input, choose only 1 or 2\n");
                        break;
                }
                Console.Clear();
            }
            
            
        }
    }
}