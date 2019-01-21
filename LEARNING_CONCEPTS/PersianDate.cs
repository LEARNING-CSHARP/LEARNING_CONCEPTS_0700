namespace LEARNING_CONCEPTS
{
	public class PersianDate
	{
		//public PersianDate()
		//{
		//}

		public PersianDate(int year, int month, int day)
		{
			Day = day;
			Year = year;
			Month = month;
		}

		public int Day;

		public int Month;

		public int Year;

		public string GetString()
		{
			string dayString =
				Day.ToString().PadLeft(2, '0');

			string monthString =
				Month.ToString().PadLeft(2, '0');

			string result =
				$"{ Year }/{ monthString }/{ dayString }";

			return result;
		}
	}
}
