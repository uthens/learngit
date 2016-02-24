using System;

public class HelloGit
{
   public static void Main(string[] args)
	{

        Console.WriteLine("Hello Happy, World!");

        Console.WriteLine("Hello, World! (again)");

	Console.WriteLine("Hello, World! (and again:)");



		Console.WriteLine("You entered the following {0} command line arguments:", args.Length );
				 
		for (int i=0; i < args.Length; i++)
		{
			Console.WriteLine("{0}", args[i]); 
		}
		// comment by uthen (02/23/16)
		Console.WriteLine("Done!!!!!");

		// fixed code on branch (Uthen,02/24/2016)
	}
}