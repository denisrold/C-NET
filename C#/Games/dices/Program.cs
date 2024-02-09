int scoreToWin = 15;
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
// Console.WriteLine("\nPuntuacion final\n");
// Console.WriteLine($"dado 1: {roll1}");
// Console.WriteLine($"dado 2: {roll2}");
// Console.WriteLine($"dado 3: {roll3}");

if(bonus == 2){
    // Console.WriteLine("\nYou rolled doubles! +2 bonus to total!");
}
if(bonus == 6){
    // Console.WriteLine("\nYou rolled triples! +6 bonus to total!");
}

if(score>=15){
    // Console.WriteLine($"\nFelicidades! su puntuacion es de: {score} usted ha GANADO un nuevo coche!\n");
}
else if(score>=10){
    // Console.WriteLine($"\nFelicidades! su puntuacion es de: {score} usted ha GANADO una cantimplora!\n");
}
else{
    // Console.WriteLine($"\nLamentablemente ha perdido! Su puntuacion es de: {score} intentelo denuevo.\n");
}


//ROL GAME

int healthHero = 10;
int healthMonster = 10;
int damage = 0;
bool npcTurn = false;
Random attack = new Random();
int numberTurns = 0;
do
{   
    if(numberTurns == 0)
       Console.WriteLine($"\n\tFIGHT!"); 
    damage = attack.Next(1,11);
    if(npcTurn){ 
        healthHero -= damage;
        Console.WriteLine($"\tThe monster damage you for {damage}");
            if(healthHero <= 0)
                Console.WriteLine($"\n\tyou are DEAD!\n");
            else 
                Console.WriteLine($"\tYou have {healthHero} health points remaining\n");
        }
    else{ 
        Console.WriteLine($"\nRound: {numberTurns}\n");
        healthMonster -= damage;
        Console.WriteLine($"\tThe monster was damaged for {damage}");
            if(healthMonster <= 0)
                Console.WriteLine($"\n\tThe monster is dead YOU WIN!\n");
            else
                Console.WriteLine($"\tit has {healthMonster} health points remaining\n");
            }
    npcTurn = !npcTurn;  
    if(npcTurn)
        numberTurns++;  
}
while(healthMonster > 0 && healthHero > 0);
