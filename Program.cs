namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Questions quest = new Questions();
        Console.WriteLine(quest.printAllNames());
        Console.WriteLine(quest.getMany(5, 10));
    }
}








