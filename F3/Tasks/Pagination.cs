using System.Numerics;

namespace F3.Tasks;

public class Pagination
{
    public void Paginator()
    {
        var numbers = Enumerable.Range(1, 100).ToList();
        var size = 10;

        for (var i = 0; i < numbers.Count; i += size)
        {
            var page = numbers.Skip(i).Take(size);
            Console.WriteLine(string.Join(", ", page));
        }
    }
}