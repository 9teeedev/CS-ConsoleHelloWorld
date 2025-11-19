namespace ConsoleHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string sex = "";
            int height = 0;

            Console.WriteLine("Hello, World!");
            Console.WriteLine();
            Console.Write("Please, enter your name (eng): ");
            name = Console.ReadLine();
            Console.Write("Please, enter your sex (M/F): ");
            sex = Console.ReadLine();
            Console.WriteLine("Welcome to C# Programming, " + name + "!");
            Console.Write("Please, enter your height (cm): ");
            height = Convert.ToInt16(Console.ReadLine());
            int weight = 0;
            if (sex == "M"){
                weight = height - 100;
            }else{
                weight = height - 110;
            }
            Console.WriteLine("Your ideal weight is " + weight + " kg.");
            Console.WriteLine("----------------++++----------------");
            {
                
            }
        }
    }
}