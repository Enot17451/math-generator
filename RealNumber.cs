namespace ConsoleApp1;

public class RealNumber : Number
{
    public double real;
    public RealNumber(int maxNumber = 10, SignStatus fullSign = SignStatus.withSign)
    {
        this.signStatus = fullSign;
        int mantissa = new Random().Next(0, 3);
        number = new Random().Next(1, maxNumber);
        string realString = "0,";
        for (int i = 0; i < mantissa; i++)
        {
            realString += "0";
        }
        real = Convert.ToDouble($"{realString}{number}");
    }

    public override string ToString()
    {
        if (sign.isMinus())
        {
            switch (signStatus)
            {
                case SignStatus.withBrackets:
                    return $"(-{real})";
                default:
                    return $"-{real}";
            }
        }
        else
        {
            switch (signStatus)
            {
                case SignStatus.withSign:
                    return $"+{real}";
                default:
                    return $"{real}";
            }
        }
    }
}