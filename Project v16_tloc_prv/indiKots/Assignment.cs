using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indiKots
{
	class Assignment : Helper
	{
		public string Title { get; private set; }
		public string Description { get; private set; }
		public DateTime SubmDate { get; private set; }
		public int OralMark { get; private set; }
		public int TotalMark { get; private set; }
		public int AssignmentID { get; private set; }
		private static int TotalAssignments = 0;
		public int AssignmentCourseID { get; private set; }

		public Assignment(string title, string description, DateTime submdate, int oralmark, int totalmark, int assignmentCourseID)
		{
			Title = title;
			Description = description;
			SubmDate = submdate;
			OralMark = oralmark;
			TotalMark = totalmark;
			TotalAssignments++;
			AssignmentID = TotalAssignments;
			AssignmentCourseID = assignmentCourseID;
		} //--- 1st constructor Assignment end ---//

		public Assignment()
		{
			TotalAssignments++;
			AssignmentID = TotalAssignments;

		} //--- 2nd constructor Assignment end ---//

		public void SetAssignment()
		{
			Console.WriteLine(" Ok let's make the list of Assignments! ");
			Console.WriteLine("\n The information about each Assignment you need to give is: Title, Description, Submission Date, Oral Mark and Written Mark. ");
			Console.WriteLine(" Pay attention to the following example: ");
			Console.WriteLine("\n\n Project A, Create an Email app, 2021,01,15, 57, 65 \n");
			Console.WriteLine("\n Give assignment's title (ex. ProjectCB11): ");
			Title = Console.ReadLine();
			Console.WriteLine(" Give assignment's description (ex. Create a webpage): ");
			Description = Console.ReadLine();
			Console.WriteLine(" Give assignment's submission date (ex. 2020,07,27): ");
			SubmDate = ValidateDateTime();
			Console.WriteLine(" Give Course ID to assign the assignment in a specific course or give 0 to skip this step: ");
			AssignmentCourseID = ValidateGivenID();
			Console.WriteLine(" Give assignment's oral mark (ex. 55): ");
			OralMark = ValidateMark();
			Console.WriteLine(" Give assignment's total mark (ex. 65): ");
			TotalMark = ValidateMark();

		} //--- SetAssignment method end ---//

	} //--- class Assignment end ---// 

} //--- namespace end ---//
