namespace SFTask5._5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите что-то");
            var str = Console.ReadLine();

            Console.WriteLine("Укажиет глубину эха");
            var deep = Convert.ToInt32(Console.ReadLine());

            Echo(str, deep);

            Console.ReadKey();
        }

        static void Echo(string phrase, int deep)
        {
            var modif = phrase;

            if (modif.Length > 2)
                modif = modif.Remove(0, 2);

            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine("..." + modif);

            if (deep > 1)
                Echo(modif, deep - 1);
        }
    }
}