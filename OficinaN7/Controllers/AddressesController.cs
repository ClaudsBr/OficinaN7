using Microsoft.AspNetCore.Mvc;

namespace OficinaN7.Controllers
{
    public class AddressesController: Controller
    {
        public IActionResult Cadastrar(){
            return View();
        }
        [HttpPost]
        public IActionResult Salvar(){
            return Content("Cliente cadastrado");
        }
    }
}