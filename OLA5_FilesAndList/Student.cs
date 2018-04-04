using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLA5_FilesAndList
{
    class Student : IComparable<Student>
    {
        // Student Name,Class,Earned Hours,GPA,Course,CourseNumber,FinalGrade,TotalCSCICreditHrs,CSCI GPA
        // "Gomez, Christine",SR,124,3.0673,CSCI1170,1170,B,36,2.8144

        public string lastName;
        public string firstName;
        public string classLevel;
        public int earnedHours;
        public double gpa;
        public string course;
        public int courseNumber;
        public string finalGrade;
        public int totalCSCICreditHours;
        public double cscigpa;
        
        public static Student FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');

            Student student = new Student();

            student.lastName = values[0];
            student.firstName = values[1];
            student.classLevel = values[2];

            try
            {
                student.earnedHours = Convert.ToInt32(values[3]);
            }
            catch(FormatException)
            {
                student.earnedHours = 0;
            }

            try
            {
                student.gpa = Convert.ToDouble(values[4]);
            }
            catch(FormatException)
            {
                student.gpa = 0.0;
            }

            student.course = values[5];

            try
            {
                student.courseNumber = Convert.ToInt32(values[6]);
            }
            catch(FormatException)
            {
                student.courseNumber = 0;
            }

            student.finalGrade = values[7];

            try
            {
                student.totalCSCICreditHours = Convert.ToInt32(values[8]);
            }
            catch(FormatException)
            {
                student.totalCSCICreditHours = 0;
            }

            try
            {
                student.cscigpa = Convert.ToDouble(values[9]);
            }
            catch(FormatException)
            {
                student.cscigpa = 0.0;
            }

            return student;

        }

        public override string ToString()
        {

            string studentString = 

                lastName + ", " +
                firstName + ", " +
                classLevel + ", " +
                Convert.ToString(earnedHours) + ", " +
                Convert.ToString(gpa) + ", " +
                course +
                Convert.ToString(courseNumber) + ", " +
                finalGrade + ", " +
                Convert.ToString(totalCSCICreditHours) + ", " +
                Convert.ToString(cscigpa) + ", ";

            return studentString;
        }

        public int CompareTo(Student other)
        {
            // we're kind of being wicked and only implementingn this for the one property used. 
            // the GPA
            return gpa.CompareTo(other.gpa);
           
        } 

    }

}
