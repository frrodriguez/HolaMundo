using System;

namespace HolaMundo {
	class MainClass {
		public const string Mensaje = "Hola, otrora nuevo mundo!";

		public static void Main(string[] args)
		{
			string msg = Mensaje;

			Output( msg );
		}

		public static void Output(string msg) {
			Console.Write( msg + "\n" );
		}
	}
}
