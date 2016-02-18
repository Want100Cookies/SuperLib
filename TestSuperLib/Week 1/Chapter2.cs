using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperLib;
using SuperLib.Week_1;

namespace TestSuperLib.Week_1
{
    public partial class Chapter2 : Form
    {
        public Chapter2()
        {
            InitializeComponent();
        }

        private void btnTestGradesArray_Click(object sender, EventArgs e)
        {
            ClassArray courseArray = new ClassArray();

            CourseArray course1 = new CourseArray() { CourseName = "Java"};
            course1.AddGrade("Piet", 7.5);
            course1.AddGrade("Jan", 6.1);
            course1.AddGrade("John", 4.5);

            CourseArray course2 = new CourseArray() { CourseName = "C#" };
            course2.AddGrade("Piet", 3.7);
            course2.AddGrade("Jan", 7.9);
            course2.AddGrade("John", 5.5);

            courseArray.AddCourse(course1);
            courseArray.AddCourse(course2);

            StringBuilder stringBuilder = new StringBuilder("Test course array with grades: \n\n");

            foreach (CourseArray course in courseArray)
            {
                stringBuilder.Append(course.CourseName + ": \n");

                foreach (Grade grade in course)
                {
                    stringBuilder.Append("\t" + grade.StudentName + "\t" + grade.Result + "\n");
                }

                stringBuilder.Append("\t\tAverage: " + course.Average() + "\n");

                Grade highestGrade = course.HighestGrade();
                stringBuilder.Append("\t\tHighest grade: " + highestGrade.StudentName + " -> " + highestGrade.Result + "\n");

                Grade lowestGrade = course.LowestGrade();
                stringBuilder.Append("\t\tLowest grade: " + lowestGrade.StudentName + " -> " + lowestGrade.Result + "\n");

                stringBuilder.Append("\n");
            }

            MessageBox.Show(stringBuilder.ToString());
        }

        private void Chapter2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Parent.Show();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            // Test the array implementation

            var arrayResult = Timing.Time<NoResult>(() =>
            {
                ClassArray courseArray = new ClassArray();

                CourseArray course1 = new CourseArray() { CourseName = "Java" };
                course1.AddGrade("Piet", 7.5);
                course1.AddGrade("Jan", 6.1);
                course1.AddGrade("John", 4.5);

                CourseArray course2 = new CourseArray() { CourseName = "C#" };
                course2.AddGrade("Piet", 3.7);
                course2.AddGrade("Jan", 7.9);
                course2.AddGrade("John", 5.5);

                courseArray.AddCourse(course1);
                courseArray.AddCourse(course2);

                foreach (CourseArray course in courseArray)
                {
                    foreach (Grade grade in course)
                    {
                        string tmpstudentname = grade.StudentName;
                        double tmpgraderesult = grade.Result;
                    }

                    double tmpaverage = course.Average();

                    Grade highestGrade = course.HighestGrade();
                    string tmphighestname = highestGrade.StudentName;
                    double tmphighestgrade = highestGrade.Result;

                    Grade lowestGrade = course.LowestGrade();
                    string tmplowestname = lowestGrade.StudentName;
                    double tmplowestgrade = lowestGrade.Result;
                }

                return new NoResult();
            });

            var arrayListResult = Timing.Time<NoResult>(() =>
            {
                ClassArrayList courseArray = new ClassArrayList();

                CourseArrayList course1 = new CourseArrayList() { CourseName = "Java" };
                course1.AddGrade("Piet", 7.5);
                course1.AddGrade("Jan", 6.1);
                course1.AddGrade("John", 4.5);

                CourseArrayList course2 = new CourseArrayList() { CourseName = "C#" };
                course2.AddGrade("Piet", 3.7);
                course2.AddGrade("Jan", 7.9);
                course2.AddGrade("John", 5.5);

                courseArray.AddCourse(course1);
                courseArray.AddCourse(course2);

                foreach (CourseArrayList course in courseArray)
                {
                    foreach (Grade grade in course)
                    {
                        string tmpstudentname = grade.StudentName;
                        double tmpgraderesult = grade.Result;
                    }

                    double tmpaverage = course.Average();

                    Grade highestGrade = course.HighestGrade();
                    string tmphighestname = highestGrade.StudentName;
                    double tmphighestgrade = highestGrade.Result;

                    Grade lowestGrade = course.LowestGrade();
                    string tmplowestname = lowestGrade.StudentName;
                    double tmplowestgrade = lowestGrade.Result;
                }

                return new NoResult();
            });

            MessageBox.Show("Test results:\nArray implementation: \t" + $"{arrayResult.Time:0.00000000}" +
                            "sec \nArrayList implementation: \t" + $"{arrayListResult.Time:0.00000000}" + "sec");
        }
    }
}
