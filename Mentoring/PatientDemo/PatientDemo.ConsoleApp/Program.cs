using PatientDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDemo.ConsoleApp
{

	class Program
	{
		static void Main(string[] args)
		{
			Patient myPatient = new Patient();
			myPatient.Surname = "Smith";
			myPatient.Forename = "John";

			Console.WriteLine("Welcome " + myPatient.Forename + " " + myPatient.Surname +" PLEASE PRESS ENTER");
			Console.ReadKey();
			Console.WriteLine("Please enter Patient Names followed by pressing enter for the next patient. Once the last patient has been entered please type in CTRL Z and press enter. From there to move on to the next steps please just press enter. PRESS ENTER TO BEGIN");
			Console.ReadLine();
			string s;

			do
			{
				s = Console.ReadLine();
				Console.WriteLine("You entered:" + s);

			} while (s != null);

			Console.WriteLine("This will self distuct in");
			Console.ReadLine();
			Console.ForegroundColor = ConsoleColor.Red;
			Console.SetWindowSize(60, 43);
			Console.WriteLine("..............1");
			Console.ReadLine();
			Console.SetWindowSize(40, 20);
			Console.WriteLine("..............2");
			Console.ReadLine();
			Console.WriteLine("..............3");
			Console.ReadLine();
			{


				const int maxProgressBarLength = 10;
				const string progressBarElement = "█";
				var title = "";

				do
				{
					title += progressBarElement;

					if (title.Length > maxProgressBarLength)
					{
						title = progressBarElement;
					}

					Console.Title = title;

					System.Threading.Thread.Sleep(100);
				} while (title.Length < 9);
			}
		}
	}
}
