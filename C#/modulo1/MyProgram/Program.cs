// See https://aka.ms/new-console-template for more information
        // 1)
        Console.WriteLine("OneLine!");
        Console.Write("this it another line");
        Console.Write(" but write is it;");
        // 2)Char = '' / String = "";
        Console.WriteLine('b');
        Console.WriteLine("Hola");
        //Int - Float = f / double / 
        Console.WriteLine(1);
        Console.WriteLine(2.2);
        Console.WriteLine(2.2f);
        Console.WriteLine(2.5m);

char userOption = 'a';
string userName = "myName";
int gameScore = 2;
decimal pariclesPerMillion = 2.3m;
bool proccessedCustomer = true;

Console.Write(userOption);
Console.Write(userName);
Console.Write(gameScore);
Console.Write(pariclesPerMillion);
Console.Write(proccessedCustomer);


//Caracter de escape \ :

Console.WriteLine("Hello \n World");
Console.WriteLine("Hello \t World!");

Console.WriteLine("c:\\localhost:3000\\api");

Console.WriteLine("Generating for costumer \"Contoso Crop\" ...\n");

Console.WriteLine("Invoice: 1021:\t\tComplete!");
Console.WriteLine("\nOutputDirectory:\t");
        
//LITERAL DE SALIDA @

Console.WriteLine(@"c:\invoices");

//Concatenacin de cadenas":
string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message + " "+ firstName);

string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");





//NUMBERS OPERATIONS
string firstname = "Bob";
int widgetSold = 7;
Console.WriteLine(firstname+" sold " + widgetSold + 7 + " widgets.");
Console.WriteLine(firstname+" sold " + (widgetSold + 7 )+ " widgets.");

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;
int module = 7 % 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);
Console.WriteLine("Module: " + module);

decimal decimalQuotinet = 7m / 5;
Console.WriteLine(decimalQuotinet);

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");


int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

int value1 = 1;

Console.WriteLine("First: " + value1);
Console.WriteLine($"Second: {value1++}");
Console.WriteLine("Third: " + value1);
Console.WriteLine("Fourth: " + (++value1));
