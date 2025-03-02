using F3.Tasks;
using Spectre.Console;

namespace F3
{
    public static class Program
    {
        private static void Main()
        {
            AnsiConsole.MarkupLine("[red]Filter Even Numbers from a List:[/]");
            Filter filter = new Filter();
            filter.EvenNumbers();

            AnsiConsole.MarkupLine("\n[red]Find All Numbers Greater Than a Given Value:[/]");
            Find find = new Find();
            find.FindNumbers();
            
            AnsiConsole.MarkupLine("\n[red]Order a List by Length:[/]");
            Order order = new Order();
            order.OrderList();
            
            AnsiConsole.MarkupLine("\n[red]Group a List by a Property:[/]");
            Group group = new Group();
            group.GroupList();
            
            AnsiConsole.MarkupLine("\n[red]Pagination:[/]");
            Pagination pagination = new Pagination();
            pagination.Paginator();
        }
    }
}

