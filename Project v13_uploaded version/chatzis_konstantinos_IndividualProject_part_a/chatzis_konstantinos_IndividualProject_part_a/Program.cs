using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace chatzis_konstantinos_IndividualProject_part_a
{
	class Program
	{
		static void Main(string[] args)
		{

			// all the variables //
			string ProjectName = "\n\n IndividualProject_Part_A \n\n";
			string AppName = "CreateYourOwnUniversityCampus.exe";
			string AppDescription = "Here you can create your own University, which can contain lists of courses, trainers, students and assignments!" +
				" After creating your data you can search and display them via their unique ID. Have fun :)";
			string ContinueOrExit = string.Empty;
			string User1stChoice = string.Empty;
			string User2ndChoice = string.Empty;
			bool SyntheticDataUsed = false;
			bool ListObjectFound = false; // display correct results through the complex foreach //

			// all the lists //
			List<Course> CourseList = new List<Course>();
			List<Trainer> TrainerList = new List<Trainer>();
			List<Student> StudentList = new List<Student>();
			List<Assignment> AssignmentList = new List<Assignment>();

			// Project's Start //
			Print(ProjectName);
			Print(" If you wish to continue give any input :) If not, write 'E' or 'e' and press 'Enter' to exit :( ");
			ContinueOrExit = Console.ReadLine();

			if (ContinueOrExit == "E" || ContinueOrExit == "e")
			{
				Console.Clear();
				Print(" Thank you and goodbye :( Press any key to exit... ");
				Console.ReadKey();
				Environment.Exit(0);
			}

			Console.Clear();
			Console.WriteLine("\n Welcome to {0} \n", AppName);
			Console.WriteLine(" {0} ", AppDescription);
			Print("\n\n Press any key to continue... ");
			Console.ReadLine();
			Console.Clear();

			// user's first choice //
			while (User1stChoice != "0")
			{
				
				Print(" To proceed you need to add values in your lists! ");
				Print("\n To add Courses select 1 ");
				Print("\n To add Trainers select 2 ");
				Print("\n To add Students select 3 ");
				Print("\n To add Assignments select 4 ");
				Print("\n To create Synthetic Data select 5 ");
				Print("\n To stop adding data select 0 ");
				Print("\n To exit the program write 'E' or 'e' and press 'Enter' ");
				Print("\n\n What would you like to do? -----> ");
				User1stChoice = Console.ReadLine();
				Console.Clear();

				if (User1stChoice == "E" || User1stChoice == "e")
				{

					Print(" Thank you and goodbye :( Press any key to exit... ");
					Console.ReadKey();
					Environment.Exit(0);

				}
				else if (User1stChoice == "1") // add Courses //
				{

					do
					{
						Course course = new Course();
						course.SetCourse();
						CourseList.Add(course);
						CourseList.Count();
						Console.Clear();
						Console.WriteLine(" Select 0 to stop adding Courses or press any other key to add more! ");
					} while (Console.ReadLine() != "0");

				} // Courses end //
				else if (User1stChoice == "2") // add Trainers //
				{

					do
					{
						Trainer trainer = new Trainer();
						trainer.SetTrainer();
						TrainerList.Add(trainer);
						Console.Clear();
						Console.WriteLine(" Select 0 to stop adding Trainers or press any other key to add more! ");
					} while (Console.ReadLine() != "0");

				} // Trainers end //
				else if (User1stChoice == "3") // add Students //
				{

					do
					{
						Student student = new Student();
						student.SetStudent();
						StudentList.Add(student);
						Console.Clear();
						Console.WriteLine(" Select 0 to stop adding Students or press any other key to add more! ");
					} while (Console.ReadLine() != "0");

				} // Students end //
				else if (User1stChoice == "4") // add Assignment //
				{

					do
					{
						Assignment assignment = new Assignment();
						assignment.SetAssignment();
						AssignmentList.Add(assignment);
						Console.Clear();
						Console.WriteLine(" Select 0 to stop adding Assignments or press any other key to add more! ");
					} while (Console.ReadLine() != "0");

				} // Assignment end //
				else if (User1stChoice == "5") // add synthetic data //
				{
					if (SyntheticDataUsed == false)
					{
						Course course1 = new Course(" Coding BootCamp 11", "c#", "part-time", new DateTime(2020, 09, 15), new DateTime(2021, 03, 15));
						Course course2 = new Course(" Coding BootCamp 11", "Java", "part-time", new DateTime(2020, 09, 15), new DateTime(2021, 03, 15));
						Course course3 = new Course(" Coding BootCamp 11", "Javascript", "full-time", new DateTime(2020, 09, 15), new DateTime(2020, 12, 15));
						Course course4 = new Course(" Coding BootCamp 11", "Python", "full-time", new DateTime(2020, 09, 15), new DateTime(2020, 12, 15));
						CourseList.Add(course1);
						CourseList.Add(course2);
						CourseList.Add(course3);
						CourseList.Add(course4);
						Trainer trainer1 = new Trainer(" Michalis", "Chamilos", "c#",4);
						Trainer trainer2 = new Trainer(" Georgios", "Pasparakis", "Java",4);
						Trainer trainer3 = new Trainer(" Aliki", "Tsirozidi", "Soft Skills",3);
						Trainer trainer4 = new Trainer(" Ansgar", "Endress", "Python",1);
						TrainerList.Add(trainer1);
						TrainerList.Add(trainer2);
						TrainerList.Add(trainer3);
						TrainerList.Add(trainer4);
						Student student1 = new Student(" Vasileios", "Papakostas", new DateTime(1996, 10, 17), 9500, 4,4);
						Student student2 = new Student(" Maria", "Mayer", new DateTime(1990, 07, 30), 4500, 3,3);
						Student student3 = new Student(" Joel", "Kostadinov", new DateTime(1996, 05, 22), 6000, 2,2);
						Student student4 = new Student(" Ellie", "Miller", new DateTime(2000, 03, 05), 16000, 1,1);
						StudentList.Add(student1);
						StudentList.Add(student2);
						StudentList.Add(student3);
						StudentList.Add(student4);
						Assignment assignment1 = new Assignment(" Project A", "Create a Calculator app", new DateTime(2020, 11, 27), 58, 65,4);
						Assignment assignment2 = new Assignment(" Project B", "Create a Messenger app", new DateTime(2020, 12, 23), 51, 72,3);
						Assignment assignment3 = new Assignment(" Project C", "Create a Maps app", new DateTime(2020, 10, 12), 85, 49,2);
						Assignment assignment4 = new Assignment(" Project D", "Create a Bank app", new DateTime(2020, 11, 09), 63, 74,1);
						AssignmentList.Add(assignment1);
						AssignmentList.Add(assignment2);
						AssignmentList.Add(assignment3);
						AssignmentList.Add(assignment4);

						SyntheticDataUsed = true;
					}
					else
					{
						Print(" You already gave synthetic data! Press any key to continue... ");
						Console.ReadKey();
					}
				} // synthetic data end //
				else
				{
					if (User1stChoice != "0")
					{
						Print(" The input you gave is not valid! Please select a number from 0 - 5! Press any key to continue... ");
						Console.ReadKey();
					}			
				}

				Console.Clear();

			}

			while (User2ndChoice != "0")
			{
				// start the display //
				Print(" Your data is set! ");
				Print("\n To display the list of Courses select 1 ");
				Print("\n To display the list of Trainers select 2 ");
				Print("\n To display the list of Students select 3 ");
				Print("\n To display the list of Assignments select 4 ");
				Print("\n To display Students per Course select 5 ");
				Print("\n To display Trainers per Course select 6 ");
				Print("\n To display Assignments per Course select 7 ");
				Print("\n To display Assignments per Student select 8 ");
				Print("\n To proceed select 0 ");
				Print("\n\n What would you like to do? -----> ");
				User2ndChoice = Console.ReadLine();
				Console.Clear();

				if (User2ndChoice == "1") // list of Courses //
				{
					Console.WriteLine("\n List of Courses: \n");

					if (CourseList.Count > 0)
					{
						foreach (var item in CourseList)
						{
							Console.WriteLine(" ID: {0}, {1}, {2}, {3}, {4}, {5} ", item.CourseID, item.Title, item.Stream, item.Type, item.StartDate, item.EndDate);
						}
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("\n The Courses List is empty! ");
						Console.ForegroundColor = ConsoleColor.White;
					}

					Print("\n  Press any key to continue... ");
					Console.ReadKey();
					Console.Clear();

				} // list of Courses end //
				else if (User2ndChoice == "2") // list of Trainers //
				{

					Console.WriteLine("\n List of Trainers: \n");
					if (TrainerList.Count > 0)
					{
						foreach (var item in TrainerList)
						{
							Console.WriteLine(" ID: {0}, {1}, {2}, {3} ", item.TrainerID, item.FirstName, item.LastName, item.Subject);
						}
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("\n The Trainers List is empty! ");
						Console.ForegroundColor = ConsoleColor.White;
					}

					Print("\n Press any key to continue... ");
					Console.ReadKey();
					Console.Clear();

				}
				else if (User2ndChoice == "3") // list of Students //
				{
					Console.WriteLine("\n List of Students: \n");

					if (StudentList.Count > 0) 
					{
						foreach (var item in StudentList)
						{
							Console.WriteLine(" ID: {0}, {1}, {2}, {3}, {4} ", item.StudentID, item.FirstName, item.LastName, item.DateofBirth, item.TuitionFees);
						}
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("\n The Students List is empty! ");
						Console.ForegroundColor = ConsoleColor.White;
					}

					Print("\n Press any key to continue... ");
					Console.ReadKey();
					Console.Clear();

				} // list of Students end //
				else if (User2ndChoice == "4") // list of Assignments //
				{

					Console.WriteLine("\n List of Assignments: \n");

					if (AssignmentList.Count > 0) 
					{
						foreach (var item in AssignmentList)
						{
							Console.WriteLine(" ID: {0}, {1}, {2}, {3}, {4}, {5} ", item.AssignmentID, item.Title, item.Description, item.SubmDate, item.OralMark, item.TotalMark);
						}
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("\n The Assignments List is empty! ");
						Console.ForegroundColor = ConsoleColor.White;
					}

					Print("\n Press any key to continue... ");
					Console.ReadKey();
					Console.Clear();

				} // list of Assignments end //
				else if (User2ndChoice == "5") // Students per Course //
				{

					Console.WriteLine("\n List of Students per Course: \n");

					if ((CourseList.Count > 0) && (StudentList.Count > 0))
					{
						foreach (var course in CourseList)
						{
							foreach (var student in StudentList)
							{
								if (course.CourseID == student.StudentCourseID)
								{
									if (!ListObjectFound)
									{
										Console.ForegroundColor = ConsoleColor.Yellow;
										Console.WriteLine("\n Course ID: {0}, Course Name: {1}, {2} \n",course.CourseID, course.Title, course.Stream);
										Console.ForegroundColor = ConsoleColor.White;
										ListObjectFound = true;
									}

									Console.WriteLine("     Student: {0}, {1}, {2}, {3}, {4} ", student.StudentID, student.FirstName, student.LastName, student.DateofBirth, student.TuitionFees);

								}
							}

							ListObjectFound = false;

						}
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("\n The Students List or the Courses List is empty.");
						Console.ForegroundColor = ConsoleColor.White;
					}

					Print("\n Press any key to continue... ");
					Console.ReadKey();
					Console.Clear();

				} // Students per Course end //
				else if (User2ndChoice == "6") // Trainers per Course //
				{
					ListObjectFound = false;
					Console.WriteLine("\n List of Trainers per Course: \n");

					if ((CourseList.Count > 0) && (TrainerList.Count > 0))
					{
						foreach (var course in CourseList)
						{

							foreach (var trainer in TrainerList)
							{
								if (course.CourseID == trainer.TrainerCourseID)
								{
									if (!ListObjectFound)
									{
										Console.ForegroundColor = ConsoleColor.Yellow;
										Console.WriteLine("\n Course ID: {0}, Course Name: {1}, {2} \n", course.CourseID, course.Title, course.Stream);
										Console.ForegroundColor = ConsoleColor.White;
										ListObjectFound = true;
									}
									Console.WriteLine("    Trainer ID: {0}, Trainer Fullname: {1} {2} ", trainer.TrainerID, trainer.FirstName, trainer.LastName);

								}

							}
							ListObjectFound = false;
						}
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("\n The Trainers List or the Courses List is empty.");
						Console.ForegroundColor = ConsoleColor.White;
					}

					Print("\n Press any key to continue... ");
					Console.ReadKey();
					Console.Clear();

				} // Trainers per Course end //
				else if (User2ndChoice == "7") // Assignments per Course //
				{
					ListObjectFound = false;
					Console.WriteLine("\n List of Assignments per Course: \n");

					if ((AssignmentList.Count > 0) && (CourseList.Count > 0))
					{
						foreach (var course in CourseList)
						{

							foreach (var assignment in AssignmentList)
							{
								if (assignment.AssignmentCourseID == course.CourseID)
								{
									
									if (!ListObjectFound)
									{
										Console.ForegroundColor = ConsoleColor.Yellow;
										Console.WriteLine("\n Course ID: {0}, Course Name: {1}, {2} \n", course.CourseID, course.Title, course.Stream);
										Console.ForegroundColor = ConsoleColor.White;
										ListObjectFound = true;
									}

									Console.WriteLine("     Assignment ID: {0}, Assignment Details: {1}, {2}, {3} ",assignment.AssignmentID, assignment.Title, assignment.Description, assignment.SubmDate);

								}

							}

							ListObjectFound = false;
						}
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("\n The Assignments List or the Students List is empty.");
						Console.ForegroundColor = ConsoleColor.White;
					}

					Print("\n Press any key to continue... ");
					Console.ReadKey();
					Console.Clear();

				} // Assignments per Course end //
				else if (User2ndChoice == "8") // Assignments per Student //
				{
					ListObjectFound = false;
					Console.WriteLine("\n List of Assignments per Student: \n");
					if ((AssignmentList.Count > 0) && (StudentList.Count > 0))
					{
						foreach (var student in StudentList)
						{

							foreach (var assignment in AssignmentList)
							{
								if (assignment.AssignmentID == student.StudentAssignmentID)
								{
									if (!ListObjectFound)
									{
										Console.ForegroundColor = ConsoleColor.Yellow;
										Console.WriteLine("\n Student: {0}, {1}, {2}, {3}, {4} ", student.StudentID, student.FirstName, student.LastName, student.DateofBirth, student.TuitionFees);
										Console.ForegroundColor = ConsoleColor.White;
										ListObjectFound = true;
									}

									Console.WriteLine("     Assignment ID: {0}, Assignment Details: {1}, {2}, {3} ", assignment.AssignmentID, assignment.Title, assignment.Description, assignment.SubmDate);
								}

							}

							ListObjectFound = false;

						}
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("\n The Assignments List or the Students List is empty.");
						Console.ForegroundColor = ConsoleColor.White;
					}

					Print("\n Press any key to continue... ");
					Console.ReadKey();
					Console.Clear();

				} // Assignments per Student end //
				 
			} // while (User2ndChoice != "0") end //
			
			// the end for now //
			Print(" ----- The End ----- ");
			Print("\n Press any key to continue... ");
			Console.ReadKey();
			Console.Clear();

		} //--- Main end ---//

		public static void Print(string message) // A simple method instead of Console.WriteLine(); //
		{
			Console.WriteLine(message);
		}

	} //--- class Program end ---//

} //--- namespace end ---//
