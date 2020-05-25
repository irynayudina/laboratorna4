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
            int size = Positive();
            GraduateStudentCollection gst = new GraduateStudentCollection();
            gst.AddDefaults();
            //##########################//Add elements to GraduateStudetCollection//############################
            int amount = 10;
            GraduateStudet[] gradArr = new GraduateStudet[amount];
            for (int i = 0; i < amount; i++)
            {
                gradArr[i] = new GraduateStudet();
            }
            GraduateStudet gradVariable = new GraduateStudet();
            Random rand = new Random();
            int lastNameInt = 0;
            int learnigYearInt = 0;
            int y = 0;
            for (int i = 0; i < amount; i++)
            {
                lastNameInt = rand.Next(1, 400);
                learnigYearInt = rand.Next(1, 4);
                gradArr[i].LearningYear = learnigYearInt;
                y = rand.Next(DateTime.Today.Year - learnigYearInt - 30, DateTime.Today.Year - learnigYearInt - 18);
                gradArr[i].ChangeBirthday = y;
                gradArr[i].PersonProperty = new Person(gradArr[i].Name, gradArr[i].LastName + lastNameInt, gradArr[i].Date);
            }
            gst.AddGraduateStudents(gradArr);
            //################################################################################
            Console.WriteLine(gst.ToString());
            Console.WriteLine("Elements of GraduateStudentCollection sorted by name:########################################");
            gst.SortByLastName();
            Console.WriteLine(gst.ToString());
            Console.WriteLine("Elements of GraduateStudentCollection sorted by birthday:####################################");
            gst.SortByBirthday();
            Console.WriteLine(gst.ToString());
            Console.WriteLine("Elements of GraduateStudentCollection sorted by learning year:###############################");
            gst.SortByLearningYear();
            Console.WriteLine(gst.ToString());
            TestCollections testColl = new TestCollections(size);

            static int Positive()
            {
                int size;
                Console.WriteLine("Enter the size of collections:");
                String temp = Console.ReadLine();
                while (!(int.TryParse(temp, out size)) || size < 0)
                {
                    Console.Write("Enter the size of collections:");
                    temp = Console.ReadLine();
                }
                return size;
            }
        }
    }
}