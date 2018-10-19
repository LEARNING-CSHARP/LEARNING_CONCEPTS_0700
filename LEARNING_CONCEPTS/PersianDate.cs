namespace LEARNING_CONCEPTS
{
	public class PersianDate
	{
		public PersianDate()
		{
		}

		public int Day;

		public int Month;

		public int Year;

		public string GetString()
		{
			string result =
				$"{ Year }/{ Month.ToString().PadLeft(2, '0') }/{ Day.ToString().PadLeft(2, '0') }";

			return result;
		}
	}
}
