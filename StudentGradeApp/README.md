# Student grading app

## Project overview

*   Create a C# console application.
    
*   Start with four students. Each student has five exam scores.
    
*   Each exam score is an integer value, 0-100, where 100 represents 100% correct.
    
*   A student's overall exam score is the average of their five exam scores.
    
*   Criteria for extra credit assignments:
    
    *   Include extra credit assignment scores in the student's scores array.
    *   Extra credit assignments are worth 10% of an exam score (when calculating the final numeric grade).
    *   Add extra credit assignment scores to the student's total exam score before calculating the final numeric grade.
*   Your application needs to automatically assign letter grades based on the calculated final score for each student.
    
*   Your application needs to output/display each student’s name and formatted grade.
    
*   Your application needs to support adding other students and scores with minimal impact to the code.

## Objective

*   Use arrays to store student names and assignment scores.
    
*   Use a `foreach` statement to iterate through the student names as an outer program loop.
    
*   Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
    
*   Use a `foreach` statement within the outer loop to iterate through the assignment scores array and sum the values.
    
*   Use an updated algorithm within the outer loop to calculate the average exam score for each student.
    
*   Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
    
*   Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    
    *   Your code must detect extra credit assignments based on the number of elements in the student's scores array.
    *   Your code must apply the 10% weighting factor to extra credit assignments before adding extra credit scores to the sum of exam scores.
