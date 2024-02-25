public class FibonacciChecker
{
    public static bool IsFibonacciNumber(int number)
    {
        if (number < 0)
            return false;

        int a = 0, b = 1;

        while (b < number)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        return b == number;
    }
}
