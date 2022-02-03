namespace LEARNING_CONCEPTS
{
	public class Utility1
	{
		public string ConvertMiladiToShamsi(System.DateTime dateTime)
		{
			return null;
		}
	}
}

























namespace LEARNING_CONCEPTS
{
	public class Utility2
	{
		public static string ConvertMiladiToShamsi(System.DateTime dateTime)
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

		public static string ConvertMiladiToShamsi(System.DateTime dateTime)
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

		public static string ConvertMiladiToShamsi(System.DateTime dateTime)
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

		public static string ConvertMiladiToShamsi(System.DateTime dateTime)
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
//		public static string ConvertMiladiToShamsi(System.DateTime dateTime)
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
		public static string ConvertMiladiToShamsi(System.DateTime dateTime)
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
		public static string ConvertMiladiToShamsi(System.DateTime dateTime)
		{
			System.Globalization.PersianCalendar
				persianCalendar = new System.Globalization.PersianCalendar();

			int year =
				persianCalendar.GetYear(dateTime);

			int month =
				persianCalendar.GetMonth(dateTime);

			int day =
				persianCalendar.GetDayOfMonth(dateTime);

			// **************************************************
			//string result =
			//	year + "/" + month + "/" + day;

			//string result =
			//	string.Format("{0}/{1}/{2}", year, month, day);

			//string result =
			//	$"{year}/{month}/{day}";

			//string result =
			//	$"{ year }/{ month }/{ day }";

			//return result;
			// **************************************************

			// **************************************************
			// ایراد دستورات فوق
			// **************************************************
			//1397/11/17 -> 1397/11/17 -> OK
			//1397/1/17  -> 1397/01/17
			//1397/11/7  -> 1397/11/07
			//1397/1/7   -> 1397/01/07
			// **************************************************

			// **************************************************
			string dayString =
				day.ToString().PadLeft(totalWidth: 2, paddingChar: '0');

			string monthString =
				month.ToString().PadLeft(totalWidth: 2, paddingChar: '0');

			string result =
				$"{ year }/{ monthString }/{ dayString }";

			return result;
			// **************************************************
		}
	}
}



namespace LEARNING_CONCEPTS
{
	public static class Utility
	{
		public static PersianDate ConvertMiladiToShamsi(System.DateTime dateTime)
		{
			System.Globalization.PersianCalendar
				persianCalendar = new System.Globalization.PersianCalendar();

			int year =
				persianCalendar.GetYear(dateTime);

			int month =
				persianCalendar.GetMonth(dateTime);

			int day =
				persianCalendar.GetDayOfMonth(dateTime);

			// **************************************************
			//PersianDate persianDate = new PersianDate();

			//persianDate.Day = day;
			//persianDate.Year = year;
			//persianDate.Month = month;
			// **************************************************

			// **************************************************
			//PersianDate persianDate =
			//	new PersianDate() { Year = year, Month = month, Day = day };
			// **************************************************

			// **************************************************
			//PersianDate persianDate =
			//	new PersianDate()
			//	{
			//		Year = year,
			//		Month = month,
			//		Day = day
			//	};
			// **************************************************

			// **************************************************
			//PersianDate persianDate =
			//	new PersianDate
			//	{
			//		Year = year,
			//		Month = month,
			//		Day = day
			//	};
			// **************************************************

			// **************************************************
			//PersianDate persianDate =
			//	new PersianDate
			//	{
			//		Year = year,
			//		Month = month,
			//		Day = day,
			//	};
			// **************************************************

			// **************************************************
			//PersianDate persianDate =
			//	new PersianDate
			//	{
			//		Day = day,
			//		Year = year,
			//		Month = month,
			//	};
			// **************************************************

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
			//text =
			//	text.Trim();

			//return text;
			// **************************************************

			// **************************************************
			//if (text == null)
			//{
			//	return null;
			//}

			//text =
			//	text.Trim();

			//return text;
			// **************************************************

			// **************************************************
			//if (text == null)
			//{
			//	return null;
			//}

			//text =
			//	text.Trim();

			// روش احمقانه

			//text = text.Replace("     ", " ");
			//text = text.Replace("    ", " ");
			//text = text.Replace("   ", " ");
			//text = text.Replace("  ", " ");

			//return text;
			// **************************************************

			// **************************************************
			if (text == null)
			{
				return null;
			}

			text =
				text.Trim();

			while (text.Contains("  "))
			{
				text =
					text.Replace("  ", " ");
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
