using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTasj.Models
{
    internal class Student
    {
        private static int Count = 0;
        public int Id { get; }
        public string Fullname { get; }

        public Student(string fullname)
        {
            if (!CheckFullname(fullname))
                throw new ArgumentException("Invalid fullname format. Fullname must consist of a first and last name.");

            Fullname = fullname;
            Count++;
            Id = Count;
        }

        public static bool CheckFullname(string fullname)
        {
            if (string.IsNullOrWhiteSpace(fullname))
                return false;

            string[] parts = fullname.Split(' ');
            if (parts.Length != 2)
                return false;

            foreach (string part in parts)
            {
                if (string.IsNullOrWhiteSpace(part) || !char.IsLetter(part[0]))
                    return false;
            }

            return true;
        }

        public override string ToString()
        {
            return $"{Id}. {Fullname}";
        }
    }
}
