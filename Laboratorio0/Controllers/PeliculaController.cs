using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Laboratorio0.Helpers;

namespace Laboratorio0.Controllers
{
	[ApiController]
	[Route("[controller]")]
    public class PeliculaController : ControllerBase
    {
       [HttpGet]
	   [Route("{id?}")]
	   public IEnumerable<Pelicula> Obtener(int id = -1)
		{
			List<Pelicula> UltimasPeliculas = new List<Pelicula>();
			if (Data.Instance.PilaPelicula.Count > 10)
			{
				for (int i = 0; i < 10; i++)
				{
					UltimasPeliculas.Add(Data.Instance.PilaPelicula.Peek());
				}
			}
			else
			{
				for (int i = 0; i < Data.Instance.PilaPelicula.Count; i++)
				{
					UltimasPeliculas.Add(Data.Instance.PilaPelicula.Peek());
				}
			}
			return UltimasPeliculas;
		}

		[HttpPost]
		public Pelicula Agregar ([FromBody]Pelicula pelicula)
		{
			Data.Instance.PilaPelicula.Push(pelicula);
			return pelicula;
		}

    }
}