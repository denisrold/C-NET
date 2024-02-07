
int[] currentAssignments = new int[5]{1,2,3,4,5};
string[] studentName = {"Sophia","Andrew","Emma","Logan"};
int[] sophiaCredits = {90,86,87,98,100};
int[] andrewCredits = {92,89,81,96,90};
int[] emmaCredits = {90,85,87,98,68};
int[] loganCredits = {90,95,87,88,96};
decimal sophiaSum = 0;
decimal andrewSum = 0;
decimal emmaSum = 0;
decimal loganSum = 0;

int index = 0;
foreach(int assignment in currentAssignments){
    sophiaSum += sophiaCredits[index] + ((sophiaCredits[index] * 10) / 100);
    andrewSum += andrewCredits[index] + ((andrewCredits[index] * 10) / 100);
    emmaSum += emmaCredits[index] + ((emmaCredits[index] * 10) / 100);
    loganSum += loganCredits[index] + ((loganCredits[index] * 10) / 100);
    index++;
    if(index >= currentAssignments.Length){index = 0;}
}
decimal[] Scores = {sophiaSum,andrewSum,emmaSum,loganSum};

Console.WriteLine("Student\t\tGrade\n");
foreach(decimal scor in Scores){
    decimal score = scor / currentAssignments.Length;
    string stringScores = "";
    if(score <= 59){
        stringScores="F";
    }else if (score <=62){
        stringScores="D-";
    }
    else if (score <=66){
        stringScores="D";
    }
    else if (score <=69){
        stringScores="D+";
    }
    else if (score <=72){
        stringScores="C-";
    }
    else if (score <=76){
        stringScores="C";
    }
    else if (score <=79){
        stringScores="C+";
    }
    else if (score <=82){
        stringScores="B-";
    }
    else if (score <=86){
        stringScores="B";
    }
    else if (score <=89){
        stringScores="B+";
    }
    else if (score <=92){
        stringScores="A-";
    }
    else if (score <=96){
        stringScores="A";
    }
    else{
        stringScores="A+";
    }
    Console.WriteLine($"{studentName[index]}:\t\t{score}\t{stringScores}");
    index++;
}
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

