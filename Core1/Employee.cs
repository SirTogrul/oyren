using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core1
{
    public class Employee
    {
        public int IdForObject { get; set; }
        private static int _idForClass { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public byte _age;
        public byte Age { 
            get { return _age; }
            set
            {
                if(value > 0)
                {
                    _age = value;
                }
            }
        }

        public int DepartmentNo { get; set; }
        public string Position { get; set; }

        private double _salary;
        public double Salary { 
            get { return _salary; }
            set
            {
                if(value > 0)
                {
                    _salary = value;
                }
            }
        }

        public Employee()
        {
            _idForClass++;
            IdForObject = _idForClass;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, DepartmentNo: {DepartmentNo}, Position: {Position}, Salary: {Salary}");
        }

    }
}
