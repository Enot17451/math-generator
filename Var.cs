namespace ConsoleApp1;

public class Var : Number
{
    public char letter;

    public Var(int maxNumber=10,SignStatus signStatus = SignStatus.withSign, char letter = 'x') :  base(maxNumber,signStatus)
    {
        this.letter = letter;
    }
    
    public override string ToString()
    {
        if (number==1)
        {
            if (sign.isMinus())
            {
                switch (signStatus)
                {
                    case SignStatus.withBrackets:
                        return $"(-{letter})";
                    default:
                        return $"-{letter}";
                }
            }
            else
            {
                switch (signStatus)
                {
                    case SignStatus.withSign:
                        return $"+{letter}";
                    default:
                        return $"{letter}";
                }
            }
        }
        else
        {
            if (sign.isMinus())
            {
                switch (signStatus)
                {
                    case SignStatus.withBrackets:
                        return $"(-{number}{letter})";
                    default:
                        return $"-{number}{letter}";
                }
            }
            else
            {
                switch (signStatus)
                {
                    case SignStatus.withSign:
                        return $"+{number}{letter}";
                    default:
                        return $"{number}{letter}";
                }
            }
        }

    }
}