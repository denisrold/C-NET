// See https://aka.ms/new-console-template for more information

Random random = new Random();
int daysUntilExpiration = random.Next(12);
if(daysUntilExpiration > 5){
    Console.WriteLine("\nYour subscription will expire soon. Renew now!\n");
}
else if(daysUntilExpiration >1){
Console.WriteLine($"\nYour subscription expires in {daysUntilExpiration} days.\nRenew now and save 10%!\n");
}

else if(daysUntilExpiration == 1){
Console.WriteLine($"\nYour subscription expires in {daysUntilExpiration} days.\nRenew now and save 20%!\n");
}

else {
Console.WriteLine("Your subscription has expired.");
}
