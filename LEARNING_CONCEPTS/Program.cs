namespace LEARNING_CONCEPTS
{
	class Program
	{
		static void Main(string[] args)
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
			//Utility utility = new Utility();
			//string shamsi =
			//	utility.ConvertMiladiToShamsi(System.DateTime.Now);
			// **************************************************

			// **************************************************
			//string shamsi =
			//	Utility.ConvertMiladiToShamsi(System.DateTime.Now);
			// **************************************************

			// **************************************************
			//string shamsi =
			//	Utility.ConvertMiladiToShamsi(System.DateTime.Now);

			//System.Console.WriteLine(shamsi);
			// **************************************************

			// **************************************************
			PersianDate persianDate =
				Utility.ConvertMiladiToShamsi(System.DateTime.Now);

			System.Console.WriteLine(persianDate.GetString());
			System.Console.WriteLine("Month: " + persianDate.Month);
			// **************************************************

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
