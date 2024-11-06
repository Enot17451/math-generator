namespace ConsoleApp1;

public static class Help
{
    static Random random = new Random();

    public static string getNumberOrVar(bool isFirst)
    {
        int typeNumber = random.Next(2);
        if (isFirst)
        {
            switch (typeNumber)
            {
                case 0: return $"{new Number(10, SignStatus.first)}";
                case 1: return $"{new Var(10, SignStatus.first)}";
            }
        }
        else
        {
            switch (typeNumber)
            {
                case 0: return $"{new Number()}";
                case 1: return $"{new Var()}";
            }
        }

        return "ERROR";
    }

    public static string getNumberOrTwoVar(bool isFirst, char otherLetter)
    {
        int typeNumber = random.Next(3);
        if (isFirst)
        {
            switch (typeNumber)
            {
                case 0: return $"{new Number(10, SignStatus.first)}";
                case 1: return $"{new Var(10, SignStatus.first)}";
                case 2: return $"{new Var(10, SignStatus.first, otherLetter)}";
            }
        }
        else
        {
            switch (typeNumber)
            {
                case 0: return $"{new Number()}";
                case 1: return $"{new Var()}";
                case 2: return $"{new Var(10, SignStatus.withSign, otherLetter)}";
            }
        }
        return "ERROR";
    }

    public static string getBracketWithVar()
    {
        Number a;
        Number b;
        int t = random.Next(2);
        if (t==0)
        {
            a = new Number(10,SignStatus.first); 
            b = new Var(10,SignStatus.withSign);
        }
        else
        {
            a = new Var(10,SignStatus.first);
            b = new Number(10,SignStatus.withSign);
        }
        return $"({a}{b})";
    }
}
    