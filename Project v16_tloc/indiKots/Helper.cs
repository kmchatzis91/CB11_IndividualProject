using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indiKots
{
	class Helper
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
					dtMess();
				}
			}

			return ValidDateTime;

		} //--- public DateTime ValidateDateTime() end ---//

		public int ValidateMark()
		{
			int ValidInt = 0;
			bool IsValid = false;
			while (!IsValid)
			{
				IsValid = Int32.TryParse(Console.ReadLine(), out ValidInt);
				if (!IsValid)
				{
					intMess();

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

		} //--- public int ValidateMark() end ---//

		public int ValidateTuitionFees()
		{
			int ValidInt = 0;
			bool IsValid = false;
			while (!IsValid)
			{
				IsValid = Int32.TryParse(Console.ReadLine(), out ValidInt);
				if (!IsValid)
				{
					intMess();

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

		} //--- public int ValidateTuitionFees() end ---//

		public int ValidateGivenID()
		{
			int ValidInt = 0;
			bool IsValid = false;
			while (!IsValid)
			{
				IsValid = Int32.TryParse(Console.ReadLine(), out ValidInt);
				if (!IsValid)
				{
					intMess();
				}
			}

			return ValidInt;

		} //--- public int ValidateGivenID() end ---//

		public void dtMess() 
		{
			Console.WriteLine(" The Date you gave was not valid!!! ");
			Console.WriteLine(" The correct format is: YYYY,MM,DD ");

		} //--- public void dtMess() end ---//

		public void intMess()
		{
			Console.WriteLine(" The number you gave was not valid!!! ");
			Console.WriteLine(" Please give a valid value (integer) ");

		} //--- public void intMess() end ---//

	} //--- class Helper end ---//

} //--- namespace end ---//
