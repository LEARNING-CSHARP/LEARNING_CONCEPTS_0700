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
			//string strTemp1 = "  Dariush Tasdighi   ";

			//string str01 = strTemp1.TrimStart(); // "Dariush Tasdighi   "
			//string str02 = strTemp1.TrimEnd(); // "  Dariush Tasdighi"
			//string str03 = strTemp1.Trim(); // "Dariush Tasdighi"
			//string str04 = strTemp1.Replace("Dariush", "Ali Reza"); // "  Ali Reza Tasdighi   "
			//string str05 = strTemp1.Replace(" ", ""); // "DariushTasdighi"
			//string str06 = strTemp1.Replace(" ", string.Empty); // "DariushTasdighi"
			//string str07 = strTemp1.ToUpper(); // "  DARIUSH TASDIGHI   "
			//string str08 = strTemp1.ToLower(); // "  DARIUSH TASDIGHI   "
			//string str09 = strTemp1.Remove(startIndex: 9); // "  Dariush"
			//string str10 = strTemp1.Remove(startIndex: 9, count: 3); // "  Dariushsdighi   "
			//string str11 = strTemp1.Substring(startIndex: 10); // "Tasdighi   "
			//string str12 = strTemp1.Substring(startIndex: 10, length: 8); // "Tasdighi"

			//string strTemp2 = "12345";

			//string str13 = strTemp2.PadLeft(10, '*'); // "*****12345"
			//string str14 = strTemp2.PadLeft(5, '*'); // "12345"
			//string str15 = strTemp2.PadRight(8, '*'); // "12345***"
			//string str16 = strTemp2.PadRight(5, '*'); // "12345"

			//bool bln1 = strTemp1.StartsWith("Ali"); // false
			//bool bln2 = strTemp1.EndsWith("Alavi"); // false
			//bool bln3 = strTemp1.Contains("Ali"); // false

			//int int1 = strTemp1.IndexOf("Dariush"); // 2
			//int int2 = strTemp1.IndexOf("Ali"); // -1
			//int int3 = strTemp1.LastIndexOf("Dariush"); // 2
			//int int4 = strTemp1.LastIndexOf("Ali"); // -1

			//int intLength = strTemp1.Length; // 22

			string strResult =
				string.Format("{0}/{1}/{2}",
				Year, Month.ToString().PadLeft(2, '0'), Day.ToString().PadLeft(2, '0'));

			return (strResult);
		}
	}
}
