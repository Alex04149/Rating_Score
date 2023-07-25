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
            int additionalPoints;
            char l;

            while (bootProgram == 1)
            {
                do
                {
                    Console.WriteLine("Виберiть мову спiлкування English(e), укр(u)");
                    l = char.Parse(Console.ReadLine());
                }
                while (l != 'e' && l != 'u');
                LanguageMessage message = new LanguageMessage();
                message.setMessage(l);
                Console.WriteLine(message.enterSemester);
                semester = int.Parse(Console.ReadLine());
                var Subjects = Subject.getSubject(semester,l);
                try
                { 
                   for (int i = 0; i < Subjects.Count; i++)
                   {
                      Console.WriteLine(message.enterScore+Subjects[i].Name) ;
                      Subjects[i].Score = int.Parse(Console.ReadLine());
                      ScoreAndCoefficient = Subjects[i].Score * Subjects[i].Coefficient;
                      sumScoreAndCoefficient += ScoreAndCoefficient;
                      sumCoefficient += Subjects[i].Coefficient;
                   }
                   Console.WriteLine(message.enterAdditionalPoints);
                   additionalPoints=int.Parse(Console.ReadLine()); 
                   rating = ((Constants.maxAssessmentOfDiscipline * sumScoreAndCoefficient) 
                        / (sumCoefficient * Constants.maxAssessmentOfRating)) + additionalPoints;
                    Console.WriteLine(message.rating + rating);
                }
                catch 
                {
                    Console.WriteLine(message.error);
                }               
                Console.WriteLine(message.reboot);
                bootProgram = int.Parse(Console.ReadLine());
                Console.Clear();

            }
        }
    }
}
