using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebPersonal.BackEnd.Controllers
{
    [Route("api/[controller]")]
    /*
     * se puede prescindir del [HttpGet("LeerPerfil/{id}")]
     * pasandole solo el nombre del controlador sin el Controller
     * es decir: PerfilPersonal
     * la URL quedaría asi: /api/PersonalController?id=1 
     * de la otra forma con el [HttpGet("LeerPerfil/{id}")]
     * la URL quedaria asi /LeerPerfil/1
     * el id forma parte de la URL antes de los atributos q se mandan
     */

    //un atributo de la clase tiene que ser  [ApiController]
    [ApiController]

    public class PerfilPersonalController : ControllerBase //tiene que heredar de Controller o ControllerBase
    {
        [HttpGet("LeerPerfil/{id}")] //decorador, "LeerPerfil es la ruta q se el pasa al decorador"
        //LeerPerfil/{id} id es el parametro
        //[Route("LeerPerfil")] antes la ruta se especificaba asi
        public string Get(int id)
        {
            return id switch
            {
                1 => "Ivan",
                2 => "Curso",
                _ => throw new NotSupportedException("el id no es válido")
            };
        }

        [HttpPost]
        public string Post(PerfilPersonalDto perfilPersonal)
        {
            //guardar perfil en la BBDD
            return perfilPersonal.Nombre;
        }
        /*
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }

    public class PerfilPersonalDto
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

    }
}
