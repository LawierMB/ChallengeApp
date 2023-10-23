using ChallengeApp;

User user1 = new User("Marek", "Password1");
User user2 = new User("Norbert", "Password2");
User user3 = new User("Gosia", "Password3");
User user4 = new User("Damian", "Password4");

Console.WriteLine("Uąytkownik 1: " + user1.Login + " " + user1.Password);
Console.WriteLine("Uąytkownik 3: " + user3.Login + " " + user3.Password);

// przypisanie punktów użytkownikowi user1 przy pomocy metody AddScore()
user1.AddScore(5);
user1.AddScore(2);
user1.AddScore(1);

// wyświetla podsumowanie punktów user1.ResuldPoint
Console.WriteLine("Zebrane punkty przez użytkownika: " + user1.Login + " to : " + user1.ResultPoint);

