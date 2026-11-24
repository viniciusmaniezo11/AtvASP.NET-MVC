using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ExASP.NETMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ExASP.NETMVC.Controllers
{
    [Route("[controller]")]
    public class EventosController : Controller
    {
        private static List<Evento> _eventos = new()
        {
            new Evento {Id = 1, Nome = "Brasil Game Show", Descricao = "Evento geek", Local = "São Paulo - SP", DataEvento = new DateTime(2026, 12, 10), QuantidadeVagas = 500, ValorIngresso = 1200m,}
        };
        public IActionResult Index()
        {
            return View(_eventos);
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Evento evento)
        {
            if(!ModelState.IsValid)
            {
                return View(evento);
            }

            evento.Id = _eventos.Any() ? _eventos.Max(a => a.Id) + 1 : 1;
            _eventos.Add(evento);

            return RedirectToAction("Index");
        }

        public IActionResult Detalhes(int id)
        {
            var evento = _eventos.FirstOrDefault(a =>a.Id == id);
            if (evento == null)
            {
                return NotFound();
            }
            return View(evento);
        }
    }
}