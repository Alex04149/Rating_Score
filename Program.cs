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
            char language;

            while (bootProgram == 1)
            {
                do
                {
                    Console.WriteLine("Виберiть мову спiлкування English(e), укр(u)");
                    language = char.Parse(Console.ReadLine());
                }
                while (language != 'e' && language != 'u');
                LanguageMessage message = new LanguageMessage();
                message.setLanguageMessage(language);
                Console.WriteLine(message.enterSemester);
                semester = int.Parse(Console.ReadLine());
                var Subjects = Subject.getSubject(semester,language);
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
                   additionalPoints = int.Parse(Console.ReadLine());
                    double numeral = (Constants.maxAssessmentOfDiscipline * sumScoreAndCoefficient);
                    double denominator = (sumCoefficient * Constants.maxAssessmentOfRating);
                   rating = (numeral
                        /denominator + additionalPoints);
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
