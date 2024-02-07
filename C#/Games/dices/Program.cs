// See https://aka.ms/new-console-template for more information
/*

Si dos dados cualesquiera muestran el mismo valor, se obtienen dos puntos extra por obtener un doble.
Si los tres dados muestran el mismo valor, se obtienen seis puntos extra por obtener un triple.
Si la suma de los tres dados, junto con los puntos extra, es igual o mayor que 15, gana el juego. De lo contrario, pierde.
A medida que obtenga más información sobre la instrucción if, podrá refinar las reglas.*/

int scoreWin = 15;

Random dice = new Random();
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);
int bonus = 0;

if(roll1 == roll2 || roll2 == roll3 || roll1 == roll3){
    if(roll1 == roll2 && roll2 == roll3){
    bonus += 6;
}
else{
    bonus += 2;
}
}

int score = roll1+roll2+roll3+bonus;

Console.WriteLine("\nPuntuacion final\n");
Console.WriteLine($"dado 1: {roll1}");
Console.WriteLine($"dado 2: {roll2}");
Console.WriteLine($"dado 3: {roll3}");
if(bonus == 2){
Console.WriteLine("\nYou rolled doubles! +2 bonus to total!");
}
if(bonus == 6){
Console.WriteLine("\nYou rolled triples! +6 bonus to total!");
}

if(score>=15){
Console.WriteLine($"\nFelicidades! su puntuacion es de: {score} usted ha GANADO un nuevo coche!\n");
}
else if(score>=10){
Console.WriteLine($"\nFelicidades! su puntuacion es de: {score} usted ha GANADO una cantimplora!\n");
}
else{
Console.WriteLine($"\nLamentablemente ha perdido! Su puntuacion es de: {score} intentelo denuevo.\n");
}



