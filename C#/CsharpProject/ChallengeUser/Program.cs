string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter a string containing at least three characters:");
// do{
//   readResult = Console.ReadLine();
//   if(readResult.Length >= 3 )
//     validEntry = !validEntry;
//   else
//     Console.WriteLine("Your input is invalid, please try again.");
        
// }
// while (validEntry == false);

// Console.WriteLine($"This is the Final result: {readResult}");

// numbers value
int numberEntries = 0;
bool numberValue = false;
do{
     readResult = Console.ReadLine();
    numberValue = int.TryParse(readResult,out numberEntries);
}
while(numberValue == false);

Console.WriteLine($"your number Result: {numberEntries}");