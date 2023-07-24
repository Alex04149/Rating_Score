﻿using System;

namespace RatingScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int semester;
            int sumScoreAndCoefficient = 0;
            int sumCoefficient = 0;
            int ScoreAndCoefficient;
            double rating;
            int bootProgram = 1;
            int additionalPoints;

            while (bootProgram == 1)
            {       
                Console.WriteLine("Enter your semester");
                semester  = int.Parse(Console.ReadLine());
                var Subjects = Subject.getSubject(semester);
                try
                { 
                   for (int i = 0; i < Subjects.Count; i++)
                   {
                      Console.WriteLine("Enter score by " + Subjects[i].Name);
                      Subjects[i].Score = int.Parse(Console.ReadLine());
                      ScoreAndCoefficient = Subjects[i].Score * Subjects[i].Coefficient;
                      sumScoreAndCoefficient += ScoreAndCoefficient;
                      sumCoefficient += Subjects[i].Coefficient;
                   }
                   Console.WriteLine("Enter your additional points");
                   additionalPoints=int.Parse(Console.ReadLine()); 
                   rating = ((Constants.maxAssessmentOfDiscipline * sumScoreAndCoefficient) / (sumCoefficient * Constants.maxAssessmentOfRating)) + additionalPoints;
                   Console.WriteLine("Your rating score = " + rating);                                           
                }
                catch 
                { 
                    Console.WriteLine("Enter right data");
                }               
                Console.WriteLine("Reboot program (1)");
                bootProgram = int.Parse(Console.ReadLine());
                Console.Clear();
            }

        }
    }
}
