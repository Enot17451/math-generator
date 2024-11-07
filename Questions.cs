namespace ConsoleApp1;

public class Questions
{
    private Random random = new Random();
    public Task[] array = new Task[12];

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
        
        array[6] = new Task("Решение уравнения", 7);
        array[6].createFun = eq;

        array[7] = new Task("Функции",7);
        array[7].createFun = functions;
        
        array[8] = new Task("Внесение под корень", 8);
        array[8].createFun = rootsIn;
        
        array[9] = new Task("Вынесение из под корень", 8);
        array[9].createFun = rootsOut;
        
        array[10] = new Task("Расчет дискриминанта", 8);
        array[10].createFun = discriminant;
        
        array[11] = new Task("Квадратное уравнение", 8);
        array[11].createFun = sqEq;
    }

    public string[] getMany(int index, int howMuch)
    {
        string[] answer = new string[howMuch];
        Console.WriteLine(array[index].name);
        for (int i = 0; i < howMuch; i++)
        {
            answer[i]=$"{array[index].createFun()}";
        }

        return answer;
    }
    
    string minus_numbers()
    {
        Number a = new Number(SignStatus.first);
        Number b = new Number(SignStatus.withBrackets);
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
        string answer = $"{new Number(SignStatus.first)}";
        answer += Help.getBracketWithVar();
        answer += $"{new Number(SignStatus.withSign)}";
        answer += Help.getBracketWithVar();
        return answer;
    } 
     
    string reduction()
    {
        string answer = "";
        Number a = new Number(SignStatus.first);
        int b = a.number * random.Next(2,7);
        int t = random.Next(2);
        if (t==0)
        {
            answer += $"{a}|{b}";
        }
        else
        {
            answer += $"{b}|{a}";

        }
        return answer;
    } 
     
    string functions()
    {
        Number[] numbers = [new Number(SignStatus.first),new Number(SignStatus.first),new Number(SignStatus.first)];
        string answer = $"y={new Var(SignStatus.first)}{new Number()}       x=[";
        answer += $"{numbers[0]}, ";
        answer += $"{numbers[1]}, ";
        answer += $"{numbers[2]}]";
        return answer;
    }
     
    string rootsIn()
    {
        int  a = random.Next(2,8);
        int b = random.Next(2,8);
        return $"{a}_/{b}";
    }
    
    string rootsOut()
    {
        int[] notRoots = [2, 3, 5, 6, 7];
        int randomNotRoot = notRoots[random.Next(notRoots.Length)];
        int a = random.Next(2,8);
        int b = (a * a) * randomNotRoot ;
        return $"_/{b}";
    }
    
    string discriminant()
    {
        Var a = new Var(SignStatus.first);
        Var b = new Var();
        Number c = new Number();
        return $"{a}{b}{c}=0";
    }
    
    string sqEq()
    {
        Var n1 = new Var(SignStatus.first);
        Number n2 = new Number(SignStatus.withSign);
        Number n3 = new Number(SignStatus.withBrackets);
        Console.WriteLine($"({n1}{n2}) = {n1.number * n1.number}x" +
                          $" + {2*n1.number*n2.number}x" +
                          $" {n2.number*n2.number - n3.number * n3.number} = 0({n3.number})");
        return $"=0";
    }
}