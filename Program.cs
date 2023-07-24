using System;

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
                        rating = (Constants.maxAssessmentOfDiscipline * sumScoreAndCoefficient) / (sumCoefficient * Constants.maxAssessmentOfRating);
                        if (rating > Constants.minAssessmentOfRating && rating < Constants.maxAssessmentOfRating)
                        {
                            Console.WriteLine("Your rating score = " + rating);                            
                        }
                        else
                        {
                            Console.WriteLine("ERROR!");
                        }                       
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
