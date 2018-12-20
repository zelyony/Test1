using System;

namespace Sravnenie
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( "введите строку" );
			string text = Console.ReadLine();
			string s0 = null;
			string s1 = null;
			for (int i = 0; i < text.Length; i++)
			{
				if ((i % 2 == 0))
				{
					s0 = s0 + text[ i ];
				}
				else
				{
					s1 = s1 + text[ i ];
				}
			}
			Console.WriteLine( "нечетных символов {0} ", s1.Length );
			Console.WriteLine( "четных символов {0} ", s0.Length );
			Console.ReadKey();
		}
	}
}
