using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatzis_konstantinos_IndividualProject_part_a
{
	class HelperClass
	{
		public DateTime ValidateDateTime() 
		{
			DateTime ValidDateTime = new DateTime();
			bool IsValid = false;
			while (!IsValid)
			{
				IsValid = DateTime.TryParse(Console.ReadLine(), out ValidDateTime);
				if (!IsValid)
				{
					Console.WriteLine(" The Date you gave was not valid!!! ");
					Console.WriteLine(" The correct format is: YYYY,MM,DD ");
					Console.ReadKey();
				}				
			}
			return ValidDateTime;

		} //--- ValidateDateTime method end ---//

		public int ValidateMark() 
		{
			int ValidInt = 0;
			bool IsValid = false;
			while (!IsValid)
			{
				IsValid = Int32.TryParse(Console.ReadLine(), out ValidInt);
				if (!IsValid)
				{

					Console.WriteLine(" The number you gave was not valid!!! ");
					Console.WriteLine(" Please give a valid value (integer) ");
					// Console.ReadKey();

					if (IsValid && ValidInt < 0)
					{
						ValidInt = 0;
					}
					else if (IsValid && ValidInt > 100)
					{
						ValidInt = 100;
					}
				}
				else
				{
					if (ValidInt < 0)
					{
						ValidInt = 0;
					}
					else if (ValidInt > 100)
					{
						ValidInt = 100;
					}
				}
			}

			return ValidInt;

		} //--- ValidateMark method end ---//

		public int ValidateTuitionFees()
		{
			int ValidInt = 0;
			bool IsValid = false;
			while (!IsValid)
			{
				IsValid = Int32.TryParse(Console.ReadLine(), out ValidInt);
				if (!IsValid)
				{
					Console.WriteLine(" The number you gave was not valid!!! ");
					Console.WriteLine(" Please give a valid value (integer) ");

					if (IsValid && ValidInt < 0)
					{
						ValidInt = 0;
					}
					else if (IsValid && ValidInt > 50000)
					{
						ValidInt = 50000;
					}
				}
				else
				{
					if (ValidInt < 0)
					{
						ValidInt = 0;
					}
					else if (ValidInt > 50000)
					{
						ValidInt = 50000;
					}
				}
			}

			return ValidInt;

		} //--- ValidateTuitionFees method end ---//

		public int ValidateGivenID()
		{
			int ValidInt = 0;
			bool IsValid = false;
			while (!IsValid)
			{
				IsValid = Int32.TryParse(Console.ReadLine(), out ValidInt);
				if (!IsValid)
				{
					Console.WriteLine(" The number you gave was not valid!!! ");
					Console.WriteLine(" Please give a valid value (integer) ");
				}
			}

			return ValidInt;

		} //--- ValidateGivenID method end ---//

	} //--- HelperClass end ---//

} //--- namespace end ---//
