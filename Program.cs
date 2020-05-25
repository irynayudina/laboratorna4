using System;
using System.Collections.Generic;

namespace laboratorna4
{
    public enum FormOfStudy
    {
        FullTime,
        PartTime,
        Distance
    }
    class Program
    {
        static void Main()//string[] args
        {
            GraduateStudentCollection gst = new GraduateStudentCollection();
            //##########################//Add elements to GraduateStudet//############################
            int amount = 10;
            GraduateStudet[] gradArr = new GraduateStudet[amount];
            GraduateStudet gradVariable = new GraduateStudet();
            gst.AddDefaults();
            Random rand = new Random();
            int lastNameInt = 0;
            int learnigYearInt = 0;
            int y = rand.Next(DateTime.Today.Year- learnigYearInt-30, DateTime.Today.Year - learnigYearInt-18);
            for (int i = 0; i < amount; i++)
            {
                lastNameInt = rand.Next(1, 400);
                gradVariable.PersonProperty.LastName = gradVariable.PersonProperty.LastName + lastNameInt;
                Console.WriteLine(gradVariable.PersonProperty.LastName);
                learnigYearInt = rand.Next(1, 4);
                gradVariable.LearningYear = learnigYearInt;
                y = rand.Next(DateTime.Today.Year - learnigYearInt - 30, DateTime.Today.Year - learnigYearInt - 18);
                gradVariable.ChangeBirthday = y;
                //gradVariable.PersonProperty = new Person();
                gradArr[i] = gradVariable;
            }
            gst.AddGraduateStudents(gradArr);
            //################################################################################
            Console.WriteLine(gst.ToString());
            //Console.WriteLine("Elements of GraduateStudentCollection sorted by name:");
            //gst.SortByLastName();
            //Console.WriteLine(gst.ToString());
            //Console.WriteLine("Elements of GraduateStudentCollection sorted by birthday:");
            //gst.SortByBirthday();
            //Console.WriteLine(gst.ToString());
            //Console.WriteLine("Elements of GraduateStudentCollection sorted by learning year:");
            //gst.SortByLearningYear();
            //Console.WriteLine(gst.ToString());
        }
    }
}