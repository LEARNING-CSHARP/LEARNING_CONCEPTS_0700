namespace LEARNING_CONCEPTS
{
	public class Utility1
	{
		public string ConvertMiladiToShamsi(System.DateTime date)
		{
			return null;
		}
	}
}

























namespace LEARNING_CONCEPTS
{
	public class Utility2
	{
		public static string ConvertMiladiToShamsi(System.DateTime date)
		{
			return null;
		}
	}
}



namespace LEARNING_CONCEPTS
{
	public class Utility3
	{
		private Utility3()
		{
		}

		public static string ConvertMiladiToShamsi(System.DateTime date)
		{
			return null;
		}
	}
}



namespace LEARNING_CONCEPTS
{
	public sealed class Utility4
	{
		private Utility4()
		{
		}

		public static string ConvertMiladiToShamsi(System.DateTime date)
		{
			return null;
		}
	}
}



namespace LEARNING_CONCEPTS
{
	public sealed class Utility5
	{
		private Utility5()
		{
		}

		public static string ConvertMiladiToShamsi(System.DateTime date)
		{
			return null;
		}

		public System.DateTime ConvertShamsiToMiladi(string persianDate)
		{
			return System.DateTime.Now;
		}
	}
}



//namespace LEARNING_CONCEPTS
//{
//	public static class Utility6
//	{
//		public static string ConvertMiladiToShamsi(System.DateTime date)
//		{
//			return null;
//		}

//		public System.DateTime ConvertShamsiToMiladi(string persianDate)
//		{
//			return System.DateTime.Now;
//		}
//	}
//}



namespace LEARNING_CONCEPTS
{
	public static class Utility7
	{
		public static string ConvertMiladiToShamsi(System.DateTime date)
		{
			return null;
		}

		public static System.DateTime ConvertShamsiToMiladi(string persianDate)
		{
			return System.DateTime.Now;
		}
	}
}



namespace LEARNING_CONCEPTS
{
	public static class Utility8
	{
		public static string ConvertMiladiToShamsi(System.DateTime time)
		{
			System.Globalization.PersianCalendar
				persianCalendar = new System.Globalization.PersianCalendar();

			int year =
				persianCalendar.GetYear(time);

			int month =
				persianCalendar.GetMonth(time);

			int day =
				persianCalendar.GetDayOfMonth(time);

			//string result =
			//	year + "/" + month + "/" + day;

			//string result =
			//	string.Format("{0}/{1}/{2}", year, month, day);

			//string result =
			//	$"{year}/{month}/{day}";

			//string result =
			//	$"{ year }/{ month }/{ day }";

			//ایراد

			//1397/11/17 -> 1397/11/17 -> OK
			//1397/1/17  -> 1397/01/17
			//1397/11/7  -> 1397/11/07
			//1397/1/7   -> 1397/01/07

			string result =
				$"{ year }/{ month.ToString().PadLeft(2, '0') }/{ day.ToString().PadLeft(2, '0') }";

			return result;
		}
	}
}



namespace LEARNING_CONCEPTS
{
	public static class Utility
	{
		public static PersianDate ConvertMiladiToShamsi(System.DateTime time)
		{
			System.Globalization.PersianCalendar
				persianCalendar = new System.Globalization.PersianCalendar();

			int year =
				persianCalendar.GetYear(time);

			int month =
				persianCalendar.GetMonth(time);

			int day =
				persianCalendar.GetDayOfMonth(time);

			//PersianDate persianDate = new PersianDate();

			//persianDate.Day = day;
			//persianDate.Year = year;
			//persianDate.Month = month;

			//PersianDate persianDate =
			//	new PersianDate() { Year = year, Month = month, Day = day };

			PersianDate persianDate =
				new PersianDate(year: year, month: month, day: day);

			return persianDate;
		}
	}
}



namespace LEARNING_CONCEPTS
{
	public static class NewUtility
	{
		/// <summary>
		/// "        Ali                Reza                         Alavi        "
		/// ->
		/// "Ali Reza Alavi"
		/// </summary>
		public static string FixText(string text)
		{
			// **************************************************
			//return text;
			// **************************************************

			// **************************************************
			//text = text.Trim();

			//return text;
			// **************************************************

			// **************************************************
			//if (text == null)
			//{
			//	return string.Empty;
			//}

			//text = text.Trim();

			//return text;
			// **************************************************

			// **************************************************
			//if (text == null)
			//{
			//	return string.Empty;
			//}

			//text = text.Trim();

			//text = text.Replace("  ", " ");
			//text = text.Replace("   ", " ");
			//text = text.Replace("    ", " ");
			//text = text.Replace("     ", " ");

			// روش احمقانه

			//return text;
			// **************************************************

			// **************************************************
			if (text == null)
			{
				return string.Empty;
			}

			text = text.Trim();

			while (text.Contains("  "))
			{
				text = text.Replace("  ", " ");
			}

			return text;
			// **************************************************

			// "Ali     Reza Alavi"
			// "Ali   Reza Alavi"
			// "Ali  Reza Alavi"
			// "Ali Reza Alavi"
		}
	}
}
