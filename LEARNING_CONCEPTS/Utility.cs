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
	//			oPersianCalendar = new System.Globalization.PersianCalendar();

	//		int intYear =
	//			oPersianCalendar.GetYear(time);

	//		int intMonth =
	//			oPersianCalendar.GetMonth(time);

	//		int intDay =
	//			oPersianCalendar.GetDayOfMonth(time);

	//		string strResult =
	//			string.Format("{0}/{1}/{2}",
	//			intYear, intMonth.ToString().PadLeft(2, '0'), intDay.ToString().PadLeft(2, '0'));

	//		return (strResult);
	//	}
	//}

	public static class Utility
	{
		public static PersianDate ConvertMiladiToShamsi(System.DateTime time)
		{
			System.Globalization.PersianCalendar
				oPersianCalendar = new System.Globalization.PersianCalendar();

			int intYear =
				oPersianCalendar.GetYear(time);

			int intMonth =
				oPersianCalendar.GetMonth(time);

			int intDay =
				oPersianCalendar.GetDayOfMonth(time);

			PersianDate oPersianDate = new PersianDate();

			oPersianDate.Day = intDay;
			oPersianDate.Year = intYear;
			oPersianDate.Month = intMonth;

			return (oPersianDate);
		}
	}
}
