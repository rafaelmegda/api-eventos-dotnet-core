using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cadastro_taxas.API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cadastro_taxas.API.Data;
using Microsoft.AspNetCore.Http;

namespace Cadastro_taxas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        public readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }
        
       [HttpGet]
       public IActionResult Get()
       {
           try
           {
                var results = _context.Eventos.ToList();
                return Ok(results);
           }
           catch (System.Exception)
           {
               return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
           }
           
       }

        //Get api/values/1
       [HttpGet("{id}")]
       public ActionResult<Evento> Get(int id)
       {
           return _context.Eventos.FirstOrDefault (x => x.EventoId == id);
       }
    }
}
