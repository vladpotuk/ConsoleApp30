public class MathOperations
{
    public static int MultiplyNumbersInRange(int start, int end)
    {
        int result = 1;

        for (int i = start; i <= end; i++)
        {
            result *= i;
        }

        return result;
    }
}
