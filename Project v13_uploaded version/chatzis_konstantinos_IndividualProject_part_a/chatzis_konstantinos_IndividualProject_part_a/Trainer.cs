using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatzis_konstantinos_IndividualProject_part_a
{
	class Trainer : HelperClass
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Subject { get; set; }
		public int TrainerID { get; private set; }
		private static int TotalTrainers = 0;
		public int TrainerCourseID { get; set; }

		public Trainer(string firstname, string lastname, string subject, int trainercourseid)
		{
			FirstName = firstname;
			LastName = lastname;
			Subject = subject;
			TotalTrainers++;
			TrainerID = TotalTrainers;
			TrainerCourseID = trainercourseid;
		} //--- 1st constructor Trainer end ---//

		public Trainer()
		{
			TotalTrainers++;
			TrainerID = TotalTrainers;
		} //--- 2nd constructor Trainer end ---//

		public void SetTrainer() 
		{
			Console.WriteLine(" Ok let's make the list of Trainers! ");
			Console.WriteLine("\n The information about each Trainer you need to give is: First Name, Last Name and Subject. ");
			Console.WriteLine(" Pay attention to the following example: ");
			Console.WriteLine("\n\n Michalis, Chamilos, CB11 \n");
			Console.WriteLine("\n Give trainer's first name (ex. Michalis): ");
			FirstName = Console.ReadLine();
			Console.WriteLine(" Give trainer's last name (ex. Chamilos): ");
			LastName = Console.ReadLine();
			Console.WriteLine(" Give trainer's subject (ex. CB11): ");
			Subject = Console.ReadLine();
			Console.WriteLine(" Give Course ID to assign the trainer in a specific course or give 0 to skip this step: ");
			TrainerCourseID = ValidateGivenID();
		} //--- SetTrainer method end ---//

	} //--- class Trainer end ---//

} //--- namespace end ---//
