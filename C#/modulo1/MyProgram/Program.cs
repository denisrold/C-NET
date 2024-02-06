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

//PROJECT 
string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int course1Grade = 4;
int course2Grade = 3;
int course3Grade = 3;
int course4Grade = 3;
int course5Grade = 4;

int coursecross1 = course1Credit*course1Grade;
int coursecross2 = course2Credit*course2Grade;
int coursecross3 = course3Credit*course3Grade;
int coursecross4 = course4Credit*course4Grade;
int coursecross5 = course5Credit*course5Grade;

int gradeSum = coursecross1+coursecross2+coursecross3+coursecross4+coursecross5;
Console.Write($"gradeSumt: {gradeSum}\n\n");
int creditSum = course1Credit+course2Credit+course3Credit+course4Credit+course5Credit;
Console.Write($"CreditSum: {creditSum}\n\n");
float finalScore = (float)gradeSum/ (float)creditSum;

Console.Write($"Student: {studentName}\n\n");

Console.WriteLine("Course\t\t\tGrade\tCredit Hours");
Console.Write($"{course1Name}\t\t\t{course1Grade}\t{course1Credit}\n");
Console.Write($"{course2Name}\t\t\t{course2Grade}\t{course2Credit}\n");
Console.Write($"{course3Name}\t\t\t{course3Grade}\t{course3Credit}\n");
Console.Write($"{course4Name}\t{course4Grade}\t{course4Credit}\n");
Console.Write($"{course5Name}\t\t{course5Grade}\t{course5Credit}\n\n");
Console.WriteLine($@"Final GPA:         {Math.Round(finalScore,2)}");

//Conseguir los decimales sin mathRound
int leadingDigit = (int)finalScore;
int firstDigit = (int) (finalScore*10)%10;
Console.WriteLine(firstDigit);
int secondDigit = (int) (finalScore * 100 ) % 10;
Console.WriteLine(secondDigit);
Console.WriteLine($"Final GPA: {leadingDigit}.{firstDigit}{secondDigit}");