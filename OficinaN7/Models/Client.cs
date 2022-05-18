namespace OficinaN7.Models
{
    public class Client
    {
        public int Id{get;set;}
        public string Nome{get;set;}
        public string Telefone{get;set;}
        public string Email {get;set;}
        public Address Endereco {get;set;}        
        public Schedule Agenda {get;set;}
        public string Role {get;set;}
        public bool Status {get;set;}

    }
}