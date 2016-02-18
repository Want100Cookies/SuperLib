using System.Collections;
using System.Linq;
using SuperLib.Week_1;

namespace TestSuperLib.Week_1
{
    public class ClassArrayList : CollectionBase
    {

        public void AddCourse(CourseArrayList course)
        {
            InnerList.Add(course);
        }

        public void RemoveCourse(string courseName)
        {
            CourseArrayList toRemove = null;

            foreach (CourseArrayList course in InnerList)
            {
                if (course.CourseName == courseName) toRemove = course;
            }

            if (toRemove != null) InnerList.Remove(toRemove);
        }

        public CourseArrayList GetCourse(string courseName)
        {
            foreach (CourseArrayList course in InnerList)
            {
                if (course.CourseName == courseName)
                {
                    return course;
                }
            }

            return null;
        }
    }

    public class CourseArrayList : CollectionBase
    {
        public string CourseName { get; set; }

        public void AddGrade(string studentName, double result)
        {
            InnerList.Add(new Grade {StudentName = studentName, Result = result});
        }

        public void RemoveGrade(string studentName)
        {
            Grade toRemove = null;

            foreach (Grade grade in InnerList)
            {
                if (grade.StudentName == studentName) toRemove = grade;
            }

            if (toRemove != null) InnerList.Remove(toRemove);
        }

        public double Average()
        {
            double total = InnerList.Cast<Grade>().Sum(grade => grade.Result);

            return total / InnerList.Count;
        }

        public Grade HighestGrade()
        {
            Grade highestGrade = null;

            foreach (Grade grade in InnerList)
            {
                if (highestGrade == null || grade.Result > highestGrade.Result)
                {
                    highestGrade = grade;
                }
            }

            return highestGrade;
        }

        public Grade LowestGrade()
        {
            Grade lowestGrade = null;

            foreach (Grade grade in InnerList)
            {
                if (lowestGrade == null || grade.Result < lowestGrade.Result)
                {
                    lowestGrade = grade;
                }
            }

            return lowestGrade;
        }
    }
}
