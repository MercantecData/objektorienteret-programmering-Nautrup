using System;
using System.Collections.Generic;
using System.Text;

namespace PersonRegisterLibrary
{
    public class Job
    {
        string title;
        int salary;
        string description;

        public Job(string title, int salary, string description)
        {
            this.title = title;
            this.salary = salary;
            this.description = description;
        }

        public string ReturnJobDescription()
        {
            return $"{title}\nTimeløn: {salary} DKK\nBeskrivelse: {description}";
        }
    }
}
