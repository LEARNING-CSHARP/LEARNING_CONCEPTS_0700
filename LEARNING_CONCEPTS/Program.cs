﻿namespace LEARNING_CONCEPTS
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
			Utility1 utility1 = new Utility1();

			string shamsi1 =
				utility1.ConvertMiladiToShamsi(System.DateTime.Now);
			// **************************************************

			// **************************************************
			string shamsi2 =
				Utility2.ConvertMiladiToShamsi(System.DateTime.Now);
			// **************************************************

			// **************************************************
			string shamsi8 =
				Utility8.ConvertMiladiToShamsi(System.DateTime.Now);

			System.Console.WriteLine(shamsi8);
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
