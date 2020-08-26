using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indiKots
{
	class Course : Helper
	{
		public string Title { get; private set; }
		public string Stream { get; private set; }
		public string Type { get; private set; }
		public DateTime StartDate { get; private set; }
		public DateTime EndDate { get; private set; }
		public int CourseID { get; private set; }
		private static int TotalCourses = 0;

		public Course(string title, string stream, string type, DateTime startdt, DateTime enddt)
		{
			Title = title;
			Stream = stream;
			Type = type;
			StartDate = startdt;
			EndDate = enddt;
			TotalCourses++;
			CourseID = TotalCourses;

		} //--- 1st constructor Course end ---//

		public Course()
		{
			TotalCourses++;
			CourseID = TotalCourses;

		} //--- 2nd constructor Course end ---//

		public void SetCourse()
		{
			Console.WriteLine(" Ok let's make the list of Courses! ");
			Console.WriteLine("\n The information about each Course you need to give is: Title, Stream, Type, Start Date and End Date. ");
			Console.WriteLine(" Pay attention to the following example: ");
			Console.WriteLine("\n\n Coding BootCamp 11, Java, Full-Time, 2020,07,15, 2020,09,15 \n");
			Console.WriteLine("\n Give course's title (ex. Coding BootCamp 11): ");
			Title = Console.ReadLine();
			Console.WriteLine(" Give course's stream (ex. Java): ");
			Stream = Console.ReadLine();
			Console.WriteLine(" Give course's type (ex. Full-Time): ");
			Type = Console.ReadLine();
			Console.WriteLine(" Give course's start date (ex. 2020,07,15): ");
			StartDate = ValidateDateTime();
			Console.WriteLine(" Give course's end date (ex. 2020,09,15): ");
			EndDate = ValidateDateTime();

		} //--- SetCourse method end ---//

	} //--- class Course end ---//

} //--- namespace end ---//
