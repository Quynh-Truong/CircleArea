namespace CircleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle1 = new Circle(5);
            double area1 = myCircle1.GetArea();
            Console.WriteLine($"The area of a cirle with a radius of 5 is {area1:0.##}");

            Circle myCircle2 = new Circle(6);
            double area2 = myCircle2.GetArea();
            Console.WriteLine($"The area of a cirle with a radius of 6 is {area2:0.##}");

            double circumference = myCircle1.GetCircumference();
            Console.WriteLine($"The circumference of a circle with a radius of 5 is {circumference:0.##}");
            double volume = myCircle1.GetVolume();
            Console.WriteLine($"The volume of a circle with a radius of 5 is {volume:0.##}");
        }
    }
}