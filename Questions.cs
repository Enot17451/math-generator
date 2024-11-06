namespace ConsoleApp1;

public class Questions
{
    private Random random = new Random();
    public Task[] array = new Task[6];

    public Questions()
    {
        array[0] = new Task("Сложение - вычитание отрицательных", 7);
        array[0].createFun = minus_numbers;
        
        array[1] = new Task("Умножение десятичных дробей", 7);
        array[1].createFun = realMultiply;

        array[2] = new Task("Сокращение дробей",7);
        array[2].createFun = reduction;
        
        array[3] = new Task("Приведение подобных", 7);
        array[3].createFun = similar;
        
        array[4] = new Task("Раскрытие скобок", 7);
        array[4].createFun = brackets;

        array[5] = new Task("Умножение скобок", 7);
        array[5].createFun = bracketsMultiply;     
        
        array[2] = new Task("Решение уравнения", 7);
        array[2].createFun = eq;
    }

    public string getMany(int index, int howMuch)
    {
        string answer = "";
        Console.WriteLine(array[index].name);
        for (int i = 0; i < howMuch; i++)
        {
            answer += $"{array[index].createFun()}\n";
        }

        return answer;
    }

    public string printAllNames()
    {
        string answer = "";
        for (int i = 0; i < array.Length; i++)
        {
            answer += $"{array[i].name}\n";
        }
        return answer;
    }
    
    string minus_numbers()
    {
        Number a = new Number(10, SignStatus.first);
        Number b = new Number(10, SignStatus.withBrackets);
        Sign s = new Sign(30);
        return $"{a} {s} {b}";
    }

    string similar()
    {
        char[] letters = ['a', 'b', 'y', 'm', 'n', 'k', 'z'];
        char otherLetter = letters[random.Next(letters.Length)];
        string answer = Help.getNumberOrTwoVar(true,otherLetter);
        for (int i = 0; i < 10; i++)
        {
            answer += Help.getNumberOrTwoVar(false,otherLetter);
        }
        return answer;
    }

     string eq()
    {
        string answer = Help.getNumberOrVar(true);
        for (int i = 0; i < 4; i++)
        {
            answer += Help.getNumberOrVar(false);
        }
        answer += $"={Help.getNumberOrVar(true)}";
        for (int i = 0; i < 5; i++)
        {
            answer += Help.getNumberOrVar(false);
        }
        return answer;
    }

     string realMultiply()
    {
        string answer = "";
        RealNumber a = new RealNumber(10, SignStatus.first);
        RealNumber b = new RealNumber(10, SignStatus.withBrackets);
        return $"{a} * {b}";
    }

     string brackets()
    {
        string answer = Help.getNumberOrVar(true);
        answer += $"{new Sign(50)}";
        answer += Help.getBracketWithVar();
        answer += Help.getNumberOrVar(false);
        return answer;
    }

     string bracketsMultiply()
    {
        string answer = $"{new Number(10, SignStatus.first)}";
        answer += Help.getBracketWithVar();
        answer += $"{new Number(10, SignStatus.withSign)}";
        answer += Help.getBracketWithVar();
        return answer;
    }

    string reduction()
    {
        string answer = "";
        int t = random.Next(2);
        if (t==0)
        {
            
        }
        else
        {
            
        }
        answer += "------";
        return "";
    }
}