using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventos.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Eventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
                        
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento() {
                    EventoId = 1,
                    Tema = "Teste Postman",
                    Local = "Floriano",
                    Lote = "Nº 1",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "Foto.png"   
                },    
                new Evento() {
                    EventoId = 2,
                    Tema = "Teste Postman 2",
                    Local = "Floriano",
                    Lote = "Nº 2",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    ImagemURL = "Foto2.png"   
                }          
            };
        public EventoController(){
            
        }

        [HttpGet]
        public IEnumerable <Evento> Get()
        {     
            return _evento;  
                 
        }

        [HttpGet("{id}")]
        public IEnumerable <Evento> GetById(int id)
        {     
            return _evento.Where(evento => evento.EventoId == id);  
                 
        }

        [HttpPost]
        public string  Post()
        {     
            return "Exemplo com post";      
        }

        [HttpPut("{id}")]
        public string  Put(int id)
        {     
            return $"Exemplo com put id {id}";      
        }

        [HttpDelete("{id}")]
        public string  Delete(int id)
        {     
            return $"Exemplo com Delete id {id}";      
        }
    }
}
