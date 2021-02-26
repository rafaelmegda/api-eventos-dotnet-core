using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cadastro_taxas.API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Cadastro_taxas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
       [HttpGet]
       public ActionResult<IEnumerable<Evento>>Get()
       {
           return new Evento[] {
               new Evento(){
                   EventoId = 1,
                   Tema = "Angular e .Net",
                   Local = "São Paulo",
                   Lote = "1º Lote",
                   QtdPessoas = 10,
                   DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
               },
               new Evento(){
                   EventoId = 2,
                   Tema = "Angular",
                   Local = "São Paulo",
                   Lote = "3º Lote",
                   QtdPessoas = 30,
                   DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
               }
           };
       }

        //Get api/values/1
       [HttpGet("{id}")]
       public ActionResult<Evento> Get(int id)
       {
           return new Evento[] {
               new Evento(){
                   EventoId = 1,
                   Tema = "Angular e .Net",
                   Local = "São Paulo",
                   Lote = "1º Lote",
                   QtdPessoas = 10,
                   DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
               },
               new Evento(){
                   EventoId = 2,
                   Tema = "Angular",
                   Local = "São Paulo",
                   Lote = "3º Lote",
                   QtdPessoas = 30,
                   DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
               }
           }.FirstOrDefault (x => x.EventoId == id);
       }
    }
}
