using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers_Namespace.Models
{
    internal class Employee
    {

        public Employee(string name, decimal salary, bool isSuccessfull)
        {
            Name = name;
			Salary=salary;
			IsSuccesfull = isSuccessfull;
        }

		

        private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private bool _isSuccessfull;

		public bool IsSuccesfull
		{
			get { return _isSuccessfull; }
			set { _isSuccessfull = value; }
		}

		private decimal _salary;


        public decimal Salary
		{
			get { return _salary; }
			set { _salary = value; }
		}

		public void GetInfo()
		{
			Console.WriteLine($"Name: {_name}");
			Console.WriteLine($"Salary: {_salary}");
			Console.WriteLine();
        }


	}
}
