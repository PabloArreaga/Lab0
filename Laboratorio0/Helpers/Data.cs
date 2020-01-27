using System.Collections.Generic;

namespace Laboratorio0.Helpers
{
	public class Data
	{
		public static Data _instance = null;
		public static Data Instance
		{
			get
			{
				if (_instance == null) _instance = new Data();
				return _instance;
			}
		}
		public Stack<Pelicula> PilaPelicula = new Stack<Pelicula>();
	}
}
