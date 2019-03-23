using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach(float grade in grades)
            {
                /*if(grade > stats.HighestGrade)
                {
                    stats.HighestGrade = grade;
                }

                if(grade < stats.LowestGrade)
                {
                    stats.LowestGrade = grade;
                }*/
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade; 
            }

            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public string Name
        {
            //get; set;
            get
            {
                return _name;
            }
  
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }
        private string _name;
        private List<float> grades;
    }
}
