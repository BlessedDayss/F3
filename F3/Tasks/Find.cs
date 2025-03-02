namespace F3.Tasks;

public class Find
{ 
    public void FindNumbers()
    {
        int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var find = numbers2.Where(n => n > 3);

        foreach (var more in find)
        {
            Console.WriteLine(more);
        }
    }
}