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
            set
            {
                coefficient = value;
            }
        }      
        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                if (value >= 0 && value <= 100)
                    score = value;
                else
                {                    
                    while (value < 0 || value > 100)
                    {
                        value = int.Parse(Console.ReadLine());
                        score = value;
                    }
                }
            }
        }

        public static List<Subject> getSubject(int semester,char l)
        {
            List<Subject> subject = new List<Subject>();
            LanguageSubject nameSubject = new LanguageSubject();
            nameSubject.setSubjectName(l);
            switch (semester)
            {
                case 1:  
                    subject.AddRange(new Subject[8]);
                    for (int i = 0; i < subject.Count; i++)
                    {
                        subject[i] = new Subject();
                    }
                    subject[0].name = nameSubject.Math;
                    subject[0].Coefficient = 6;
                    subject[1].name = nameSubject.Physics;
                    subject[1].Coefficient = 5;
                    subject[2].name = nameSubject.Informatics;
                    subject[2].Coefficient = 4;
                    subject[3].name = nameSubject.Grafics;
                    subject[3].Coefficient = 5;
                    subject[4].name = nameSubject.ukrainianLanguage;
                    subject[4].Coefficient = 3;
                    subject[5].name = nameSubject.introductionToSpecialty;
                    subject[5].Coefficient = 3;
                    subject[6].name = nameSubject.english;
                    subject[6].Coefficient = 2;
                    subject[7].name = nameSubject.PE;
                    subject[7].Coefficient = 2;
                    break;

                case 2:
                    subject.AddRange(new Subject[8]);
                    for (int i = 0; i < subject.Count; i++)
                    { 
                        subject[i] = new Subject(); 
                    }
                    subject[0].name = nameSubject.Math;
                    subject[0].Coefficient = 6;
                    subject[1].name = nameSubject.Physics;
                    subject[1].Coefficient = 5;
                    subject[2].name = nameSubject.Informatics;
                    subject[2].Coefficient = 4;
                    subject[3].name = nameSubject.history;
                    subject[3].Coefficient = 4;
                    subject[4].name = nameSubject.theoryOfDigitalAutomata;
                    subject[4].Coefficient = 4;
                    subject[5].name = nameSubject.ecology;
                    subject[5].Coefficient = 3;
                    subject[6].name = nameSubject.english;
                    subject[6].Coefficient = 2;
                    subject[7].name = nameSubject.PE;
                    subject[7].Coefficient = 2;
                    break;

                case 3:
                    subject.AddRange(new Subject[8]);
                    for (int i = 0; i < subject.Count; i++)
                    { 
                        subject[i] = new Subject();
                    }
                    subject[0].name = nameSubject.Math;
                    subject[0].Coefficient = 6;
                    subject[1].name = nameSubject.electricalEngineeringAndElectromechanics;
                    subject[1].Coefficient = 6;
                    subject[2].name = nameSubject.Physics;
                    subject[2].Coefficient = 3;
                    subject[3].name = nameSubject.informationTechnologyAndProgramming;
                    subject[3].Coefficient = 5;
                    subject[4].name = nameSubject.phylosophy;
                    subject[4].Coefficient = 3;
                    subject[5].name = nameSubject.PE;
                    subject[5].Coefficient = 2;
                    subject[6].name = nameSubject.appliedMechanics;
                    subject[6].Coefficient = 2;
                    subject[7].name = nameSubject.PE;
                    subject[7].Coefficient = 2;
                    break;

                default:
                    break;
            }

            return subject;
        }     
    }
}
