namespace F3.Tasks;

public class Order
{   
    public class SomeList
    {
        public string Name { get; set; }
    }
    public void OrderList()
    {
        var list = new List<SomeList>
        {
            new SomeList { Name = "John" },
            new SomeList { Name = "Jane" },
            new SomeList { Name = "Doe" },
            new SomeList { Name = "Smith" }
        };

        var orderList = list.OrderBy(o => o.Name);

        foreach (var order in orderList)
        {
            Console.WriteLine(order.Name);
        }
    }
}