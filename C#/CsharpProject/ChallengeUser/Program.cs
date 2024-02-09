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
// int numberEntries = 0;
// bool numberValue = false;
// do{
//      readResult = Console.ReadLine();
//     numberValue = int.TryParse(readResult,out numberEntries);
// }
// while(numberValue == false);

// Console.WriteLine($"your number Result: {numberEntries}");

// //PROYECT 1 
// Console.WriteLine("\nEscribe un número entre 5 y 10.");
// int intValue = 0;  

// do{
//     readResult = Console.ReadLine();
//     bool intParse = int.TryParse(readResult,out intValue); 
//     if(!intParse){
//         Console.WriteLine("\nErrors: valor incorrecto! debe ser número!");
//     }
//     if(intParse)
//         Console.WriteLine("\nErrors: el número debe estar entre 5 y 10.");
// }
// while(intValue <5 || intValue >10);

// Console.WriteLine($"\nSu valor {intValue} ha sido ACEPTADO\n");

// //PROYECTO 2 
//  Console.WriteLine("ES USTED: Administrador, Director o Usuario? ");
//  bool flag = true;
// while(flag){
//     readResult = Console.ReadLine();
//     string proccesResult = readResult.Trim(' ').ToLower();
//     flag=false;
//     if (
//         proccesResult != "administrador" &&
//         proccesResult != "director" &&
//         proccesResult != "usuario")
//         {
//         Console.WriteLine($"\n{readResult} No es un rol válido. \n");
//         Console.WriteLine("Ingrese un rol válido: Administrador, Director o Usuario");
//         flag=true;
//         }
// }

// Console.WriteLine($"Bienvenido}");

// Proyecto de código 3

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

foreach (string myString in myStrings ){ 
int periodLocation = 0;
    string cutString = myString;
    while(periodLocation > -1){
        periodLocation = cutString.IndexOf(".");
        string answer = "";
        if (periodLocation != -1){
            answer = cutString.Substring(0,periodLocation);
            cutString = cutString.Remove(0,periodLocation+1).TrimStart(' ');
            Console.WriteLine(answer);
        }
        else
             Console.WriteLine(cutString);   
    };
}

// Output
// I like pizza
// I like roast chicken
// I like salad
// I like all three of the menu choices


