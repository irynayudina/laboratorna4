using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace laboratorna4
{
    class GraduateStudentCollection
    {
        private List<GraduateStudet> ListOfStudents = new List<GraduateStudet>();
        public void AddDefaults()
        {
            /*c допомогою якого можна додати деяке число елементів
              * типу GraduateStudent для ініціалізації колекції за замовчуванням; */
            int sizedef = 7;
            GraduateStudet[] p = new GraduateStudet[sizedef];
            for(int i = 0; i< sizedef; i++)
            {
                GraduateStudet grd = new GraduateStudet();
                grd.LastName = grd.LastName + i;
                p[i] = grd;
            }
            ListOfStudents.AddRange(p);

        }
        public void AddGraduateStudents(params GraduateStudet[] p)
        {
            ListOfStudents.AddRange(p);
        }
        public override string ToString()
        {
            string res = "";
            foreach(GraduateStudet g in ListOfStudents)
            {
                res += g.ToString();
            }
            return res;
        }
        public string ToShortString()
        {
            string res = "";
            foreach (GraduateStudet g in ListOfStudents)
            {
                res += g.ToShortString();
            }
            return res;
        }
        public void SortByLastName()
        {
            ListOfStudents.Sort();
        }
        public void SortByBirthday()
        {
            ListOfStudents.Sort(new Person());
        }
        public void SortByLearningYear()
        {
            ListOfStudents.Sort(new GraduateStudet.YearComparer());
        }
    }
}
