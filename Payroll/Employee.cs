using System;
using System.Collections.Generic;
using System.Linq;

namespace Payroll
{
    public class Employee : Employable
    {
        string FirstName { get; }
        string LastName { get; }
        float Salary { get; }

        public Employee(string firstName, string lastName, float salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.notes = new Dictionary<string, string>();
        }

        private Dictionary<string, string> notes;

        public string GetFullName()
        {
            return $"{this.FirstName} {this.LastName}";
        }

        public float GetSalary()
        {
            return this.Salary;
        }

        public void AddNote(string type, string note)
        {
            this.notes[type] = note;
        }

        public string GetNote(string type)
        {
            if (!this.notes.Keys.Contains(type))
            {
                throw new ArgumentException($"no note of type {type} available");
            }
            return this.notes[type];
        }

        public override string ToString()
        {
            return this.GetFullName();
        }
    }
}
