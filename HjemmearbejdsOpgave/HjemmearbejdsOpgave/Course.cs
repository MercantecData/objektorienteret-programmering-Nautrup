using System;
using System.Collections.Generic;
using System.Text;

namespace HjemmearbejdsOpgave
{
    public class Course
    {
        string name;
        Classroom classroom;

        public Course(string name, Classroom classroom)
        {
            this.name = name;
            this.classroom = classroom;
        }

        public List<Student> WhoIsMemberOf(string courseName, Student student)
        {
            List<Student> memberOfCourse = new List<Student>();
            if (name == courseName)
            {
                memberOfCourse.Add(student);
            }
            return memberOfCourse;
        }

    }
}
