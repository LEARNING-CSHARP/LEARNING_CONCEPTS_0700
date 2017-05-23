namespace LEARNING_CONCEPTS
{
	public class PersianDate
	{
		public PersianDate()
		{
		}

		public int Day { get; set; }

		public int Month { get; set; }

		public int Year { get; set; }

		public string GetString()
		{
			string strResult =
				string.Format("{0}/{1}/{2}",
				Year, Month.ToString().PadLeft(2, '0'), Day.ToString().PadLeft(2, '0'));

			return (strResult);
		}
	}
}
