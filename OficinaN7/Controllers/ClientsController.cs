using Microsoft.AspNetCore.Mvc;
using OficinaN7.Data;
using OficinaN7.DTO;
using OficinaN7.Models;

namespace OficinaN7.Controllers
{
    public class ClientsController: Controller
    {
        private readonly ApplicationDbContext database;
        public ClientsController(ApplicationDbContext database){
            this.database = database;
        }
        public IActionResult Cadastrar(){
            return View();
        }

        [HttpPost]
        public IActionResult Salvar(ClientDTO clienteTemp){
            
            Client cliente = new Client();
            cliente.Id = clienteTemp.Id;
            cliente.Name = clienteTemp.Name;
            cliente.BirthDate = clienteTemp.BirthDate;
            cliente.CPF = clienteTemp.CPF;
            cliente.RG = clienteTemp.RG;
            cliente.Email = clienteTemp.Email;
            cliente.Phone = clienteTemp.Phone;
            cliente.Rua = clienteTemp.Rua;
            cliente.Numero = clienteTemp.Numero;
            cliente.CEP = clienteTemp.CEP;
            cliente.Complemento = clienteTemp.Complemento;
            cliente.Bairro = clienteTemp.Bairro;
            cliente.Cidade = clienteTemp.Cidade;
            
            cliente.Status = true;
            cliente.Role = "Cliente";
            database.Clients.Add(cliente);
            database.SaveChanges();
            return Content("Nome: "+cliente.Name+"\nCPF: "+cliente.CPF+"\nRG: "+cliente.RG+"\nTelefone: "+cliente.Phone+
                            "\nE-Mail: "+cliente.Email+"\n\nEndereço:\nRua: "+cliente.Rua+"\nNumero: "+cliente.Numero+
                            "       Complemento: "+cliente.Complemento+"\nCEP: "+cliente.CEP+"\nBairro: "+cliente.Bairro+
                            "\nCidade: "+cliente.Cidade);
            
        }
    }
}