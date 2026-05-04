using Bussines.Interfaces;

namespace Bussines.Services;

public class FibonacciService : IFibonacciService
{
    public List<int> Generate(int count)
    {
        var result = new List<int>();

        if (count <= 0)
            return result;

        if (count >= 1)
            result.Add(0);

        if (count >= 2)
            result.Add(1);

        for (int i = 2; i < count; i++)
        {
            int next = result[i - 1] + result[i - 2];
            result.Add(next);
        }

        return result;
    }
}