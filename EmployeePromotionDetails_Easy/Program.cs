using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePromotionDetails_Easy
{
    class Program
    {
        static void Main(string[] args)
        {
			// Easy 1- Getting Employee names List for Promotion
			List<string> employeelist = new List<string>();
			Console.WriteLine("Please enter the employee names in the order of thier eligibility for promotion(Please enter blank to stop)");
			string name = Console.ReadLine();
			while (!string.IsNullOrEmpty(name))
			{
				employeelist.Add(name);
				name = Console.ReadLine();
			}
			foreach (var employee in employeelist)
			{
				Console.WriteLine(employee);
			}


			// Easy 2-Finding the promotion positon of given employee
			/*
			List<string> employeelist = new List<string>();
			Console.WriteLine("Please enter the employee names in the order of thier eligibility for promotion(Please enter blank to stop)");
			string name = Console.ReadLine();
			while (!string.IsNullOrEmpty(name))
			{
				employeelist.Add(name);
				name = Console.ReadLine();
			}
            Console.WriteLine("Please enter the name of the employee to check promotion position");
            name = Console.ReadLine();
            int position = employeelist.IndexOf(name);
            Console.WriteLine(position + 1);
            Console.WriteLine(name + " is in the position " + ( position + 1) + " for promotion ");
			*/


			//Easy 3-Trimming the extra spaces in list memory
			/*
			List<string> employeelist = new List<string>();
			Console.WriteLine("Please enter the employee names in the order of thier eligibility for promotion(Please enter blank to stop)");
			string name = Console.ReadLine();
			while (!string.IsNullOrEmpty(name))
			{
				employeelist.Add(name);
				name = Console.ReadLine();
			}
			Console.WriteLine("The current size of the collection is "+employeelist.Capacity);
			employeelist.TrimExcess();
			Console.WriteLine("The size after removing the extra space is "+employeelist.Capacity);
			*/


			//Easy 4-Sorting the Employee List in ascending order
			/*
			List<string> employeelist = new List<string>();
			Console.WriteLine("Please enter the employee names in the order of thier eligibility for promotion(Please enter blank to stop)");
			string name = Console.ReadLine();
			while (!string.IsNullOrEmpty(name))
			{
				employeelist.Add(name);
				name = Console.ReadLine();
			}
			employeelist.Sort();
			Console.WriteLine("Promoted employee list:");
			foreach( var employee in employeelist)
            {
				Console.WriteLine(employee);
            }
			*/

			Console.ReadKey();
		}
	}
}
