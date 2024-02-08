// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// bool found =false;
// int total=0;
// foreach (int number in numbers)
// {
//     total += number;
//     if (number == 42)

//         found = true;
// }
// if (found) 
//         Console.WriteLine("Set contains 42");

// Console.WriteLine($"Total: {total}");

/////////////// SWITCH CASES



// int employeeLevel =100;
// string employeeName = "jhon Smith";
// string title="";

// switch(employeeLevel)
// {  //case 100:
//         // title="Junior Associate";
//         // break;
//     case 100:
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title= "Senior Manager";
//         break;
//     default:
//         title= "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName},{title}");


// SKU = Stock Keeping Unit. 

// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch(product[0]){ 
// case "01":
//     type = "Sweat shirt";
//     break;
// case "02":
//     type = "T-Shirt";
//     break;
// case "03":
//     type = "Sweat pants";
//     break;
// default:
//     type = "Other";
//     break;
// }

// switch(product[1]){ 
// case "BL":
//     color = "Black";
//     break;
// case "MN":
//     color = "Maroon";
//     break;
// default:
//     color = "White";
//     break;
// }

// switch(product[2]){
//  case "S":
//     size = "Small";
//     break;
// case "M":
//     size = "Medium";
//     break;
// case "L":
//     size = "Large";
//     break;
// default:
//     size = "One Size Fits All";
//     break;
//     }

// Console.WriteLine($"Product: {size} {color} {type}");

//BUCLE FOR 

// for(int i=0;i <= 8;i++){
//     Console.WriteLine(i);
// }

// for(int i = 10 ; i >0 ; i--){
//     Console.WriteLine(i);
// }


// for(int i=0;i <= 9;i+=3){
//     Console.WriteLine(i);
//     if(i==6)break;
// }
// string[] names = { "Alex", "Eddie", "David", "Michael" };

// for(int i = names.Length -1; i >=0; i--){
//     Console.WriteLine(names[i]);
// }
// for(int i = 0; i <= names.Length-1;i++)
//     if(names[i] == "Eddie") 
//         names[i] = "Sammy";

// foreach(string name in names)
//     Console.WriteLine(name);

// // /*
// Estas son las reglas de FizzBuzz que necesita implementar en el proyecto de código:

// Valores de salida de 1 a 100, un número por línea, dentro del bloque de código de una instrucción de iteración.
// Si el valor actual es divisible por 3, se imprime el término Fizz junto al número.
// Si el valor actual es divisible por 5, se imprime el término Buzz junto al número.
// Si el valor actual es divisible por 3 y por 5, se imprime el término FizzBuzz junto al número.


for(int i = 1; i <=100;i++){
    if(i % 3 == 0 && i % 5 == 0)
        Console.WriteLine($"{i} FizzBuzz");
    else if( i % 3 == 0)
        Console.WriteLine($"{i} Fizz");
    else if( i % 5 == 0)
        Console.WriteLine($"{i} Buzz");
    else
        Console.WriteLine($"{i}");
}