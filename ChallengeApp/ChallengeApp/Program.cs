using ChallengeApp;

List<Employee> workers = new List<Employee>();

Employee worker1 = new Employee("Antoni", "Szpak", 32);
workers.Add(worker1);
Employee worker2 = new Employee("Marianna", "Wieczorek", 25);
workers.Add(worker2);
Employee worker3 = new Employee("Artem", "Dziarski", 30);
workers.Add(worker3);

worker1.AddScore(3);
worker1.AddScore(5);
worker1.AddScore(8);
worker1.AddScore(2);
worker1.AddScore(4);

worker2.AddScore(2);
worker2.AddScore(3);
worker2.AddScore(8);
worker2.AddScore(9);
worker2.AddScore(1);

worker3.AddScore(5);
worker3.AddScore(1);
worker3.AddScore(9);
worker3.AddScore(2);
worker3.AddScore(3);

Console.WriteLine("Zebrane punkty przez pracownika: " 
    + worker1.FirstName + " " + worker1.LastName +" to : " + worker1.ResultPoint);
Console.WriteLine("Zebrane punkty przez pracownika: " 
    + worker2.FirstName + " " + worker2.LastName +" to : " + worker2.ResultPoint);
Console.WriteLine("Zebrane punkty przez pracownika: " 
    + worker3.FirstName + " " + worker3.LastName +" to : " + worker3.ResultPoint);

int maxResult = -1;
Employee workerWithMaxResult = null;

foreach (var worker in workers)
{
    if (worker.ResultPoint > maxResult)
    {
        workerWithMaxResult = worker;
        maxResult = worker.ResultPoint;
    }
}
Console.WriteLine("\nNajlepszy wynik osiągnął pracownik: " 
    + workerWithMaxResult.FirstName + " " + workerWithMaxResult.LastName 
    + " z " + workerWithMaxResult.ResultPoint + " punktami !");