using ChallengeApp;

//var employee = new Employee("Artem", "Dziarski");
Console.WriteLine("Witamy w programie XYZ do oceny pracowników !");
Console.WriteLine("==============================================");
Console.WriteLine("Podaj Imię pracownika: ");
var name = Console.ReadLine();
Console.WriteLine("Podaj Nazwisko pracownika: ");
var lastName = Console.ReadLine();

var employee = new Employee(name, lastName);

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika " + name + " " + lastName + ": ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        if (char.TryParse(input, out char result))
        {
            employee.AddGrade(result);
        }
        else
        {
            employee.AddGrade(input);
        }
    }
    catch (Exception e) 
    {
        Console.WriteLine($"Exception Catchet:{e.Message}");
    }
}


var statistic = employee.GetStatistics();

Console.WriteLine($"Average :{statistic.Average:N2}");
Console.WriteLine($"Max :{statistic.Max}");
Console.WriteLine($"Min :{statistic.Min}");
Console.WriteLine($"Grade :{statistic.AverageLetter}");
