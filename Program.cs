using System;

namespace HolaMundo {
	class MainClass {
		public const string Mensaje = "Hola, nuevo mundo!";

		public static void Main(string[] args)
		{
			string msg = Mensaje;

			Salida.Output( msg );
		}
	}
}
