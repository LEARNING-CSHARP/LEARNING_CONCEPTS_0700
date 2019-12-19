namespace LEARNING_CONCEPTS
{
	internal static class Program
	{
		static Program()
		{
		}

		internal static void Main(string[] args)
		{
			// **************************************************
			SomeClass someClass = new SomeClass();

			someClass.PublicField = 10;
			//someClass.privateField = 20;

			//someClass.PublicStaticField = 30;
			//someClass.privateStaticField = 40;
			// **************************************************

			// **************************************************
			//SomeClass.PublicField = 10;
			//SomeClass.privateField = 20;

			SomeClass.PublicStaticField = 30;
			//SomeClass.privateStaticField = 40;
			// **************************************************

			// **************************************************
			Utility1 utility1 = new Utility1();

			string shamsi1 =
				utility1.ConvertMiladiToShamsi(System.DateTime.Now);
			// **************************************************

			// **************************************************
			string shamsi2 =
				Utility2.ConvertMiladiToShamsi(System.DateTime.Now);
			// **************************************************

			// **************************************************
			//string shamsi8 =
			//	Utility8.ConvertMiladiToShamsi(System.DateTime.Now);

			//System.Console.WriteLine(shamsi8);

			//// shamsi8 = "1397/11/01"

			////int monthInt =
			////	System.Convert.ToInt32(shamsi8.Substring(startIndex: 5, length: 2));

			////System.Console.WriteLine($"Month: { monthInt }");
			// **************************************************

			// **************************************************
			//PersianDate persianDate =
			//	Utility.ConvertMiladiToShamsi(System.DateTime.Now);

			//System.Console.WriteLine(persianDate.GetString());
			//System.Console.WriteLine("Day: " + persianDate.Day);
			//System.Console.WriteLine("Month: " + persianDate.Month);
			//System.Console.WriteLine("Year: " + persianDate.Year);
			// **************************************************

			// **************************************************
			//System.DateTime birthDate = System.DateTime.Now;

			System.DateTime birthDate =
				new System.DateTime(year: 1973, month: 2, day: 17);

			PersianDate persianDate =
				Utility.ConvertMiladiToShamsi(birthDate);

			System.Console.WriteLine(persianDate.GetString());
			System.Console.WriteLine("Day: " + persianDate.Day);
			System.Console.WriteLine("Month: " + persianDate.Month);
			System.Console.WriteLine("Year: " + persianDate.Year);
			// **************************************************

			System.Console.Write("Press [ENTER] To Exit... ");
			System.Console.ReadLine();
		}
	}
}
