using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Laboratorio0.Helpers;

namespace Laboratorio0.Controllers
{
	[ApiController]
	[Route("[api/controller]")]
    public class PeliculaController : ControllerBase
    {
       [HttpGet]
	   [Route("{id?}")]
	   public IEnumerable<Pelicula> Obtener()
		{
			return null;
		}

		[HttpPost]
		public Pelicula Agregar ([FromBody]Pelicula pelicula)
		{
			Data.Instance.PilaPelicula.Push(pelicula);
			return pelicula;
		}

    }
}