// See https://aka.ms/new-console-template for more information

using ArrayOefener2;

UserInput input1 = new UserInput();
UserInput input2 = new UserInput();

int[] getInput1 = input1.UserMultiInput();
int[] getInput2 = input2.UserMultiInput();
int[] sumInputs = new int[getInput1.Length];

for (int i = 0; i < getInput1.Length; i++)
{
    sumInputs[i] = getInput1[i] + getInput2[i];
}

foreach (var item in sumInputs)
{
    Console.Write($"Sum is {item} ");
}