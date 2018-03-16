using System;
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
        public JsonResult Get()
        {

            

            Servico servico1 = new Servico();
            servico1.id = 01;
            servico1.servicoPrestado = "Corte de Cabelo";
            servico1.valor = "R$20,00";
            servico1.data = DateTime.Now;

            Servico servico2 = new Servico();
            servico2.id = 02;
            servico2.servicoPrestado = "Escova";
            servico2.valor = "R$120,00";
            servico2.data = DateTime.Now;

            Servico[] servicos = new Servico[] {
               servico1,
               servico2
            };

            
            return Json(_contexto.Servico.ToListAsync());
        }

        [HttpPost]
        public JsonResult Create(string id, string servicoPrestado, string valor, string data)
        {
            Servico servico = new Servico();

            servico.id = Convert.ToInt32(id);
            servico.servicoPrestado = servicoPrestado;
            servico.valor = valor;
            servico.data = Convert.ToDateTime(data);

            return Json("OK");
        }
    }
}