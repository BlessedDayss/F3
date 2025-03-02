using Spectre.Console;

namespace F3.Tasks;

public class Car
{
    public string Name { get; set; }
    public string Model { get; set; }
    public string Engine { get; set; }
}

public class Group
{
    public void GroupList()
    {
        var car = new List<Car>
        {
            new Car { Name = "BMW", Model = "M3", Engine = "V8" },
            new Car { Name = "BMW", Model = "M5", Engine = "V10" },
            new Car { Name = "BMW", Model = "M7", Engine = "V12" },
            new Car { Name = "Mercedes", Model = "C-Class", Engine = "V6" },
            new Car { Name = "Mercedes", Model = "E-Class", Engine = "V8" },
            new Car { Name = "Mercedes", Model = "S-Class", Engine = "V12" },
        };
        
        var groupList = car.GroupBy(g => g.Engine);

        foreach (var engine in groupList)
        {
            Console.WriteLine($"Engine: {engine.Key}");
            foreach (var group in engine)
            {
                AnsiConsole.WriteLine($"        Name: {group.Name}, Model: {group.Model}");
            }
        }
    }

    
}