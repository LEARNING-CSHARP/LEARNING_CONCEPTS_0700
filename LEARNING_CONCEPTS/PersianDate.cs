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
			//string tempText = "  Dariush Tasdighi   ";

			//string str01 = tempText.TrimStart(); // "Dariush Tasdighi   "
			//string str02 = tempText.TrimEnd(); // "  Dariush Tasdighi"
			//string str03 = tempText.Trim(); // "Dariush Tasdighi"
			//string str04 = tempText.Replace("Dariush", "Ali Reza"); // "  Ali Reza Tasdighi   "
			//string str05 = tempText.Replace(" ", ""); // "DariushTasdighi"
			//string str06 = tempText.Replace(" ", string.Empty); // "DariushTasdighi"
			//string str07 = tempText.ToUpper(); // "  DARIUSH TASDIGHI   "
			//string str08 = tempText.ToLower(); // "  dariush tasdighi   "
			//string str09 = tempText.Remove(startIndex: 9); // "  Dariush"
			//string str10 = tempText.Remove(startIndex: 9, count: 3); // "  Dariushsdighi   "
			//string str11 = tempText.Substring(startIndex: 10); // "Tasdighi   "
			//string str12 = tempText.Substring(startIndex: 10, length: 8); // "Tasdighi"

			//string strTemp2 = "12345";

			//string str13 = strTemp2.PadLeft(10, '*'); // "*****12345"
			//string str14 = strTemp2.PadLeft(5, '*'); // "12345"
			//string str15 = strTemp2.PadRight(8, '*'); // "12345***"
			//string str16 = strTemp2.PadRight(5, '*'); // "12345"

			//bool bln1 = tempText.StartsWith("Ali"); // false
			//bool bln2 = tempText.EndsWith("Alavi"); // false
			//bool bln3 = tempText.Contains("Ali"); // false

			//int int1 = tempText.IndexOf("Dariush"); // 2
			//int int2 = tempText.IndexOf("Ali"); // -1
			//int int3 = tempText.LastIndexOf("Dariush"); // 2
			//int int4 = tempText.LastIndexOf("Ali"); // -1

			//int intLength = tempText.Length; // 22

			string result =
				$"{ Year }/{ Month.ToString().PadLeft(2, '0') }/{ Day.ToString().PadLeft(2, '0') }";

			return (result);
		}
	}
}
