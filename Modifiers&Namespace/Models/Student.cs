using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Modifiers_Namespace.Models
{
    internal class Student
    {
        public Student(string name,byte age,double grade)
        {
			Name = name;
			Age = age;
			Grade = grade;
        }
        private string _name;

		public string Name
		{
			get { return _name; }
			set {

                string pattern = "^[A-z]{3,}$";
				Regex rg = new(pattern);
				while (true){
					if (rg.IsMatch(value))
					{
                        _name = NameFormat(value);
						break;
                    }
					else
					{
                        Console.WriteLine("Enter your name again(name must not consist of (.'/\"<,>-_+=) and numbers):");
						value = Console.ReadLine();
                    }
                    
                    
				}
			}
		}


        public string NameFormat(string name)
        {
            name = name.Trim().ToUpper();

            StringBuilder result = new StringBuilder();

            result.Append(name[0] + name.Substring(1).ToLower());

            return result.ToString();
        }





        private byte _age;

		public byte Age
		{
			get { return _age; }
			set {
				while (true)
				{
					if (value >= 16 && value <= 50)
					{
						_age = value;
						break;
					}
					else
					{
						Console.Write("Enter Your Age Again(Age should be 16-50):");
						value = Convert.ToByte(Console.ReadLine());
					}
                }
				
            }
		}

		private double _grade;

		public double Grade
		{
			get { return _grade; }
			set {
                while (true)
                {
                    if (value >= 0 && value <= 100)
                    {
                        _grade = value;
                        break;
                    }
                    else
                    {
                        Console.Write("Enter Your Grade Again(grade should be 0-100):");
                        value = Convert.ToDouble(Console.ReadLine());
                    }
                }
            }
		}

		public void GetInfo()
		{
			Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Age: {_age}");
            Console.WriteLine($"Grade: {_grade}");
        }

	}
}
