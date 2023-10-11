using Modifiers_Namespace.Models;

namespace Modifiers_Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new("Adil",213M,false);
            employee.GetInfo();

            Assistant assistant = new Assistant();

            assistant.GetFeedBack(employee);

            employee.GetInfo();
        }
    }
}