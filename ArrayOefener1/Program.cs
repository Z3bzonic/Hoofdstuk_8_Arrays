// See https://aka.ms/new-console-template for more information


using ArrayOefener1;

UserInput input = new UserInput();
Calculate calc = new Calculate();
int[] result = input.InputMain();
double[] calculated = calc.CheckSumAvgLargest(result);
int secondNumber = input.InputSecond();
int teller = result.Length-1;
if (teller >= 0)
{
    while (result[teller] >= secondNumber)
    {
        Console.Write($"{result[teller]} ");
        Console.WriteLine("is the larger then ");
        teller--;
    }
}
Console.Write(secondNumber);
Console.WriteLine($"First numbers average {calculated[0]} sum {calculated[1]} and arraylenght{calculated[2]}");
