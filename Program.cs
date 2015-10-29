using System;

namespace HolaMundo {
	class MainClass {
		public static void Main(string[] args)
		{
			string msg = "Hola, otrora nuevo mundo!";

			Output( msg );
		}

		public static void Output(string msg) {
			Console.Write( msg + "\n" );
		}
	}
}
