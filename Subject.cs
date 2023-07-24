using System;
using System.Collections.Generic;

namespace RatingScore
{
    public class Subject
    {
        private string name;
        private int coefficient;
        private int score;
        public string Name
        {
            get 
            {
                return name;
            }
            set 
            {
                name = value; 
            }
        }
        public int Coefficient
        {
            get 
            {
                return coefficient;
            }
            set {
                coefficient = value;
            }
        }      
        public int Score
        {
            get { return score; }
            set
            {
                if (value >= 0 && value <= 100)
                    score = value;
                else
                {                    
                    while (value < 0 || value > 100)
                    {
                        Console.WriteLine("Enter right score");
                        value = int.Parse(Console.ReadLine());
                        score = value;
                    }
                }
            }

        }

        public static List<Subject> getSubject(int semester)
        {
            List<Subject> subject = new List<Subject>();
            switch (semester)
            {
                case 1:
                    subject.AddRange(new Subject[8]);
                    for (int i = 0; i < subject.Count; i++)
                    {
                        subject[i] = new Subject();
                    }
                    subject[0].name = "Math";
                    subject[0].Coefficient = 6;
                    subject[1].name = "Physics";
                    subject[1].Coefficient = 5;
                    subject[2].name = "informatics";
                    subject[2].Coefficient = 4;
                    subject[3].name = "Grafics";
                    subject[3].Coefficient = 5;
                    subject[4].name = "Ukrainian language";
                    subject[4].Coefficient = 3;
                    subject[5].name = "Introduction to specialty";
                    subject[5].Coefficient = 3;
                    subject[6].name = "English";
                    subject[6].Coefficient = 2;
                    subject[7].name = "PE";
                    subject[7].Coefficient = 2;
                    break;

                case 2:
                    subject.AddRange(new Subject[8]);
                    for (int i = 0; i < subject.Count; i++)
                    { 
                        subject[i] = new Subject(); 
                    }
                    subject[0].name = "Math";
                    subject[0].Coefficient = 6;
                    subject[1].name = "Physics";
                    subject[1].Coefficient = 5;
                    subject[2].name = "informatics";
                    subject[2].Coefficient = 4;
                    subject[3].name = "History";
                    subject[3].Coefficient = 4;
                    subject[4].name = "Theory of digital automata";
                    subject[4].Coefficient = 4;
                    subject[5].name = "Ecology";
                    subject[5].Coefficient = 3;
                    subject[6].name = "English";
                    subject[6].Coefficient = 2;
                    subject[7].name = "PE";
                    subject[7].Coefficient = 2;
                    break;

                case 3:
                    subject.AddRange(new Subject[8]);
                    for (int i = 0; i < subject.Count; i++)
                    { 
                        subject[i] = new Subject();
                    }
                    subject[0].name = "Math";
                    subject[0].Coefficient = 6;
                    subject[1].name = "Electrical engineering and electromechanics";
                    subject[1].Coefficient = 6;
                    subject[2].name = "Physics";
                    subject[2].Coefficient = 3;
                    subject[3].name = "Information Technology and Programming";
                    subject[3].Coefficient = 5;
                    subject[4].name = "Philosophy";
                    subject[4].Coefficient = 3;
                    subject[5].name = "English";
                    subject[5].Coefficient = 2;
                    subject[6].name = "Applied Mechanics";
                    subject[6].Coefficient = 2;
                    subject[7].name = "PE";
                    subject[7].Coefficient = 2;
                    break;

                default:
                    break;
            }

            return subject;
        }     
    }
}
