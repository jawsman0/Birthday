using System;
using System.IO;
using System.Diagnostics;
using System.Collections;


//Test
class Ethan
{
	public static int correct = 0;
	public static int Age = 0;
	public static string StringAge;
	public static string Correct;

	public static void Main ()
	{
		Console.WriteLine ("");
		System.Console.WriteLine ("How Old Are You?");
		System.Console.WriteLine ("");
		StringAge = System.Console.ReadLine ();

		if (int.TryParse (StringAge, out Age))
		{
			Console.WriteLine ("");
			other ();
		}else{
			Console.WriteLine ("");
			Console.WriteLine ("That Is Not A Number!!");
			Main ();
		}

		StringAge = Age.ToString ();

		if (StringAge == Age.ToString ())
		{
			Console.WriteLine ("Colour");
		}

		if (Age > 150)
		{
			Console.WriteLine ("It Is Very Unlikely To Be That Old Please Try This Again");
			Console.WriteLine ("");
			Main ();
		}else{
			Console.WriteLine ("");
		}
	}

		public static void other ()

		{
		System.Console.WriteLine ("Since You Are " + Age + " Years Old Next Year You'll Be...");
		Age = Age + 1;
		System.Console.WriteLine (Age + "!");
		System.Console.WriteLine ("");
		System.Console.WriteLine ("Am I Right y/n?");
		Correct = System.Console.ReadLine ();

		if (int.TryParse (Correct, out correct))
		{
			Console.WriteLine ("");
			Console.WriteLine ("That Is A Number Not A Choice For This");
			Console.WriteLine ("");
			other ();
		}else
		{
			Console.WriteLine ("");
			Console.WriteLine ("Good Choice");
		}

		if (Correct == "y")
		{
			System.Console.WriteLine ("");
			System.Console.WriteLine ("Wow! I am smart");
		}else if (Correct == "n")
		{
			System.Console.WriteLine ("");
			System.Console.WriteLine ("You Must Have Entered The Wrong Age Try Again!");
		}else 
		{
			System.Console.WriteLine ("");
			System.Console.WriteLine ("That Is Not A Answer!");
		}
	}
}