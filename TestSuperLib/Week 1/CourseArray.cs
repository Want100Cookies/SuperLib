using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TestSuperLib.Week_1
{
    public class ClassArray : IEnumerable<CourseArray>
    {
        private CourseArray[] _courses = new CourseArray[0];

        public void AddCourse(CourseArray course)
        {
            Array.Resize(ref _courses, _courses.Length + 1);
            _courses[_courses.Length - 1] = course;
        }

        public void RemoveCourse(string courseName)
        {
            for (int i = 0; i < _courses.Length; i++)
            {
                if (_courses[i].CourseName != courseName) continue;

                _courses[i] = _courses[_courses.Length - 1];
                Array.Resize(ref _courses, _courses.Length - 1);
            }
        }

        public CourseArray GetCourse(string courseName)
        {
            foreach (CourseArray course in _courses)
            {
                if (course.CourseName == courseName)
                {
                    return course;
                }
            }

            return null;
        }

        public IEnumerator<CourseArray> GetEnumerator()
        {
            return ((IEnumerable<CourseArray>)_courses).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<CourseArray>)_courses).GetEnumerator();
        }
    }

    public class CourseArray : IEnumerable<Grade>
    {
        public string CourseName { get; set; }

        private Grade[] _grades = new Grade[0];

        public void AddGrade(string studentName, double result)
        {
            Array.Resize(ref _grades, _grades.Length + 1);
            _grades[_grades.Length - 1] = new Grade() { StudentName = studentName, Result = result };
        }

        public void RemoveGrade(string studentName)
        {
            for (int i = 0; i < _grades.Length; i++)
            {
                if (_grades[i].StudentName != studentName) continue;

                _grades[i] = _grades[_grades.Length - 1];
                Array.Resize(ref _grades, _grades.Length - 1);
                return;
            }
        }

        public double Average()
        {
            double total = _grades.Sum(t => t.Result);

            return total / _grades.Length;
        }

        public Grade HighestGrade()
        {
            Grade highestGrade = null;

            foreach (Grade grade in _grades)
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

            foreach (Grade grade in _grades)
            {
                if (lowestGrade == null || grade.Result < lowestGrade.Result)
                {
                    lowestGrade = grade;
                }
            }

            return lowestGrade;
        }

        public IEnumerator<Grade> GetEnumerator()
        {
            return ((IEnumerable<Grade>)_grades).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Grade>)_grades).GetEnumerator();
        }
    }

    public class Grade
    {
        public string StudentName { get; set; }
        public double Result { get; set; }
    }
}
