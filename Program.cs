using System;
using System.Collections.Generic;


namespace RatingScore
{
    internal class Program
    {
        static void Main(string[] args)
        {


            const double maxAssessmentOfDiscipline = 90.0;
            const int minAssessmentOfRating = 0;
            const int maxAssessmentOfRating = 100;
            int semester;
            int sumScoreAndCoefficient = 0;
            int sumCoefficient = 0;
            double rating;
            try
            {
                Console.WriteLine("Enter your semester");
                semester = int.Parse(Console.ReadLine());
                List<Subject> subjects = Subject.getSubject(semester);
                try
                {
                    for (int i = 0; i < subjects.Count - 1; i++)
                    {
                        Console.WriteLine("Enter score by " + subjects[i].name);
                        subjects[i].Score = int.Parse(Console.ReadLine());
                    }
                    for (int i = 0; i < subjects.Count - 1; i++)
                    {
                        int temp;
                        temp = subjects[i].Score * subjects[i].Coefficient;
                        sumScoreAndCoefficient += temp;
                        sumCoefficient += subjects[i].Coefficient;
                    }
                    rating = (maxAssessmentOfDiscipline * sumScoreAndCoefficient) / (sumCoefficient * maxAssessmentOfRating);
                    if (rating > minAssessmentOfRating && rating < maxAssessmentOfRating)
                    {
                        Console.WriteLine("Your rating score = " + rating);
                    }
                    else
                    {
                        Console.WriteLine("ERROR!");
                    }
                    Console.ReadLine();
                }
                catch { Console.WriteLine("Enter right score of discipline!"); }
            }
            catch { Console.WriteLine("Enter right semester"); }
                

        }
    }
}
