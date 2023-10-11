using Modifiers_Namespace.Models;

namespace Modifiers_Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new("Adil",213M,false);
            //employee.GetInfo();

            //Assistant assistant = new Assistant();

            //assistant.GetFeedBack(employee);

            //employee.GetInfo();

            Console.Write("Enter your name:");
            string name = Console.ReadLine().Trim();

            Console.Write("Enter your age:");
            byte age = Convert.ToByte(Console.ReadLine());

            Console.Write("Enter your grade:");
            double grade = Convert.ToDouble(Console.ReadLine());

            Student student = new Student(name,age,grade);

            student.GetInfo();
        }
    }
}