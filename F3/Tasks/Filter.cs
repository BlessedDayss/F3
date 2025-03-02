namespace F3.Tasks;

public class Filter
{
    public void EvenNumbers()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var filter = numbers.Where(n => n % 2 == 0);

        foreach (var even in filter)
        {
            Console.WriteLine($"Even numbers: {even}");
        }
    }
}