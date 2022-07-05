//Maak een programma voor een koeriersbedrijf. Maak een array die 10 postcodes bevat (zelf te kiezen) 
//van gemeenten waar het bedrijf naar levert. Maak een tweede array die de prijs bevat per kg 
//van iedere respectievelijke gemeente. Het eerste element van deze array bevat dus de prijs/kg 
//om naar de gemeente die als eerste in de array met postcodes staat.
//Vraag aan de gebruiker een postcode en het gewicht van het pakket. 
//Vervolgens wordt de prijs opgezocht voor die gemeente en wordt deze berekend gegeven het ingegeven gewicht.
//Indien het bedrijf niet levert aan de ingetypte postcode dan wordt een foutmelding weergegeven.
Console.OutputEncoding = System.Text.Encoding.UTF8;

const int DELIVERYPOSTALCODE = 1980;
double priceTag = 0.0;
double[,] postcodeLevergebiedEnPrijs = { { 1800,2.34 }, { 9000 , 4.65 }, { 2000 , 3.21 }, { 3000 , 5.12} , { 1080 , 7.23} ,
                                         { 4230,8.61 }, { 1300 , 5.37 }, { 5000 , 7.78 }, { 6780 , 8.45} , { 1980 , 1.23} };

Console.WriteLine("Kies je postcode");

for (int i = 0; i < postcodeLevergebiedEnPrijs.Length / 2; i++)
{
    Console.WriteLine($"{postcodeLevergebiedEnPrijs[i, 0]}");
}
Console.WriteLine();
int userChoice = int.Parse(Console.ReadLine());
Console.WriteLine("Geef pakketgewicht in kg");
double packetWeight = double.Parse(Console.ReadLine());
for (int i = 0; i < postcodeLevergebiedEnPrijs.Length / 2; i++)
{
    if (postcodeLevergebiedEnPrijs[i, 0] == userChoice)
    {
        priceTag = packetWeight * postcodeLevergebiedEnPrijs[i,1];

    }
}
Console.WriteLine($"Verzending kost €{Math.Round(priceTag, 2)}");
