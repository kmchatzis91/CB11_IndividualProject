using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indiKots
{
	class Student : Helper
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateofBirth { get; set; }
		public int TuitionFees { get; set; }
		public int StudentID { get; private set; }
		private static int TotalSudents = 0;
		public int StudentCourseID { get; set; }
		public int StudentAssignmentID { get; set; }

		public Student(string firstname, string lastname, DateTime dateofbirth, int tuitionfees, int studentcourseid, int studentassignmentid)
		{
			FirstName = firstname;
			LastName = lastname;
			DateofBirth = dateofbirth;
			TuitionFees = tuitionfees;
			TotalSudents++;
			StudentID = TotalSudents;
			StudentCourseID = studentcourseid;
			StudentAssignmentID = studentassignmentid;

		} //--- 1st constructor Student end ---//

		public Student()
		{
			TotalSudents++;
			StudentID = TotalSudents;

		} //--- 2nd constructor Student end ---//

		public void SetStudent()
		{
			Console.WriteLine(" Ok let's make the list of Students! ");
			Console.WriteLine("\n The information about each Student you need to give is: First Name, Last Name, Date of Birth and Tuition Fees. ");
			Console.WriteLine(" Pay attention to the following example: ");
			Console.WriteLine("\n\n Konstantinos, Chatzis, 1994,12,31, 10000 \n");
			Console.WriteLine("\n Give student's first name (ex. Iro): ");
			FirstName = Console.ReadLine();
			Console.WriteLine(" Give student's last name (ex. Vogatsikou): ");
			LastName = Console.ReadLine();
			Console.WriteLine(" Give student's date of birth (ex. 1993,08,28): ");
			DateofBirth = ValidateDateTime();
			Console.WriteLine(" Give student's tuition fees (ex. 9500): ");
			TuitionFees = ValidateTuitionFees();
			Console.WriteLine(" Give Course ID to assign the student in a specific course or give 0 to skip this step: ");
			StudentCourseID = ValidateGivenID();
			Console.WriteLine(" Give Assignment ID to assign the student in a specific assignment or give 0 to skip this step: ");
			StudentAssignmentID = ValidateGivenID();

		} //--- SetStudent method end ---//

	} //--- class Student end ---//

} //--- namespace end ---//
