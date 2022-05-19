using Microsoft.AspNetCore.Mvc;
using OficinaN7.Data;
using OficinaN7.DTO;
using OficinaN7.Models;

namespace OficinaN7.Controllers
{
    public class ServicesController: Controller
    {
        private readonly ApplicationDbContext database;
        public ServicesController(ApplicationDbContext database){
            this.database = database;
        }
        public IActionResult Cadastrar(){
            return View();
        }
        [HttpPost]
        public IActionResult Salvar(ServiceDTO servicoTemp){
            Service servico = new Service();
            servico.Type = servicoTemp.Type;
            servico.Description = servicoTemp.Description;
            servico.Status = true;
            database.Services.Add(servico);
            database.SaveChanges();
            return Content("Serviço Salvo com Sucesso!\n\nTipo de Serviço: "+servico.Type+"\nDescrição:\n"+servico.Description);
        }
    }
}