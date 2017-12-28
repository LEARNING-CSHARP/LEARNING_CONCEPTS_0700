namespace LEARNING_CONCEPTS
{
	class Program
	{
		static void Main(string[] args)
		{
			// **************************************************
			SomeClass someClass1 = new SomeClass();

			someClass1.PublicField = 10;
			//someClass1._privateField = 20;
			//someClass1.PublicStaticField = 30;
			//someClass1._privateStaticField = 40;
			// **************************************************

			// **************************************************
			//SomeClass.PublicField = 10;
			//SomeClass._privateField = 20;
			SomeClass.PublicStaticField = 30;
			//SomeClass._privateStaticField = 40;
			// **************************************************

			// **************************************************
			//Utility utility = new Utility();
			//utility.ConvertMiladiToShamsi();
			// **************************************************

			// **************************************************
			//Utility.ConvertMiladiToShamsi();
			// **************************************************

			// **************************************************
			//string shamsi =
			//	Utility.ConvertMiladiToShamsi(System.DateTime.Now);

			//System.Console.WriteLine(shamsi);
			// **************************************************

			// **************************************************
			PersianDate persinDate =
				Utility.ConvertMiladiToShamsi(System.DateTime.Now);

			System.Console.WriteLine(persinDate.GetString());
			System.Console.WriteLine("Month: " + persinDate.Month);
			// **************************************************

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
