﻿using System;
using System.Collections.Generic;

namespace RatingScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int semester;
            int sumScoreAndCoefficient = 0;
            int sumCoefficient = 0;
            double rating=90.0;
            int boot = 1;
            while (boot==1)
            {
                try
                {
                    Console.WriteLine("Enter your semester");
                    semester = int.Parse(Console.ReadLine());
                    List<Subject> subjects = Subject.getSubject(semester);
                    try
                    {
                        for (int i = 0; i < subjects.Count; i++)
                        {
                            Console.WriteLine("Enter score by " + subjects[i].name);
                            subjects[i].Score = int.Parse(Console.ReadLine());
                        }
                        for (int i = 0; i < subjects.Count; i++)
                        {
                            int temp;
                            temp = subjects[i].Score * subjects[i].Coefficient;
                            sumScoreAndCoefficient += temp;
                            sumCoefficient += subjects[i].Coefficient;
                        }
                        rating = (Subject.maxAssessmentOfDiscipline * sumScoreAndCoefficient) / (sumCoefficient * Subject.maxAssessmentOfRating);
                        if (rating > Subject.minAssessmentOfRating && rating < Subject.maxAssessmentOfRating)
                        {
                            Console.WriteLine("Your rating score = " + rating);
                            
                        }
                        else
                        {
                            Console.WriteLine("ERROR!");
                        }
                       
                    }
                    catch {
                        Console.WriteLine("Enter right score of discipline!");
                    }
                }
                catch { 
                    Console.WriteLine("Enter right semester");
                }
                Console.Clear();
                Console.WriteLine("Reboot(1)");
                boot = int.Parse(Console.ReadLine());
                Console.Clear();
            }      

        }
    }
}
