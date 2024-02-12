
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}",second,first);
Console.WriteLine(result);
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);
Console.WriteLine("{1} {0}!", second, first);
//INTERPOLACION
Console.WriteLine($"{first} {second}!");


///monedas :C
decimal price = 124.5m;
int discount = 24;
//Observe que si se agrega :C a los tokens incluidos entre las llaves,
// se aplica formato de moneda al número, independientemente de si se usa int o decimal.
Console.WriteLine($"Price {price:C} (save{discount:C})");

//Formatos de numero :N
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");
Console.WriteLine($"Measurement: {measurement:N} units");

//porcentajes:
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P4}");



//all
decimal prices = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
yourDiscount += $"A discount of {((prices - salePrice)/prices):P2}!"; //inserted
Console.WriteLine(yourDiscount);
Console.WriteLine("/////////////////////////////////////////////\n\n\n\n");

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"Shares:{productShares:N3} Product Shares");
Console.WriteLine($"\tSubTotal: {subtotal:C}");
Console.WriteLine($"\tTax: {taxPercentage:P2}");
Console.WriteLine($"     \tTotal Billed: {total:C}");

///
string pad = "total";
Console.WriteLine(pad.PadLeft(12) );
Console.WriteLine(pad.PadRight(12)+ " 1");

Console.WriteLine(pad.PadLeft(12, '.'));
 Console.WriteLine(pad.PadRight(12, '-'));


string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine("Here's a quick comparison:\n");

// Your logic here

Console.WriteLine(customerName);
Console.Write($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}");
Console.WriteLine("Here's a quick comparison:");

Console.WriteLine($"{currentProduct.PadRight(22)}{currentReturn:P2}\t\t {currentProfit:C}");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);
