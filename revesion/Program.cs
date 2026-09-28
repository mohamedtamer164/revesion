namespace revesion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*                                                                                 
                 السؤال 1 — Variables & Input                       
            */
            
            Console.Write("enter age :");
            int age = int.Parse(Console.ReadLine());
            Console.Write("enter Weight:");
            double Weight = int.Parse(Console.ReadLine());
            Console.Write("enter name:");
            string name = Console.ReadLine();
            Console.WriteLine($"{age},{Weight},{name}");
        }
    }
}
