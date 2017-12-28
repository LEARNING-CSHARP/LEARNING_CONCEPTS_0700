namespace LEARNING_CONCEPTS
{
	//public class Utility
	//{
	//	public string ConvertMiladiToShamsi(System.DateTime date)
	//	{
	//		return (null);
	//	}
	//}




























	//public class Utility
	//{
	//	public static string ConvertMiladiToShamsi(System.DateTime date)
	//	{
	//		return (null);
	//	}
	//}

	//public class Utility
	//{
	//	private Utility()
	//	{
	//	}

	//	public static string ConvertMiladiToShamsi(System.DateTime date)
	//	{
	//		return (null);
	//	}
	//}

	//public sealed class Utility
	//{
	//	private Utility()
	//	{
	//	}

	//	public static string ConvertMiladiToShamsi(System.DateTime date)
	//	{
	//		return (null);
	//	}
	//}

	//public sealed class Utility
	//{
	//	private Utility()
	//	{
	//	}

	//	public static string ConvertMiladiToShamsi(System.DateTime date)
	//	{
	//		return (null);
	//	}

	//	public System.DateTime ConvertShamsiToMiladi(string persianDate)
	//	{
	//		return (System.DateTime.Now);
	//	}
	//}

	//public static class Utility
	//{
	//	public static string ConvertMiladiToShamsi(System.DateTime date)
	//	{
	//		return (null);
	//	}

	//	public System.DateTime ConvertShamsiToMiladi(string persianDate)
	//	{
	//		return (System.DateTime.Now);
	//	}
	//}

	//public static class Utility
	//{
	//	public static string ConvertMiladiToShamsi(System.DateTime date)
	//	{
	//		return (null);
	//	}

	//	public static System.DateTime ConvertShamsiToMiladi(string persianDate)
	//	{
	//		return (System.DateTime.Now);
	//	}
	//}

	//public static class Utility
	//{
	//	public static string ConvertMiladiToShamsi(System.DateTime time)
	//	{
	//		System.Globalization.PersianCalendar
	//			persianCalendar = new System.Globalization.PersianCalendar();

	//		int year =
	//			persianCalendar.GetYear(time);

	//		int month =
	//			persianCalendar.GetMonth(time);

	//		int day =
	//			persianCalendar.GetDayOfMonth(time);

	//		//string result =
	//		//	$"{year}/{month}/{day}";

	//		//string result =
	//		//	$"{ year }/{ month }/{ day }";

	//		string result =
	//			$"{ year }/{ month.ToString().PadLeft(2, '0') }/{ day.ToString().PadLeft(2, '0') }";

	//		return (result);
	//	}
	//}

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

			PersianDate persianDate = new PersianDate();

			persianDate.Day = day;
			persianDate.Year = year;
			persianDate.Month = month;

			return (persianDate);
		}

		/// <summary>
		/// "        Ali                Reza                         Alavi        "
		/// ->
		/// "Ali Reza Alavi"
		/// </summary>
		public static string FixText(string text)
		{
			// **************************************************
			//return (text);
			// **************************************************

			// **************************************************
			//text = text.Trim();

			//return (text);
			// **************************************************

			// **************************************************
			//if (text == null)
			//{
			//	return (string.Empty);
			//}

			//text = text.Trim();

			//return (text);
			// **************************************************

			// **************************************************
			//if (text == null)
			//{
			//	return (string.Empty);
			//}

			//text = text.Trim();

			//text = text.Replace("     ", " ");
			//text = text.Replace("    ", " ");
			//text = text.Replace("   ", " ");
			//text = text.Replace("  ", " ");

			//return (text);
			// **************************************************

			// **************************************************
			if (text == null)
			{
				return (string.Empty);
			}

			text = text.Trim();

			while (text.Contains("  "))
			{
				text = text.Replace("  ", " ");
			}

			return (text);
			// **************************************************

			// "Ali     Reza Alavi"
			// "Ali   Reza Alavi"
			// "Ali  Reza Alavi"
			// "Ali Reza Alavi"
		}
	}
}
