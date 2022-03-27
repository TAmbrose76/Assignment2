using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _206_Tute4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = generateList();
            List<Employee> femaleEmployees = FilterByGender(employees, Gender.F);
            printList(femaleEmployees);
        }

        static void printList(List<Employee> staff)
        {
            foreach (Employee employee in staff)
            {
                Console.WriteLine(employee);
            }
        }

        static List<Employee> generateList()
        {
            List<Employee> staff = new List<Employee>();
            Employee a = new Employee { name = "Tom", id = 1, gender = Gender.M };
            Employee b = new Employee { name = "Jeremiah", id = 2, gender = Gender.M };
            Employee c = new Employee { name = "Yvette", id = 3, gender = Gender.F };
            Employee d = new Employee { name = "Georgette", id = 4, gender = Gender.F };
            Employee e = new Employee { name = "Kirsten", id = 5, gender = Gender.F };
            staff.Add(a);
            staff.Add(b);
            staff.Add(c);
            staff.Add(d);
            staff.Add(e);

            return staff;
        }

        static List<Employee> FilterByGender(List<Employee> staff, Gender gender)
        {
            List<Employee> employees = new List<Employee>();
            foreach (Employee employee in staff)
            {
                if (employee.gender == gender)
                {
                    employees.Add(employee);
                }
            }
            return employees;
        }
    }
}
