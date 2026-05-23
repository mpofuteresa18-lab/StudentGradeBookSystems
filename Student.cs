using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace StudentGradeBookSystems
{
    internal class Student
    {
        public string StudentID;
        public string Module;
        public int Test;
        public int Assignment;
        public int FinalExam;
        public double Coursework;
        public double moduleMark;
        public string Grade;

        public double CalculateModuleMark() 
        {

            Coursework = (Test + Assignment) / 2.0;
            moduleMark = (Coursework * 0.4) + (FinalExam * 0.6);
            return moduleMark;

        }
        public string CalculateGrade()
        {
           
            if (moduleMark >= 75)
                Grade = "Distinction";
            else if (moduleMark >= 50)
                Grade = "Pass";
            else if (moduleMark >= 40)
                Grade = "Supplementary";
            else
                Grade = "Fail";
            return Grade;
        }




    }
}
