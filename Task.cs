namespace ConsoleApp1;

public delegate string CreateTask();

public class Task
{
    public string name;
    public int classNumber;
    public CreateTask createFun;

    public Task(string name,int classNumber)
    {
        this.name = name;
        this.classNumber = classNumber;
    }
}