//Vraag Array
//Maak een array die 6 strings kan bevatten.
//Ieder element van de array bevat een vraag (naar keuze te verzinnen)
//als string waar de gebruiker met een getal op moet antwoorden.
//Maak een array aan die tot 6 ints kan bevatten.
//Lees 1 voor 1 de vraag uit de string-array uit en toon deze op het scherm.
//Lees vervolgens het antwoord uit dat de gebruiker intypt en bewaar dit als int in de 2e array.
//Na de 6 vragen toon je vervolgens de vragen opnieuw met achter iedere vraag het antwoord van de gebruiker.
string[] questionaire = { "Hoeveel eieren zitten in een dozijn:", "Wat is je leeftijd:", "Wat is het antwoord op de vraag van het leven:", "Hoeveel tomaten groeien aan één tros:", "De hoeveelste Franse koning noemde zich de zonnegod:", "Tot hoeveel kan een kraai tellen:" };
int[] answer = new int[questionaire.Length];

for (int i = 0; i < questionaire.Length; i++)
{
    Console.WriteLine($"{questionaire[i]}");
    Console.SetCursorPosition(questionaire[i].Count(), i);
    answer[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Druk enter om alle antwoorden af te beelden");
Console.ReadLine();
Console.Clear();
for (int i = 0; i < questionaire.Length; i++)
{
    Console.WriteLine($"{questionaire[i]}");
    Console.SetCursorPosition(questionaire[i].Count(), i);
    Console.WriteLine(answer[i]);
}