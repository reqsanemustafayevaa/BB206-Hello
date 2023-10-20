using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflection_task
{
    public class Employee
    {
        private string _fullname { get; set; }
        private static double _id { get; set; }
        private string _departmentNo { get; set; }
        private sbyte _age { get; set; }
        private double _experience { get; set; }
        private double _salary;

        private static double idd;

        static Employee()
        {
            _id = 0;
        }
        public Employee()
        {
            _id = idd;
            idd++;
        }

        public sbyte Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0 && value < 150)
                {
                    _age = value;
                }
                else
                {
                    throw new InvalidAgeException();
                }
            }
        }
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                if (value == _fullname && value.Split(' ').Length == 2)
                {
                    _fullname = value;
                }
                else
                {
                    throw new InvalidNameException("invalid name");
                }
            }
        }
        public string DepartmentNo
        {
            get
            {
                return _departmentNo;
            }
            set
            {
                if ((value == _departmentNo && value.Length == 2 && value.ToUpper() == value))
                {
                    _fullname = value;
                }
                else
                {
                    throw new InvalidDepartmentNo();
                }
            }




        }
        public double Experience
        {
            get
            {
                return _experience;
            }
            set
            {
                if (value > 0 && value < (Age - 18))
                {
                    _experience = value;
                }
                else
                {
                    throw new InvalidAgeException();
                }




            }
        }


    }
}
