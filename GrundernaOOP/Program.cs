namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle cirkel1 = new Circle(5);
            Circle cirkel2 = new Circle(6);

            Console.WriteLine($"Cirkel 1 area är: {cirkel1.GetArea()}");
            Console.WriteLine($"Cirkel 2 area är: {cirkel2.GetArea()}");
            Console.WriteLine("");
            Console.WriteLine($"Cirkel 1 omkrets är: {cirkel1.GetCircumference()}");
            Console.WriteLine($"Cirkel 2 omkrets är: {cirkel2.GetCircumference()}");
            Console.WriteLine("");
            Console.WriteLine($"Cirkel 1 var en sfär, så skulle volymen vara: {cirkel1.GetSphereVolume()}");
            Console.WriteLine($"Cirkel 2 var en sfär, så skulle volymen vara: {cirkel2.GetSphereVolume()}");
        }
    }
}
