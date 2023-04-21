
namespace cSharp
{
    


    class program
    {
        // Inheritance is a mechanism in which one class 
        // acquires the property of another class

        // Using inheritance , you can create a general class
        // that defines traits common to a set of related items.


        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.height= 10;
            rect.width = 7;
            rect.shapeName = "Rectangle";
            rect.printDimension();
            rect.Area(); 
            
         
            Triangle triangle = new Triangle();
            triangle.height = 20;
            triangle.width = 5;
            triangle.shapeName = "Triangle";
            triangle.printDimension();
            triangle.Area();
            Console.ReadKey();
        }

        public class Shape//base class
        {
            public int height;
            public int width;
            public string shapeName;

            public void printDimension()
            {
                Console.WriteLine(shapeName+ " width is : " + width + " And Height is : " +height);
            }
        }

        public class Rectangle : Shape//derived class
        {

            public void Area()
            {
                Console.WriteLine("Area of Rectangle is :" + height * width);
            }
        }
        public class Triangle : Shape//derived class
        {

            public void Area()
            {
                Console.WriteLine("Area of Triangle is :" + (height * width /2));
            }
        }
    }
}
