using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
              EventoId= 1,
              Tema = "Angular e Net 5",
              Local = "Belo Horizonte",
              Lote = "1º Lote",
              QtdPessoa = 250,
              DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyy"),
              ImagemURL = "Photo.png"
            },
            new Evento() {
              EventoId= 2,
              Tema = "Angular e Net 5",
              Local = "São Paulo",
              Lote = "2º Lote",
              QtdPessoa = 350,
              DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyy"),
              ImagemURL = "Photo.png"
            }
          };

        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(e => e.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "exemplo POST";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"exemplo PUT id:{id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"exemplo DELETE id:{id}";
        }
    }
}
