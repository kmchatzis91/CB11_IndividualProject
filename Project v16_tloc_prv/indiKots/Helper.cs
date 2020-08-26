using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indiKots
{
	class Helper
	{
		public Helper() 
		{

		} //--- 1st constructor Helper end ---//

		protected DateTime ValidateDateTime()
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

		} //--- protected DateTime ValidateDateTime() end ---//

		protected int ValidateMark()
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

		} //--- protected int ValidateMark() end ---//

		protected int ValidateTuitionFees()
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

		} //--- protected int ValidateTuitionFees() end ---//

		protected int ValidateGivenID()
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

		} //---protected int ValidateGivenID() end ---//

		protected void dtMess() 
		{
			Console.WriteLine(" The Date you gave was not valid!!! ");
			Console.WriteLine(" The correct format is: YYYY,MM,DD ");

		} //--- protected void dtMess() end ---//

		protected void intMess()
		{
			Console.WriteLine(" The number you gave was not valid!!! ");
			Console.WriteLine(" Please give a valid value (integer) ");

		} //--- protected void intMess() end ---//

	} //--- class Helper end ---//

} //--- namespace end ---//
