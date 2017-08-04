namespace LEARNING_CONCEPTS
{
	class Program
	{
		static void Main(string[] args)
		{
			SomeClass oSomeClass1 = new SomeClass();

			oSomeClass1.PublicField = 10;
			//oSomeClass1._privateField = 20;
			//oSomeClass1.PublicStaticField = 30;
			//oSomeClass1._privateStaticField = 40;

			// هرگاه از کلاسی شیء بسازیم، پس از زدن نقطه بعد از نام آن شیء، تمام
			// Member
			// های
			// Public
			// و نیز
			// غیر
			// Static
			// را خواهیم دید یا اصطلاحا به آنها دسترسی داریم

			//SomeClass.PublicField = 10;
			//SomeClass._privateField = 20;
			SomeClass.PublicStaticField = 30;
			//SomeClass._privateStaticField = 40;

			// هرگاه بعد از نام کلاس، نقظه بزنیم، تمام
			// Member
			// های
			// Public
			// و نیز
			// Static
			// را خواهیم دید و یا اصطلاحا به آنها دسترسی خواهیم داشت

			//Utility oUtility = new Utility();
			//oUtility.ConvertMiladiToShamsi();

			//Utility.ConvertMiladiToShamsi();

			//string strShamsi =
			//	Utility.ConvertMiladiToShamsi(System.DateTime.Now);

			//System.Console.WriteLine(strShamsi);

			PersianDate oPersinDate =
				Utility.ConvertMiladiToShamsi(System.DateTime.Now);

			System.Console.WriteLine(oPersinDate.GetString());
			System.Console.WriteLine("Month: " + oPersinDate.Month);

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
