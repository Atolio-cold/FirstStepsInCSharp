using System;

namespace Coding.Exercise
{
    using System.Collections.Generic;
    using System.Linq;

    public class GradeManager
    {
        Dictionary<string, List<int>> studentMakrs = new Dictionary<string, List<int>>();

        public void AddGrade(string studentName, int grade)
        {
            if (studentMakrs.ContainsKey(studentName))
            {
                studentMakrs[studentName].Add(grade);
            }
            else
            {
                List<int> newList = new List<int>();
                newList.Add(grade);
                studentMakrs.Add(studentName, newList);

            }
        }

        public void RemoveGrade(string studentName, int grade)
        {
            // TODO: Uzupełnij implementację metody RemoveGrade, aby usuwała ocenę z listy ocen ucznia, jeśli istnieje.

            if (studentMakrs.ContainsKey(studentName) && studentMakrs[studentName].Contains(grade))
            {
                studentMakrs[studentName].Remove(grade);
                if (studentMakrs[studentName].Count == 0)
                {
                    studentMakrs.Remove(studentName);
                }
            }



        }

        public double CalculateAverageGrade(string studentName)
        {
            // TODO: Uzupełnij implementację metody CalculateAverageGrade, aby obliczała średnią ocen ucznia, jeśli istnieją oceny.
            if (studentMakrs.ContainsKey(studentName))
            {
                List<int> grades = studentMakrs[studentName];

            }
            else
            {
                return 0;
            }

        }
    }

}
