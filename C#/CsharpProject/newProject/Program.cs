// // See https://aka.ms/new-console-template for more information[]

string[] arrayString = new string[4];
arrayString[0] = "uno";
arrayString[1] = "Dos";
arrayString[2] = "tres";
arrayString[3] = "cuatro";

string[] arrayStringDos = {"uno","dos","tres"};

Console.WriteLine(arrayString[1]);
Console.WriteLine(arrayString.Length);

Console.WriteLine(arrayStringDos[1]);
Console.WriteLine(arrayStringDos.Length);

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach(int item in inventory){
    bin++;
    sum+=item;
}
Console.Write(bin);
Console.WriteLine(sum );

string[] inventoryString = { "B200", "F450", "B700", "A175", "C250" };
int index = 0;
foreach(string item in inventoryString){
        index++;
    if(item.StartsWith("B")){
        Console.WriteLine($"el item de la posicion {index-1} Empieza con B!");
    }
}

Random dice = new Random();
int roll = dice.Next(1,7);
Console.WriteLine(roll);

Random newDice = new();
int rollTwo = newDice.Next(1,7);
Console.WriteLine(rollTwo);

Random newDiceTwo = new();
int rollThree = newDiceTwo.Next();
Console.WriteLine(rollThree);

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue,secondValue);
Console.WriteLine(largerValue);

