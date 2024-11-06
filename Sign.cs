namespace ConsoleApp1;

public class Sign
{
    static Random random = new Random();
    string sign;

    public Sign(int minusProportion)
    {
        int t = random.Next(100);
        if (t > minusProportion)
        {
            sign = "-";
        }
        else
        {
            sign = "+";
        }
    }

    public bool isMinus() => sign == "-";

    public override string ToString()
    {
        return sign;
    }
}