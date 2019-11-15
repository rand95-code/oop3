using System;
using System.Collections.Generic;
using System.Text;

namespace oop3.NewFolder
{
    class person
    {
       readonly int id; 
        string name;
        string address;
        string phone;
        double salary;
        const double tax = 0.1; 

        public double getNetSalary()

        {

            double NetSal = salary - (salary * tax);
            return NetSal; 

        }

        public string GetPerson()

        {

            string allData = "ID: " + id + "\n";
            allData += "Name: " + name + "\n";
            allData += "Address: " + address + "\n";
            allData += "Phone: " + phone + "\n";
            allData += "Salary: " + salary + "\n;";
            allData += "Net Salary: " + getNetSalary ()+ "\n";

            return allData; 

        }

        public void printPersonData()

        {

            Console.WriteLine(GetPerson());
        }



        
    }
}
