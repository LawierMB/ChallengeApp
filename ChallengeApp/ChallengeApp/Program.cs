using ChallengeApp;

var employee = new Employee("Artem", "Dziarski");

int gradeint = int.MaxValue;
double dgrade = double.MaxValue;

employee.AddGrade("2");
employee.AddGrade("Marek");
employee.AddGrade("4000");
employee.AddGrade(3);
employee.AddGrade(5);
employee.AddGrade(gradeint);
employee.AddGrade(dgrade);

var statistic = employee.GetStatistics();
var statistic1 = employee.GetStatisticsWithDoWhile();
var statistic2 = employee.GetStatisticsWithWhile();
var statistic3 = employee.GetStatisticsWithFor();
var statistic4 = employee.GetStatisticsWithForEach();


Console.WriteLine($"Average :{statistic.Average:N2}");
Console.WriteLine($"Max :{statistic.Max}");
Console.WriteLine($"Min :{statistic.Min}");
