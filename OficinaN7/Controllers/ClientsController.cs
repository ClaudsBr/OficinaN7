using Microsoft.AspNetCore.Mvc;

namespace OficinaN7.Controllers
{
    public class ClientsController: Controller
    {
        public IActionResult Cadastrar(){
            return View();
        }

        [HttpPost]
        public IActionResult IrParaEndereco(){
            return RedirectToAction("Cadastrar", "Addresses");
        }
    }
}