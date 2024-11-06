namespace ConsoleApp1;

public enum SignStatus
{
    first,
    withSign,
    withBrackets
}

public class Number
{
    public Sign sign = new Sign(50);
    public int number;
    public SignStatus signStatus;

    public Number(int maxNumber = 10, SignStatus signStatus = SignStatus.withSign)
    {
        this.signStatus = signStatus;
        number = new Random().Next(1, maxNumber);
    }

    public override string ToString()
    {
        if (sign.isMinus())
        {
            switch (signStatus)
            {
                case SignStatus.withBrackets:
                    return $"(-{number})";
                default:
                    return $"-{number}";
            }
        }
        else
        {
            switch (signStatus)
            {
                case SignStatus.withSign:
                    return $"+{number}";
                default:
                    return $"{number}";
            }
        }
    }
}