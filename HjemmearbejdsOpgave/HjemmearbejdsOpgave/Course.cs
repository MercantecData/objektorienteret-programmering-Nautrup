using System;
using System.Collections.Generic;
using System.Text;

namespace HjemmearbejdsOpgave
{
    public class Course
    {
        public string name;
        Classroom classroom;

        public Course(string name, Classroom classroom)
        {
            this.name = name;
            this.classroom = classroom;
        }

        public List<string> ReturnCourseList(Course course)
        {
            List<string> courseList = new List<string>();
            courseList.Add(course.name);
            return courseList;
        }
    }
}
