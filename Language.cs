using System;

namespace RatingScore
{
    public class LanguageMessage
    {
        public string enterSemester;
        public string enterScore;
        public string enterAdditionalPoints;
        public string error;
        public string rating;
        public string reboot;
        public void setMessage(char l)
        {
            switch (l)
            {
                case 'e':
                    enterSemester = "Enter semester";
                    enterScore = "Enter score by ";
                    enterAdditionalPoints = "Enter additional points ";
                    error = "Enter right data";
                    rating = "Your rating score ";
                    reboot = "Reboot program (1)";
                    break;
                case 'u':
                    enterSemester = "Введiть семестер ";
                    enterScore = "Введiть оцiнку з дисциплiни ";
                    enterAdditionalPoints = "Введiть додатковi бали ";
                    error = "Введiть правильно данi";
                    rating = "Ваш рейтинговий бал";
                    reboot = "Щоб перезавантажити програму натиснiть 1";
                    break;

            }
        }
    }
    public class LanguageSubject{
        public string Math;
        public string Physics;
        public string Informatics;
        public string Grafics;
        public string ukrainianLanguage;
        public string introductionToSpecialty;
        public string english;
        public string PE;
        public string history;
        public string theoryOfDigitalAutomata;
        public string ecology;
        public string electricalEngineeringAndEelectromechanics;
        public string informationTechnologyAndProgramming;
        public string phylosophy;
        public string appliedMechanics;
        
        public void setSubjectName(char l)
        {
            switch (l)
            {
                case 'e':
                    Math = "Higher math";
                    Physics = "Physics";
                    Informatics = "Informatics";
                    Grafics = "Grafics";
                    ukrainianLanguage = "Ukrainian laguage";
                    introductionToSpecialty = "Introduction to specialty";
                    english = "English";
                    PE = "PE";
                    history = "history";
                    theoryOfDigitalAutomata = "Theory of digital automata";
                    ecology = "ecology";
                    informationTechnologyAndProgramming = "Information Technology and Programming";
                    phylosophy = "phylosophy";
                    appliedMechanics = "Applied Mechanics";

                        break;
                case 'u':
                    Math = "Вища математика";
                    Physics = "Фiзика";
                    Informatics = "Iнформатика";
                    Grafics = "Графiка";
                    ukrainianLanguage = "Укр мова ";
                    introductionToSpecialty = "Вступ до спецiальностi";
                    english = "Англiйська мова";
                    PE = "Фiзична культура";
                    history = "Iсторiя";
                    theoryOfDigitalAutomata = "Теорiя цифрових автоматiв";
                    ecology = "Екологiя";
                    informationTechnologyAndProgramming = "Iнформацiйні технологі та програмування";
                    phylosophy = "Філософія";
                    appliedMechanics = "Прикладна механіка";

                    break;

            }
        }
    }
}
