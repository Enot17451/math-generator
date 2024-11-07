using System.IO.Pipes;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Questions quest = new Questions();
        string[] answer = quest.getMany(11,10);
        for (int i = 0; i < answer.Length; i++)
        {
            Console.WriteLine(answer[i]);
        }
    }
}








