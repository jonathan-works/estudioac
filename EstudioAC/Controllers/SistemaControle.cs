using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EstudioAC.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EstudioAC.Controllers
{
    [Route("api/[controller]")]
    public class SistemaController : Controller
    {
        private readonly EacContexto _contexto;

        public SistemaController(EacContexto contexto)
        {
            _contexto = contexto;

        }

        [HttpGet]
        public async Task<JsonResult> Get()
        {
            //return await _contexto.Servico.ToListAsync();

            
            
            return Json(await _contexto.Servico.ToListAsync());
        }

        [HttpPost]
        public JsonResult Create(string servicoPrestado, double valor, string data)
        {
            Servico servico = new Servico();
            servico.servicoPrestado = servicoPrestado;
            servico.valor = valor;
            servico.data = Convert.ToDateTime(data);

            //Salvar
            _contexto.Servico.Add(servico);
            _contexto.SaveChanges();

            return Json("Salvo");
        }
    }
}