using System;

// initialize variables - graded assignments 
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScores = new int[10];


Console.WriteLine("Student\t\tExam Score\t\tOverall\t\tFinal Grade\t\tExtra Credit\n");

foreach (string name in studentNames)
{
    if (name == "Sophia")
        studentScores = sophiaScores;
    else if (name == "Andrew")
        studentScores = andrewScores;
    else if (name == "Emma")
        studentScores = emmaScores;
    else if (name == "Logan")
        studentScores = loganScores;
    else if (name == "Becky")
        studentScores = beckyScores;
    else if (name == "Chris")
        studentScores = chrisScores;
    else if (name == "Eric")
        studentScores = ericScores;
    else if (name == "Gregor")
        studentScores = gregorScores;
    else
        continue;

    decimal scoreSum = 0;
    decimal finalScore = 0;
    decimal examScore = 0;
    decimal examFinalScore = 0;
    decimal creditFinalScore = 0;
    int creditScore = 0;
    int numExtraCredit = 0;
    string finalGrade;
    int currentAssignment = 0;

    foreach (int score in studentScores)
    {
        currentAssignment += 1;
        if (currentAssignment <= examAssignments)
            examScore += score;
        else
        {
            numExtraCredit += 1;
            creditScore += score;
        }
    }

    examFinalScore = examScore / examAssignments;
    creditFinalScore = creditScore / numExtraCredit;

    scoreSum = examScore + creditScore / 10m;
    finalScore = scoreSum / examAssignments;

    if (finalScore >= 97)
        finalGrade = "A+";

    else if (finalScore >= 93)
        finalGrade = "A";

    else if (finalScore >= 90)
        finalGrade = "A-";

    else if (finalScore >= 87)
        finalGrade = "B+";

    else if (finalScore >= 83)
        finalGrade = "B";

    else if (finalScore >= 80)
        finalGrade = "B-";

    else if (finalScore >= 77)
        finalGrade = "C+";

    else if (finalScore >= 73)
        finalGrade = "C";

    else if (finalScore >= 70)
        finalGrade = "C-";

    else if (finalScore >= 67)
        finalGrade = "D+";

    else if (finalScore >= 63)
        finalGrade = "D";

    else if (finalScore >= 60)
        finalGrade = "D-";
    else finalGrade = "F";

    Console.WriteLine($"{name}\t\t{examFinalScore}\t\t\t{finalScore}\t\t{finalGrade}\t\t\t{creditFinalScore} ({finalScore - examFinalScore} pts)");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();