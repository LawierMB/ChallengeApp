﻿using ChallengeApp;

string name="", lastName="", sex = "", age="";

//var employee = new Employee("Artem", "Dziarski");
Console.WriteLine("-----------------------------------------------------------------");
Console.WriteLine("| Witamy w programie XYZ do oceny kierowników i pracowników !   |");
Console.WriteLine("+---------------------------------------------------------------+");
Console.WriteLine("| Dodajesz pracownika: (PM) in Memory (PF) in File, kierownika (K) czy wychodzisz (Q)?  |");

var objectType = Console.ReadLine();


    switch (objectType.ToUpper())
    {
        case "Q":
            {
                return;
            }
    case "PF":
        {
            AddDataPerson("pracownika", 1);
            var employee = new EmployeeInFile(name, lastName);
            while (true)
            {
                Console.WriteLine("Podaj kolejną ocenę w zakresie od 0 do 100 i A do E dla pracownika " + name + " " + lastName + ": ");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    employee.AddGrade(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception Catchet:{e.Message}");
                }
            }
            //employee.AddGrade(45);
            //employee.AddGrade(80);
            //employee.AddGrade(20);
            //employee.AddGrade(5.6f);

            var statistic = employee.GetStatistics();
            Console.WriteLine($"Average :{statistic.Average:N2}");
            Console.WriteLine($"Max :{statistic.Max}");
            Console.WriteLine($"Min :{statistic.Min}");
            Console.WriteLine($"Grade :{statistic.AverageLetter}");
        }
        break;
        case "PM":
            {
                AddDataPerson("pracownika", 1);
                var employee = new EmployeeInMemory(name, lastName, sex, age);
            while (true)
            {
                Console.WriteLine("Podaj kolejną ocenę w zakresie od 0 do 100 i A do E dla pracownika " + name + " " + lastName + ": ");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    employee.AddGrade(input);
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
        }break;
    case "K":
        {
            AddDataPerson("Kierownika", 2);
            var supervisor = new Supervisor(name, lastName);
            while (true)
            {
                Console.WriteLine("Podaj kolejną ocenę w zakresie od 1 (+/-) do 6 (+/-) dla Kierownika  " + name + " " + lastName + ": ");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    supervisor.AddGrade(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception Catchet:{e.Message}");
                }
            }
            var statistic = supervisor.GetStatistics();
            Console.WriteLine($"Average :{statistic.Average:N2}");
            Console.WriteLine($"Max :{statistic.Max}");
            Console.WriteLine($"Min :{statistic.Min}");
        }
        break;
    }    
void AddDataPerson(string personType, int idPerson)
{
    switch (idPerson)
    {
        case 1:
            {
                Console.WriteLine($"Podaj Imię {personType}: ");
                name = Console.ReadLine();
                Console.WriteLine($"Podaj Nazwisko {personType} ");
                lastName = Console.ReadLine();
                Console.WriteLine($"Podaj płeć {personType}: ");
                sex = Console.ReadLine();
                Console.WriteLine($"Podaj Wiek {personType}: ");
                age = Console.ReadLine();
            }
            break;
        case 2:
            {
                Console.WriteLine($"Podaj Imię {personType}: ");
                name = Console.ReadLine();
                Console.WriteLine($"Podaj Nazwisko {personType} ");
                lastName = Console.ReadLine();
            }break;

    }
}


