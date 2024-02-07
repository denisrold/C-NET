
decimal currentAssignments = 5;

decimal sophiaSum = 0;
int[] sophiaCredits = [90,86,87,98,100];
foreach(decimal note in sophiaCredits){
    sophiaSum += note + ((note * 10) / 100);
}

decimal andrewSum = 0;
int[] andrewCredits = [92,89,81,96,90];
foreach(decimal note in andrewCredits){
    andrewSum +=  note + ((note * 10) / 100);
}

decimal emmaSum = 0;
int[] emmaCredits = [90,85,87,98,68];
foreach(decimal note in emmaCredits){
    emmaSum += note + ((note * 10) / 100);
}

decimal loganSum = 0;
int[] loganCredits = [90,95,87,88,96];
foreach(decimal note in loganCredits){
   loganSum = note + ((note * 10) / 100);
}

decimal sophiaScore = sophiaSum / currentAssignments;
decimal andrewScore = andrewSum / currentAssignments;
decimal emmaScore = loganSum / currentAssignments;
decimal loganScore = emmaSum / currentAssignments;

int indexSofia = 0;
int indexAndrew = 1;
int indexemma = 2;
int indexLogan = 3;

decimal[] Scores = [sophiaScore,andrewScore,emmaScore,loganScore];
string[] stringScores = new string[4];

int index = 0;
foreach(decimal score in Scores){
    if(score <= 59){
        stringScores[index]="F";
    }else if (score >=60 && score <=62){
        stringScores[index]="D-";
    }
    else if (score >=63 && score <=66){
        stringScores[index]="D";
    }
    else if (score >=67 && score <=69){
        stringScores[index]="D+";
    }
    else if (score >=70 && score <=72){
        stringScores[index]="C-";
    }
    else if (score >=73 && score <=76){
        stringScores[index]="C";
    }
    else if (score >=77 && score <=79){
        stringScores[index]="C+";
    }
    else if (score >=80 && score <=82){
        stringScores[index]="B-";
    }
    else if (score >=83 && score <=86){
        stringScores[index]="B";
    }
    else if (score >=87 && score <=89){
        stringScores[index]="B+";
    }
    else if (score >=90 && score <=92){
        stringScores[index]="A-";
    }
    else if (score >=93 && score <=96){
        stringScores[index]="A";
    }
    else{
        stringScores[index]="A+";
    }
    index++;
}

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + $"\t{stringScores[indexSofia]}");
Console.WriteLine("Andrew:\t\t" + andrewScore + $"\t{stringScores[indexAndrew]}");
Console.WriteLine("Emma:\t\t" + emmaScore + $"\t{stringScores[indexemma]}");
Console.WriteLine("Logan:\t\t" + loganScore + $"\t{stringScores[indexLogan]}");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
