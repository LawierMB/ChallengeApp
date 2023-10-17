// Przygotój program, który policzy ile jakich cyfr występuje w podanej liczbie

var number = 4566;
var numberToString = number.ToString();
var letters = numberToString.ToArray();
int[] counterLeters = new int[10];


/*for (int index = 0; index < 10; index++)
{
    counterLeters[index] = index;
}*/



foreach (var letter in letters)
{
    if (letter == '0')
    {
        counterLeters[0]++;
    }else if (letter == '1')
    {
        counterLeters[1]++;
    }else if (letter == '2')
    {
        counterLeters[2]++;
    }else if (letter == '3')
    {
        counterLeters[3]++;
    }else if (letter == '4')
    {
        counterLeters[4]++;
    }else if (letter == '5')
    {
        counterLeters[5]++;
    }else if (letter == '6')
    {
        counterLeters[6]++;
    }else if (letter == '7')
    {
        counterLeters[7]++;
    }else if (letter == '8')
    {
        counterLeters[8]++;
    }else
    {
        counterLeters[9]++;
    }
    
}

Console.WriteLine("Podliczenie cyfr w liczbie: " + number + " Wygląda następująco: ");
for (int index = 0; index < 10; index++)
{
    Console.WriteLine("Cyfra: " + index + " Wystąpienie: " + counterLeters[index] + " Razy !");
}