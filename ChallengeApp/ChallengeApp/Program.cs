// Zadanie 1
//Console.WriteLine("Hello, Marek! \n");
//Console.WriteLine("wciśnij dowolny klawisz!");
//Console.ReadKey();

// Zadanie 2

var imie = "Ania";
var plec = 'k';
var wiek = 29;

Console.WriteLine("przyjęto dane do sprawdzenia: ");
Console.WriteLine("Imię: " + imie + " płeć: " + plec + " Wiek: " + wiek + " :");

if (plec == 'k')
{
    if (imie == "Ewa" && wiek == 33)
    {
        Console.WriteLine("Ewa, lat 33 ");
    }
    else if (wiek < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    } 
}
else if (wiek < 18)
{
    Console.WriteLine("Niepelnoletni mężczyzna.");
}
else
{
    Console.WriteLine("Pełnoletni mężczyzna.");
}