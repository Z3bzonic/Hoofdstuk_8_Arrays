//Maak 2 methoden Encrypt en Decrypt die als parameters telkens een chararray krijgen en een integer.
//Bedoeling is dat de Encrypt-methode de array van het type string versleuteld gegeven de sleutel x
//volgens het Caesar cipher (zie hieronder). Als resultaat komt er uit de methode de geëncrypteerde array.
//De decrypt-methode doet hetzelfde maar omgekeerd: je kan er een versleutelde tekst insteken
//en de sleutel en de ontcijferde tekst komt terug (merk op dat je decrypt-methode
//gebruik kan maken van de encrypt-methode!).
//Toon in je main aan dat je methoden werken
//(door bijvoorbeeld aan de gebruiker een stuk tekst als string te vragen en een sleutel
//en deze dan te encrypteren/de-crypteren).

using Assignment_Ceasar_Encryptie;

UserInputs userInput = new UserInputs();
Cryptor encryptUserInput = new Cryptor();
Menu menu = new Menu();
int cypher = userInput.InputCypher();
char[] input = userInput.InputMessageToEncrypt();
char[] secret = encryptUserInput.EnAndDeCrypt(input, cypher);
string answer = "";
while (answer == "failed" || answer == "")
{
    Console.Clear();
    answer = menu.SelectChoice(secret, cypher);
}
Console.WriteLine(answer);




