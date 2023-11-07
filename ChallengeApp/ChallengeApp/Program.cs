using ChallengeApp;

var employee = new Employee("Artem", "Dziarski");

employee.AddGrade(8);
employee.AddGrade(3);
employee.AddGrade(5);

var statistic = employee.GetStatistics();
Console.WriteLine($"Average :{statistic.Average:N2}");
Console.WriteLine($"Max :{statistic.Max}");
Console.WriteLine($"Min :{statistic.Min}");
