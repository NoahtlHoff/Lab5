using Lab5;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle cirkel1 = new Circle(5);
            Circle cirkel2 = new Circle(6);

            Triangle triange1 = new Triangle(5, 3);

            Console.WriteLine($"Cirkel 1 area är: {cirkel1.GetArea()} cm^2");
            Console.WriteLine($"Cirkel 2 area är: {cirkel2.GetArea()} cm^2");
            Console.WriteLine("");
            Console.WriteLine($"Cirkel 1 omkrets är: {cirkel1.GetCircumference()} cm");
            Console.WriteLine($"Cirkel 2 omkrets är: {cirkel2.GetCircumference()} cm");
            Console.WriteLine("");
            Console.WriteLine($"Cirkel 1 var en sfär, så skulle volymen vara: {cirkel1.GetSphereVolume()} cm^3");
            Console.WriteLine($"Cirkel 2 var en sfär, så skulle volymen vara: {cirkel2.GetSphereVolume()} cm^3");
            Console.WriteLine("");
            Console.WriteLine($"Triangel 1 har arean: {triange1.GetArea()} cm^2");
        }
    }
}
